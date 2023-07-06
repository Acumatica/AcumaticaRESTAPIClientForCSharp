using System;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using JsonSubTypes;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), nameof(Type))]
    [JsonSubtypes.KnownSubType(typeof(CustomIntField), nameof(CustomIntField))]
    [JsonSubtypes.KnownSubType(typeof(CustomStringField), nameof(CustomStringField))]
    [JsonSubtypes.KnownSubType(typeof(CustomBooleanField), nameof(CustomBooleanField))]
    [JsonSubtypes.KnownSubType(typeof(CustomByteField), nameof(CustomByteField))]
    [JsonSubtypes.KnownSubType(typeof(CustomDateTimeField), nameof(CustomDateTimeField))]
    [JsonSubtypes.KnownSubType(typeof(CustomDoubleField), nameof(CustomDoubleField))]
    [JsonSubtypes.KnownSubType(typeof(CustomShortField), nameof(CustomShortField))]
    [JsonSubtypes.KnownSubType(typeof(CustomLongField), nameof(CustomLongField))]
    [JsonSubtypes.KnownSubType(typeof(CustomDecimalField), nameof(CustomDecimalField))]
    [JsonSubtypes.KnownSubType(typeof(CustomGuidField), nameof(CustomGuidField))]
    public abstract class CustomField 
    {
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public string Type { get; set; }

        [Obsolete("viewName property is for backward compatibility with SOAP only. Please use Custom property of Entity instead.")]
        public string viewName;

        [Obsolete("fieldName property is for backward compatibility with SOAP only. Please use Custom property of Entity instead.")]
        public string fieldName;
    }
    
    [DataContract]
    public abstract class CustomField<TValue> : CustomField
    {
        [JsonConstructor]
        protected CustomField() { }

        public CustomField(string type)
        {
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for CustomField and cannot be null");
            }
            else
            {
                Type = type;
            }
        }

        public CustomField(Type type)
        {
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for CustomField and cannot be null");
            }
            else
            {
                Type = type.Name;
            }
        }

        [DataMember(Name = "value", EmitDefaultValue = false)]
        public TValue Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var res = Value?.ToString();
            return res ?? "{}";
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomField<TValue>);
        }

        /// <summary>
        /// Returns true if instances are equal
        /// </summary>
        /// <param name="input">Instance of RestValueBase<T> to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomField<TValue> input)
        {
            if (input is null)
                return false;
            return Value.Equals(input.Value);
        }

        public override int GetHashCode()
        {
            return Value != null ? Value.GetHashCode() : 0;
        }

        public static bool operator ==(CustomField<TValue> left, CustomField<TValue> right) => left.Value.Equals(right.Value);
        public static bool operator !=(CustomField<TValue> left, CustomField<TValue> right) => !left.Value.Equals(right.Value);

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }

}
