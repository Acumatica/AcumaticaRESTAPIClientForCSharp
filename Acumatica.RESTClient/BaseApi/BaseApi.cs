using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

using Acumatica.RESTClient.Client;

using static Acumatica.RESTClient.Auxiliary.Constants;


namespace Acumatica.RESTClient.Api
{
    /// <summary>
    /// Represents a base class with common logic for all Api classes.
    /// </summary>
    public abstract partial class BaseApi
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
        /// <param name="client">An instance of Configuration</param>
        /// <returns></returns>
        public BaseApi(ApiClient client)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }
            ApiClient = client;

        }

        #endregion
        #region Implementation
        /// <summary>
        /// Composes Query Parameters for API Request. 
        /// </summary>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="filter">The conditions that determine which records should be selected from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <param name="skip">The number of records to be skipped from the list of returned records. (optional)</param>
        /// <param name="top">The number of records to be returned from the system. (optional)</param>
        protected List<KeyValuePair<string, string>> ComposeQueryParams(string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            if (!String.IsNullOrEmpty(select)) queryParameters.AddRange(ApiClient.ParameterToKeyValuePairs("", "$select", select)); // query parameter
            if (!String.IsNullOrEmpty(filter)) queryParameters.AddRange(ApiClient.ParameterToKeyValuePairs("", "$filter", filter)); // query parameter
            if (!String.IsNullOrEmpty(expand)) queryParameters.AddRange(ApiClient.ParameterToKeyValuePairs("", "$expand", expand)); // query parameter
            if (!String.IsNullOrEmpty(custom)) queryParameters.AddRange(ApiClient.ParameterToKeyValuePairs("", "$custom", custom)); // query parameter
            if (skip != null) queryParameters.AddRange(ApiClient.ParameterToKeyValuePairs("", "$skip", skip)); // query parameter
            if (top != null) queryParameters.AddRange(ApiClient.ParameterToKeyValuePairs("", "$top", top)); // query parameter

            return queryParameters;
        }
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
