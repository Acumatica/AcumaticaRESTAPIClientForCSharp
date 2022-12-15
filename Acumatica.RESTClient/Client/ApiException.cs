using System;
using System.Text.RegularExpressions;

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
        /// Get the error content.
        /// </summary>
        /// <value>The error content (Http response body).</value>
        public string ErrorContent { get; }

        /// <summary>
        /// Get the error message if it presented as part of entity.
        /// </summary>
        public string Error { get; }

        public string MessageText { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        public ApiException() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
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
        public ApiException(int errorCode, string message, string errorContent = null) : this(errorCode, message)
        {
            if (errorContent != null)
            {
                ErrorContent = message + "\r\n Error code: " + errorCode.ToString() +
                    "\r\n" + StripHTML(errorContent);
            }
        }
        public static string StripHTML(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }

        public override string Message => MessageText + (ErrorContent != null ? Environment.NewLine + ErrorContent.ToString() : null);

    }
}
