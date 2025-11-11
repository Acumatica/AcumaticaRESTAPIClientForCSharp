using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DebuggerDisplay("{Value} {Error != null ? \"(Error: \" + Error + \")\" : string.Empty}")]
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
