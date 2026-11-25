using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.CustomizationApi;

using Newtonsoft.Json.Linq;

using RESTClientTests.Mocks;

using Xunit;

using static Acumatica.RESTClient.CustomizationApi.CustomizationApiExtensions;

namespace RESTClientTests
{
    public class CustomizationApiTests
    {
        private const string LogJson = "{\"log\":[{\"timestamp\":\"2026-11-25T10:00:00\",\"logType\":\"Information\",\"message\":\"Publishing has started.\"}]}";

        private class Recorder
        {
            public List<string> Paths = new List<string>();
            public List<JObject?> Bodies = new List<JObject?>();
        }

        /// <summary>Creates a client that records the requests and answers with the given responses, repeating the last one.</summary>
        private static ApiClient CreateClient(Recorder recorder, params (HttpStatusCode status, string json)[] responses)
        {
            int index = 0;
            return new ApiClient(new HttpClientMock(async (request, ct) =>
            {
                recorder.Paths.Add(request.RequestUri!.AbsolutePath.Replace("//", "/"));
                recorder.Bodies.Add(request.Content == null
                    ? null
                    : CamelCaseKeys(JObject.Parse(await request.Content.ReadAsStringAsync())));
                var (status, json) = responses[Math.Min(index++, responses.Length - 1)];
                return new HttpResponseMessage(status)
                {
                    RequestMessage = request,
                    Content = new StringContent(json, Encoding.UTF8, "application/json")
                };
            }));
        }

        /// <summary>
        /// The client sends property names as they are in the model (PascalCase) and the server reads them
        /// case-insensitively, so the tests look at the names in camelCase.
        /// </summary>
        private static JObject CamelCaseKeys(JObject source)
        {
            var result = new JObject();
            foreach (var property in source.Properties())
                result[char.ToLowerInvariant(property.Name[0]) + property.Name.Substring(1)] = property.Value;
            return result;
        }

        private static string State(bool completed, bool failed, string? message = null)
        {
            string log = message == null ? "[]" : "[{\"logType\":\"Error\",\"message\":\"" + message + "\"}]";
            return "{\"isCompleted\":" + completed.ToString().ToLower() + ",\"isFailed\":" + failed.ToString().ToLower() + ",\"log\":" + log + "}";
        }

        #region PublishBegin
        [Fact]
        public void PublishBegin_SingleProject_MergesWithExistingByDefault()
        {
            var rec = new Recorder();
            var client = CreateClient(rec, (HttpStatusCode.OK, LogJson));

            var result = client.PublishBegin("MyProject");

            Assert.Equal("/CustomizationApi/PublishBegin", rec.Paths[0]);
            Assert.True((bool)rec.Bodies[0]!["isMergeWithExistingPackages"]!);
            Assert.Equal(new[] { "MyProject" }, rec.Bodies[0]!["projectNames"]!.Values<string>());
            Assert.Equal("Current", (string)rec.Bodies[0]!["tenantMode"]!);
            Assert.Equal("Publishing has started.", Assert.Single(result.Log!).Message);
        }

        [Fact]
        public void PublishBegin_ProjectList_PublishesExactlyTheListByDefault()
        {
            var rec = new Recorder();
            var client = CreateClient(rec, (HttpStatusCode.OK, LogJson));

            client.PublishBegin(new[] { "A", "B" });

            Assert.False((bool)rec.Bodies[0]!["isMergeWithExistingPackages"]!);
            Assert.Equal(new[] { "A", "B" }, rec.Bodies[0]!["projectNames"]!.Values<string>());
        }

        [Fact]
        public void PublishBegin_TenantModeList_SendsTenantLoginNames()
        {
            var rec = new Recorder();
            var client = CreateClient(rec, (HttpStatusCode.OK, LogJson));

            client.PublishBegin("P", tenantMode: TenantMode.List, tenantLoginNames: new[] { "Company", "Other" });

            Assert.Equal("List", (string)rec.Bodies[0]!["tenantMode"]!);
            Assert.Equal(new[] { "Company", "Other" }, rec.Bodies[0]!["tenantLoginNames"]!.Values<string>());
        }

        [Fact]
        public void PublishBegin_TenantModeListWithoutNames_Throws()
        {
            var client = CreateClient(new Recorder(), (HttpStatusCode.OK, LogJson));
            Assert.Throws<ApiException>(() => client.PublishBegin("P", tenantMode: TenantMode.List));
        }

        [Fact]
        public void PublishBegin_TenantNamesWithoutListMode_Throws()
        {
            var client = CreateClient(new Recorder(), (HttpStatusCode.OK, LogJson));
            Assert.Throws<ArgumentException>(() => client.PublishBegin("P", tenantLoginNames: new[] { "Company" }));
        }

        [Fact]
        public void PublishBegin_InvalidTenantMode_Throws()
        {
            var client = CreateClient(new Recorder(), (HttpStatusCode.OK, LogJson));
            Assert.Throws<ArgumentOutOfRangeException>(() => client.PublishBegin("P", tenantMode: (TenantMode)42));
        }

        [Fact]
        public async Task PublishBeginAsync_SingleProject_HonorsCancellation()
        {
            var client = CreateClient(new Recorder(), (HttpStatusCode.OK, LogJson));
            using (var cts = new CancellationTokenSource())
            {
                cts.Cancel();
                await Assert.ThrowsAnyAsync<OperationCanceledException>(
                    () => client.PublishBeginAsync("P", cancellationToken: cts.Token));
            }
        }
        #endregion


        #region GetPublished, GetProject, DeleteProject, UnpublishAll
        [Fact]
        public void GetPublished_ReturnsProjectsAndItems()
        {
            var rec = new Recorder();
            var client = CreateClient(rec, (HttpStatusCode.OK,
                "{\"projects\":[{\"name\":\"Proj1\"},{\"name\":\"Proj2\"}],\"items\":[{\"key\":\"k1\",\"screenId\":\"SO301000\",\"type\":\"Page\"}],\"log\":[]}"));

            var published = client.GetPublished();

            Assert.Equal("/CustomizationApi/GetPublished", rec.Paths[0]);
            Assert.Equal(new[] { "Proj1", "Proj2" }, published.Projects!.Select(_ => _.Name));
            var item = Assert.Single(published.Items!);
            Assert.Equal("k1", item.Key);
            Assert.Equal("SO301000", item.ScreenId);
            Assert.Equal("Page", item.Type);
        }

        [Fact]
        public void GetProject_SendsRequestAndReturnsPackage()
        {
            var rec = new Recorder();
            byte[] package = { 80, 75, 3, 4, 200 };
            var client = CreateClient(rec, (HttpStatusCode.OK,
                "{\"projectContentBase64\":\"" + Convert.ToBase64String(package) + "\",\"hasConflicts\":true,\"log\":[]}"));

            var project = client.GetProject("Proj", isAutoResolveConflicts: true);

            Assert.Equal("/CustomizationApi/GetProject", rec.Paths[0]);
            Assert.Equal("Proj", (string)rec.Bodies[0]!["projectName"]!);
            Assert.True((bool)rec.Bodies[0]!["isAutoResolveConflicts"]!);
            Assert.True(project.HasConflicts);
            Assert.Equal(package, project.GetContent());
        }

        [Fact]
        public void DeleteProject_SendsProjectName()
        {
            var rec = new Recorder();
            var client = CreateClient(rec, (HttpStatusCode.OK, LogJson));

            var result = client.DeleteProject("Old");

            Assert.Equal("/CustomizationApi/Delete", rec.Paths[0]);
            Assert.Equal("Old", (string)rec.Bodies[0]!["projectName"]!);
            Assert.Single(result.Log!);
        }

        [Fact]
        public void UnpublishAll_DefaultsToCurrentTenant()
        {
            var rec = new Recorder();
            var client = CreateClient(rec, (HttpStatusCode.OK, LogJson));

            client.UnpublishAll();

            Assert.Equal("/CustomizationApi/UnpublishAll", rec.Paths[0]);
            Assert.Equal("Current", (string)rec.Bodies[0]!["tenantMode"]!);
            Assert.Null(rec.Bodies[0]!["tenantLoginNames"]);
        }

        [Fact]
        public void UnpublishAll_TenantModeList_SendsNames()
        {
            var rec = new Recorder();
            var client = CreateClient(rec, (HttpStatusCode.OK, LogJson));

            client.UnpublishAll(TenantMode.List, new[] { "Company" });

            Assert.Equal("List", (string)rec.Bodies[0]!["tenantMode"]!);
            Assert.Equal(new[] { "Company" }, rec.Bodies[0]!["tenantLoginNames"]!.Values<string>());
        }

        [Fact]
        public void UnpublishAll_TenantModeListWithoutNames_Throws()
        {
            var client = CreateClient(new Recorder(), (HttpStatusCode.OK, LogJson));
            Assert.Throws<ApiException>(() => client.UnpublishAll(TenantMode.List));
        }

        [Fact]
        public void GetProject_MissingName_Throws()
        {
            var client = CreateClient(new Recorder(), (HttpStatusCode.OK, LogJson));
            Assert.Throws<ApiException>(() => client.GetProject(null!));
        }
        #endregion

        #region Errors
        [Fact]
        public void FailedCall_ThrowsApiExceptionWithServerMessage()
        {
            var client = CreateClient(new Recorder(), (HttpStatusCode.InternalServerError, "{\"message\":\"Project 'X' is not found.\"}"));

            var ex = Assert.Throws<ApiException>(() => client.PublishBegin("X"));

            Assert.Equal(500, ex.ErrorCode);
            Assert.Contains("Project 'X' is not found.", ex.Message);
        }
        #endregion

        #region Import
        [Fact]
        public void Import_SendsPackageAsBase64()
        {
            var rec = new Recorder();
            var client = CreateClient(rec, (HttpStatusCode.OK, LogJson));
            byte[] content = { 1, 2, 3, 250 };

            client.Import(new MemoryStream(content), "Proj", "Description", replaceIfExists: false, level: 5);

            var body = rec.Bodies[0]!;
            Assert.Equal("/CustomizationApi/Import", rec.Paths[0]);
            Assert.Equal(Convert.ToBase64String(content), (string)body["projectContentBase64"]!);
            Assert.Equal("Proj", (string)body["projectName"]!);
            Assert.Equal("Description", (string)body["projectDescription"]!);
            Assert.False((bool)body["isReplaceIfExists"]!);
            Assert.Equal(5, (int)body["projectLevel"]!);
        }
        #endregion

        #region PublishEnd
        [Fact]
        public void PublishEnd_SendsAJsonBody()
        {
            // Without a body no Content-Type is sent and the server answers 415 Unsupported Media Type.
            var rec = new Recorder();
            var client = CreateClient(rec, (HttpStatusCode.OK, State(true, false)));

            var state = client.PublishEnd();

            Assert.Equal("/CustomizationApi/PublishEnd", rec.Paths[0]);
            Assert.NotNull(rec.Bodies[0]);
            Assert.True(state.IsCompleted);
        }

        [Fact]
        public void Result_HasErrors_ReflectsErrorRecordsInTheLog()
        {
            var withError = CreateClient(new Recorder(), (HttpStatusCode.OK, "{\"log\":[{\"logType\":\"information\",\"message\":\"a\"},{\"logType\":\"error\",\"message\":\"The project is not found: X\"}]}"))
                .DeleteProject("X");
            var withoutError = CreateClient(new Recorder(), (HttpStatusCode.OK, LogJson)).DeleteProject("X");

            Assert.True(withError.HasErrors);
            Assert.False(withoutError.HasErrors);
        }
        #endregion

        #region WaitPublishingCompletion
        [Fact]
        public void Wait_ReturnsWhenCompleted()
        {
            var rec = new Recorder();
            var client = CreateClient(rec, (HttpStatusCode.OK, State(false, false)), (HttpStatusCode.OK, State(true, false)));

            client.WaitPublishingCompletion(millisecondsInterval: 5);

            Assert.Equal(2, rec.Paths.Count);
            Assert.All(rec.Paths, p => Assert.Equal("/CustomizationApi/PublishEnd", p));
        }

        [Fact]
        public void Wait_Failed_ThrowsWithLog()
        {
            var client = CreateClient(new Recorder(), (HttpStatusCode.OK, State(false, true, "Compilation error")));

            var ex = Assert.Throws<CustomizationPublishException>(() => client.WaitPublishingCompletion(5));

            Assert.Contains("Compilation error", ex.Message);
            Assert.Equal("Compilation error", Assert.Single(ex.Log).Message);
        }

        [Fact]
        public void Wait_CompletedAndFailed_IsReportedAsFailure()
        {
            var client = CreateClient(new Recorder(), (HttpStatusCode.OK, State(true, true, "Validation failed")));

            Assert.Throws<CustomizationPublishException>(() => client.WaitPublishingCompletion(5));
        }

        [Fact]
        public void Wait_NeverFinishes_TimesOut()
        {
            var client = CreateClient(new Recorder(), (HttpStatusCode.OK, State(false, false)));

            Assert.Throws<TimeoutException>(() => client.WaitPublishingCompletion(millisecondsInterval: 10, millisecondsTimeout: 100));
        }

        [Fact]
        public async Task WaitAsync_CanBeCancelled()
        {
            var client = CreateClient(new Recorder(), (HttpStatusCode.OK, State(false, false)));
            using (var cts = new CancellationTokenSource(TimeSpan.FromMilliseconds(100)))
            {
                await Assert.ThrowsAnyAsync<OperationCanceledException>(
                    () => client.WaitPublishingCompletionAsync(TimeSpan.FromMilliseconds(10), cancellationToken: cts.Token));
            }
        }
        #endregion
    }
}
