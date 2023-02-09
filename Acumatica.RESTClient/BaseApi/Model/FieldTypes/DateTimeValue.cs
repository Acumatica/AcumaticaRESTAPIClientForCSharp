using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// DateTimeValue
    /// </summary>
    [DataContract]
    public partial class DateTimeValue : RestValueBase<DateTime?>, IEquatable<DateTimeValue>
    {
        public static implicit operator DateTime?(DateTimeValue value) => value.Value;
        public static implicit operator DateTimeValue(DateTime? value) => new DateTimeValue(value);

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeValue" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        public DateTimeValue(DateTime? value = default)
        {
            this.Value = value;
        }

        public bool Equals(DateTimeValue other)
        {
            return base.Equals(other);
        }
    }
}
