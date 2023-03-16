using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
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
