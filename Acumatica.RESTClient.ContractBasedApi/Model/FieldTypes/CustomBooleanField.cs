using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    public partial class CustomBooleanField : CustomField<bool?>
    {
        [JsonConstructor]
        protected CustomBooleanField() : base(typeof(CustomBooleanField)) { }

        public CustomBooleanField(bool? value = default) : base(typeof(CustomBooleanField))
        {
            Value = value;
        }
    }
}