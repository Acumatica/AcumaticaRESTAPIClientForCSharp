using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace RESTClientTests.Mocks
{
    internal class HttpClientMock : HttpClient
    {
        public HttpClientMock(Func<HttpRequestMessage, HttpResponseMessage> returnResponse) : base(new HttpMessageHandlerMock(returnResponse))
        { }

        private class HttpMessageHandlerMock : HttpMessageHandler
        {
            private Func<HttpRequestMessage, HttpResponseMessage> returnResponse;

            public HttpMessageHandlerMock(Func<HttpRequestMessage, HttpResponseMessage> returnResponse)
            {
                this.returnResponse = returnResponse;
            }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                return Task.FromResult(returnResponse(request));
            }
        }
    }
}
