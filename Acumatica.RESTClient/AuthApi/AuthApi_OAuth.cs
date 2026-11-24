using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.AuthApi.Model;
using Acumatica.RESTClient.Client;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;


namespace Acumatica.RESTClient.AuthApi
{
    public static partial class AuthApiExtensions
    {
		#region Refresh Token
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
		#endregion
		#region Client Credentials Flow
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
		#endregion
		#region Authorization Code Flow
		/// <summary>
		/// 
		/// </summary>
		/// <param name="client"></param>
		/// <param name="clientID"></param>
		/// <param name="clientSecret"></param>
		/// <param name="redirectUrl"></param>
		/// <param name="scope"></param>
		/// <param name="responseType"></param>
		/// <param name="usePost"></param>
		/// <param name="nonce"></param>
		public static string Authorize(this ApiClient client, string clientID, string clientSecret, string redirectUrl, OAuthScope scope, ResponseType? responseType = null, bool usePost = false, string nonce = "")
        {
            return AuthorizeAsync(client, clientID, clientSecret, redirectUrl, scope, responseType: responseType, usePost: usePost, nonce: nonce).GetAwaiter().GetResult();
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
		/// <param name="responseType"></param>
		/// <param name="usePost"></param>
		/// <param name="nonce"></param>
		public async static Task<string> AuthorizeAsync(
            this ApiClient client, 
            string clientID, 
            string clientSecret, 
            string redirectUrl, 
            OAuthScope scope, 
            CancellationToken cancellationToken = default,
            ResponseType? responseType = null,
            bool usePost = false,
            string nonce = "")
        {
			List<KeyValuePair<string, string>> queryParams = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("response_type", PrepareResponseType(responseType)),
                new KeyValuePair<string, string>("client_id", clientID),
                new KeyValuePair<string, string>("scope", PrepareScopeParameter(scope)),
                new KeyValuePair<string, string>("redirect_uri",  redirectUrl),
                new KeyValuePair<string, string>("response_mode",  usePost ? "form_post" : "fragment"),
			};


			if (!string.IsNullOrEmpty(nonce))
			{
				queryParams.Add(new KeyValuePair<string, string>("nonce", nonce));
			}

			HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       "identity/connect/authorize",
                method:             HttpMethod.Get,
                acceptType:         HeaderContentType.Any,
                contentType:        HeaderContentType.None,
                queryParams:        queryParams,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(client, response, "RequestToken").ConfigureAwait(false);

			var locationHeaders = response.Headers.FirstOrDefault(_ => string.Equals(_.Key, "Location", StringComparison.OrdinalIgnoreCase));
			string returnUrl;
			if (locationHeaders.Value == null || !locationHeaders.Value.Any())
			{
				//maybe we've already been redirected, let's take response URL in this case
				returnUrl = response.RequestMessage.RequestUri.ToString();
			}
			else
			{
				returnUrl = locationHeaders.Value.First().ToString();
			}
            return returnUrl;
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
                                    }).ConfigureAwait(false),
               cancellationToken:   cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(client, response, "RequestToken").ConfigureAwait(false);

            client.Token = await DeserializeAsync<Token>(response).ConfigureAwait(false);
            client.Token?.SetTokenObtainedDT(time);
        }
		#endregion
	}
}