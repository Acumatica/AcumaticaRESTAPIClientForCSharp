using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.AuthApi.Model
{
    /// <summary>
    /// The token that is returned after signing in with OAuth 2.0.
    /// The <see cref="Acumatica.RESTClient.Client.ApiClient"/> stores it and sends it with every request.
    /// </summary>
    [DataContract]
    public partial class Token
    {
        [JsonConstructor]
        protected Token() { }

		/// <summary>
		/// Creates a token and marks it as obtained right now.
		/// Normally not called directly - the client creates the token when signing in.
		/// </summary>
		/// <param name="accessToken">The access token.</param>
		/// <param name="expiresIn">Seconds till the access token expires.</param>
		/// <param name="refreshToken">The refresh token. Only retrieved if the <see cref="AuthApiExtensions.OAuthScope.OfflineAccess"/> scope was requested.</param>
		/// <param name="scope">The scopes that were granted.</param>
		/// <param name="token_type">The token type, usually <c>Bearer</c>.</param>
		public Token(
            string? accessToken = default,
            string? expiresIn = default,
            string? refreshToken = default,
            string? scope = default,
            string? token_type = default)
        {
            Access_token = accessToken;
            Expires_in = expiresIn;
            Refresh_token = refreshToken;
            Scope = scope;
            Token_type = token_type;
            SetTokenObtainedDT();
        }

        /// <summary>
        /// The key sent with each API call to authenticate the request.
        /// </summary>
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string? Access_token { get; set; }

        /// <summary>
        /// How many seconds the access token stays valid, counted from <see cref="ObtainedAtUTC"/>.
        /// </summary>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public string? Expires_in { get; set; }

        /// <summary>
        /// Used to get a new access token without signing in again.
        /// Only issued if the OfflineAccess scope was requested.
        /// </summary>
        [DataMember(Name = "refresh_token", EmitDefaultValue = false)]
        public string? Refresh_token { get; set; }

		/// <summary>
		/// A signed JWT that says who signed in. Only issued if the OpenID scope was requested.
		/// </summary>
		[DataMember(Name = "id_token", EmitDefaultValue = false)]
		public string? Id_token { get; set; }

		/// <summary>
		/// The scopes that were granted, separated by spaces.
		/// </summary>
		[DataMember(Name = "scope", EmitDefaultValue = false)]
        public string? Scope { get; set; }

        /// <summary>
        /// The kind of token - usually <c>Bearer</c>.
        /// </summary>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public string? Token_type { get; set; }

        /// <summary>
        /// When this token was received (UTC). Used to work out whether it has expired.
        /// </summary>
        public DateTime ObtainedAtUTC{ get; private set; }

        /// <summary>
        /// <c>true</c> if there is an access token and it has not expired yet.
        /// </summary>
        public bool IsValid { get => isValid(); }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Sets the time the token was received. If omitted, the current time is used.
        /// </summary>
        /// <param name="dt">The time to use (UTC). Optional.</param>
        public virtual void SetTokenObtainedDT(DateTime? dt = null)
        {
            ObtainedAtUTC = dt ?? DateTime.UtcNow;
        }

        private bool isValid()
        {
            return !string.IsNullOrEmpty(Access_token) && (DateTime.UtcNow - ObtainedAtUTC).TotalSeconds < Convert.ToUInt32(Expires_in);
        }
    }

}
