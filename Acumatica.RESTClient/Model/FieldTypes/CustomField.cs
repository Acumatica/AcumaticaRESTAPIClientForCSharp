using System;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using JsonSubTypes;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// CustomField
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(CustomIntField), "CustomIntField")]
    [JsonSubtypes.KnownSubType(typeof(CustomStringField), "CustomStringField")]
    [JsonSubtypes.KnownSubType(typeof(CustomBooleanField), "CustomBooleanField")]
    [JsonSubtypes.KnownSubType(typeof(CustomByteField), "CustomByteField")]
    [JsonSubtypes.KnownSubType(typeof(CustomDateTimeField), "CustomDateTimeField")]
    [JsonSubtypes.KnownSubType(typeof(CustomDoubleField), "CustomDoubleField")]
    [JsonSubtypes.KnownSubType(typeof(CustomShortField), "CustomShortField")]
    [JsonSubtypes.KnownSubType(typeof(CustomLongField), "CustomLongField")]
    [JsonSubtypes.KnownSubType(typeof(CustomDecimalField), "CustomDecimalField")]
    [JsonSubtypes.KnownSubType(typeof(CustomGuidField), "CustomGuidField")]
    public partial class CustomField : IEquatable<CustomField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomField" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        public CustomField(string type)
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for CustomField and cannot be null");
            }
            else
            {
                this.Type = type;
            }
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        [Obsolete("viewName property is for backward compatibility with SOAP only. Please use Custom property of Entity instead.")]
        public string viewName;
      
        [Obsolete("fieldName property is for backward compatibility with SOAP only. Please use Custom property of Entity instead.")]
        public string fieldName;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString() => "CustomField";

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as CustomField);
        }

        /// <summary>
        /// Returns true if CustomField instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomField input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }

}
