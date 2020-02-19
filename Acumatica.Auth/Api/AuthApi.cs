using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Acumatica.RESTClient.Client;
using Acumatica.Auth.Model;
using Acumatica.RESTClient.Api;

namespace Acumatica.Auth.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the Authorization endpoint
    /// </summary>
    public partial class AuthApi : BaseApi
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuthApi(String basePath)
        {
            this.Configuration = new Configuration(basePath);

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials"></param>
        /// <returns></returns>
        public void AuthLogin(Credentials credentials)
        {
            AuthLoginWithHttpInfo(credentials);
        }
        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AuthLoginAsync(Credentials credentials)
        {
            await AuthLoginAsyncWithHttpInfo(credentials);

        }

        /// <summary>
        /// Logs out from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void AuthLogout()
        {
            AuthLogoutWithHttpInfo();
        }
        /// <summary>
        /// Logs out from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AuthLogoutAsync()
        {
            await AuthLogoutAsyncWithHttpInfo();

        }
        #endregion

        #region Implementation
        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        protected ApiResponse<Object> AuthLoginWithHttpInfo(Credentials credentials)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
                throw new ApiException(400, "Missing required parameter 'credentials' when calling AuthApi->AuthLogin");

            var localVarPath = "/entity/auth/login";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, ComposeBody(credentials), ComposeAcceptHeaders(HeaderContentType.None), localVarFormParams, localVarFileParams,
                localVarPathParams, ComposeContentHeaders(HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm));

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthLogin", localVarResponse);
                if (exception != null) throw exception;
            }

            return GetResponseHeaders(localVarResponse, localVarStatusCode);
        }

        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials"></param>
        /// <returns>Task of ApiResponse</returns>
        protected async System.Threading.Tasks.Task<ApiResponse<Object>> AuthLoginAsyncWithHttpInfo(Credentials credentials)
        {
            // verify the required parameter 'credentials' is set
            if (credentials == null)
                throw new ApiException(400, "Missing required parameter 'credentials' when calling AuthApi->AuthLogin");

            var localVarPath = "/entity/auth/login";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, ComposeBody(credentials), ComposeAcceptHeaders(HeaderContentType.None), localVarFormParams, localVarFileParams,
                localVarPathParams, ComposeContentHeaders(HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm));

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthLogin", localVarResponse);
                if (exception != null) throw exception;
            }

            return GetResponseHeaders(localVarResponse, localVarStatusCode);
        }

        /// <summary>
        /// Logs out from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        protected ApiResponse<Object> AuthLogoutWithHttpInfo()
        {

            var localVarPath = "/entity/auth/logout";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, ComposeAcceptHeaders(HeaderContentType.None), localVarFormParams, localVarFileParams,
                localVarPathParams, ComposeContentHeaders(HeaderContentType.None));

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthLogout", localVarResponse);
                if (exception != null) throw exception;
            }

            return GetResponseHeaders(localVarResponse, localVarStatusCode);
        }

        /// <summary>
        /// Logs out from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        protected async System.Threading.Tasks.Task<ApiResponse<Object>> AuthLogoutAsyncWithHttpInfo()
        {

            var localVarPath = "/entity/auth/logout";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, ComposeAcceptHeaders(HeaderContentType.None), localVarFormParams, localVarFileParams,
                localVarPathParams, ComposeContentHeaders(HeaderContentType.None));

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AuthLogout", localVarResponse);
                if (exception != null) throw exception;
            }

            return GetResponseHeaders(localVarResponse, localVarStatusCode);
        }
        #endregion
    }
}
