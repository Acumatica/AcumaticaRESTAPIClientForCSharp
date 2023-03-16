using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class CustomByteField : CustomField<byte?>
    {
        [JsonConstructor]
        protected CustomByteField() : base(typeof(CustomByteField)) { }

        public CustomByteField(byte? value = default) : base(typeof(CustomByteField))
        {
            Value = value;
        }
    }
}
