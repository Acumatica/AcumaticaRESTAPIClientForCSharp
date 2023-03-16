using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class DecimalValue : RestValueBase<decimal?>
    {
        public static implicit operator decimal?(DecimalValue value) => value.Value;
        public static implicit operator DecimalValue(decimal? value) => new DecimalValue(value);

        public DecimalValue(decimal? value = default)
        {
            this.Value = value;
        }
    }
}
