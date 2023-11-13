using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Auxiliary;


using Newtonsoft.Json;

using static Acumatica.RESTClient.Auxiliary.Constants;
using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;
using Acumatica.RESTClient.AuthApi.Model;
using Microsoft.Extensions.DependencyInjection;

namespace Acumatica.RESTClient.Client
{
    /// <summary>
    /// API client is mainly responsible for making the HTTP call to the API backend.
    /// </summary>
    public partial class ApiClient
    {
        #region State & ctor
        public CookieContainer SharedCookieContainer { get; set; }

        public IEnumerable<string> Cookies { get; set; }    


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
        /// Gets or sets the HTTP timeout (milliseconds) of the ApiClient. Default to 100000 milliseconds.
        /// </param>
        public ApiClient(string basePath,
            int timeout = 100000,
             Action<HttpRequestMessage> requestInterceptor = null,
             Action<HttpResponseMessage> responseInterceptor = null)
        {
            BasePath = basePath.EndsWith("/") ? basePath : basePath + "/";

            RequestInterceptor = requestInterceptor;
            ResponseInterceptor = responseInterceptor;
            if (SharedCookieContainer == null)
            {
                SharedCookieContainer = new CookieContainer();
            }
            var services = new ServiceCollection();
            services.AddHttpClient("HttpClient", c => {
                c.Timeout = new TimeSpan(0, 0, 0, 0, timeout);
            }
            ).ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                //CookieContainer = SharedCookieContainer
                UseCookies = false

            });
            var serviceProvider = services.BuildServiceProvider();
            HttpClientFactory = serviceProvider.GetService<IHttpClientFactory>();
        }



        /// <summary>
        /// Method that is executed before request. May be used for loggin the request body.
        /// </summary>
        public Action<HttpRequestMessage> RequestInterceptor { get; set; }

        /// <summary>
        /// Method that is executed after receiving response. May be used for loggin the response.
        /// </summary>
        public Action<HttpResponseMessage> ResponseInterceptor { get; set; }


        /// <summary>
        /// Gets or sets the HttpClient.
        /// </summary>
        /// <value>An instance of the HttpClient</value>
        public IHttpClientFactory HttpClientFactory { get; set; }
        /// <summary>
        /// Gets or sets the base path for API access.
        /// </summary>
        public virtual string BasePath
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the username (HTTP basic authentication).
        /// </summary>
        /// <value>The username.</value>
        public virtual string Username { get; set; }

        /// <summary>
        /// Gets or sets the password (HTTP basic authentication).
        /// </summary>
        /// <value>The password.</value>
        public virtual string Password { get; set; }

        /// <summary>
        /// Gets or sets the access token for OAuth2 authentication.
        /// </summary>
        /// <value>The access token.</value>
        public virtual Token Token { get; set; }
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
            List<KeyValuePair<String, String>> queryParams,
            Object postBody,
            HeaderContentType acceptType,
            HeaderContentType contentType,
            Dictionary<String, String> customHeaders = null)
        {
            var request = PrepareRequest(
                resourcePath,
                method,
                queryParams,
                postBody,
                customHeaders,
                acceptType: ComposeAcceptHeaders(acceptType),
                contentType: ComposeContentHeaders(contentType));

            if (RequestInterceptor != null)
            {
                RequestInterceptor(request);
            }
            var response = await HttpClientFactory.CreateClient().SendAsync(request);
            
            if (ResponseInterceptor != null)
            {
                ResponseInterceptor(response);
            }
            
            return response;
        }
        #endregion

        #region Implementation

        // Creates and sets up a RestRequest prior to a call.
        private HttpRequestMessage PrepareRequest(
            String resourcePath,
            HttpMethod method,
            List<KeyValuePair<String, String>> queryParams,
            Object postBody,
            Dictionary<String, String> headerParams,
            string acceptType,
            string contentType)
        {

            var url = new UriBuilder(BasePath + resourcePath);

            if (queryParams != null)
            {
                // add query parameter, if any
                foreach (var param in queryParams)
                {
                    var query = System.Web.HttpUtility.ParseQueryString(url.Query);
                    foreach (var kvp in queryParams)
                    {
                        query.Set(kvp.Key, kvp.Value);
                    }
                    url.Query = query.ToString();
                }
            }

            var request = new HttpRequestMessage(method, url.ToString());
           if(Cookies != null && !resourcePath.Contains("login"))
            {
                string cookieHeader = string.Join("; ", Cookies);
                request.Headers.Add("Cookie", cookieHeader);
            }
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


            if (Token != null)
            {
                request.Headers.Add("Authorization", $"{Token.Token_type} {Token.Access_token}");
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
        #endregion
    }
}
