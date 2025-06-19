using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("RESTClientTests")]

namespace Acumatica.RESTClient.Client
{
    internal class SimpleHttpClientHandler : IHttpClientHandler, ITestableHttpClientHandler
    {
        private HttpClient httpClient;
        public SimpleHttpClientHandler(
            int timeout,
            bool ignoreSslErrors)
        {
            Cookies = new CookieContainer();
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
            httpClient = new HttpClient(handler)
            {
                Timeout = new TimeSpan(0, 0, 0, 0, timeout),
            };

        }

        public CookieContainer Cookies
        {
            get; protected set;
        }



        public async Task<HttpResponseMessage> SendRequest(HttpRequestMessage request)
        {
            return await GetHttpClient().SendAsync(request);
        }

        public virtual HttpClient GetHttpClient()
        {
            return httpClient;
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