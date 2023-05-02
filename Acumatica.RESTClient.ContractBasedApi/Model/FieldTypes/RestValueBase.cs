using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    public interface IRestValueMarker { }
    [DataContract]
    public abstract class RestValueBase<TValue> : IRestValueMarker
    {
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public TValue Value { get; set; }

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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestValueBase<TValue>);
        }

        /// <summary>
        /// Returns true if instances are equal
        /// </summary>
        /// <param name="input">Instance of RestValueBase<T> to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestValueBase<TValue> input)
        {
            if (input is null)
                return false;
            return Value.Equals(input.Value);
        }

        public override int GetHashCode()
        {
            return  Value != null ? Value.GetHashCode() : 0;
        }

        public static bool operator ==(RestValueBase<TValue> left, RestValueBase<TValue> right) => right is null || left is null ? (right is null && left is null) : left.Value.Equals(right.Value);
        public static bool operator !=(RestValueBase<TValue> left, RestValueBase<TValue> right) => !(left == right);

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
