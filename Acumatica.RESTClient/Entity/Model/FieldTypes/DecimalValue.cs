using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// DecimalValue
    /// </summary>
    [DataContract]
    public partial class DecimalValue : RestValueBase<decimal?>, IEquatable<DecimalValue>
    {
        public static implicit operator decimal?(DecimalValue value) => value.Value;
        public static implicit operator DecimalValue(decimal? value) => new DecimalValue(value);

        /// <summary>
        /// Initializes a new instance of the <see cref="DecimalValue" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        public DecimalValue(decimal? value = default)
        {
            this.Value = value;
        }

        public bool Equals(DecimalValue other)
        {
            return base.Equals(other);
        }
    }
}
