using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class CustomStringField : CustomField<string>
    {
        [JsonConstructor]
        public CustomStringField() : base(typeof(CustomStringField)) { }

        public CustomStringField(string value) : base(typeof(CustomStringField))
        {
            Value = value;
        }
    }
}
