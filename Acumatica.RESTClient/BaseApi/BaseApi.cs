using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

using Acumatica.RESTClient.Client;


namespace Acumatica.RESTClient.Api
{
    /// <summary>
    /// Represents a base class with common logic for all Api classes.
    /// </summary>
    public abstract class BaseApi
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BaseApi(String basePath, int timeout = 100000,
            Action<HttpRequestMessage, HttpClient> requestInterceptor = null,
            Action<HttpRequestMessage, HttpResponseMessage, HttpClient> responseInterceptor = null)
        {
            ApiClient = new ApiClient(basePath, timeout, requestInterceptor, responseInterceptor);

        }

        public ApiClient ApiClient { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BaseApi(ApiClient configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }
            ApiClient = configuration;

        }
        #endregion

        #region Implementation
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return ApiClient.BasePath.ToString();
        }
        private const string ApplicationJsonAcceptContentType = "application/json";
        private const string TextJsonAcceptContentType = "text/json";
        private const string ApplicationXmlAcceptContentType = "application/xml";
        private const string TextXmlAcceptContentType = "text/xml";
        private const string WwwFormEncoded = "application/x-www-form-urlencoded";
        private const string OctetStream = "application/octet-stream";
        private const string AnyAcceptContentType = "*/*";
        [Flags]
        protected enum HeaderContentType : short
        {
            None = 0,
            Json = 1,
            Xml = 2,
            Any = 4,
            WwwForm = 8,
            OctetStream = 16
        };
        protected string ComposeContentHeaders(HeaderContentType contentTypes)
        {
            // to determine the Content-Type header
            string[] localVarHttpContentTypes = ComposeHeadersArray(contentTypes);
            return ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
        }
        protected string ComposeAcceptHeaders(HeaderContentType contentTypes)
        {
            var localVarHeaderParams = new Dictionary<String, String>();
            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = ComposeHeadersArray(contentTypes);
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            return localVarHttpHeaderAccept;
        }

        private static string[] ComposeHeadersArray(HeaderContentType contentTypes)
        {
            List<string> headers = new List<string>();
            if ((contentTypes & HeaderContentType.Json) == HeaderContentType.Json)
            {
                headers.Add(ApplicationJsonAcceptContentType);
                headers.Add(TextJsonAcceptContentType);
            }
            if ((contentTypes & HeaderContentType.Xml) == HeaderContentType.Xml)
            {
                headers.Add(ApplicationXmlAcceptContentType);
                headers.Add(TextXmlAcceptContentType);
            }
            if ((contentTypes & HeaderContentType.Any) == HeaderContentType.Any)
            {
                headers.Add(AnyAcceptContentType);
            }
            if ((contentTypes & HeaderContentType.WwwForm) == HeaderContentType.WwwForm)
            {
                headers.Add(WwwFormEncoded);
            }

            if ((contentTypes & HeaderContentType.OctetStream) == HeaderContentType.OctetStream)
            {
                headers.Add(OctetStream);
            }
            String[] localVarHttpHeaderAccepts = headers.ToArray();
            return localVarHttpHeaderAccepts;
        }

        protected object ComposeBody(object objectForRequestBody)
        {
            object postBody = null;

            if (objectForRequestBody != null && objectForRequestBody.GetType() != typeof(byte[]))
            {
                postBody = ApiClient.Serialize(objectForRequestBody); // http body (model) parameter
            }
            else
            {
                postBody = objectForRequestBody; // byte array
            }

            return postBody;
        }
        protected ApiResponse<T> DeserializeResponse<T>(HttpResponseMessage response)
        {
            int localVarStatusCode = (int)response.StatusCode;

            return new ApiResponse<T>(localVarStatusCode,
                GetHeadersExceptCookies(response),
                (T)ApiClient.Deserialize<T>(response));
        }
        protected ApiResponse ConvertRestResponeToApiResponse(HttpResponseMessage response)
        {
            int localVarStatusCode = (int)response.StatusCode;

            return new ApiResponse<object>(localVarStatusCode,
                GetHeadersExceptCookies(response),
                null);
        }

        private static Dictionary<string, string> GetHeadersExceptCookies(HttpResponseMessage response)
        {
            return response.Headers
                            .Where(header => header.Key != "Set-Cookie")
                            .GroupBy(header => header.Key, StringComparer.OrdinalIgnoreCase)
                            //Accodring to HTTP RFC2616 standard, we need to combine values of the same headers into comma separated list
                            .ToDictionary(
                                g => g.Key,
                                g => string.Join(",", g.Select(header => header.Value)),
                                StringComparer.OrdinalIgnoreCase);
        }

        protected void VerifyResponse<T>(HttpResponseMessage response, string methodName)
        {
            response.EnsureSuccessStatusCode();
        }

        protected void VerifyResponse(HttpResponseMessage response, string methodName)
        {
            response.EnsureSuccessStatusCode();
        }

        protected void ThrowMissingParameter(string methodName, string paramName)
        {
            throw new ApiException(400, $"Missing required parameter '{paramName}' when calling {methodName}");
        }

        protected ExceptionFactory _exceptionFactory = (name, response, type) => null;

        #endregion
    }
}
