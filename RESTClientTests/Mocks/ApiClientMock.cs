using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Acumatica.RESTClient.Client;

using Microsoft.Extensions.DependencyInjection;

namespace RESTClientTests.Mocks
{
    internal class HttpClientHandlerMock : IHttpClientHandler
    {
        Func<HttpRequestMessage, HttpResponseMessage> ReturnResponse;
        public HttpClientHandlerMock(Func<HttpRequestMessage, HttpResponseMessage> returnResponse)
        {
            ReturnResponse = returnResponse;
        }

        public bool HasSessionCookie(Uri path, string sessionCookieName)
        {
            return true;
        }

        public async Task<HttpResponseMessage> SendRequest(HttpRequestMessage request)
        {
            return ReturnResponse(request);
        }
    }
}
