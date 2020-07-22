using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// DoubleValue
    /// </summary>
    [DataContract]
    public partial class DoubleValue : RestValueBase<double?>, IEquatable<DoubleValue>
    {
        public static implicit operator double?(DoubleValue value) => value.Value;
        public static implicit operator DoubleValue(double? value) => new DoubleValue(value);

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleValue" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        public DoubleValue(double? value = default)
        {
            this.Value = value;
        }

        public bool Equals(DoubleValue other)
        {
            return base.Equals(other);
        }
    }
}
