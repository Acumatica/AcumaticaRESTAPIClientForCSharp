using System;
using System.Collections.Generic;
using System.Linq;

using RestSharp;

namespace Acumatica.RESTClient.Client
{
    /// <summary>
    /// Represents a base class with common logic for all Api classes.
    /// </summary>
    public abstract class BaseApi 
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class
        /// and creates a new <see cref="Session"/> for it.
        /// </summary>
        public BaseApi(String basePath, int timeout = 100000,
            Action<RestRequest, RestClient> requestInterceptor = null,
            Action<RestRequest, RestResponse, RestClient> responseInterceptor = null)
        {
            Session = new Session(basePath, timeout, requestInterceptor, responseInterceptor);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class
        /// </summary>
        /// <param name="session">An API session</param>
        public BaseApi(Session session)
        {
            if (session == null)
            {
                throw new ArgumentNullException(nameof(session));
            }
            Session = session;
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Session.BasePath.ToString();
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
            return this.Session.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
        }
        protected Dictionary<string, string> ComposeAcceptHeaders(HeaderContentType contentTypes)
        {
            var localVarHeaderParams = new Dictionary<String, String>();
            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = ComposeHeadersArray(contentTypes);
            String localVarHttpHeaderAccept = this.Session.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            return localVarHeaderParams;
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

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Session Session { get; set; }

        protected Dictionary<string, FileParameter> ComposeEmptyFileParams()
        {
            return new Dictionary<String, FileParameter>();
        }
        protected List<KeyValuePair<string, string>> ComposeEmptyQueryParams()
        {
            return new List<KeyValuePair<String, String>>();
        }
        protected Dictionary<string, string> ComposeEmptyPathParams()
        {
            return new Dictionary<String, String>();
        }
        protected Dictionary<string, string> ComposeEmptyFormParams()
        {
            return new Dictionary<String, String>();
        }
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
            var queryParameters = ComposeEmptyQueryParams();
            if (!String.IsNullOrEmpty(select)) queryParameters.AddRange(this.Session.ApiClient.ParameterToKeyValuePairs("", "$select", select)); // query parameter
            if (!String.IsNullOrEmpty(filter)) queryParameters.AddRange(this.Session.ApiClient.ParameterToKeyValuePairs("", "$filter", filter)); // query parameter
            if (!String.IsNullOrEmpty(expand)) queryParameters.AddRange(this.Session.ApiClient.ParameterToKeyValuePairs("", "$expand", expand)); // query parameter
            if (!String.IsNullOrEmpty(custom)) queryParameters.AddRange(this.Session.ApiClient.ParameterToKeyValuePairs("", "$custom", custom)); // query parameter
            if (skip != null) queryParameters.AddRange(this.Session.ApiClient.ParameterToKeyValuePairs("", "$skip", skip)); // query parameter
            if (top != null) queryParameters.AddRange(this.Session.ApiClient.ParameterToKeyValuePairs("", "$top", top)); // query parameter

            return queryParameters;
        }
        protected object ComposeBody(object objectForRequestBody)
        {
            object postBody = null;

            if (objectForRequestBody != null && objectForRequestBody.GetType() != typeof(byte[]))
            {
                postBody = this.Session.ApiClient.Serialize(objectForRequestBody); // http body (model) parameter
            }
            else
            {
                postBody = objectForRequestBody; // byte array
            }

            return postBody;
        }
        protected ApiResponse<T> DeserializeResponse<T>(RestResponse response)
        {
            int localVarStatusCode = (int)response.StatusCode;

            return new ApiResponse<T>(localVarStatusCode,
                GetHeadersExceptCookies(response),
                (T)this.Session.ApiClient.Deserialize<T>(response));
        }

        protected ApiResponse<object> GetResponseHeaders(RestResponse response)
        {
            int localVarStatusCode = (int)response.StatusCode;

            return new ApiResponse<object>(localVarStatusCode,
                GetHeadersExceptCookies(response),
                null);
        }

        private static Dictionary<string, string> GetHeadersExceptCookies(RestResponse response)
        {
            return response.Headers
                            .Where(x => x.Name != "Set-Cookie")
                            .ToDictionary(x => x.Name, x => x.Value.ToString());
        }

        protected virtual void VerifyResponse(RestResponse response, string methodName)
        {
            if (!response.IsSuccessStatusCode)
                throw new ApiException((int)response.StatusCode, methodName);
            if (!response.IsSuccessful)
                throw new ApiException((int)response.StatusCode, methodName);
        }

        protected void ThrowMissingParameter(string methodName, string paramName)
        {
            throw new ApiException(400, $"Missing required parameter '{paramName}' when calling {methodName}");
        }
        #endregion
    }
}
