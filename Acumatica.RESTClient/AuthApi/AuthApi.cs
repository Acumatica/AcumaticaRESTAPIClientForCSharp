using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
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
            Task.Run(() => RefreshAccessTokenAsync(client, clientID, clientSecret)).GetAwaiter().GetResult();
        }

        public async static Task RefreshAccessTokenAsync(this ApiClient client, string clientID, string clientSecret)
        {
            if (client == null || string.IsNullOrEmpty(client.Token?.Refresh_token))
                ApiClientHelpers.ThrowMissingParameter(nameof(RefreshAccessToken), "Refresh_Token");

            HttpResponseMessage response = await client.CallApiAsync(
               "/identity/connect/token",
               HttpMethod.Post,
               null,
               await ApiClientHelpers.ToFormUrlEncodedAsync(new Dictionary<string, string>()
               {
                    {"grant_type", "refresh_token" },
                    {"client_id", clientID },
                    {"client_secret", clientSecret },
                    {"refresh_token", client.Token.Refresh_token },
               }),
               HeaderContentType.None,
               HeaderContentType.WwwForm);

            response.EnsureSuccessStatusCode();

            client.Token = (Token)await DeserializeAsync<Token>(response);
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
            Task.Run(() => ReceiveAccessTokenAsync(client, clientID, clientSecret, username, password, scope)).GetAwaiter().GetResult();
        }
        /// <summary>
        /// Receives access token for OAuth 2.0 authentication (Resource owner password credentials flow)
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="clientSecret"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="scope"></param>
        public async static Task ReceiveAccessTokenAsync(this ApiClient client, string clientID, string clientSecret, string username, string password, OAuthScope scope)
        {
            HttpResponseMessage response = await client.CallApiAsync(
               "identity/connect/token",
               HttpMethod.Post,
               null,
               await ApiClientHelpers.ToFormUrlEncodedAsync(new Dictionary<string, string>
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

            await VerifyResponseAsync(client, response, nameof(ReceiveAccessTokenAsync));

            client.Token = (Token)await DeserializeAsync<Token>(response);
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
            return AuthorizeAsync(client, clientID, clientSecret, redirectUrl, scope).Result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="clientSecret"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="scope"></param>
        public async static Task<string> AuthorizeAsync(this ApiClient client, string clientID, string clientSecret, string redirectUrl, OAuthScope scope)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                "/identity/connect/authorize",
                HttpMethod.Get,
                null,
                null,
                HeaderContentType.None,
                HeaderContentType.WwwForm);

            await VerifyResponseAsync(client, response, "RequestToken");

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
            Task.Run(() => ReceiveAccessTokenAuthCodeAsync(client, clientID, clientSecret, redirectUrl, code)).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Receives access token for OAuth 2.0 authentication (Authorization code flow)
        /// </summary>
        /// <param name="client"></param>
        /// <param name="clientID"></param>
        /// <param name="clientSecret"></param>
        /// <param name="redirectUrl"></param>
        /// <param name="code"></param>
        public static async Task ReceiveAccessTokenAuthCodeAsync(this ApiClient client, string clientID, string clientSecret, string redirectUrl, string code)
        {
            HttpResponseMessage response = await client.CallApiAsync(
               "/identity/connect/token",
               HttpMethod.Post,
               null,
               await ApiClientHelpers.ToFormUrlEncodedAsync(new Dictionary<string, string>
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

            await VerifyResponseAsync(client, response, "RequestToken");

            client.Token = (Token)await DeserializeAsync<Token>(response);
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
        public static void Login(this ApiClient client, string username, string password, string? tenant = null, string? branch = null, string? locale = null)
        {
            Login(client, new Credentials(name: username, password: password, tenant: tenant, branch: branch, locale: locale));
        }

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
        public async static Task LoginAsync(this ApiClient client, string username, string password, string? tenant = null, string? branch = null, string? locale = null)
        {
            await LoginAsync(client, new Credentials(name: username, password: password, tenant: tenant, branch: branch, locale: locale));
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
           Task.Run(() => LoginAsync(client, credentials)).GetAwaiter().GetResult();
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
        public async static Task LoginAsync(this ApiClient client, Credentials credentials)
        {
            if (credentials == null)
                ApiClientHelpers.ThrowMissingParameter(nameof(LoginAsync), nameof(credentials));

            HttpResponseMessage response = await client.CallApiAsync(
                "/entity/auth/login",
                HttpMethod.Post,
                null,
                credentials,
                HeaderContentType.None,
                HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm);

            await VerifyResponseAsync(client, response, nameof(LoginAsync));
            if (response.Headers.TryGetValues("Set-Cookie", out var cookieValues))
            {
                client.Cookies = cookieValues;
            }              
            client.SharedCookieContainer = new CookieContainer();

           SetCookiesFromResponse(response, client.SharedCookieContainer);
        }
        #endregion
    

    #region Logout
    /// <summary>
    /// Logs out from the system. 
    /// </summary>
    /// <exception cref="ApiException">Thrown when fails to make API call</exception>
    /// <returns></returns>
    public static HttpResponseMessage Logout(this ApiClient client)
        {
            return Task.Run(() => LogoutAsync(client)).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Logs out from the system without throwing exceptions if the logout failed.
        /// </summary>
        /// <returns>Returns <c>true</c> if the logout has been successful</returns>
        public static bool TryLogout(this ApiClient client)
        {
            try
            {             
                var response = Logout(client);
                if(!HasSessionInfo(response, client))
                {
                    return false;
                }
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
        public static async Task<HttpResponseMessage> LogoutAsync(this ApiClient client)
        {
            HttpResponseMessage response = await client.CallApiAsync(
               "/entity/auth/logout",
               HttpMethod.Post,
               null,
               null,
               HeaderContentType.None,
               HeaderContentType.None);

             await VerifyResponseAsync(client, response, nameof(LogoutAsync));
            return response;
        }

        #endregion
        #endregion

        #region Auxiliary
        private async static Task VerifyResponseAsync(ApiClient client, HttpResponseMessage response, string methodName)
        {
            if (!response.IsSuccessStatusCode)
            {
                //if content as string contains string "API login limit", report separate error
                if (response.Content != null && (await response.Content.ReadAsStringAsync()).Contains("API Login Limit"))
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

        private static void SetCookiesFromResponse(HttpResponseMessage response, CookieContainer cookieContainer)
        {
            // Check if the response contains any cookies.
            if (response.Headers.TryGetValues("Set-Cookie", out var cookieValues))
            {
                
                foreach (var cookieValue in cookieValues)
                {
                    // Parse the cookie string.
                    var cookie = new Cookie();
                    Console.WriteLine(cookie.Value);
                    cookieContainer.SetCookies(response.RequestMessage.RequestUri, cookieValue);
                }
            }
        }
        private static bool HasSessionInfo(HttpResponseMessage response, ApiClient client)
        {
            if (client?.Cookies != null)
            {
                foreach (var cookieValue in client.Cookies)
                {
                    var sessionInfo = GetSessionInfoFromResponse(response);
                    if (!string.IsNullOrEmpty(sessionInfo) && !string.IsNullOrEmpty(cookieValue) && cookieValue.Contains(sessionInfo))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static string GetSessionInfoFromResponse(HttpResponseMessage response)
        {
            // Check if the response contains any cookies.
            if (response.RequestMessage.Headers.TryGetValues("Cookie", out var cookieValues))
            {

                foreach (var cookieValue in cookieValues)
                {
                    if (!string.IsNullOrEmpty(cookieValue) && cookieValue.Contains("ASP.NET_SessionId"))
                    {
                        var startIndex = cookieValue.IndexOf("ASP.NET_SessionId=") + "ASP.NET_SessionId=".Length;
                        return cookieValue.Substring(startIndex).Split(';')[0];
                    }
                }
            }
            return string.Empty;
        }
        #endregion
    }
}
