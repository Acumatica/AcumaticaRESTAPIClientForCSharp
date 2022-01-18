using Acumatica.Auth.Model;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using RestSharp;
using System;
using System.Net;


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
        public AuthApi(String basePath, int timeout = 100000,
            Action<RestRequest, RestClient> requestInterceptor = null,
            Action<RestRequest, RestResponse, RestClient> responseInterceptor = null) : base(basePath, timeout, requestInterceptor, responseInterceptor)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuthApi(Configuration configuration) : base(configuration)
        { }
        #endregion

        #region Public Methods
        public Configuration LogIn(string username, string password, string tenant = null, string branch = null, string locale = null)
        {

            this.AuthLogin(new Credentials(username, password, tenant, branch, locale));
          //  Console.WriteLine("Logged In...");
            var configuration = new Configuration(Configuration);

            //share cookie container between API clients because we use different client for authentication and interaction with endpoint
            configuration.ApiClient.RestClient.CookieContainer.Add(Configuration.ApiClient.RestClient.CookieContainer.GetCookies(new Uri(Configuration.BasePath)));
            return configuration;
        }
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
                ThrowMissingParameter("AuthLogin", nameof(credentials));

            var localVarPath = "/entity/auth/login";

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, ComposeEmptyQueryParams(), ComposeBody(credentials), ComposeAcceptHeaders(HeaderContentType.None), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm)).Result;

            VerifyResponse(localVarResponse, "AuthLogin");

            return GetResponseHeaders(localVarResponse);
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
                ThrowMissingParameter("AuthLogin", nameof(credentials));

            var localVarPath = "/entity/auth/login";

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, ComposeEmptyQueryParams(), ComposeBody(credentials), ComposeAcceptHeaders(HeaderContentType.None), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm));

            VerifyResponse(localVarResponse, "AuthLogin");

            return GetResponseHeaders(localVarResponse);
        }

        /// <summary>
        /// Logs out from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        protected ApiResponse<Object> AuthLogoutWithHttpInfo()
        {
            var localVarPath = "/entity/auth/logout";

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.None), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.None)).Result;

            VerifyResponse(localVarResponse, "AuthLogout");

            return GetResponseHeaders(localVarResponse);
        }

        /// <summary>
        /// Logs out from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        protected async System.Threading.Tasks.Task<ApiResponse<Object>> AuthLogoutAsyncWithHttpInfo()
        {
            var localVarPath = "/entity/auth/logout";

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.None), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "AuthLogout");

            return GetResponseHeaders(localVarResponse);
        }
        #endregion
    }
}
