using System;
using System.Globalization;
using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    /// <summary>
    /// Represents a date-only field of the Contract Based REST API.
    /// Although the inner value is DateTime, the time component is discarded on every assignment, and the value is sent to and read
    /// from the server as a bare "yyyy-MM-dd" date.
    /// </summary>
    [DataContract]
    public partial class DateOnlyValue : RestValueBase<DateTime?>
    {
        /// <summary>
        /// The wire format for this field, matching the "format: date" declared by the endpoint schema.
        /// </summary>
        internal const string DateFormat = "yyyy-MM-dd";

        public static implicit operator DateTime?(DateOnlyValue? value) => value?.Value;
        public static implicit operator DateOnlyValue(DateTime? value) => new DateOnlyValue(value);

        public DateOnlyValue()
        {
        }

        public DateOnlyValue(DateTime? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// The date held by this field. Assigning to this property discards the time component,
        /// so the value always reads back at midnight with a <see cref="DateTimeKind"/> of
        /// <see cref="DateTimeKind.Unspecified"/> - a calendar date carries no time zone.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonConverter(typeof(DateOnlyConverter))]
        public override DateTime? Value
        {
            get => base.Value;
            set => base.Value = Normalize(value);
        }

        /// <summary>
        /// Reduces <paramref name="value"/> to a plain calendar date, dropping both the time
        /// component and the <see cref="DateTimeKind"/>.
        /// </summary>
        internal static DateTime? Normalize(DateTime? value)
            => value == null ? null : DateTime.SpecifyKind(value.Value.Date, DateTimeKind.Unspecified);

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var res = Value?.ToString(DateFormat, CultureInfo.InvariantCulture);
            if (Error != null)
                return string.Join(" ", res, "Error:", Error);
            return res ?? "{}";
        }
    }
}