using System;
using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    public partial class CustomGuidField : CustomField<Guid?>
    {
        [JsonConstructor]
        protected CustomGuidField() : base(typeof(CustomGuidField)) { }

        public CustomGuidField(Guid? value = default) : base(typeof(CustomGuidField))
        {
            Value = value;
        }
    }
}
