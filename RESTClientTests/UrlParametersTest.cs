using FluentAssertions;
using System.Linq;
using Xunit;
using System;
using System.Globalization;
using Acumatica.RESTClient.Api;
using RESTClientTests.Mocks;
using Acumatica.RESTClient.Client;
using System.Net.Http;
using System.Net;
using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;
using System.Collections.Generic;
using Acumatica.RESTClient.ContractBasedApi;

namespace RESTClientTests
{
    public partial class UrlParametersTest
    {
        [Fact]
        public void AllParametersArePropagatedToUrl()
        {
            var client = new ApiClient("http://localhost/23r211/",
                new HttpClientHandlerMock(request=>
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

