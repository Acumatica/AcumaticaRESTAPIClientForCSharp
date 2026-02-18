using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
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
