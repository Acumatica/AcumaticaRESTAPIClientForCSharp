using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// GuidValue
    /// </summary>
    [DataContract]
    public partial class GuidValue : RestValueBase<Guid?>, IEquatable<GuidValue>
    {
        public static implicit operator Guid?(GuidValue value) => value.Value;
        public static implicit operator GuidValue(Guid? value) => new GuidValue(value);

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidValue" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        public GuidValue(Guid? value = default)
        {
            this.Value = value;
        }

        public bool Equals(GuidValue other)
        {
            return base.Equals(other);
        }
    }
}
