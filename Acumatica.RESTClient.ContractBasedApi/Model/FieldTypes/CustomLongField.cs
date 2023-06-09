using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
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
