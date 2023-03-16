using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
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