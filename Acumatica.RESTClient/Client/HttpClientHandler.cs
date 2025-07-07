using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("RESTClientTests")]
namespace Acumatica.RESTClient.Client
{
    public class HttpClientHandler : IHttpClientHandler
    {
        private const string SessionCookieName = "ASP.NET_SessionId";
        private readonly CookieContainer _cookieContainer;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _httpClientName;

        public HttpClientHandler(
            CookieContainer cookieContainer,
            IHttpClientFactory httpClientFactory,
            string httpClientName)
        {
            _cookieContainer = cookieContainer;
            _httpClientFactory = httpClientFactory;
            _httpClientName = httpClientName;
        }

        public HttpClientHandler(
            int timeout,
            bool ignoreSslErrors)
        {
            _httpClientName = "HttpClient";

            var serviceProvider = new ServiceCollection()
                .ConfigureDefaultHttpClientHandler(
                    timeout,
                    ignoreSslErrors,
                    _httpClientName)
                .BuildServiceProvider();

            _httpClientFactory = serviceProvider
                .GetRequiredService<IHttpClientFactory>();
            _cookieContainer = serviceProvider
                .GetRequiredService<CookieContainer>();
        }

        public Task<HttpResponseMessage> SendRequest(
            HttpRequestMessage request) =>
                GetHttpClient().SendAsync(request);

        public virtual HttpClient GetHttpClient() =>
            _httpClientFactory.CreateClient(_httpClientName);

        public bool HasSessionCookie(Uri path, string sessionCookieName) =>
            _cookieContainer
                .GetCookies(path)
                .Cast<Cookie>()
                .Any(cookie => cookie.Name == sessionCookieName);
    }
}
