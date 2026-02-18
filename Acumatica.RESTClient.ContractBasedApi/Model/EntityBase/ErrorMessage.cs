using System.Runtime.Serialization;

using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    public class ErrorMessage
    {
        public string? message { get; set; }

        public string? exceptionMessage { get; set; }

        public string? ExceptionType { get; set; }

        public string? StackTrace { get; set; }

        public ErrorMessage? innerException { get; set; }

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
