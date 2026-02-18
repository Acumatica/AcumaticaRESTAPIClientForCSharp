using Newtonsoft.Json;

using System;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    public partial class CustomDecimalField : CustomField<Decimal?>
    {
        [JsonConstructor]
        protected CustomDecimalField() : base(typeof(CustomDecimalField)) { }

        public CustomDecimalField(decimal? value = default) : base(typeof(CustomDecimalField))
        {
            Value = value;
        }
    }
}