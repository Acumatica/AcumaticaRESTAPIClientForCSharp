using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// ByteValue
    /// </summary>
    [DataContract]
    public partial class ByteValue : RestValueBase<byte?>, IEquatable<ByteValue>
    {
        public static implicit operator byte?(ByteValue value) => value.Value;
        public static implicit operator ByteValue(byte? value) => new ByteValue(value);

        /// <summary>
        /// Initializes a new instance of the <see cref="ByteValue" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        public ByteValue(byte? value = default)
        {
            this.Value = value;
        }

        public bool Equals(ByteValue other)
        {
            return base.Equals(other);
        }
    }
}
