using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Acumatica.Auth.Model;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Auxiliary;
using Acumatica.RESTClient.Client;


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
        public AuthApi(string basePath, int timeout = 100000,
            Action<HttpRequestMessage, HttpClient> requestInterceptor = null,
            Action<HttpResponseMessage, HttpClient> responseInterceptor = null) : base(basePath, timeout, requestInterceptor, responseInterceptor)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        protected AuthApi(ApiClient configuration) : base(configuration)
        { }
        #endregion

        #region Public Methods

        #region OAuth
        public ApiClient RefreshAccessToken(string clientID, string clientSecret, ApiClient configuration)
        {
            if (configuration == null || string.IsNullOrEmpty(ApiClient.Token?.Refresh_token))
                ThrowMissingParameter("RefreshAccessToken", "Refresh_Token");

            var result = RefreshWithHttpInfo(clientID, clientSecret, ApiClient.Token.Refresh_token);
            ApiClient.Token = result.Data;
            return configuration;
        }

        public void ReceiveAccessToken(string clientID, string clientSecret, string username, string password, OAuthScope scope)
        {
            var result = ConnectWithHttpInfo(
                clientID,
                clientSecret,
                username,
                password,
                scope);
            ApiClient.Token = result.Data;
        }

        public string Authorize(string clientID, string clientSecret, string redirectUrl, OAuthScope scope)
        {
            var response = AuthorizeWithHttpInfo(
              clientID,
              redirectUrl,
              scope);
            var locationHeader = response.Headers.Where(_ => _.Key == "Location").FirstOrDefault();
            if (!response.Headers.Where(_ => _.Key == "Location").Any())
            {
                //maybe we've already been redirected, let's take response URL in this case
                return response.RequestMessage.RequestUri.ToString();
            }
            return response.Headers.Where(_ => _.Key == "Location").First().Value.First().ToString();
        }

        public void ReceiveAccessTokenAuthCode(string clientID, string clientSecret, string redirectUrl, string code)
        {
            var result = ConnectWithHttpInfoAuthCode(
                clientID,
                clientSecret,
                redirectUrl,
                code);
            ApiClient.Token = result.Data;
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
        public void LogIn(string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            LogIn(new Credentials(name: username, password: password, tenant: tenant, branch: branch, locale: locale));
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
        public void LogIn(Credentials credentials)
        {
            AuthLoginWithHttpInfo(credentials);
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
            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                "/identity/connect/token",
                HttpMethod.Post,
                null,
                ApiClientHelpers.ToFormUrlEncoded(new Dictionary<string, string>()
                {
                    {"grant_type", "refresh_token" },
                    {"client_id", clientID },
                    {"client_secret", clientSecret },
                    {"refresh_token", refreshToken },
                }),
                HeaderContentType.None,
                HeaderContentType.WwwForm).Result;

            VerifyResponse(localVarResponse, "RefreshToken");

            return DeserializeResponse<Token>(localVarResponse);
        }

        protected ApiResponse<Token> ConnectWithHttpInfo(string clientID, string clientSecret, string username, string password, OAuthScope scope)
        {
            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                "identity/connect/token",
                HttpMethod.Post,
                null,
                ApiClientHelpers.ToFormUrlEncoded(new Dictionary<string, string>
                {
                    {"grant_type", "password" },
                    {"client_id", clientID },
                    {"client_secret", clientSecret },
                    {"username", username },
                    {"password", password },
                    {"scope", PrepareScopeParameter(scope) }
                }),
                HeaderContentType.None,
                HeaderContentType.WwwForm).Result;

            VerifyResponse(localVarResponse, "RequestToken");

            return DeserializeResponse<Token>(localVarResponse);
        }

        protected HttpResponseMessage AuthorizeWithHttpInfo(string clientID, string redirectUrl, OAuthScope scope)
        {
            //queryParameters.Add(new KeyValuePair<string, string>("response_type", "code"));
            //queryParameters.Add(new KeyValuePair<string, string>("client_id", clientID));
            //queryParameters.Add(new KeyValuePair<string, string>("scope", PrepareScopeParameter(scope)));
            //queryParameters.Add(new KeyValuePair<string, string>("redirect_uri", redirectUrl));

            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                "/identity/connect/authorize",
                HttpMethod.Get,
                null,
                null,
                HeaderContentType.None,
                HeaderContentType.WwwForm).Result;

            VerifyResponse(localVarResponse, "RequestToken");

            return localVarResponse;
        }

        protected ApiResponse<Token> ConnectWithHttpInfoAuthCode(string clientID, string clientSecret, string redirectUrl, string code)
        {
            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                "/identity/connect/token",
                HttpMethod.Post,
                null,
                ApiClientHelpers.ToFormUrlEncoded(new Dictionary<string, string>
                {
                    {"grant_type", "authorization_code" },
                    {"code", code },
                    {"redirect_uri", redirectUrl },
                    {"client_id", clientID },
                    {"client_secret", clientSecret }
                   // ,                    {"scope", PrepareScopeParameter(scope) }
                }),
                HeaderContentType.None,
                HeaderContentType.WwwForm).Result;

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
        protected ApiResponse AuthLoginWithHttpInfo(Credentials credentials)
        {
            if (credentials == null)
                ThrowMissingParameter("AuthLogin", nameof(credentials));

            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                "/entity/auth/login",
                HttpMethod.Post,
                null,
                credentials, 
                HeaderContentType.None, 
                HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm).Result;

            VerifyResponse(localVarResponse, "AuthLogin");

            return ConvertRestResponeToApiResponse(localVarResponse);
        }

        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials"></param>
        /// <returns>Task of ApiResponse</returns>
        protected async Task<ApiResponse> AuthLoginAsyncWithHttpInfo(Credentials credentials)
        {
            if (credentials == null)
                ThrowMissingParameter("AuthLogin", nameof(credentials));

            HttpResponseMessage localVarResponse = await ApiClient.CallApiAsync(
                "/entity/auth/login",
                HttpMethod.Post,
                null,
                credentials, 
                HeaderContentType.None, 
                HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm);

            VerifyResponse(localVarResponse, "AuthLogin");

            return ConvertRestResponeToApiResponse(localVarResponse);
        }

        /// <summary>
        /// Logs out from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        protected ApiResponse AuthLogoutWithHttpInfo()
        {

            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                "/entity/auth/logout",
                HttpMethod.Post,
                null,
                null, 
                HeaderContentType.None, 
                HeaderContentType.None).Result;

            VerifyResponse(localVarResponse, "AuthLogout");

            return ConvertRestResponeToApiResponse(localVarResponse);
        }

        /// <summary>
        /// Logs out from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        protected async Task<ApiResponse> AuthLogoutAsyncWithHttpInfo()
        {

            HttpResponseMessage localVarResponse = await ApiClient.CallApiAsync(
                "/entity/auth/logout",
                HttpMethod.Post,
                null,
                null,
                HeaderContentType.None,
                HeaderContentType.None);

            VerifyResponse(localVarResponse, "AuthLogout");

            return ConvertRestResponeToApiResponse(localVarResponse);
        }
        #endregion
    }
}
