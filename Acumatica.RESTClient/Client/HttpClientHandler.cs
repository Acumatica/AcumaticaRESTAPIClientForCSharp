using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("RESTClientTests")]

namespace Acumatica.RESTClient.Client
{
    internal class HttpClientHandler : IHttpClientHandler
    {
        private const string httpClientName = "HttpClient";
        private const string SessionCookieName = "ASP.NET_SessionId";

        public HttpClientHandler(
            int timeout,
            bool ignoreSslErrors)
        {
            Cookies = new CookieContainer();

            var services = new ServiceCollection();
            services.AddHttpClient(httpClientName, c => {
                c.Timeout = new TimeSpan(0, 0, 0, 0, timeout);
            }
            ).ConfigurePrimaryHttpMessageHandler(() => {
                System.Net.Http.HttpClientHandler handler;
                if (ignoreSslErrors)
                {
                    handler = new System.Net.Http.HttpClientHandler
                    {
                        UseCookies = true,
                        CookieContainer = Cookies,
                        ServerCertificateCustomValidationCallback = (HttpRequestMessage httpRequestMessage, System.Security.Cryptography.X509Certificates.X509Certificate2 cert, System.Security.Cryptography.X509Certificates.X509Chain cetChain, System.Net.Security.SslPolicyErrors policyErrors) => true
                    };
                }
                else
                {
                    handler = new System.Net.Http.HttpClientHandler
                    {
                        UseCookies = true,
                        CookieContainer = Cookies
                    };
                }
                return handler;
            });
            var serviceProvider = services.BuildServiceProvider();
            HttpClientFactory = serviceProvider.GetService<IHttpClientFactory>()!;
        }

        public CookieContainer Cookies
        {
            get; protected set;
        }

        public IHttpClientFactory HttpClientFactory { get; set; }


        public async Task<HttpResponseMessage> SendRequest(HttpRequestMessage request)
        {
            return await GetHttpClient().SendAsync(request);
        }

        public virtual HttpClient GetHttpClient()
        {
            return HttpClientFactory.CreateClient(httpClientName);
        }

        public bool HasSessionCookie(Uri path, string sessionCookieName)
        {
            if (Cookies != null
                && Cookies.GetCookies(path).Cast<Cookie>()
                .Any(cookie => cookie.Name == sessionCookieName))
            {
                return true;
            }
            return false;
        }
    }
}