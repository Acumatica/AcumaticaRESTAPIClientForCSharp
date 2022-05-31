using Acumatica.Auth.Model;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Auxiliary;
using Acumatica.RESTClient.Client;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

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
        protected AuthApi(Configuration configuration) : base(configuration)
        { }
        #endregion

        #region Public Methods
        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="branch"></param>
        /// <param name="locale"></param>
        /// <param name="password"></param>
        /// <param name="tenant"></param>
        /// <param name="username"></param>
        /// <returns>
        /// <see cref="Configuration"></see> that is required to make subsequent REST API calls.
        /// </returns>
        public Configuration LogIn(string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            return LogIn(new Credentials(username, password, tenant, branch, locale));
        }

        public Configuration RefreshAccessToken(string clientID, string clientSecret, Configuration configuration)
        {
            if (configuration == null || String.IsNullOrEmpty(configuration.Token?.Refresh_token))
                ThrowMissingParameter("RefreshAccessToken", "Refresh_Token");

            var result = RefreshWithHttpInfo(clientID, clientSecret, configuration.Token.Refresh_token);
            configuration.Token = result.Data;
            return configuration;
        }

        public Configuration ReceiveAccessToken(string clientID, string clientSecret, string username, string password, OAuthScope scope)
        {
            var configuration = new Configuration(Configuration);

            var result = ConnectWithHttpInfo(
                clientID,
                clientSecret,
                username,
                password,
                scope);
            configuration.Token = result.Data;
            return configuration;
        }

        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials"></param>
        /// <returns>
        /// <see cref="Configuration"></see> that is required to make subsequent REST API calls.
        /// </returns>
        public Configuration LogIn(Credentials credentials)
        {
            this.AuthLoginWithHttpInfo(credentials);
            var configuration = new Configuration(Configuration);

            //share cookie container between API clients because we use different client for authentication and interaction with endpoint
            configuration.ApiClient.RestClient.CookieContainer.Add(Configuration.ApiClient.RestClient.CookieContainer.GetCookies(new Uri(Configuration.BasePath)));
            return configuration;
        }


        [Obsolete("Use LogIn method instead.")]
        public Configuration AuthLogIn(Credentials credentials)
        {
            return LogIn(credentials);
        }

        /// <summary>
        /// Logs out from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void Logout()
        {
            AuthLogoutWithHttpInfo();
        }

        [Obsolete("Use Logout or TryLogout instead.")]
        public void AuthLogout()
        {
            AuthLogoutWithHttpInfo();
        }

        /// <summary>
        /// Logs out from the system without throwing exceptions if the logout failed.
        /// </summary>
        /// <returns>Returns <c>true</c> if the logout has been successful</returns>
        public bool TryLogout()
        {
            try
            {
                Logout();
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Logs out from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task LogoutAsync()
        {
            await AuthLogoutAsyncWithHttpInfo();
        }

        [Obsolete("Use LogoutAsync instead.")]
        public async System.Threading.Tasks.Task AuthLogoutAsync()
        {
            await AuthLogoutAsyncWithHttpInfo();
        }
        #endregion

        #region Implementation
        [Flags]
        public enum OAuthScope
        {
            None = 0,
            API = 1,
            OfflineAccess = 2,
            ConcurrentAccess = 4
        }
        protected ApiResponse<Token> RefreshWithHttpInfo(string clientID, string clientSecret, string refreshToken)
        {
            var localVarPath = "/identity/connect/token";

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApiAsync(
                localVarPath,
                Method.Post,
                ComposeEmptyQueryParams(),
                FormUrlEncodedConverter.ToFormUrlEncoded(new Dictionary<string, string>() 
                { 
                    {"grant_type", "refresh_token" },
                    {"client_id", clientID },
                    {"client_secret", clientSecret },
                    {"refresh_token", refreshToken },
                }),
                ComposeAcceptHeaders(HeaderContentType.None),
                ComposeEmptyFormParams(),
                ComposeEmptyFileParams(),
                ComposeEmptyPathParams(),
                ComposeContentHeaders(HeaderContentType.WwwForm)).Result;

            VerifyResponse(localVarResponse, "RefreshToken");

            return DeserializeResponse<Token>(localVarResponse);
        }

        protected ApiResponse<Token> ConnectWithHttpInfo(string clientID, string clientSecret, string username, string password, OAuthScope scope)
        {
            var localVarPath = "/identity/connect/token";

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApiAsync(
                localVarPath,
                Method.Post, 
                ComposeEmptyQueryParams(),
                FormUrlEncodedConverter.ToFormUrlEncoded(new Dictionary<string, string>
                {
                    {"grant_type", "password" },
                    {"client_id", clientID },
                    {"client_secret", clientSecret },
                    {"username", username },
                    {"password", password },
                    {"scope", PrepareScopeParameter(scope) }
                }), 
                ComposeAcceptHeaders(HeaderContentType.None), 
                ComposeEmptyFormParams(), 
                ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), 
                ComposeContentHeaders(HeaderContentType.WwwForm)).Result;
            
            VerifyResponse(localVarResponse, "RequestToken");

            return DeserializeResponse<Token>(localVarResponse);
        }


        private static string PrepareScopeParameter(OAuthScope scope)
        {
            StringBuilder s = new StringBuilder();
            if (scope.HasFlag(OAuthScope.API))
                s.Append("api ");
            if (scope.HasFlag(OAuthScope.OfflineAccess))
                s.Append("offline_access ");
            if (scope.HasFlag(OAuthScope.ConcurrentAccess))
                s.Append("api:concurrent_access ");

            return s.ToString().TrimEnd(' ');
        }

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
