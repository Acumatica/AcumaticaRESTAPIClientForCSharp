using Newtonsoft.Json;

using System;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    public partial class CustomDateTimeField : CustomField<DateTime?>
    {
        [JsonConstructor]
        protected CustomDateTimeField() : base(typeof(CustomDateTimeField)) { }

        public CustomDateTimeField(DateTime? value = default) : base(typeof(CustomDateTimeField))
        {
            Value = value;
        }
    }
}