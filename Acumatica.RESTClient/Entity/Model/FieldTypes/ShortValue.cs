using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// ShortValue
    /// </summary>
    [DataContract]
    public partial class ShortValue : RestValueBase<short?>, IEquatable<ShortValue>
    {
        public static implicit operator short?(ShortValue value) => value.Value;
        public static implicit operator ShortValue(short? value) => new ShortValue(value);

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortValue" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        public ShortValue(short? value = default)
        {
            this.Value = value;
        }

        public bool Equals(ShortValue other)
        {
            return base.Equals(other);
        }
    }
}
