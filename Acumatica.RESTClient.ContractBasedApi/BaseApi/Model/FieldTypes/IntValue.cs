using System;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// IntValue
    /// </summary>
    [DataContract]
    public partial class IntValue : RestValueBase<int?>, IEquatable<IntValue>
    {
        public static implicit operator int?(IntValue value) => value.Value;
        public static implicit operator IntValue(int? value) => new IntValue(value);

        /// <summary>
        /// Initializes a new instance of the <see cref="IntValue" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        public IntValue(int? value = default)
        {
            this.Value = value;
        }

        public bool Equals(IntValue other)
        {
            return base.Equals(other);
        }
    }
}
