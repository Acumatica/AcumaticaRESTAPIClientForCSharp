using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
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