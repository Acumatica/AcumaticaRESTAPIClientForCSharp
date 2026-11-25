using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;


namespace Acumatica.RESTClient.AuthApi
{
    /// <summary>
    /// Represents a collection of functions to interact with the Authorization endpoint
    /// </summary>
    public static partial class AuthApiExtensions
    {
		#region Public Methods
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
            if (!client.HasToken() && !client.HasSessionInfo())
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

		/// <summary>
		///     How the authorization server returns the result of the authorization request.
		/// </summary>
		public enum ResponseMode
		{
			/// <summary>The result is returned in the query string of the redirect URL. This is the default.</summary>
			Query,
			/// <summary>The result is returned in the fragment of the redirect URL.</summary>
			Fragment,
			/// <summary>The server returns an HTML form that posts the result to the redirect URL.</summary>
			FormPost
		}

		/// <summary>
		///     The scopes a token is requested for. Scopes can be combined with <c>|</c>.
		/// </summary>
		[Flags]
        public enum OAuthScope
        {
            /// <summary>No scopes.</summary>
            None = 0,
            /// <summary>Access to the API (<c>api</c>).</summary>
            API = 1,
            /// <summary>Allows getting a refresh token (<c>offline_access</c>).</summary>
            OfflineAccess = 2,
            /// <summary>Concurrent API access (<c>api:concurrent_access</c>). Without it API calls use the same session and process sequentially.</summary>
            ConcurrentAccess = 4,
            /// <summary>Allows getting an ID token (<c>openid</c>).</summary>
            OpenID = 8
        }

        /// <summary>
        ///     The response types requested from the authorize endpoint in addition to <c>code</c>.
        ///     They are used for the hybrid flow.
        /// </summary>
        [Flags]
        public enum ResponseType
        {
            /// <summary>Also request an ID token (<c>id_token</c>). Requires the OpenID scope and a nonce.</summary>
            IdToken = 1,
            /// <summary>Also request an access token (<c>token</c>) directly from the authorize endpoint.</summary>
            Token = 2
        }

        private static string PrepareResponseType(ResponseType? responseType)
        {
            StringBuilder s = new StringBuilder();
            s.Append("code");
            if (responseType != null)
            {
                if (responseType.Value.HasFlag(ResponseType.IdToken))
                    s.Append(" id_token");
                if (responseType.Value.HasFlag(ResponseType.Token))
                    s.Append(" token");
            }

            return s.ToString().TrimEnd(' ');
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
            if (scope.HasFlag(OAuthScope.OpenID))
                s.Append("openid ");

            return s.ToString().TrimEnd(' ');
        }

        #endregion
    }
}