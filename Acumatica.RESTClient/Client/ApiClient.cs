using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.AuthApi.Model;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;
using System.Linq;
using System.Web;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("RESTClientTests")]

namespace Acumatica.RESTClient.Client
{
    /// <summary>
    /// API client is mainly responsible for making the HTTP call to the API backend.
    /// </summary>
    public class ApiClient : IDisposable
    {
        #region State & ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class.
        /// </summary> 
        /// <param name="basePath">
        /// Path to the Acumatica instance e.g. <c>https://example.acumatica.com/</c>
        /// </param>
        /// <param name="requestInterceptor">
        /// An action delegate that will be executed along with sending an API request. 
        /// Can be used for logging purposes.
        /// </param>
        /// <param name="responseInterceptor">
        /// An action delegate that will be executed along with receiving an API response. 
        /// Can be used for logging purposes.
        /// </param>
        /// <param name="timeout">
        /// Sets the HTTP timeout (milliseconds) of the ApiClient. Default to 100000 milliseconds.
        /// </param>
        /// <param name="ignoreSslErrors">
        /// Sets whether SSL/TLS related errors should be ignored.
        /// </param>
        public ApiClient(HttpClient httpClient,
            Action<HttpRequestMessage>? requestInterceptor = null,
            Action<HttpResponseMessage>? responseInterceptor = null)
        {
            RequestInterceptor = requestInterceptor;
            ResponseInterceptor = responseInterceptor;

            HttpClient = httpClient;
            OwnsHttpClient = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class.
        /// </summary> 
        /// <param name="basePath">
        /// Path to the Acumatica instance e.g. <c>https://example.acumatica.com/</c>
        /// </param>
        /// <param name="requestInterceptor">
        /// An action delegate that will be executed along with sending an API request. 
        /// Can be used for logging purposes.
        /// </param>
        /// <param name="responseInterceptor">
        /// An action delegate that will be executed along with receiving an API response. 
        /// Can be used for logging purposes.
        /// </param>
        /// <param name="timeout">
        /// Sets the HTTP timeout (milliseconds) of the ApiClient. Default to 100000 milliseconds.
        /// </param>
        /// <param name="ignoreSslErrors">
        /// Sets whether SSL/TLS related errors should be ignored.
        /// </param>
        public ApiClient(string basePath,
            int timeout = 100000,
            bool ignoreSslErrors = false,
            Action<HttpRequestMessage>? requestInterceptor = null,
            Action<HttpResponseMessage>? responseInterceptor = null)
        {

            RequestInterceptor = requestInterceptor;
            ResponseInterceptor = responseInterceptor;

            Cookies = new CookieContainer();
            HttpClientHandler handler;
            if (ignoreSslErrors)
            {
                handler = new HttpClientHandler
                {
                    UseCookies = true,
                    CookieContainer = Cookies,
                    ServerCertificateCustomValidationCallback = (HttpRequestMessage httpRequestMessage, System.Security.Cryptography.X509Certificates.X509Certificate2 cert, System.Security.Cryptography.X509Certificates.X509Chain cetChain, System.Net.Security.SslPolicyErrors policyErrors) => true
                };
            }
            else
            {
                handler = new HttpClientHandler
                {
                    UseCookies = true,
                    CookieContainer = Cookies
                };
            }
            HttpClient = new HttpClient(handler)
            {
                Timeout = new TimeSpan(0, 0, 0, 0, timeout),
                BaseAddress = new Uri(basePath)
            };
            OwnsHttpClient = true;
            BasePath = basePath;
        }

        /// <summary>
        /// Method that is executed before request. May be used for loggin the request body.
        /// </summary>
        public Action<HttpRequestMessage>? RequestInterceptor { get; set; }

        /// <summary>
        /// Method that is executed after receiving response. May be used for loggin the response.
        /// </summary>
        public Action<HttpResponseMessage>? ResponseInterceptor { get; set; }

        /// <summary>
        /// Gets or sets the HttpClient.
        /// </summary>
        /// <value>An instance of the HttpClient</value>
        internal HttpClient HttpClient { get; set; }

        protected bool OwnsHttpClient { get; set; }

        /// <summary>
        /// Gets or sets the base path for API access.
        /// </summary>
        public virtual string BasePath
        {
            get
            {
                return HttpClient.BaseAddress?.ToString() ?? string.Empty;
            }
            set
            {
                HttpClient.BaseAddress = new Uri(value.EndsWith("/") ? value : value + "/");
            }
        }

        /// <summary>
        /// Gets or sets the username (HTTP basic authentication).
        /// </summary>
        /// <value>The username.</value>
        public virtual string? Username { get; set; }

        /// <summary>
        /// Gets or sets the password (HTTP basic authentication).
        /// </summary>
        /// <value>The password.</value>
        public virtual string? Password { get; set; }

        /// <summary>
        /// Gets or sets the access token for OAuth2 authentication.
        /// </summary>
        /// <value>The access token.</value>
        public virtual Token? Token { get; set; }
        #endregion

        #region Public Methods

        /// <summary>
        /// Makes the asynchronous HTTP request.
        /// </summary>
        /// <param name="resourcePath">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="customHeaders">Header parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content type.</param>
        /// <returns>The Task instance.</returns>
        public async Task<HttpResponseMessage> CallApiAsync(
            String resourcePath,
            HttpMethod method,
            List<KeyValuePair<String, String>>? queryParams,
            Object? postBody,
            HeaderContentType acceptType,
            HeaderContentType contentType,
            Dictionary<String, String>? customHeaders = null)
        {
            var request = PrepareRequest(
                resourcePath,
                method,
                queryParams,
                postBody,
                customHeaders,
                acceptType: ComposeAcceptHeaders(acceptType),
                contentType: ComposeContentHeaders(contentType));

            RequestInterceptor?.Invoke(request);

            HttpResponseMessage response = await HttpClient.SendAsync(request).ConfigureAwait(false);

            ResponseInterceptor?.Invoke(response);

            return response;
        }
      
        public bool HasToken()
        {
            return Token != null;
        }
        public void Dispose()
        {
            if (HasToken() || HasSessionInfo())
            {
                AuthApi.AuthApiExtensions.TryLogout(this);
            }
            if(OwnsHttpClient)
            {
                HttpClient.Dispose();
            }
        }
        #endregion

        #region Implementation

        // Creates and sets up a RestRequest prior to a call.
        private HttpRequestMessage PrepareRequest(
            String resourcePath,
            HttpMethod method,
            List<KeyValuePair<String, String>>? queryParams,
            Object? postBody,
            Dictionary<String, String>? headerParams,
            string acceptType,
            string contentType)
        {

            var url = new UriBuilder(BasePath + resourcePath);

            if (queryParams != null)
            {
                url.Query += string.Join("&", queryParams.Select(queryParamter => $"{queryParamter.Key}={HttpUtility.UrlEncode(queryParamter.Value, Encoding.UTF8)}"));
            }

            var request = new HttpRequestMessage(method, url.ToString());
            if (headerParams != null)
            {
                // add header parameter, if any
                foreach (var param in headerParams)
                {
                    request.Headers.Add(param.Key, param.Value);
                }
            }
            if (!String.IsNullOrWhiteSpace(acceptType))
            {
                request.Headers.Add("Accept", acceptType);
            }


            if (HasToken())
            {
                request.Headers.Add("Authorization", $"{Token!.Token_type} {Token.Access_token}");
            }

            if (postBody != null)
            {
                if (postBody is string)
                {
                    request.Content = new StringContent(postBody as string, Encoding.UTF8, contentType);
                }

                else if (postBody is byte[])
                {
                    request.Content = new ByteArrayContent(postBody as byte[]);
                }
                else
                {
                    request.Content = new StringContent(Serialize(postBody), Encoding.UTF8, contentType);
                }
            }
            return request;
        }

        private const string SessionCookieName = "ASP.NET_SessionId";
        internal bool HasSessionInfo()
        {
            return HasSessionCookie(new Uri(BasePath), SessionCookieName);
        }

        protected readonly CookieContainer Cookies;


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
        #endregion
    }
}
