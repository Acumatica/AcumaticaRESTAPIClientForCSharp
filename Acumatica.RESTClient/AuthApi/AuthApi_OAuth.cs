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
		/// 
		/// </summary>
		/// <param name="client"></param>
		/// <param name="clientID"></param>
		/// <param name="redirectUrl"></param>
		/// <param name="scope"></param>
		/// <param name="responseType"></param>
		/// <param name="responseMode"></param>
		/// <param name="codeChallenge"></param>
		/// <param name="nonce"></param>
		/// <param name="state"></param>
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
		/// Calls the authorize endpoint and returns the URL to open in a browser: the login URL
		/// when the user isn't signed in (taken from the Location header, or from the final request
		/// URL when redirects were followed automatically).
		/// </summary>
		/// <param name="client"></param>
		/// <param name="clientID"></param>
		/// <param name="redirectUrl">Must exactly match a redirect URI registered for the client.</param>
		/// <param name="scope"></param>
		/// <param name="responseType"></param>
		/// <param name="responseMode">With FormPost the server returns an HTML form, not a redirect.</param>
		/// <param name="codeChallenge">S256 code challenge, required if PKCE is used.</param>
		/// <param name="nonce"></param>
		/// <param name="state">Optional. If omitted, there is no state check on the callback. </param>
		/// <param name="cancellationToken"></param>
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
		/// <summary>
		/// Receives access token for OAuth 2.0 authentication (Authorization code flow)
		/// </summary>
		/// <param name="client"></param>
		/// <param name="clientID"></param>
		/// <param name="clientSecret"></param>
		/// <param name="redirectUrl"></param>
		/// <param name="code"></param>
		/// <param name="codeVerifier"></param>
		/// <param name="expectedNonce"></param>
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
		/// Receives access token for OAuth 2.0 authentication (Authorization code flow)
		/// </summary>
		/// <param name="client"></param>
		/// <param name="clientID"></param>
		/// <param name="clientSecret"></param>
		/// <param name="callbackUrl"></param>
		/// <param name="codeVerifier"></param>
		/// <param name="expectedNonce"></param>
		/// <param name="expectedState"></param>
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
		/// Receives access token for OAuth 2.0 authentication (Authorization code flow)
		/// </summary>
		/// <param name="client"></param>
		/// <param name="clientID"></param>
		/// <param name="clientSecret"></param>
		/// <param name="redirectUrl"></param>
		/// <param name="code"></param>
		/// <param name="codeVerifier"></param>
		/// <param name="expectedNonce"></param>
		/// <param name="cancellationToken"></param>
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
		/// Receives access token for OAuth 2.0 authentication (Authorization code flow)
		/// </summary>
		/// <param name="client"></param>
		/// <param name="clientID"></param>
		/// <param name="clientSecret"></param>
		/// <param name="callbackUrl"></param>
		/// <param name="codeVerifier"></param>
		/// <param name="expectedNonce"></param>
		/// <param name="expectedState"></param>
		/// <param name="cancellationToken"></param>
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