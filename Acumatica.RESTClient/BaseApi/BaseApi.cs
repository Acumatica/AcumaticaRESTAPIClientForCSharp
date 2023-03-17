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
    public abstract partial class BaseApi
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BaseApi(String basePath, int timeout = 100000,
            Action<HttpRequestMessage, HttpClient> requestInterceptor = null,
            Action<HttpResponseMessage, HttpClient> responseInterceptor = null) :
            this(new ApiClient(basePath, timeout, requestInterceptor, responseInterceptor))
        { }

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
  
        protected ApiResponse<T> DeserializeResponse<T>(HttpResponseMessage response)
        {
            return new ApiResponse<T>((int)response.StatusCode,
                GetHeadersExceptCookies(response),
                (T)ApiClient.Deserialize<T>(response));
        }
        protected ApiResponse ConvertRestResponeToApiResponse(HttpResponseMessage response)
        {
            return new ApiResponse<object>((int)response.StatusCode,
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

        protected virtual void VerifyResponse(HttpResponseMessage response, string methodName)
        {
            response.EnsureSuccessStatusCode();
        }

        protected void ThrowMissingParameter(string methodName, string paramName)
        {
            throw new ApiException(400, $"Missing required parameter '{paramName}' when calling {methodName}");
        }

        #endregion
    }
}
