using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DebuggerDisplay("{Value} {Error != null ? \"(Error: \" + Error + \")\" : string.Empty}")]
    [DataContract]
    public partial class DateTimeValue : RestValueBase<DateTime?>
    {
        public static implicit operator DateTime?(DateTimeValue value) => value.Value;
        public static implicit operator DateTimeValue(DateTime? value) => new DateTimeValue(value);

        public DateTimeValue(DateTime? value = default)
        {
            this.Value = value;
        }
    }
}
