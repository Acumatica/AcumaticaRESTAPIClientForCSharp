using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    /// <summary>
    /// Represents a date-only field of the Contract Based REST API.
    /// The server-side counterpart (PX.Api.ContractBased.Models.DateOnlyValue)
    /// carries a <see cref="DateTime"/>; only the date part is meaningful.
    /// </summary>
    [DataContract]
    public partial class DateOnlyValue : RestValueBase<DateTime?>
    {
        public static implicit operator DateTime?(DateOnlyValue? value) => value?.Value;
        public static implicit operator DateOnlyValue(DateTime? value) => new DateOnlyValue(value);

        public DateOnlyValue(DateTime? value = default)
        {
            this.Value = value;
        }
    }
}