using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// HttpError
    /// </summary>
    [DataContract]
    public partial class HttpError : Dictionary<string, object>, IEquatable<HttpError>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpError" /> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="messageDetail">messageDetail.</param>
        /// <param name="exceptionMessage">exceptionMessage.</param>
        /// <param name="exceptionType">exceptionType.</param>
        /// <param name="stackTrace">stackTrace.</param>
        /// <param name="modelState">modelState.</param>
        public HttpError(string message = default, string messageDetail = default, string exceptionMessage = default, string exceptionType = default, string stackTrace = default, Dictionary<string, List<string>> modelState = default) : base()
        {
            Message = message;
            MessageDetail = messageDetail;
            ExceptionMessage = exceptionMessage;
            ExceptionType = exceptionType;
            StackTrace = stackTrace;
            ModelState = modelState;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets MessageDetail
        /// </summary>
        [DataMember(Name = "messageDetail", EmitDefaultValue = false)]
        public string MessageDetail { get; set; }

        /// <summary>
        /// Gets or Sets ExceptionMessage
        /// </summary>
        [DataMember(Name = "exceptionMessage", EmitDefaultValue = false)]
        public string ExceptionMessage { get; set; }

        /// <summary>
        /// Gets or Sets ExceptionType
        /// </summary>
        [DataMember(Name = "exceptionType", EmitDefaultValue = false)]
        public string ExceptionType { get; set; }

        /// <summary>
        /// Gets or Sets StackTrace
        /// </summary>
        [DataMember(Name = "stackTrace", EmitDefaultValue = false)]
        public string StackTrace { get; set; }

        /// <summary>
        /// Gets or Sets ModelState
        /// </summary>
        [DataMember(Name = "modelState", EmitDefaultValue = false)]
        public Dictionary<string, List<string>> ModelState { get; set; }

    }

}
