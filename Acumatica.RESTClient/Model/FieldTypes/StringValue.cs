using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// StringValue
    /// </summary>
    [DataContract]
    public partial class StringValue : RestValueBase<string>, IEquatable<StringValue>
    {
        public static implicit operator string(StringValue value) => value?.Value;
        public static implicit operator StringValue(string value) => new StringValue(value);

        /// <summary>
        /// Initializes a new instance of the <see cref="StringValue" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        public StringValue(string value = default)
        {
            this.Value = value;
        }

        public bool Equals(StringValue other)
        {
            return base.Equals(other);
        }
    }
}
