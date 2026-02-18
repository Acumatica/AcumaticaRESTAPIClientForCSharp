using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    public interface IRestValueMarker { }
    public abstract class RestFieldWithError : IRestValueMarker
    {
        public string? Error { get; set; }
    }

    public abstract class RestValueBase<TValue> : RestFieldWithError
    {
        public TValue? Value { get; set; }

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
        public override bool Equals(object? input)
        {
            return this.Equals(input as RestValueBase<TValue>);
        }

        /// <summary>
        /// Returns true if instances are equal
        /// </summary>
        /// <param name="input">Instance of <see cref="RestValueBase{TValue}"/> to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestValueBase<TValue>? input)
        {
            if(this is null && input is null)
            {
                return true;
            }
            else if (this is null || input is null)
            {
                return false;
            }
            else if (Value == null && input.Value == null)
            {
                return true;
            }
            else if (Value == null || input.Value == null)
            {
                return false;
            }
            else
            {
                return Value!.Equals(input.Value!);
            }
        }

        public override int GetHashCode()
        {
            return  Value != null ? Value.GetHashCode() : 0;
        }

        public static bool operator ==(RestValueBase<TValue> left, RestValueBase<TValue> right) => right is null || left is null ? (right is null && left is null) : left.Value!.Equals(right.Value);
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
