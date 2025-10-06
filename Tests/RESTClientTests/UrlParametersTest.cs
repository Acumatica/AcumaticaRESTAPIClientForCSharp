using System.Net;
using System.Net.Http;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;

using RESTClientTests.Mocks;

using Xunit;

using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;

namespace RESTClientTests
{
    public partial class UrlParametersTest
    {
        [Fact]
        public void AllParametersArePropagatedToUrl()
        {
            var client = new ApiClient(
                new HttpClientMock(async (request, ct) =>
                {
                    Assert.Contains("expand=files", request.RequestUri.ToString());
                    Assert.Contains("select=OrderNbr", request.RequestUri.ToString());
                    Assert.Contains("top=5", request.RequestUri.ToString());
                    Assert.Contains("skip=5", request.RequestUri.ToString());
                    Assert.Contains("filter=", request.RequestUri.ToString());
                    return new HttpResponseMessage(HttpStatusCode.OK)
                    { Content = new StringContent("[]") };
                }));
            client.GetList<SalesOrder>(expand: "files", select: "OrderNbr", filter: "OrderNbr eq 'SO1234'", top: 5, skip: 5);
        }
    }
}

