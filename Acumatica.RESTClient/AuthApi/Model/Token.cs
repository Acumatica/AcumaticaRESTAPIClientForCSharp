using Newtonsoft.Json;

using System;

namespace Acumatica.RESTClient.AuthApi.Model
{
    public partial class Token
    {
        [JsonConstructor]
        protected Token() { }

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

        public string? Access_token { get; set; }

        public string? Expires_in { get; set; }

        public string? Refresh_token { get; set; }

        public string? Scope { get; set; }

        public string? Token_type { get; set; }

        public DateTime ObtainedAtUTC{ get; private set; }

        public bool IsValid { get => isValid(); }
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

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
