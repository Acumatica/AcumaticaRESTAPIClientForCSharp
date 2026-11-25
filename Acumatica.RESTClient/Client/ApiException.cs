using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Acumatica.RESTClient.Client
{
    /// <summary>
    /// API Exception
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// Get the error code (HTTP status code).
        /// </summary>
        /// <value>The error code (HTTP status code).</value>
        public int ErrorCode { get; }

        /// <summary>
        /// Get the error content (body json object).
        /// </summary>
        /// <value>The error content (Http response body).</value>
        public JToken? ErrorContent { get; }

        /// <summary>
        /// Get the server exception (if unexpected exception happend and error cannot be presented as part of object).
        /// </summary>
        public ServerException? ServerException { get; }

        /// <summary>
        /// Get the error message if it presented as part of entity.
        /// </summary>
        public string? Error { get; }

        /// <summary>The error message, without the error content.</summary>
        public string MessageText { get; }

        /// <inheritdoc cref="ApiException(int,string,string)"/>
        public ApiException(int errorCode, string message)
        {
            ErrorCode = errorCode;
            MessageText = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="errorContent">Error content.</param>
        public ApiException(int errorCode, string message, string? errorContent = null) : this(errorCode, message)
        {
            if (errorContent != null)
            {
                try
                {
                    ErrorContent = JToken.Parse(errorContent);
                    ServerException = ErrorContent.ToObject<ServerException>();
                    if (ServerException?.Message == null)
                    {
                        ServerException = null;
                        Error = ErrorContent["error"]?.ToString();
                    }
                }
                catch
                {
                    ErrorContent = message + "\r\n Error code: " + errorCode.ToString();
                }
            }
        }

        /// <summary>The error message followed by the error content, if there is any.</summary>
        public override string Message => MessageText + (ErrorContent != null ? Environment.NewLine + ErrorContent.ToString() : null);

        private static readonly string[] keyFields =
        {
            "error",
            "value",
            "id",
            "ID",
        };

        // clear from body all fields that doesn't contain "error" field recursively
        /// <summary>
        ///     Removes from a response body everything that does not relate to errors. Entities that contain an error
        ///     are kept together with their key fields.
        /// </summary>
        /// <param name="token">The part of the response body to reduce.</param>
        /// <returns>The reduced body, or <c>null</c> if it contains no errors.</returns>
        public static JToken? GetEntityBodyWithOnlyErrors(JToken token)
        {
            switch (token)
            {
                case JProperty jprop:
                    {
                        if (keyFields.Contains(jprop.Name))
                            return jprop;

                        if (jprop.Value is JObject || jprop.Value is JArray)
                        {
                            var val = GetEntityBodyWithOnlyErrors(jprop.Value);
                            if (val != null)
                                return new JProperty(jprop.Name, val);
                        }

                        return null;
                    }

                case JObject jobj:
                    {
                        if (jobj["id"] != null)
                        {
                            // rm not valuable props
                            var props = jobj.Properties().Select(GetEntityBodyWithOnlyErrors).OfType<JProperty>().ToList();
                            if (props.Count > 1) // rm only id
                                return new JObject(props);
                        }
                        if (jobj["error"] != null)
                        {
                            return jobj;
                        }
                        return null;
                    }
                case JArray jarr:
                    {
                        var tokens = jarr.Select(GetEntityBodyWithOnlyErrors).OfType<JObject>().ToList();
                        if (tokens.Any())
                            return new JArray(tokens);
                        return null;
                    }
                default:
                    return null;
            }
        }
    }

    /// <summary>
    ///     An API exception that also carries the response body deserialized to <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of the entity the response is expected to contain.</typeparam>
    public class ApiException<T> : ApiException where T : class, new()
    {
        /// <inheritdoc cref="ApiException{T}(int,string,string)"/>
        public ApiException(int errorCode, string message) : base(errorCode, message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ApiException{T}" /> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="errorContent">Error content: the response body.</param>
        public ApiException(int errorCode, string message, string? errorContent = null) : base(errorCode, message, errorContent)
        {
            if (ErrorContent != null)
            {
                try
                {
                    Body = ErrorContent?.ToObject<T>();
                    ErrorBody = GetEntityBodyWithOnlyErrors(ErrorContent!);
                }
                catch { }
            }
        }

        /// <summary>The response body deserialized to <typeparamref name="T"/>, or <c>null</c> if that is not possible.</summary>
        public T? Body { get; }
        /// <summary>The part of the response body that relates to errors. See <see cref="ApiException.GetEntityBodyWithOnlyErrors"/>.</summary>
        public JToken? ErrorBody { get; }

        /// <summary>The error message, the name of <typeparamref name="T"/> and the error body, if there is one.</summary>
        public override string Message
        {
            get
            {
                if (ErrorBody is null)
                    return base.Message + Environment.NewLine + typeof(T).Name;
                return MessageText + Environment.NewLine + typeof(T).Name + Environment.NewLine + ErrorBody;
            }
        }
    }

    /// <summary>
    ///     An unexpected exception that happened on the server, as described in the response body.
    /// </summary>
    public class ServerException
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ServerException" /> class.
        /// </summary>
        /// <param name="message">The message of the server error.</param>
        /// <param name="exceptionMessage">The message of the exception.</param>
        /// <param name="exceptionType">The type of the exception.</param>
        /// <param name="stackTrace">The stack trace of the exception.</param>
        /// <param name="innerException">The exception that caused this one.</param>
        [JsonConstructor]
        public ServerException(string message, string exceptionMessage, string exceptionType, string stackTrace, ServerException? innerException = null)
        {
            Message = message;
            ExceptionMessage = exceptionMessage;
            ExceptionType = exceptionType;
            StackTrace = stackTrace;
            InnerException = innerException;
        }

        /// <summary>The message of the server error.</summary>
        public string Message { get; }
        /// <summary>The message of the exception.</summary>
        public string ExceptionMessage { get; }
        /// <summary>The type of the exception.</summary>
        public string ExceptionType { get; }
        /// <summary>The stack trace of the exception.</summary>
        public string StackTrace { get; }
        /// <summary>The exception that caused this one.</summary>
        public ServerException? InnerException { get; }

        /// <summary>
        ///     Gets the innermost exception of the chain of inner exceptions.
        /// </summary>
        /// <returns>The innermost exception, or this exception if it has no inner exception.</returns>
        public ServerException GetInnermostException() => InnerException?.GetInnermostException() ?? this;

        private static string GetIndention(int depth)
        {
            return new string('\t', depth);
        }

        private void BuildString(StringBuilder builder, int depth = 0)
        {
            var indent = GetIndention(depth);
            builder.AppendLine($"{indent}Message: {Message}");
            builder.AppendLine($"{indent}ExceptionMessage: {ExceptionMessage}");
            builder.AppendLine($"{indent}ExceptionType: {ExceptionType}");
            if (InnerException != null)
            {
                builder.AppendLine($"{indent}InnerException:");
                InnerException.BuildString(builder, depth + 1);
            }
            builder.AppendLine($"{indent}StackTrace:");
            var traceIndention = GetIndention(depth + 1);
            builder.AppendLine($"{traceIndention}{StackTrace?.Replace("\n", "\n" + traceIndention)}");
        }

        /// <summary>Returns the details of this exception and of its inner exceptions as multi-line text.</summary>
        public override string ToString()
        {
            var builder = new StringBuilder();
            BuildString(builder);
            return builder.ToString();
        }
    }
}
