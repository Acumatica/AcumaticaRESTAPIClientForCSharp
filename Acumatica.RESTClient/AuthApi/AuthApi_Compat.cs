using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

using Acumatica.RESTClient.Client;

namespace Acumatica.RESTClient.AuthApi
{
	// Overloads with the signatures that were published in versions 5.7.x and 5.8.x.
	// They keep existing code compiling (and already-compiled code running) after the OAuth
	// authorization code flow was reworked in 5.9.0, and forward to the current methods.
	// New code should use the overloads without clientSecret instead.
	public static partial class AuthApiExtensions
	{
		#region Compatibility overloads (5.7.x and 5.8.x)

		private const string ObsoleteAuthorize =
			"The clientSecret parameter is not used by the authorize request. Use the overload without it.";

		/// <summary>
		/// Before 5.9.0, <see cref="ResponseType.Token"/> always came together with <c>id_token</c>.
		/// Callers of the old overloads keep getting exactly that request.
		/// </summary>
		private static ResponseType? LegacyResponseType(ResponseType? responseType)
		{
			return responseType == ResponseType.Token ? ResponseType.IdToken | ResponseType.Token : responseType;
		}

		private static ResponseMode LegacyResponseMode(bool usePost)
		{
			return usePost ? ResponseMode.FormPost : ResponseMode.Fragment;
		}

		#region Authorize (5.7.x)
		/// <summary>Obsolete. Use the overload without <paramref name="clientSecret"/>.</summary>
		[Obsolete(ObsoleteAuthorize)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string Authorize(this ApiClient client, string clientID, string clientSecret, string redirectUrl, OAuthScope scope)
		{
			return Authorize(client, clientID, redirectUrl, scope);
		}

		/// <summary>Obsolete. Use the overload without <paramref name="clientSecret"/>.</summary>
		[Obsolete(ObsoleteAuthorize)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Task<string> AuthorizeAsync(this ApiClient client, string clientID, string clientSecret, string redirectUrl, OAuthScope scope)
		{
			return AuthorizeAsync(client, clientID, redirectUrl, scope);
		}

		/// <summary>Obsolete. Use the overload without <paramref name="clientSecret"/>.</summary>
		[Obsolete(ObsoleteAuthorize)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Task<string> AuthorizeAsync(this ApiClient client, string clientID, string clientSecret, string redirectUrl, OAuthScope scope, CancellationToken cancellationToken)
		{
			return AuthorizeAsync(client, clientID, redirectUrl, scope, cancellationToken: cancellationToken);
		}
		#endregion

		#region Authorize (5.8.x)
		/// <summary>
		/// Obsolete. Use the overload without <paramref name="clientSecret"/>;
		/// <paramref name="usePost"/> is replaced by <c>responseMode</c>.
		/// </summary>
		[Obsolete(ObsoleteAuthorize + " Use responseMode instead of usePost.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static string Authorize(this ApiClient client, string clientID, string clientSecret, string redirectUrl, OAuthScope scope,
			ResponseType? responseType = null, bool usePost = false, string nonce = "")
		{
			return Authorize(client, clientID, redirectUrl, scope,
				responseType: LegacyResponseType(responseType),
				responseMode: LegacyResponseMode(usePost),
				nonce: nonce);
		}

		/// <inheritdoc cref="Authorize(ApiClient,string,string,string,OAuthScope,Nullable{ResponseType},bool,string)"/>
		[Obsolete(ObsoleteAuthorize + " Use responseMode instead of usePost.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Task<string> AuthorizeAsync(this ApiClient client, string clientID, string clientSecret, string redirectUrl, OAuthScope scope,
			CancellationToken cancellationToken = default,
			ResponseType? responseType = null, bool usePost = false, string nonce = "")
		{
			return AuthorizeAsync(client, clientID, redirectUrl, scope,
				responseType: LegacyResponseType(responseType),
				responseMode: LegacyResponseMode(usePost),
				nonce: nonce,
				cancellationToken: cancellationToken);
		}
		#endregion

		#region ReceiveAccessTokenAuthCode (5.7.x and 5.8.x)
		/// <summary>Same as the overload with the optional <c>codeVerifier</c> and <c>expectedNonce</c> parameters. Kept for binary compatibility with 5.7.x and 5.8.x.</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void ReceiveAccessTokenAuthCode(this ApiClient client, string clientID, string clientSecret, string redirectUrl, string code)
		{
			ReceiveAccessTokenAuthCode(client, clientID, clientSecret, redirectUrl, code, codeVerifier: "", expectedNonce: "");
		}

		/// <summary>Same as the overload with the optional <c>codeVerifier</c> and <c>expectedNonce</c> parameters. Kept for binary compatibility with 5.7.x and 5.8.x.</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Task ReceiveAccessTokenAuthCodeAsync(this ApiClient client, string clientID, string clientSecret, string redirectUrl, string code)
		{
			return ReceiveAccessTokenAuthCodeAsync(client, clientID, clientSecret, redirectUrl, code,
				codeVerifier: "", expectedNonce: "", cancellationToken: default);
		}

		/// <summary>Same as the overload with the optional <c>codeVerifier</c> and <c>expectedNonce</c> parameters. Kept for binary compatibility with 5.7.x and 5.8.x.</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Task ReceiveAccessTokenAuthCodeAsync(this ApiClient client, string clientID, string clientSecret, string redirectUrl, string code, CancellationToken cancellationToken)
		{
			return ReceiveAccessTokenAuthCodeAsync(client, clientID, clientSecret, redirectUrl, code,
				codeVerifier: "", expectedNonce: "", cancellationToken: cancellationToken);
		}
		#endregion

		#endregion
	}
}
