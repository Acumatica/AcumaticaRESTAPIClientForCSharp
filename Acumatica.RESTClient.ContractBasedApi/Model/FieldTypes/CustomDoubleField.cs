using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
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
