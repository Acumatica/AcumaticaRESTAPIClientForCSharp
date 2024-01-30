using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json.Linq;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class StringValue : RestValueBase<string>
    {
        public static implicit operator string?(StringValue value) => value?.Value;
        public static implicit operator StringValue(string value) => new StringValue(value);

        public StringValue(string? value = default)
        {
            this.Value = value;
        }
        [DataMember(Name = "Translations", EmitDefaultValue = false)]
        public Dictionary<string, string>? Translations { get; set; }
    }
}
