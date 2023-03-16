using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class CustomIntField : CustomField<int?>
    {
        [JsonConstructor]
        protected CustomIntField() : base(typeof(CustomIntField)) { }

        public CustomIntField(int? value = default) : base(typeof(CustomIntField))
        {
            Value = value;
        }
    }
}
