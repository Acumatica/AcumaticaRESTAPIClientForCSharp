using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Acumatica.RESTClient.AuthApi;
using Acumatica.RESTClient.Client;

using RESTClientTests.Mocks;

using Xunit;
using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;

namespace RESTClientTestsNetFramework
{
    public class ErrorMessagesTests
    {
        [Fact]
        public void DetailLevelErrorsAreReported()
        {
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    return new HttpResponseMessage()
                    {
                        StatusCode = (HttpStatusCode)422,
                        Content = new StringContent(
                      @"{""id"": ""b6410d82-9476-ef11-8c65-ac198e472cfe"", ""rowNumber"": 1,""error"": ""Inserting  'AP Transactions' record raised at least one error. Please review the errors."", ""Amount"": {""value"": 201.73}, ""Details"": [{""id"": ""b8410d82-9476-ef11-8c65-ac198e472cfe"", ""rowNumber"": 1, ""note"": { ""value"": """"},   ""Amount"": { ""value"": 201.73 }, ""InventoryID"": {}, ""Project"": { ""value"": ""TES2323T"",  ""error"": ""Project 'TES2323T  ' cannot be found in the system."" }, ""_links"": { ""files:put"": ""/23r211/entity/Default/20.200.001/files/PX.Objects.AP.APInvoiceEntry/Transactions/b8410d82-9476-ef11-8c65-ac198e472cfe/{filename}"" } } ], ""ReferenceNbr"": { ""value"": ""<NEW>"" }, ""_links"": { ""self"": ""/23r211/entity/Default/20.200.001/Bill/b6410d82-9476-ef11-8c65-ac198e472cfe"", ""files:put"": ""/23r211/entity/Default/20.200.001/files/PX.Objects.AP.APInvoiceEntry/Document/b6410d82-9476-ef11-8c65-ac198e472cfe/{filename}""}}")
                    };



                }));
            Assert.Contains("Project 'TES2323T  ' cannot be found in the system.",
                Assert.Throws<ApiException>(() =>
            client.Put(new Bill())).MessageText);
        }

        [Fact]
        public void Timeout_IsIndicatedInTHeErrorMessage()
        {
            var mockHttpClient = new HttpClientMock(async (request, ct) =>
            {
                await Task.Delay(Timeout.InfiniteTimeSpan, ct);
                return new HttpResponseMessage() { StatusCode = HttpStatusCode.Accepted };
            });
            mockHttpClient.Timeout = TimeSpan.FromMilliseconds(10);
            var client = new ApiClient(mockHttpClient);
            Assert.Contains("Timeout",
                Assert.Throws<TaskCanceledException>(() =>
            client.Login("admin", "123")).Message);
        }

    }
}
