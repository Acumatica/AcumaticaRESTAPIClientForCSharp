using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.AuthApi.Model;
using Acumatica.RESTClient.Client;

using Newtonsoft.Json.Linq;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;


namespace Acumatica.RESTClient.AuthApi
{
	public static partial class AuthApiExtensions
	{
		#region Refresh Token
		/// <inheritdoc cref="RefreshAccessTokenAsync(ApiClient,string,string,CancellationToken)"/>
		public static void RefreshAccessToken(this ApiClient client, string clientID, string clientSecret)
		{
			RefreshAccessTokenAsync(client, clientID, clientSecret).GetAwaiter().GetResult();
		}

		/// <summary>
		/// Gets a new access token using the refresh token stored on the client.
		/// </summary>
		/// <remarks>
		/// Works only if the OfflineAccess scope was requested at sign-in, so that a refresh token was issued.
		/// </remarks>
		/// <param name="client">The API client. The token is stored on it.</param>
		/// <param name="clientID">The Client ID of the connected application in Acumatica.</param>
		/// <param name="clientSecret">The client secret of the connected application.</param>
		/// <param name="cancellationToken">Token to cancel the call.</param>
		public async static Task RefreshAccessTokenAsync(this ApiClient client, string clientID, string clientSecret, CancellationToken cancellationToken = default)
		{
			if (client == null || string.IsNullOrEmpty(client.Token?.Refresh_token))
				ThrowMissingParameter(nameof(RefreshAccessToken), "Refresh_Token");
			var time = DateTime.UtcNow;
			HttpResponseMessage response = await client!.CallApiAsync(
				resourcePath: "/identity/connect/token",
				method: HttpMethod.Post,
				queryParams: null,
				body: await ToFormUrlEncodedAsync(new Dictionary<string, string>()
									{
										{"grant_type", "refresh_token" },
										{"client_id", clientID },
										{"client_secret", clientSecret },
										{"refresh_token", client.Token!.Refresh_token! },
									}).ConfigureAwait(false),
				acceptType: HeaderContentType.None,
				contentType: HeaderContentType.WwwForm,
				cancellationToken: cancellationToken
			).ConfigureAwait(false);

			response.EnsureSuccessStatusCode();

			client.Token = await DeserializeAsync<Token>(response).ConfigureAwait(false);
			client.Token?.SetTokenObtainedDT(time);
		}
		#endregion
		#region Client Credentials Flow
		/// <inheritdoc cref="ReceiveAccessTokenAsync(ApiClient,string,string,string,string,OAuthScope,CancellationToken)"/>
		public static void ReceiveAccessToken(this ApiClient client, string clientID, string clientSecret, string username, string password, OAuthScope scope)
		{
			ReceiveAccessTokenAsync(client, clientID, clientSecret, username, password, scope).GetAwaiter().GetResult();
		}
		/// <summary>
		/// Signs in with a username and password and stores the access token on the client.
		/// Uses the OAuth 2.0 "password" flow.
		/// </summary>
		/// <param name="client">The API client. The token is stored on it.</param>
		/// <param name="clientID">The Client ID of the connected application in Acumatica.</param>
		/// <param name="clientSecret">The client secret of the connected application.</param>
		/// <param name="username">The Acumatica user to sign in as.</param>
		/// <param name="password">The user's password.</param>
		/// <param name="scope">What the token is allowed to do, e.g. <c>OAuthScope.API</c>. Scopes can be combined with <c>|</c>.</param>
		/// <param name="cancellationToken">Token to cancel the call.</param>
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
			   resourcePath: "identity/connect/token",
			   method: HttpMethod.Post,
			   acceptType: HeaderContentType.None,
			   contentType: HeaderContentType.WwwForm,
			   body: await ToFormUrlEncodedAsync(new Dictionary<string, string>
									{
										{"grant_type", "password" },
										{"client_id", clientID },
										{"client_secret", clientSecret },
										{"username", username },
										{"password", password },
										{"scope", PrepareScopeParameter(scope) }
									}).ConfigureAwait(false),
			   cancellationToken: cancellationToken
			).ConfigureAwait(false);

			await VerifyResponseAsync(client, response, nameof(ReceiveAccessTokenAsync)).ConfigureAwait(false);

			client.Token = await DeserializeAsync<Token>(response).ConfigureAwait(false);
			client.Token?.SetTokenObtainedDT(time);
		}
		#endregion
		#region Authorization Code Flow
		/// <summary>
		/// Step 1 of the authorization code flow: gets the URL where the user signs in.
		/// The returned URL is meant to be opened in a browser. After the user signs in, the browser is redirected to <c>redirectUrl</c>. 
		/// That callback URL is then passed to <c>ReceiveAccessTokenAuthCode</c> to complete the flow.
		/// </summary>
		/// <param name="client">The API client.</param>
		/// <param name="clientID">The Client ID of the connected application in Acumatica.</param>
		/// <param name="redirectUrl">Where Acumatica sends the browser after sign-in. Must exactly match a redirect URI registered for the client.</param>
		/// <param name="scope">What the token is allowed to do, e.g. <c>OAuthScope.API | OAuthScope.OfflineAccess</c>.</param>
		/// <param name="responseType">Optional. Additional response types on top of <c>code</c>, used for the hybrid flow. Not needed for the plain authorization code flow.</param>
		/// <param name="responseMode">Optional. How the result is returned. <c>Query</c> is the default. With <c>FormPost</c>, the server returns an HTML form instead of redirecting.</param>
		/// <param name="codeChallenge">Optional. The S256 PKCE code challenge. The matching <c>codeVerifier</c> is passed when receiving the token.</param>
		/// <param name="nonce">Optional. A random value that is included in the ID token. The same value is passed as <c>expectedNonce</c> when receiving the token (requires the OpenID scope).</param>
		/// <param name="state">Optional. A random value that is returned on the callback. The same value is passed as <c>expectedState</c> when receiving the token to detect forged callbacks.</param>
		/// <returns>The URL to open in a browser.</returns>
		public static string Authorize(this ApiClient client,
			string clientID,
			string redirectUrl,
			OAuthScope scope,
			ResponseType? responseType = null,
			ResponseMode responseMode = ResponseMode.Query,
			string codeChallenge = "",
			string nonce = "",
			string state = "")
		{
			return AuthorizeAsync(client, clientID, redirectUrl, scope, responseType: responseType, responseMode: responseMode, codeChallenge: codeChallenge, nonce: nonce, state: state).GetAwaiter().GetResult();
		}
		/// <summary>
		/// Step 1 of the authorization code flow: gets the URL where the user signs in.
		/// The returned URL is meant to be opened in a browser. After the user signs in, the browser is redirected to <c>redirectUrl</c>. That callback URL is then passed to <c>ReceiveAccessTokenAuthCode</c> to complete the flow.
		/// </summary>
		/// <param name="client">The API client.</param>
		/// <param name="clientID">The Client ID of the connected application in Acumatica.</param>
		/// <param name="redirectUrl">Where Acumatica sends the browser after sign-in. Must exactly match a redirect URI registered for the client.</param>
		/// <param name="scope">What the token is allowed to do, e.g. <c>OAuthScope.API | OAuthScope.OfflineAccess</c>.</param>
		/// <param name="responseType">Optional. Additional response types on top of <c>code</c>, used for the hybrid flow. Not needed for the plain authorization code flow.</param>
		/// <param name="responseMode">Optional. How the result is returned. <c>Query</c> is the default. With <c>FormPost</c>, the server returns an HTML form instead of redirecting.</param>
		/// <param name="codeChallenge">Optional. The S256 PKCE code challenge. The matching <c>codeVerifier</c> is passed when receiving the token.</param>
		/// <param name="nonce">Optional. A random value that is included in the ID token. The same value is passed as <c>expectedNonce</c> when receiving the token (requires the OpenID scope).</param>
		/// <param name="state">Optional. A random value that is returned on the callback. The same value is passed as <c>expectedState</c> when receiving the token to detect forged callbacks.</param>
		/// <param name="cancellationToken">Token to cancel the call.</param>
		/// <returns>The URL to open in a browser.</returns>
		public async static Task<string> AuthorizeAsync(
			this ApiClient client,
			string clientID,
			string redirectUrl,
			OAuthScope scope,
			ResponseType? responseType = null,
			ResponseMode responseMode = ResponseMode.Query,
			string codeChallenge = "",
			string nonce = "",
			string state = "",
			CancellationToken cancellationToken = default)
		{
			if (string.IsNullOrEmpty(clientID)) throw new ArgumentException("Required.", nameof(clientID));
			if (string.IsNullOrEmpty(redirectUrl)) throw new ArgumentException("Required.", nameof(redirectUrl));

			List<KeyValuePair<string, string>> queryParams = new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("response_type", PrepareResponseType(responseType)),
				new KeyValuePair<string, string>("client_id", clientID),
				new KeyValuePair<string, string>("scope", PrepareScopeParameter(scope)),
				new KeyValuePair<string, string>("redirect_uri",  redirectUrl),
				new KeyValuePair<string, string>("response_mode",  PrepareResponseMode(responseMode)),
			};

			if (!string.IsNullOrEmpty(state))
			{
				queryParams.Add(new KeyValuePair<string, string>("state", state));
			}
			if (!string.IsNullOrEmpty(nonce))
			{
				queryParams.Add(new KeyValuePair<string, string>("nonce", nonce));
			}
			if (!string.IsNullOrEmpty(codeChallenge))
			{
				queryParams.Add(new KeyValuePair<string, string>("code_challenge", codeChallenge));
				queryParams.Add(new KeyValuePair<string, string>("code_challenge_method", "S256"));
			}

			using HttpResponseMessage response = await client.CallApiAsync(
				resourcePath: "identity/connect/authorize",
				method: HttpMethod.Get,
				acceptType: HeaderContentType.Any,
				contentType: HeaderContentType.None,
				queryParams: queryParams,
				cancellationToken: cancellationToken
			).ConfigureAwait(false);

			await VerifyResponseAsync(client, response, nameof(AuthorizeAsync)).ConfigureAwait(false);

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

		private static string PrepareResponseMode(ResponseMode responseMode)
		{
			string response_mode;
			switch (responseMode)
			{
				case ResponseMode.Query: response_mode = "query"; break;
				case ResponseMode.Fragment: response_mode = "fragment"; break;
				case ResponseMode.FormPost: response_mode = "form_post"; break;
				default:
					throw new ArgumentOutOfRangeException(nameof(responseMode), responseMode, $"Invalid responseMode value: {responseMode}.");
			}

			return response_mode;
		}
		/// <inheritdoc cref="ReceiveAccessTokenAuthCodeAsync(ApiClient,string,string,string,string,string,string,CancellationToken)"/>
		public static void ReceiveAccessTokenAuthCode(
			this ApiClient client,
			string clientID,
			string clientSecret,
			string redirectUrl,
			string code,
			string codeVerifier = "",
			string expectedNonce = "")
		{
			ReceiveAccessTokenAuthCodeAsync(client, clientID, clientSecret, redirectUrl, code, codeVerifier: codeVerifier, expectedNonce: expectedNonce).GetAwaiter().GetResult();
		}

		/// <summary>
		/// Step 2 of the authorization code flow: exchanges the callback URL for an access token and stores it on the client.
		/// This overload reads the code from the URL, validates <c>state</c> if <c>expectedState</c> is provided, and reports any error returned by Acumatica.
		/// </summary>
		/// <param name="client">The API client. The token is stored on it.</param>
		/// <param name="clientID">The Client ID of the connected application in Acumatica.</param>
		/// <param name="clientSecret">The client secret.</param>
		/// <param name="callbackUrl">The full URL the browser was redirected to after sign-in. The authorization code is extracted from it.</param>
		/// <param name="codeVerifier">Optional. The PKCE code verifier that matches the <c>codeChallenge</c> sent to <c>Authorize</c>.</param>
		/// <param name="expectedNonce">Optional. The same <c>nonce</c> that was sent to <c>Authorize</c>. If provided, it is checked against the ID token (requires the OpenID scope).</param>
		/// <param name="expectedState">Optional. The same <c>state</c> that was sent to <c>Authorize</c>. If provided, a callback with a different value is rejected.</param>
		public static void ReceiveAccessTokenAuthCode(
			this ApiClient client,
			string clientID,
			string clientSecret,
			Uri callbackUrl,
			string codeVerifier = "",
			string expectedNonce = "",
			string expectedState = "")
		{
			ReceiveAccessTokenAuthCodeAsync(client, clientID, clientSecret, callbackUrl, codeVerifier: codeVerifier, expectedNonce: expectedNonce, expectedState: expectedState).GetAwaiter().GetResult();
		}

		/// <summary>
		/// Step 2 of the authorization code flow: exchanges the authorization code for an access token and stores it on the client.
		/// This overload takes the <c>code</c> that was already extracted from the callback.
		/// </summary>
		/// <param name="client">The API client. The token is stored on it.</param>
		/// <param name="clientID">The Client ID of the connected application in Acumatica.</param>
		/// <param name="clientSecret">The client secret.</param>
		/// <param name="redirectUrl">The same redirect URL that was used in <c>Authorize</c>.</param>
		/// <param name="code">The authorization code from the callback.</param>
		/// <param name="codeVerifier">Optional. The PKCE code verifier that matches the <c>codeChallenge</c> sent to <c>Authorize</c>.</param>
		/// <param name="expectedNonce">Optional. The same <c>nonce</c> that was sent to <c>Authorize</c>. If provided, it is checked against the ID token (requires the OpenID scope).</param>
		/// <param name="cancellationToken">Token to cancel the call.</param>
		public static async Task ReceiveAccessTokenAuthCodeAsync(
			this ApiClient client,
			string clientID,
			string clientSecret,
			string redirectUrl,
			string code,
			string codeVerifier = "",
			string expectedNonce = "",
			CancellationToken cancellationToken = default)
		{
			var time = DateTime.UtcNow;

			var bodyParams = new Dictionary<string, string>
			{
				{ "grant_type", "authorization_code" },
				{ "code", code },
				{ "redirect_uri", redirectUrl },
				{ "client_id", clientID },
			};

			if (!string.IsNullOrEmpty(clientSecret))
			{
				bodyParams.Add("client_secret", clientSecret);
			}
			if (!string.IsNullOrEmpty(codeVerifier))
			{
				bodyParams.Add("code_verifier", codeVerifier);
			}

			using HttpResponseMessage response = await client.CallApiAsync(
			   resourcePath: "/identity/connect/token",
			   method: HttpMethod.Post,
			   acceptType: HeaderContentType.None,
			   contentType: HeaderContentType.WwwForm,
			   body: await ToFormUrlEncodedAsync(bodyParams).ConfigureAwait(false),
			   cancellationToken: cancellationToken
			).ConfigureAwait(false);

			await VerifyResponseAsync(client, response, nameof(ReceiveAccessTokenAuthCodeAsync)).ConfigureAwait(false);
			var token = await DeserializeAsync<Token>(response).ConfigureAwait(false);
			if (token == null)
			{
				throw new InvalidOperationException("Token response is null.");
			}
			if (!string.IsNullOrEmpty(expectedNonce))
			{
				VerifyIdTokenNonce(token.Id_token, expectedNonce);
			}
			client.Token = token;
			client.Token.SetTokenObtainedDT(time);
		}
		/// <summary>
		/// Step 2 of the authorization code flow: exchanges the callback URL for an access token and stores it on the client.
		/// This overload reads the code from the URL, validates <c>state</c> if <c>expectedState</c> is provided, and reports any error returned by Acumatica.
		/// </summary>
		/// <param name="client">The API client. The token is stored on it.</param>
		/// <param name="clientID">The Client ID of the connected application in Acumatica.</param>
		/// <param name="clientSecret">The client secret.</param>
		/// <param name="callbackUrl">The full URL the browser was redirected to after sign-in. The authorization code is extracted from it. Only if ResponseType is query</param>
		/// <param name="codeVerifier">Optional. The PKCE code verifier that matches the <c>codeChallenge</c> sent to <c>Authorize</c>.</param>
		/// <param name="expectedNonce">Optional. The same <c>nonce</c> that was sent to <c>Authorize</c>. If provided, it is checked against the ID token (requires the OpenID scope).</param>
		/// <param name="expectedState">Optional. The same <c>state</c> that was sent to <c>Authorize</c>. If provided, a callback with a different value is rejected.</param>
		/// <param name="cancellationToken">Token to cancel the call.</param>
		public static async Task ReceiveAccessTokenAuthCodeAsync(
			this ApiClient client,
			string clientID,
			string clientSecret,
			Uri callbackUrl,
			string codeVerifier = "",
			string expectedNonce = "",
			string expectedState = "",
			CancellationToken cancellationToken = default)
		{

			if (callbackUrl == null) throw new ArgumentNullException(nameof(callbackUrl));
			if (!callbackUrl.IsAbsoluteUri) throw new ArgumentException("Callback URL must be absolute.", nameof(callbackUrl));

			string rawParams = callbackUrl.Fragment.Length > 1 ? callbackUrl.Fragment.Substring(1) : callbackUrl.Query;
			var callbackParams = HttpUtility.ParseQueryString(rawParams);

			if (!string.IsNullOrEmpty(expectedState) &&
				!string.Equals(callbackParams["state"], expectedState, StringComparison.Ordinal))
				throw new InvalidOperationException(
					$"State mismatch, possible CSRF. Server error: {callbackParams["error"] ?? "none"}");

			if (callbackParams["error"] != null)
				throw new InvalidOperationException(
					$"Authorization failed: {callbackParams["error"]} {callbackParams["error_description"]}");

			string code = callbackParams["code"]
				?? throw new InvalidOperationException("No code found in the callback URL.");
			string redirectUrl = callbackUrl.GetLeftPart(UriPartial.Path);

			await ReceiveAccessTokenAuthCodeAsync(
				client,
				clientID,
				clientSecret,
				redirectUrl,
				code,
				codeVerifier: codeVerifier,
				expectedNonce: expectedNonce,
				cancellationToken: cancellationToken).ConfigureAwait(false);
		}
		private static void VerifyIdTokenNonce(string? idToken, string expectedNonce)
		{
			if (string.IsNullOrEmpty(idToken))
				throw new InvalidOperationException(
					"A nonce check was requested, but the token response has no id_token " +
					"(is the openid scope requested and allowed for this client?).");

			string[] parts = idToken!.Split('.');
			if (parts.Length != 3)
				throw new InvalidOperationException("ID token is not a valid JWT.");

			string payloadJson = Encoding.UTF8.GetString(Base64UrlDecode(parts[1]));
			string? nonce = (string?)JObject.Parse(payloadJson)["nonce"];   // null if the claim is missing

			if (!string.Equals(nonce, expectedNonce, StringComparison.Ordinal))
				throw new InvalidOperationException("Nonce mismatch, possible ID token replay.");
		}

		private static byte[] Base64UrlDecode(string s)
		{
			s = s.Replace('-', '+').Replace('_', '/');
			switch (s.Length % 4)
			{
				case 2: s += "=="; break;
				case 3: s += "="; break;
			}
			return Convert.FromBase64String(s);
		}
		#endregion
	}
}