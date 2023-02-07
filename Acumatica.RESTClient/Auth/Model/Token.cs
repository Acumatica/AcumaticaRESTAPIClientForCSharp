using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace Acumatica.RESTClient.Auth.Model
{
    [DataContract]
    public partial class Token
    {
        [JsonConstructor]
        protected Token() { }

        public Token(
            string accessToken = default,
            string expiresIn = default,
            string refreshToken = default,
            string scope = default,
            string token_type = default)
        {
            Access_token = accessToken;
            Expires_in = expiresIn;
            Refresh_token = refreshToken;
            Scope = scope;
            Token_type = token_type;
        }

        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string Access_token { get; set; }

        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public string Expires_in { get; set; }

        [DataMember(Name = "refresh_token", EmitDefaultValue = false)]
        public string Refresh_token { get; set; }

        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; set; }

        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public string Token_type { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

}
