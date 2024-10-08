using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Acumatica.RESTClient.Client
{
    internal interface IHttpClientHandler
    {
        Task<HttpResponseMessage> SendRequest(HttpRequestMessage request);
        bool HasSessionCookie(Uri path, string sessionCookieName);
    }
}
