using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    public partial class CustomDoubleField : CustomField<double?>
    {
        [JsonConstructor]
        protected CustomDoubleField() : base(typeof(CustomDoubleField)) { }

        public CustomDoubleField(double? value = default) : base(typeof(CustomDoubleField))
        {
            Value = value;
        }
    }
}
