using System;

using Acumatica.Auth.Model;

using RestSharp;

namespace Acumatica.RESTClient.Client
{
    /// <summary>
    /// Represents a set of configuration settings
    /// </summary>
    public class Configuration
    {
        #region Constants

        /// <summary>
        /// Version of the package.
        /// </summary>
        /// <value>Version of the package.</value>
        public const string Version = "1.0.0";

        /// <summary>
        /// Identifier for ISO 8601 DateTime Format
        /// </summary>
        /// <remarks>See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.</remarks>
        // ReSharper disable once InconsistentNaming
        public const string ISO8601_DATETIME_FORMAT = "o";

        #endregion Constants

        #region Static Members
        /// <summary>
        /// Default creation of exceptions for a given method name and response object
        /// </summary>
        public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response, objectType) =>
        {
            var status = (int)response.StatusCode;
            if (status >= 400)
            {
                return GetGenericApiException(status, "Error calling " + methodName, response.Content, objectType);
            }
            if (status == 0)
            {
                return GetGenericApiException(status,
                    string.Format("Error calling {0}", methodName, response.ErrorMessage),
                    null, objectType);
            }
            return null;
        };

        public static ApiException GetGenericApiException(int status, string message, string content, Type genericType)
        {
            if (genericType == null || genericType.IsAbstract)
                return new ApiException(status, message, content);
            return (ApiException)Activator.CreateInstance(
                typeof(ApiException<>).MakeGenericType(genericType),
                status, message, content);
        }

        #endregion Static Members

        #region Private Members
        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;
        #endregion Private Members

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Configuration" /> class
        /// </summary>
        public Configuration(string basePath, int timeout = 100000,
            Action<RestRequest, RestClient> requestInterceptor = null,
            Action<RestRequest, RestResponse, RestClient> responseInterceptor = null)
        {
            BasePath = basePath;
            Timeout = timeout;
            RequestInterceptor = requestInterceptor;
            ResponseInterceptor = responseInterceptor;
        }

        public Configuration(Configuration prototype) : 
            this(prototype.BasePath, prototype.Timeout, prototype.RequestInterceptor, prototype.ResponseInterceptor)
        { }
        #endregion Constructors


        #region Properties
        /// <summary>
        /// Method that is executed before request. May be used for loggin the request body.
        /// </summary>
        public Action<RestRequest, RestClient> RequestInterceptor { get; set; }

        /// <summary>
        /// Method that is executed after receiving response. May be used for loggin the response.
        /// </summary>
        public Action<RestRequest, RestResponse, RestClient> ResponseInterceptor { get; set; }


        private ApiClient _apiClient = null;
        /// <summary>
        /// Gets an instance of an ApiClient for this configuration
        /// </summary>
        public virtual ApiClient ApiClient
        {
            get
            {
                if (_apiClient == null) _apiClient = CreateApiClient();
                return _apiClient;
            }
        }

        /// <summary>
        /// Gets or sets the base path for API access.
        /// </summary>
        public virtual string BasePath
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the HTTP timeout (milliseconds) of ApiClient. Default to 100000 milliseconds.
        /// </summary>
        public virtual int Timeout
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the username (HTTP basic authentication).
        /// </summary>
        /// <value>The username.</value>
        public virtual string Username { get; set; }

        /// <summary>
        /// Gets or sets the password (HTTP basic authentication).
        /// </summary>
        /// <value>The password.</value>
        public virtual string Password { get; set; }

        /// <summary>
        /// Gets or sets the access token for OAuth2 authentication.
        /// </summary>
        /// <value>The access token.</value>
        public virtual Token Token { get; set; }

        /// <summary>
        /// Gets or sets the the date time format used when serializing in the ApiClient
        /// By default, it's set to ISO 8601 - "o", for others see:
        /// https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx
        /// and https://msdn.microsoft.com/en-us/library/8kb3ddd4(v=vs.110).aspx
        /// No validation is done to ensure that the string you're providing is valid
        /// </summary>
        /// <value>The DateTimeFormat string</value>
        public virtual string DateTimeFormat
        {
            get { return _dateTimeFormat; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    // Never allow a blank or null string, go back to the default
                    _dateTimeFormat = ISO8601_DATETIME_FORMAT;
                    return;
                }

                // Caution, no validation when you choose date time format other than ISO 8601
                // Take a look at the above links
                _dateTimeFormat = value;
            }
        }

 
        #endregion Properties

        #region Methods


        /// <summary>
        /// Creates a new <see cref="ApiClient" /> based on this <see cref="Configuration" /> instance.
        /// </summary>
        /// <returns></returns>
        public ApiClient CreateApiClient()
        {
            return new ApiClient(this);
        }
        #endregion Methods
    }
}
