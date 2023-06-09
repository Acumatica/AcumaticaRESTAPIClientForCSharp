using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public class ErrorMessage
    {
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string message { get; set; }

        [DataMember(Name = "exceptionMessage", EmitDefaultValue = false)]
        public string exceptionMessage { get; set; }

        [DataMember(Name = "exceptionType", EmitDefaultValue = false)]
        public string ExceptionType { get; set; }

        [DataMember(Name = "stackTrace", EmitDefaultValue = false)]
        public string StackTrace { get; set; }

        [DataMember(Name = "innerException", EmitDefaultValue = false)]
        public ErrorMessage innerException { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public virtual string ToStringWithoutStack()
        {
            return innerException==null?$"{message} : {exceptionMessage}": $"{message} : {exceptionMessage} : {innerException.ToStringWithoutStack()}";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
           return ToJson().ToString();
        }
  
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
