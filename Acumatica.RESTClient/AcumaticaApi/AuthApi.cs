using Acumatica.Auth.Model;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Auxiliary;
using Acumatica.RESTClient.Client;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
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
        /// Initializes a new instance of the <see cref="AuthApi"/> class
        /// </summary>
        /// <param name="basePath">
        /// Path to the Acumatica instance e.g. <c>https://example.acumatica.com/</c>
        /// </param>
        /// <param name="timeout">
        /// Request timeout of API requests in milliseconds. Default to 10000 milliseconds. 
        /// The timeout is saved in the <see cref="Configuration"/> and will be applied to 
        /// all subsequent requests using the same <see cref="Configuration"/>.
        /// </param>
        /// <param name="requestInterceptor">
        /// An action delegate that will be executed along with sending an API request. 
        /// Can be used for logging purposes.
        /// </param>
        /// <param name="responseInterceptor">
        /// An action delegate that will be executed along with receiving an API response. 
        /// Can be used for logging purposes.
        /// </param>
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

        #region OAuth
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

        public string Authorize(string clientID, string clientSecret, string redirectUrl, OAuthScope scope)
        {
            var response = AuthorizeWithHttpInfo(
              clientID,
              redirectUrl,
              scope);
            var locationHeader = response.Headers.Where(_ => _.Name == "Location").FirstOrDefault();
            if (locationHeader == null)
            {
                //maybe we've already been redirected, let's take response URL in this case
                return response.ResponseUri.ToString();
            }
            return locationHeader.Value.ToString();
        }

        public Configuration ReceiveAccessTokenAuthCode(string clientID, string clientSecret, string redirectUrl, string code)
        {
            var configuration = new Configuration(Configuration);

            var result = ConnectWithHttpInfoAuthCode(
                clientID,
                clientSecret,
                redirectUrl,
                code);
            configuration.Token = result.Data;
            return configuration;
        }
        #endregion

        #region Login
        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">Name of the user that is used to open a new session (required).</param>
        /// <param name="password">User password (required).</param>
        /// <param name="tenant">Defines the tenant to log in.</param>
        /// <param name="branch">Defines the branch to log in.</param>
        /// <param name="locale">Defines the locale to use for localizable data.</param>
        /// <returns>
        /// <see cref="Configuration"></see> that is required to make subsequent REST API calls.
        /// </returns>
        public Configuration LogIn(string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            return LogIn(new Credentials(name: username, password: password, tenant: tenant, branch: branch, locale: locale));
        }

        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials">
        /// <see cref="Credentials"/> object that provides information required to log into the web service.
        /// </param>
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
        #endregion

        #region Logout
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

        protected RestResponse AuthorizeWithHttpInfo(string clientID, string redirectUrl, OAuthScope scope)
        {
            var localVarPath = "/identity/connect/authorize";

            var queryParameters = ComposeEmptyQueryParams();
            queryParameters.Add(new KeyValuePair<string, string>("response_type", "code"));
            queryParameters.Add(new KeyValuePair<string, string>("client_id", clientID));
            queryParameters.Add(new KeyValuePair<string, string>("scope", PrepareScopeParameter(scope)));
            queryParameters.Add(new KeyValuePair<string, string>("redirect_uri", redirectUrl));
            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApiAsync(
                localVarPath,
                Method.Get,
                queryParameters,
                String.Empty,
                ComposeAcceptHeaders(HeaderContentType.None),
                ComposeEmptyFormParams(),
                ComposeEmptyFileParams(),
                ComposeEmptyPathParams(),
                ComposeContentHeaders(HeaderContentType.WwwForm)).Result;

            VerifyResponse(localVarResponse, "RequestToken");

            return localVarResponse;
        }
      
        protected ApiResponse<Token> ConnectWithHttpInfoAuthCode(string clientID, string clientSecret, string redirectUrl, string code)
        {
            var localVarPath = "/identity/connect/token";

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApiAsync(
                localVarPath,
                Method.Post,
                ComposeEmptyQueryParams(),
                FormUrlEncodedConverter.ToFormUrlEncoded(new Dictionary<string, string>
                {
                    {"grant_type", "authorization_code" },
                    {"code", code },
                    {"redirect_uri", redirectUrl },
                    {"client_id", clientID },
                    {"client_secret", clientSecret }
                   // ,                    {"scope", PrepareScopeParameter(scope) }
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
