using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace RESTClientTests.Mocks
{
    public class HttpClientMock : HttpClient
    {
        public HttpClientMock(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> returnResponse) : base(new HttpMessageHandlerMock(returnResponse))
        {
            BaseAddress = new Uri("https://localhost");
        }

        private class HttpMessageHandlerMock : HttpMessageHandler
        {
            private Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> returnResponse;

            public HttpMessageHandlerMock(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> returnResponse)
            {
                this.returnResponse = returnResponse;
            }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                return await returnResponse(request, cancellationToken);
            }
        }
    }
}
