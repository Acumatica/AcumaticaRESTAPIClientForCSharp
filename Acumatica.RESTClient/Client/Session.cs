using System;

using Acumatica.RESTClient.Auth.Model;
using Acumatica.RESTClient.Auxiliary;

using RestSharp;

namespace Acumatica.RESTClient.Client
{
    /// <summary>
    /// Represents an open API session.
    /// </summary>
    public class Session
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Session" /> class
        /// </summary>
        public Session(string basePath, int timeout = 100000,
            Action<RestRequest, RestClient> requestInterceptor = null,
            Action<RestRequest, RestResponse, RestClient> responseInterceptor = null)
        {
            BasePath = basePath;
            Timeout = timeout;
            RequestInterceptor = requestInterceptor;
            ResponseInterceptor = responseInterceptor;
        }

        public Session(Session prototype) : 
            this(prototype.BasePath, prototype.Timeout, prototype.RequestInterceptor, prototype.ResponseInterceptor)
        { }

        #endregion Constructors


        #region Properties

        public Action<RestRequest, RestClient> RequestInterceptor { get; set; }
        public Action<RestRequest, RestResponse, RestClient> ResponseInterceptor { get; set; }


        internal ApiClient _apiClient = null;
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
            get;
            set;
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

        private string _dateTimeFormat = Constants.ISO8601_DATETIME_FORMAT;

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
                    _dateTimeFormat = Constants.ISO8601_DATETIME_FORMAT;
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
        /// Creates a new <see cref="ApiClient" /> based on this <see cref="Session" /> instance.
        /// </summary>
        /// <returns></returns>
        protected ApiClient CreateApiClient()
        {
            return new ApiClient(this);
        }

        #endregion Methods
    }
}
