using System.Collections.Generic;


namespace Acumatica.RESTClient.Client
{
    /// <summary>
    /// API Response
    /// </summary>
    public class ApiResponse
    {
        /// <summary>
        /// Gets or sets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        public int StatusCode { get; private set; }

        /// <summary>
        /// Gets or sets the HTTP headers
        /// </summary>
        /// <value>HTTP headers</value>
        public IDictionary<string, string> Headers { get; private set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP status code.</param>
        /// <param name="headers">HTTP headers.</param>
        public ApiResponse(int statusCode, IDictionary<string, string> headers)
        {
            this.StatusCode = statusCode;
            this.Headers = headers;
        }
    }

    /// <summary>
    /// API Response with <see cref="Data">Content(parsed HTTP body)</see>
    /// </summary>
    public class ApiResponse<T> :ApiResponse
    {
        /// <summary>
        /// Gets or sets the data (parsed HTTP body)
        /// </summary>
        /// <value>The data.</value>
        public T Data { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse&lt;T&gt;" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP status code.</param>
        /// <param name="headers">HTTP headers.</param>
        /// <param name="data">Data (parsed HTTP body)</param>
        public ApiResponse(int statusCode, IDictionary<string, string> headers, T data)
            : base(statusCode, headers)
        {
            this.Data = data;
        }
    }
}
