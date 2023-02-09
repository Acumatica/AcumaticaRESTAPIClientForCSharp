using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.Model
{
    public interface IRestValueMarker { }
    public interface IRestValue<TValue> : IRestValueMarker
    {
        TValue Value { get; }
    }

    public interface IRestValueWithError<TValue> : IRestValue<TValue>
    {
        string Error { get; }
    }

    [DataContract]
    public abstract class RestValueBase<T> : IEquatable<RestValueBase<T>>, IRestValueWithError<T>
    {
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public T Value { get; set; }

        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var res = Value?.ToString();
            if (Error != null)
                return string.Join(" ", res, "Error:", Error);
            return res ?? "{}";
        }

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
            return this.Equals(input as RestValueBase<T>);
        }

        /// <summary>
        /// Returns true if instances are equal
        /// </summary>
        /// <param name="input">Instance of RestValueBase<T> to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestValueBase<T> input)
        {
            if (input is null)
                return false;
            return EqualityComparer<T>.Default.Equals(Value, input.Value);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                return EqualityComparer<T>.Default.GetHashCode(Value) ^ 123143;
            }
        }

        public static bool operator ==(RestValueBase<T> left, RestValueBase<T> right) => EqualityComparer<RestValueBase<T>>.Default.Equals(left, right);
        public static bool operator !=(RestValueBase<T> left, RestValueBase<T> right) => !EqualityComparer<RestValueBase<T>>.Default.Equals(left, right);

    }
}
