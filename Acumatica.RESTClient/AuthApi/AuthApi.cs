using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.AuthApi.Model;
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
            RefreshAccessTokenAsync(client, clientID, clientSecret).GetAwaiter().GetResult();
        }

        public async static Task RefreshAccessTokenAsync(this ApiClient client, string clientID, string clientSecret, CancellationToken cancellationToken = default)
        {
            if (client == null || string.IsNullOrEmpty(client.Token?.Refresh_token))
                ThrowMissingParameter(nameof(RefreshAccessToken), "Refresh_Token");

            var time = DateTime.UtcNow;
            HttpResponseMessage response = await client!.CallApiAsync(
                resourcePath:       "/identity/connect/token",
                method:             HttpMethod.Post,
                queryParams:        null,
                body:               await ToFormUrlEncodedAsync(new Dictionary<string, string>()
                                    {
                                        {"grant_type", "refresh_token" },
                                        {"client_id", clientID },
                                        {"client_secret", clientSecret },
                                        {"refresh_token", client.Token!.Refresh_token! },
                                    }).ConfigureAwait(false),
                acceptType:         HeaderContentType.None,
                contentType:        HeaderContentType.WwwForm,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            client.Token = await DeserializeAsync<Token>(response).ConfigureAwait(false);
            client.Token?.SetTokenObtainedDT(time);
        }
        /// <summary>
        /// Receives access token for OAuth 2.0 authentication (Resource owner password credentials flow)
        /// </summary>
        /// <param name="client"></param>
        /// <param name="clientID"></param>
        /// <param name="clientSecret"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="scope"></param>
        public static void ReceiveAccessToken(this ApiClient client, string clientID, string clientSecret, string username, string password, OAuthScope scope)
        {
            ReceiveAccessTokenAsync(client, clientID, clientSecret, username, password, scope).GetAwaiter().GetResult();
        }
        /// <summary>
        /// Receives access token for OAuth 2.0 authentication (Resource owner password credentials flow)
        /// </summary>
        /// <param name="client"></param>
        /// <param name="clientID"></param>
        /// <param name="clientSecret"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="scope"></param>
        /// <param name="cancellationToken"></param>
        public async static Task ReceiveAccessTokenAsync(
            this ApiClient client, 
            string clientID, 
            string clientSecret, 
            string username, 
            string password, 
            OAuthScope scope, 
            CancellationToken cancellationToken = default)
        {
            var time = DateTime.UtcNow;
            HttpResponseMessage response = await client.CallApiAsync(
               resourcePath:        "identity/connect/token",
               method:              HttpMethod.Post,
               acceptType:          HeaderContentType.None,
               contentType:         HeaderContentType.WwwForm,
               body:                await ToFormUrlEncodedAsync(new Dictionary<string, string>
                                    {
                                        {"grant_type", "password" },
                                        {"client_id", clientID },
                                        {"client_secret", clientSecret },
                                        {"username", username },
                                        {"password", password },
                                        {"scope", PrepareScopeParameter(scope) }
                                    }).ConfigureAwait(false),
               cancellationToken:   cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(client, response, nameof(ReceiveAccessTokenAsync)).ConfigureAwait(false);

            client.Token = await DeserializeAsync<Token>(response).ConfigureAwait(false);
            client.Token?.SetTokenObtainedDT(time);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="clientID"></param>
        /// <param name="clientSecret"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="scope"></param>
        public static string Authorize(this ApiClient client, string clientID, string clientSecret, string redirectUrl, OAuthScope scope)
        {
            return AuthorizeAsync(client, clientID, clientSecret, redirectUrl, scope).Result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="clientID"></param>
        /// <param name="clientSecret"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="scope"></param>
        /// <param name="cancellationToken"></param>
        public async static Task<string> AuthorizeAsync(
            this ApiClient client,
            string clientID,
            string clientSecret,
            string redirectUrl,
            OAuthScope scope,
            CancellationToken cancellationToken = default)
        {
            List<KeyValuePair<string, string>> queryParams = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("response_type", "code"),
                new KeyValuePair<string, string>("client_id", clientID),
                new KeyValuePair<string, string>("scope", PrepareScopeParameter(scope)),
                new KeyValuePair<string, string>("redirect_uri",  redirectUrl)
            };

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       "identity/connect/authorize",
                method:             HttpMethod.Get,
                acceptType:         HeaderContentType.Any,
                contentType:        HeaderContentType.None,
                queryParams:        queryParams,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(client, response, "RequestToken").ConfigureAwait(false);

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
            ReceiveAccessTokenAuthCodeAsync(client, clientID, clientSecret, redirectUrl, code).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Receives access token for OAuth 2.0 authentication (Authorization code flow)
        /// </summary>
        /// <param name="client"></param>
        /// <param name="clientID"></param>
        /// <param name="clientSecret"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="code"></param>
        /// <param name="cancellationToken"></param>
        public static async Task ReceiveAccessTokenAuthCodeAsync(
            this ApiClient client, 
            string clientID, 
            string clientSecret, 
            string redirectUrl, 
            string code, 
            CancellationToken cancellationToken = default)
        {
            var time = DateTime.UtcNow;
            HttpResponseMessage response = await client.CallApiAsync(
               resourcePath:        "/identity/connect/token",
               method:              HttpMethod.Post,
               acceptType:          HeaderContentType.None,
               contentType:         HeaderContentType.WwwForm,
               body:                await ToFormUrlEncodedAsync(new Dictionary<string, string>
                                    {
                                        {"grant_type", "authorization_code" },
                                        {"code", code },
                                        {"redirect_uri", redirectUrl },
                                        {"client_id", clientID },
                                        {"client_secret", clientSecret },
                                     // {"scope", PrepareScopeParameter(scope) }
                                    }).ConfigureAwait(false),
               cancellationToken:   cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(client, response, "RequestToken").ConfigureAwait(false);

            client.Token = await DeserializeAsync<Token>(response).ConfigureAwait(false);
            client.Token?.SetTokenObtainedDT(time);
        }
        #endregion

        #region Login
        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param>
        /// <param name="username">Name of the user that is used to open a new session (required).</param>
        /// <param name="password">User password (required).</param>
        /// <param name="tenant">Defines the tenant to log in.</param>
        /// <param name="branch">Defines the branch to log in.</param>
        /// <param name="locale">Defines the locale to use for localizable data.</param>
        [Obsolete("Use OAuth 2.0 methods instead.")]
        public static void Login(this ApiClient client, string username, string password, string? tenant = null, string? branch = null, string? locale = null)
        {
            Login(client, new Credentials(name: username, password: password, tenant: tenant, branch: branch, locale: locale));
        }

        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param>
        /// <param name="username">Name of the user that is used to open a new session (required).</param>
        /// <param name="password">User password (required).</param>
        /// <param name="tenant">Defines the tenant to log in.</param>
        /// <param name="branch">Defines the branch to log in.</param>
        /// <param name="locale">Defines the locale to use for localizable data.</param>
        /// <param name="cancellationToken"></param>
        [Obsolete("Use OAuth 2.0 methods instead.")]
        public async static Task LoginAsync(this ApiClient client, 
            string username, string password, string? tenant = null, string? branch = null, string? locale = null,
            CancellationToken cancellationToken = default)
        {
            await LoginAsync(
                client:             client,
                credentials:        new Credentials(name: username, password: password, tenant: tenant, branch: branch, locale: locale),
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);
        }

        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param>
        /// <param name="credentials">
        /// <see cref="Credentials"/> object that provides information required to log into the web service.
        /// </param>
        [Obsolete("Use OAuth 2.0 methods instead.")]
        public static void Login(this ApiClient client, Credentials credentials)
        {
           LoginAsync(client, credentials).GetAwaiter().GetResult();
		}

        /// <summary>
        /// Logs in to the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="client"></param>
        /// <param name="credentials">
        /// <see cref="Credentials"/> object that provides information required to log into the web service.
        /// </param>
        /// <param name="cancellationToken"></param>
        [Obsolete("Use OAuth 2.0 methods instead.")]
        public async static Task LoginAsync(
            this ApiClient client, 
            Credentials credentials, 
            CancellationToken cancellationToken = default)
        {
            if (credentials == null)
                ThrowMissingParameter(nameof(LoginAsync), nameof(credentials));

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       "/entity/auth/login",
                method:             HttpMethod.Post,
                acceptType:         HeaderContentType.None,
                contentType:        HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm,
                body:               credentials,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(client, response, nameof(LoginAsync)).ConfigureAwait(false);
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
            LogoutAsync(client).GetAwaiter().GetResult();
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
        public static async Task LogoutAsync(this ApiClient client, CancellationToken cancellationToken = default)
        {
            if (!client.HasSessionInfo())
            {
                throw new Exception("There is no open session to log out.");
            }
            HttpResponseMessage response = await client.CallApiAsync(
               resourcePath:        "/entity/auth/logout",
               method:              HttpMethod.Post,
               acceptType:          HeaderContentType.None,
               contentType:         HeaderContentType.None,
               cancellationToken:   cancellationToken
            ).ConfigureAwait(false);

             await VerifyResponseAsync(client, response, nameof(LogoutAsync)).ConfigureAwait(false);
        }

        #endregion
        #endregion

        #region Auxiliary
        private async static Task VerifyResponseAsync(ApiClient client, HttpResponseMessage response, string methodName)
        {
            if (!response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                if (content?.Contains("API Login Limit") == true)
                {
                    throw new ApiException(429, $"Error when calling {methodName}: API login limit exceeded. Please try again later.");
                }
                else if (content?.Contains("Invalid credentials") == true)
                {
                    throw new ApiException((int)response.StatusCode, $"Error when calling {methodName}: Invalid credentials.");
                }
                throw new ApiException((int)response.StatusCode, $"Error {(int)response.StatusCode}:{response.ReasonPhrase} when calling {methodName}: {content}");
            }
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
    }
}
