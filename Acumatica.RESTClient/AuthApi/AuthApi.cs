using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.AuthApi.Model;
using Acumatica.RESTClient.Auxiliary;
using Acumatica.RESTClient.Client;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;


namespace Acumatica.RESTClient.AuthApi
{
    /// <summary>
    /// Represents a collection of functions to interact with the Authorization endpoint
    /// </summary>
    public static class AuthApiExtensions
    {
        #region Public Methods
        #region OAuth
        public static void RefreshAccessToken(this ApiClient client, string clientID, string clientSecret)
        {
            if (client == null || string.IsNullOrEmpty(client.Token?.Refresh_token))
                ApiClientHelpers.ThrowMissingParameter("RefreshAccessToken", "Refresh_Token");

            client.Token = RefreshAsyncWithHttpInfo(
                client, 
                clientID, 
                clientSecret, 
                client.Token.Refresh_token).Result;
        }

        /// <summary>
        /// Receives access token for OAuth 2.0 authentication (Resource owner password credentials flow)
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="clientSecret"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="scope"></param>
        public static void ReceiveAccessToken(this ApiClient client, string clientID, string clientSecret, string username, string password, OAuthScope scope)
        {
            client.Token = ConnectAsyncWithHttpInfo(
                client,
                clientID,
                clientSecret,
                username,
                password,
                scope).Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="clientSecret"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="scope"></param>
        public static string Authorize(this ApiClient client, string clientID, string clientSecret, string redirectUrl, OAuthScope scope)
        {
            var response = AuthorizeAsyncWithHttpInfo(
              client,
              clientID,
              redirectUrl,
              scope).Result;
            var locationHeader = response.Headers.Where(_ => _.Key == "Location").FirstOrDefault();
            if (!response.Headers.Where(_ => _.Key == "Location").Any())
            {
                //maybe we've already been redirected, let's take response URL in this case
                return response.RequestMessage.RequestUri.ToString();
            }
            return response.Headers.Where(_ => _.Key == "Location").First().Value.First().ToString();
        }

        /// <summary>
        /// Receives access token for OAuth 2.0 authentication (Authorization code flow)
        /// </summary>
        /// <param name="client"></param>
        /// <param name="clientID"></param>
        /// <param name="clientSecret"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="code"></param>
        public static void ReceiveAccessTokenAuthCode(this ApiClient client, string clientID, string clientSecret, string redirectUrl, string code)
        {
            client.Token = ConnectAsyncWithHttpInfoAuthCode(
                client,
                clientID,
                clientSecret,
                redirectUrl,
                code).Result;
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
        public static void Login(this ApiClient client, string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            Login(client, new Credentials(name: username, password: password, tenant: tenant, branch: branch, locale: locale));
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
        public static void Login(this ApiClient client, Credentials credentials)
        {
            AuthLoginAsyncWithHttpInfo(client, credentials).RunSynchronously();
        }
        #endregion

        #region Logout
        /// <summary>
        /// Logs out from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public static void Logout(this ApiClient client)
        {
            AuthLogoutAsyncWithHttpInfo(client).RunSynchronously();
        }

        /// <summary>
        /// Logs out from the system without throwing exceptions if the logout failed.
        /// </summary>
        /// <returns>Returns <c>true</c> if the logout has been successful</returns>
        public static bool TryLogout(this ApiClient client)
        {
            try
            {
                Logout(client);
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
        public static async Task LogoutAsync(this ApiClient client)
        {
            await AuthLogoutAsyncWithHttpInfo(client);
        }

        #endregion
        #endregion

        #region Implementation
        #region Auxiliary
        private static void VerifyResponse(ApiClient client, HttpResponseMessage response, string methodName)
        {
            if (!response.IsSuccessStatusCode)
            {
                //if content as string contains string "API login limit", report separate error
                if (response.Content != null && response.Content.ReadAsStringAsync().Result.Contains("API Login Limit"))
                {
                    throw new ApiException(429, $"Error when calling {methodName}: API login limit exceeded. Please try again later.");
                }
            }
            response.EnsureSuccessStatusCode();
        }

        [Flags]
        public enum OAuthScope
        {
            None = 0,
            API = 1,
            OfflineAccess = 2,
            ConcurrentAccess = 4
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
        #endregion

        #region Api Calls
        private static async Task<Token> RefreshAsyncWithHttpInfo(ApiClient client, string clientID, string clientSecret, string refreshToken)
        {
            HttpResponseMessage response = await client.CallApiAsync(
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
                HeaderContentType.WwwForm);

            response.EnsureSuccessStatusCode();

            return (Token)Deserialize<Token>(response);
        }

        private static async Task<Token> ConnectAsyncWithHttpInfo(ApiClient client, string clientID, string clientSecret, string username, string password, OAuthScope scope)
        {
            HttpResponseMessage response = await client.CallApiAsync(
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
                HeaderContentType.WwwForm);

            VerifyResponse(client, response, "RequestToken");

            return (Token)Deserialize<Token>(response);
        }

        private static async Task<HttpResponseMessage> AuthorizeAsyncWithHttpInfo(ApiClient client, string clientID, string redirectUrl, OAuthScope scope)
        {
              HttpResponseMessage response = await client.CallApiAsync(
                "/identity/connect/authorize",
                HttpMethod.Get,
                null,
                null,
                HeaderContentType.None,
                HeaderContentType.WwwForm);

            VerifyResponse(client, response, "RequestToken");

            return response;
        }

        private static async Task<Token> ConnectAsyncWithHttpInfoAuthCode(ApiClient client, string clientID, string clientSecret, string redirectUrl, string code)
        {
            HttpResponseMessage response = await client.CallApiAsync(
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
                HeaderContentType.WwwForm);

            VerifyResponse(client, response, "RequestToken");

            return (Token)Deserialize<Token>(response);
        }

        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="credentials"></param>
        private static async Task AuthLoginAsyncWithHttpInfo(ApiClient client, Credentials credentials)
        {
            if (credentials == null)
                ApiClientHelpers.ThrowMissingParameter("AuthLogin", nameof(credentials));

            HttpResponseMessage response = await client.CallApiAsync(
                "/entity/auth/login",
                HttpMethod.Post,
                null,
                credentials,
                HeaderContentType.None,
                HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm);

            VerifyResponse(client, response, "AuthLogin");
        }

        /// <summary>
        /// Logs out from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        private static async Task AuthLogoutAsyncWithHttpInfo(ApiClient client)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                "/entity/auth/logout",
                HttpMethod.Post,
                null,
                null,
                HeaderContentType.None,
                HeaderContentType.None);

            VerifyResponse(client, response, "AuthLogout");
        }
        #endregion
        #endregion
    }
}
