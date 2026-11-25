using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.AuthApi.Model;
using Acumatica.RESTClient.Client;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;


namespace Acumatica.RESTClient.AuthApi
{
	public static partial class AuthApiExtensions
	{
		#region Refresh Token
		/// <inheritdoc cref="RefreshAccessTokenJWTAsync(ApiClient,string,string,CancellationToken)"/>
		public static void RefreshAccessTokenJWT(this ApiClient client, string clientID, string privateJwkJson)
		{
			RefreshAccessTokenJWTAsync(client, clientID, privateJwkJson).GetAwaiter().GetResult();
		}

		/// <summary>
		/// Gets a new access token using the refresh token stored on the client.
		/// The client is authenticated with a client assertion, signed with its private key, instead of the client secret.
		/// </summary>
		/// <remarks>
		/// Works only if the OfflineAccess scope was requested at sign-in, so that a refresh token was issued.
		/// </remarks>
		/// <param name="client">The API client. The token is stored on it.</param>
		/// <param name="clientID">The Client ID of the connected application in Acumatica.</param>
		/// <param name="privateJwkJson">The private RSA key of the client as a JSON Web Key (JWK), or a JWK Set (<c>{ "keys": [ ... ] }</c>) that contains it as the only private RSA key. It is used to sign the client assertion.</param>
		/// <param name="cancellationToken">Token to cancel the call.</param>
		public async static Task RefreshAccessTokenJWTAsync(this ApiClient client, string clientID, string privateJwkJson, CancellationToken cancellationToken = default)
		{
			if (client == null || string.IsNullOrEmpty(client.Token?.Refresh_token))
				ThrowMissingParameter(nameof(RefreshAccessTokenJWTAsync), "Refresh_Token");
			if (string.IsNullOrEmpty(privateJwkJson))
				ThrowMissingParameter(nameof(RefreshAccessTokenJWTAsync), nameof(privateJwkJson));
			var time = DateTime.UtcNow;
			HttpResponseMessage response = await client!.CallApiAsync(
				resourcePath: TokenEndpointPath,
				method: HttpMethod.Post,
				queryParams: null,
				body: await ToFormUrlEncodedAsync(new Dictionary<string, string>()
									{
										{"grant_type", "refresh_token" },
										{"client_id", clientID },
										{"client_assertion_type", ClientAssertionType },
										{"client_assertion", CreateRsaJwkAssertion(privateJwkJson, clientID, GetTokenEndpointUrl(client)) },
										{"refresh_token", client.Token!.Refresh_token! },
									}).ConfigureAwait(false),
				acceptType: HeaderContentType.None,
				contentType: HeaderContentType.WwwForm,
				cancellationToken: cancellationToken
			).ConfigureAwait(false);

			await VerifyResponseAsync(client, response, nameof(RefreshAccessTokenJWTAsync)).ConfigureAwait(false);

			client.Token = await DeserializeAsync<Token>(response).ConfigureAwait(false);
			client.Token?.SetTokenObtainedDT(time);
		}
		#endregion
		#region Authorization Code Flow
		
	
		/// <inheritdoc cref="ReceiveAccessTokenJWTAsync(ApiClient,string,string,string,string,string,string,CancellationToken)"/>
		public static void ReceiveAccessTokenJWT(
			this ApiClient client,
			string clientID,
			string privateJwkJson,
			string redirectUrl,
			string code,
			string codeVerifier = "",
			string expectedNonce = "")
		{
			ReceiveAccessTokenJWTAsync(client, clientID, privateJwkJson, redirectUrl, code, codeVerifier: codeVerifier, expectedNonce: expectedNonce).GetAwaiter().GetResult();
		}

		/// <summary>
		/// Step 2 of the authorization code flow: exchanges the callback URL for an access token and stores it on the client.
		/// This overload reads the code from the URL, validates <c>state</c> if <c>expectedState</c> is provided, and reports any error returned by Acumatica.
		/// </summary>
		/// <param name="client">The API client. The token is stored on it.</param>
		/// <param name="clientID">The Client ID of the connected application in Acumatica.</param>
		/// <param name="privateJwkJson">The private RSA key of the client as a JSON Web Key (JWK), or a JWK Set (<c>{ "keys": [ ... ] }</c>) that contains it as the only private RSA key. It is used to sign the client assertion.</param>
		/// <param name="callbackUrl">The full URL the browser was redirected to after sign-in. The authorization code is extracted from it.</param>
		/// <param name="codeVerifier">Optional. The PKCE code verifier that matches the <c>codeChallenge</c> sent to <c>Authorize</c>.</param>
		/// <param name="expectedNonce">Optional. The same <c>nonce</c> that was sent to <c>Authorize</c>. If provided, it is checked against the ID token (requires the OpenID scope).</param>
		/// <param name="expectedState">Optional. The same <c>state</c> that was sent to <c>Authorize</c>. If provided, a callback with a different value is rejected.</param>
		public static void ReceiveAccessTokenJWT(
			this ApiClient client,
			string clientID,
			string privateJwkJson,
			Uri callbackUrl,
			string codeVerifier = "",
			string expectedNonce = "",
			string expectedState = "")
		{
			ReceiveAccessTokenJWTAsync(client, clientID, privateJwkJson, callbackUrl, codeVerifier: codeVerifier, expectedNonce: expectedNonce, expectedState: expectedState).GetAwaiter().GetResult();
		}

		/// <summary>
		/// Step 2 of the authorization code flow: exchanges the authorization code for an access token and stores it on the client.
		/// This overload takes the <c>code</c> that was already extracted from the callback.
		/// </summary>
		/// <param name="client">The API client. The token is stored on it.</param>
		/// <param name="clientID">The Client ID of the connected application in Acumatica.</param>
		/// <param name="privateJwkJson">The private RSA key of the client as a JSON Web Key (JWK), or a JWK Set (<c>{ "keys": [ ... ] }</c>) that contains it as the only private RSA key. It is used to sign the client assertion.</param>
		/// <param name="redirectUrl">The same redirect URL that was used in <c>Authorize</c>.</param>
		/// <param name="code">The authorization code from the callback.</param>
		/// <param name="codeVerifier">Optional. The PKCE code verifier that matches the <c>codeChallenge</c> sent to <c>Authorize</c>.</param>
		/// <param name="expectedNonce">Optional. The same <c>nonce</c> that was sent to <c>Authorize</c>. If provided, it is checked against the ID token (requires the OpenID scope).</param>
		/// <param name="cancellationToken">Token to cancel the call.</param>
		public static async Task ReceiveAccessTokenJWTAsync(
			this ApiClient client,
			string clientID,
			string privateJwkJson,
			string redirectUrl,
			string code,
			string codeVerifier = "",
			string expectedNonce = "",
			CancellationToken cancellationToken = default)
		{
			if (string.IsNullOrEmpty(privateJwkJson))
				ThrowMissingParameter(nameof(ReceiveAccessTokenJWTAsync), nameof(privateJwkJson));
			var time = DateTime.UtcNow;

			var bodyParams = new Dictionary<string, string>
			{
				{ "grant_type", "authorization_code" },
				{ "code", code },
				{ "redirect_uri", redirectUrl },
				{ "client_id", clientID },
			};

			bodyParams.Add("client_assertion_type", ClientAssertionType);
			bodyParams.Add("client_assertion", CreateRsaJwkAssertion(privateJwkJson, clientID, GetTokenEndpointUrl(client)));
			if (!string.IsNullOrEmpty(codeVerifier))
			{
				bodyParams.Add("code_verifier", codeVerifier);
			}

			using HttpResponseMessage response = await client.CallApiAsync(
			   resourcePath: TokenEndpointPath,
			   method: HttpMethod.Post,
			   acceptType: HeaderContentType.None,
			   contentType: HeaderContentType.WwwForm,
			   body: await ToFormUrlEncodedAsync(bodyParams).ConfigureAwait(false),
			   cancellationToken: cancellationToken
			).ConfigureAwait(false);

			await VerifyResponseAsync(client, response, nameof(ReceiveAccessTokenJWTAsync)).ConfigureAwait(false);
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
		/// <param name="privateJwkJson">The private RSA key of the client as a JSON Web Key (JWK), or a JWK Set (<c>{ "keys": [ ... ] }</c>) that contains it as the only private RSA key. It is used to sign the client assertion.</param>
		/// <param name="callbackUrl">The full URL the browser was redirected to after sign-in. The authorization code is extracted from it. Only if ResponseType is query</param>
		/// <param name="codeVerifier">Optional. The PKCE code verifier that matches the <c>codeChallenge</c> sent to <c>Authorize</c>.</param>
		/// <param name="expectedNonce">Optional. The same <c>nonce</c> that was sent to <c>Authorize</c>. If provided, it is checked against the ID token (requires the OpenID scope).</param>
		/// <param name="expectedState">Optional. The same <c>state</c> that was sent to <c>Authorize</c>. If provided, a callback with a different value is rejected.</param>
		/// <param name="cancellationToken">Token to cancel the call.</param>
		public static async Task ReceiveAccessTokenJWTAsync(
			this ApiClient client,
			string clientID,
			string privateJwkJson,
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

			await ReceiveAccessTokenJWTAsync(
				client,
				clientID,
				privateJwkJson,
				redirectUrl,
				code,
				codeVerifier: codeVerifier,
				expectedNonce: expectedNonce,
				cancellationToken: cancellationToken).ConfigureAwait(false);
		}
		// The type of a client assertion that is a JWT (RFC 7523).
		private const string ClientAssertionType = "urn:ietf:params:oauth:client-assertion-type:jwt-bearer";

		/// <summary>
		/// The URL of the token endpoint of the site the client is connected to.
		/// It is the audience (<c>aud</c>) of the client assertion.
		/// </summary>
		private static string GetTokenEndpointUrl(ApiClient client)
		{
			string basePath = client.BasePath;
			return (basePath.EndsWith("/") ? basePath : basePath + "/") + TokenEndpointPath;
		}

		/// <summary>
		/// Gets the key to sign with. The string is either a single JWK, which is returned as it is,
		/// or a JWK Set (<c>{ "keys": [ ... ] }</c>), from which the only private RSA key is taken.
		/// </summary>
		private static JObject SelectSigningJwk(JObject root, string paramName)
		{
			if (root["keys"] is not JArray keys)
				return root;

			var candidates = keys.OfType<JObject>()
				.Where(key => (string?)key["kty"] == "RSA" && !string.IsNullOrEmpty((string?)key["d"]))
				.ToList();
			if (candidates.Count == 1)
				return candidates[0];

			throw new ArgumentException(candidates.Count == 0
				? "The JWK Set does not contain a private RSA key to sign the client assertion with."
				: $"The JWK Set contains {candidates.Count} private RSA keys. Pass a single key, or a set that contains only the key to sign with.",
				paramName);
		}

		/// <summary>
		/// Creates a client assertion: a JWT that is signed with the private key of the client (RS256)
		/// and is sent to the token endpoint instead of the client secret.
		/// </summary>
		/// <param name="privateJwkJson">The private RSA key as a JSON Web Key (JWK).</param>
		/// <param name="clientId">The Client ID of the connected application. It is the issuer and the subject.</param>
		/// <param name="audience">The URL of the token endpoint.</param>
		/// <returns>The signed JWT. It is valid for 5 minutes.</returns>
		private static string CreateRsaJwkAssertion(string privateJwkJson, string clientId, string audience)
		{
			JObject jwk;
			try
			{
				jwk = SelectSigningJwk(JObject.Parse(privateJwkJson), nameof(privateJwkJson));
			}
			catch (JsonReaderException ex)
			{
				throw new ArgumentException("The JWK is not valid JSON.", nameof(privateJwkJson), ex);
			}
			string? Str(string name) => (string?)jwk[name];

			if (Str("kty") != "RSA")
				throw new ArgumentException("Only RSA JWKs are supported.", nameof(privateJwkJson));

			foreach (string field in new[] { "n", "e", "d", "p", "q", "dp", "dq", "qi" })
			{
				if (string.IsNullOrEmpty(Str(field)))
					throw new ArgumentException(
						$"The JWK cannot be used to sign the client assertion: its '{field}' field is missing. A private RSA key is required, not only the public part.",
						nameof(privateJwkJson));
			}

			byte[] n = Base64UrlDecode(Str("n")!);
			int half = (n.Length + 1) / 2;
			using var rsa = RSA.Create();
			rsa.ImportParameters(new RSAParameters
			{
				Modulus = n,
				Exponent = Base64UrlDecode(Str("e")!),
				D = PadLeft(Base64UrlDecode(Str("d")!), n.Length),
				P = PadLeft(Base64UrlDecode(Str("p")!), half),
				Q = PadLeft(Base64UrlDecode(Str("q")!), half),
				DP = PadLeft(Base64UrlDecode(Str("dp")!), half),
				DQ = PadLeft(Base64UrlDecode(Str("dq")!), half),
				InverseQ = PadLeft(Base64UrlDecode(Str("qi")!), half),
			});
			string? kid = Str("kid");

			long now = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
			var header = new Dictionary<string, object> { ["alg"] = "RS256", ["typ"] = "JWT" };
			if (kid is not null) header["kid"] = kid;

			var payload = new Dictionary<string, object>
			{
				["iss"] = clientId,
				["sub"] = clientId,
				["aud"] = audience,
				["jti"] = Guid.NewGuid().ToString(),
				["iat"] = now,
				["nbf"] = now,
				["exp"] = now + 300,
			};

			string input = Base64UrlEncode(ToUtf8Json(header)) + "." + Base64UrlEncode(ToUtf8Json(payload));
			byte[] signature = rsa.SignData(Encoding.ASCII.GetBytes(input), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
			return input + "." + Base64UrlEncode(signature);
		}

		private static byte[] ToUtf8Json(object value)
		{
			return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(value));
		}

		private static string Base64UrlEncode(byte[] data)
		{
			return Convert.ToBase64String(data).TrimEnd('=').Replace('+', '-').Replace('/', '_');
		}

		/// <summary>
		/// JWKs drop leading zero bytes of the key components, while <see cref="RSAParameters"/> needs them at a fixed length.
		/// </summary>
		private static byte[] PadLeft(byte[] bytes, int length)
		{
			if (bytes.Length >= length) return bytes;
			var result = new byte[length];
			Buffer.BlockCopy(bytes, 0, result, length - bytes.Length, bytes.Length);
			return result;
		}

		#endregion
	}
}