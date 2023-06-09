using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class CustomShortField : CustomField<short?>
    {
        [JsonConstructor]
        protected CustomShortField() : base(typeof(CustomShortField)) { }

        public CustomShortField(short? value = default) : base(typeof(CustomShortField))
        {
            Value = value;
        }
    }
}
