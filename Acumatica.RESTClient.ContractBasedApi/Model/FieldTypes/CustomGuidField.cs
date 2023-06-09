using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
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
