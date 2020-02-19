using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Acumatica.RESTClient.Client;
using System.Threading;
using Acumatica.RESTClient.Model;

namespace Acumatica.RESTClient.Api
{
    /// <summary>
    /// Represents a base class with common logic for all Api classes.
    /// </summary>
    public abstract class BaseApi : IApiAccessor
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BaseApi(String basePath)
        {
            this.Configuration = new Configuration(basePath);

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class
        /// </summary>
        /// <returns></returns>
        public BaseApi()
        {
            this.Configuration = Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BaseApi(Configuration configuration)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }
        #endregion

        #region Implementation
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }
        private const string ApplicationJsonAcceptContentType = "application/json";
        private const string TextJsonAcceptContentType = "text/json";
        private const string ApplicationXmlAcceptContentType = "application/xml";
        private const string TextXmlAcceptContentType = "text/xml";
        private const string WwwFormEncoded = "application/x-www-form-urlencoded";
        private const string AnyAcceptContentType = "*/*";
        [Flags]
        protected enum HeaderContentType : short
        {
            None = 0,
            Json = 1,
            Xml = 2,
            Any = 4,
            WwwForm = 8
        };
        protected string ComposeContentHeaders(HeaderContentType contentTypes)
        {
            // to determine the Content-Type header
            string[] localVarHttpContentTypes = ComposeHeadersArray(contentTypes);
            return this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);
        }
        protected Dictionary<string, string> ComposeAcceptHeaders(HeaderContentType contentTypes)
        {
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = ComposeHeadersArray(contentTypes);
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
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
            if ((contentTypes & HeaderContentType.Json) == HeaderContentType.Xml)
            {
                headers.Add(ApplicationXmlAcceptContentType);
                headers.Add(TextXmlAcceptContentType);
            }
            if ((contentTypes & HeaderContentType.Json) == HeaderContentType.Any)
            {
                headers.Add(AnyAcceptContentType);
            }
            if ((contentTypes & HeaderContentType.Json) == HeaderContentType.WwwForm)
            {
                headers.Add(WwwFormEncoded);
            }
            String[] localVarHttpHeaderAccepts = headers.ToArray();
            return localVarHttpHeaderAccepts;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }
        protected object ComposeBody(object credentials)
        {
            object localVarPostBody = null;

            if (credentials != null && credentials.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(credentials); // http body (model) parameter
            }
            else
            {
                localVarPostBody = credentials; // byte array
            }

            return localVarPostBody;
        }
        protected ApiResponse<T> DeserializeResponseGeneric<T>(IRestResponse localVarResponse, int localVarStatusCode)
        {
            return new ApiResponse<T>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (T)this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(T)));
        }
        protected ApiResponse<object> GetResponseHeaders(IRestResponse localVarResponse, int localVarStatusCode)
        {
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        protected void ThrowMissingParameter(string methodName, string paramName)
        {
            throw new ApiException(400, $"Missing required parameter '{paramName}' when calling {methodName}");
        }

        protected ExceptionFactory _exceptionFactory = (name, response) => null;

        #endregion
    }
}
