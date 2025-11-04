using System.Collections.Generic;
using System.Net;
using System.Net.Http;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;

using RESTClientTests.Mocks;

using Xunit;

using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;

namespace RESTClientTests
{
    public class ExpandParameterOverloadTest
    {
        [Fact]
        public void GetList_WithExpandCollection_ConcatenatesWithComma()
        {
            var expandValues = new List<string> { "Details", "Contact", "Orders" };
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    var uri = request.RequestUri.ToString();
                    // Check for URL-encoded comma-separated expand values (lowercase %2c is standard encoding)
                    Assert.Contains("$expand=Details%2cContact%2cOrders", uri);
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));
            client.GetList<SalesOrder>(expand: expandValues);
        }

        [Fact]
        public void GetList_WithSingleExpandInCollection_WorksCorrectly()
        {
            var expandValues = new List<string> { "Details" };
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    Assert.Contains("$expand=Details", request.RequestUri.ToString());
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));
            client.GetList<SalesOrder>(expand: expandValues);
        }

        [Fact]
        public void GetList_WithEmptyExpandCollection_DoesNotIncludeExpand()
        {
            var expandValues = new List<string>();
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    // Empty collection should not add expand parameter to URL  
                    // (empty string handling ensures no parameter is included)
                    Assert.DoesNotContain("$expand=", request.RequestUri.ToString());
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));
            client.GetList<SalesOrder>(expand: expandValues);
        }

        [Fact]
        public void Put_WithExpandCollection_ConcatenatesWithComma()
        {
            var expandValues = new List<string> { "Details", "Contact" };
            var entity = new SalesOrder();
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    Assert.Contains("$expand=Details%2cContact", request.RequestUri.ToString());
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("{}") };
                }));
            client.Put(entity, expand: expandValues);
        }

        [Fact]
        public void Patch_WithExpandCollection_ConcatenatesWithComma()
        {
            var expandValues = new List<string> { "Details", "Contact" };
            var entity = new SalesOrder();
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    Assert.Contains("$expand=Details%2cContact", request.RequestUri.ToString());
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("{}") };
                }));
            client.Patch(entity, expand: expandValues);
        }

        [Fact]
        public void GetByKeys_WithExpandCollection_ConcatenatesWithComma()
        {
            var expandValues = new List<string> { "Details", "Contact" };
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    Assert.Contains("$expand=Details%2cContact", request.RequestUri.ToString());
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("{}") };
                }));
            client.GetByKeys<SalesOrder>("SO001", expand: expandValues);
        }

        [Fact]
        public void GetById_WithExpandCollection_ConcatenatesWithComma()
        {
            var expandValues = new List<string> { "Details", "Contact" };
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    Assert.Contains("$expand=Details%2cContact", request.RequestUri.ToString());
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("{\"id\":\"12345678-1234-1234-1234-123456789012\"}") };
                }));
            var id = System.Guid.NewGuid();
            client.GetById<SalesOrder>(id, expand: expandValues);
        }
    }
}
