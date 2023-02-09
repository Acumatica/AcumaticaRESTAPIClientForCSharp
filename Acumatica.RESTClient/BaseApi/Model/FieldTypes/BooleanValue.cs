using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// BooleanValue
    /// </summary>
    [DataContract]
    public partial class BooleanValue : RestValueBase<bool?>, IEquatable<BooleanValue>
    {
        public static implicit operator bool?(BooleanValue value) => value.Value;
        public static implicit operator BooleanValue(bool? value) => new BooleanValue(value);

        /// <summary>
        /// Initializes a new instance of the <see cref="BooleanValue" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        public BooleanValue(bool? value = default)
        {
            this.Value = value;
        }

        public bool Equals(BooleanValue other)
        {
            return base.Equals(other);
        }
    }
}
