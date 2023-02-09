using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// LongValue
    /// </summary>
    [DataContract]
    public partial class LongValue : RestValueBase<long?>, IEquatable<LongValue>
    {
        public static implicit operator long?(LongValue value) => value.Value;
        public static implicit operator LongValue(long? value) => new LongValue(value);

        /// <summary>
        /// Initializes a new instance of the <see cref="LongValue" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        public LongValue(long? value = default)
        {
            this.Value = value;
        }

        public bool Equals(LongValue other)
        {
            return base.Equals(other);
        }
    }
}
