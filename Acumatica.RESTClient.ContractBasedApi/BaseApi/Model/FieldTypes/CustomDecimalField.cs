using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// CustomDecimalField
    /// </summary>
    [DataContract]
    public partial class CustomDecimalField : CustomField, IEquatable<CustomDecimalField>, IRestValue<Decimal?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDecimalField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomDecimalField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDecimalField" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        public CustomDecimalField(decimal? value = default(decimal?), string type = default(string)) : base(type)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() => Value?.ToString() ?? "{}";

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomDecimalField);
        }

        /// <summary>
        /// Returns true if CustomDecimalField instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomDecimalField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomDecimalField input)
        {
            if (input == null)
                return false;

            return base.Equals(input) &&
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }

}
