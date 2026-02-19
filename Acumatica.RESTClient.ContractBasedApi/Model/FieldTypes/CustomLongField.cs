using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    public partial class CustomLongField : CustomField<long?>
    {
        [JsonConstructor]
        protected CustomLongField() : base(typeof(CustomLongField)) { }

        public CustomLongField(long? value = default) : base(typeof(CustomLongField))
        {
            Value = value;
        }
    }
}
