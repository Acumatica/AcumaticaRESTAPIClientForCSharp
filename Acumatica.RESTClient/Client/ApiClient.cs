using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Acumatica.Auth.Model;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Auxiliary;


using Newtonsoft.Json;

using static Acumatica.RESTClient.Auxiliary.Constants;

namespace Acumatica.RESTClient.Client
{
    /// <summary>
    /// API client is mainly responsible for making the HTTP call to the API backend.
    /// </summary>
    public partial class ApiClient
    {
        #region State & ctor

        private string _dateTimeFormat = ISO8601_DATETIME_FORMAT;

        private JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        };
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class
        /// with default base path.
        /// </summary>
        /// <param name="timeout">
        /// Gets or sets the HTTP timeout (milliseconds) of ApiClient. Default to 100000 milliseconds.
        /// </param>
        public ApiClient(string basePath, 
            int timeout = 100000,
             Action<HttpRequestMessage, HttpClient> requestInterceptor = null,
             Action<HttpResponseMessage, HttpClient> responseInterceptor = null)
        {
            BasePath = basePath;
            RequestInterceptor = requestInterceptor;
            ResponseInterceptor = responseInterceptor;

            Client = new HttpClient();
            Client.Timeout = new TimeSpan(0, 0, 0, 0, timeout);
        }

        /// <summary>
        /// Method that is executed before request. May be used for loggin the request body.
        /// </summary>
        public Action<HttpRequestMessage, HttpClient> RequestInterceptor { get; set; }

        /// <summary>
        /// Method that is executed after receiving response. May be used for loggin the response.
        /// </summary>
        public Action<HttpResponseMessage, HttpClient> ResponseInterceptor { get; set; }


        /// <summary>
        /// Gets or sets the HttpClient.
        /// </summary>
        /// <value>An instance of the HttpClient</value>
        public HttpClient Client { get; set; }
        /// <summary>
        /// Gets or sets the base path for API access.
        /// </summary>
        public virtual string BasePath
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
        #endregion

        #region Public Methods

        /// <summary>
        /// Makes the asynchronous HTTP request.
        /// </summary>
        /// <param name="resourcePath">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="customHeaders">Header parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content type.</param>
        /// <returns>The Task instance.</returns>
        public async Task<HttpResponseMessage> CallApiAsync(
            String resourcePath, 
            HttpMethod method,
            List<KeyValuePair<String, String>> queryParams,
            Object postBody,
            HeaderContentType acceptType,
            HeaderContentType contentType,
            Dictionary<String, String> customHeaders = null)
        {
            var request = PrepareRequest(
                resourcePath,
                method, 
                queryParams,
                postBody,
                customHeaders,
                acceptType: ComposeAcceptHeaders(acceptType),
                contentType: ComposeContentHeaders(contentType));

            if (RequestInterceptor != null)
            {
                RequestInterceptor(request, Client);
            }
            var response = await Client.SendAsync(request);
            if (ResponseInterceptor != null)
            {
                ResponseInterceptor(response, Client);
            }

            return response;
        }


        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public object Deserialize<T>(HttpResponseMessage response)
        {
            if (typeof(T) == typeof(byte[])) // return byte array
            {
                return response.Content.ReadAsByteArrayAsync().Result;
            }

            if (typeof(T).Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(response.Content.ReadAsStringAsync().Result, null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (typeof(T) == typeof(String)) // return primitive type
            {
                return (String)response.Content.ReadAsStringAsync().Result;
            }

            if (typeof(T).Name.StartsWith("System.Nullable"))
            {
                return Convert.ChangeType(response.Content, typeof(T));
            }

            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result, typeof(T), serializerSettings);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Serialize an input (model) into JSON string
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        public String Serialize(object obj)
        {
            try
            {
                return obj != null ? JsonConvert.SerializeObject(obj) : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON type exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'.
        /// </summary>
        /// <remarks>
        /// We need this because only one content type is allowed
        /// </remarks>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        private String SelectHeaderContentType(IEnumerable<string> contentTypes)
        {
            if (contentTypes.Count() == 0)
                return ApplicationJsonAcceptContentType;

            foreach (var contentType in contentTypes)
            {
                if (ApiClientHelpers.IsJsonMime(contentType.ToLower()))
                    return contentType;
            }

            return contentTypes.First(); 
        }

        protected string ComposeAcceptHeaders(HeaderContentType contentTypes)
        {
            return string.Join(",", ComposeHeadersArray(contentTypes));
        }

        private static IEnumerable<string> ComposeHeadersArray(HeaderContentType contentTypes)
        {
            List<string> headers = new List<string>();
            if ((contentTypes & HeaderContentType.Json) == HeaderContentType.Json)
            {
                headers.Add(ApplicationJsonAcceptContentType);
                headers.Add(TextJsonAcceptContentType);
            }
            if ((contentTypes & HeaderContentType.Xml) == HeaderContentType.Xml)
            {
                headers.Add(ApplicationXmlAcceptContentType);
                headers.Add(TextXmlAcceptContentType);
            }
            if ((contentTypes & HeaderContentType.Any) == HeaderContentType.Any)
            {
                headers.Add(AnyAcceptContentType);
            }
            if ((contentTypes & HeaderContentType.WwwForm) == HeaderContentType.WwwForm)
            {
                headers.Add(WwwFormEncoded);
            }

            if ((contentTypes & HeaderContentType.OctetStream) == HeaderContentType.OctetStream)
            {
                headers.Add(OctetStream);
            }
            return headers;
        }


        /// <summary>
        /// Convert params to key/value pairs. 
        /// Use collectionFormat to properly format lists and collections.
        /// </summary>
        /// <param name="name">Key name.</param>
        /// <param name="value">Value object.</param>
        /// <returns>A list of KeyValuePairs</returns>
        public IEnumerable<KeyValuePair<string, string>> ParameterToKeyValuePairs(string collectionFormat, string name, object value)
        {
            var parameters = new List<KeyValuePair<string, string>>();

            if (IsCollection(value) && collectionFormat == "multi")
            {
                var valueCollection = value as IEnumerable;
                parameters.AddRange(from object item in valueCollection select new KeyValuePair<string, string>(name, item.ToString()));
            }
            else
            {
                parameters.Add(new KeyValuePair<string, string>(name,value.ToString()));
            }

            return parameters;
        }

        #endregion

        #region Implementation
        protected string ComposeContentHeaders(HeaderContentType contentTypes)
        {
            return SelectHeaderContentType(ComposeHeadersArray(contentTypes));
        }
        // Creates and sets up a RestRequest prior to a call.
        private HttpRequestMessage PrepareRequest(
            String resourcePath, 
            HttpMethod method, 
            List<KeyValuePair<String, String>> queryParams, 
            Object postBody,
            Dictionary<String, String> headerParams,
            string acceptType, 
            string contentType)
        {

            var url = new UriBuilder(BasePath + resourcePath);

            if (queryParams != null)
            {
                // add query parameter, if any
                foreach (var param in queryParams)
                {
                    var query = System.Web.HttpUtility.ParseQueryString(url.Query);
                    foreach(var kvp in queryParams)
                    {
                        query.Set(kvp.Key, kvp.Value);  
                    }
                    url.Query = query.ToString();
                }
            }

            var request = new HttpRequestMessage(method, url.ToString());

            if (headerParams != null)
            {
                // add header parameter, if any
                foreach (var param in headerParams)
                {
                    request.Headers.Add(param.Key, param.Value);
                }
            }
            if (!String.IsNullOrWhiteSpace(acceptType))
            {
                request.Headers.Add("Accept", acceptType);
            }


            if (Token != null)
            {
                request.Headers.Add("Authorization", $"{Token.Token_type} {Token.Access_token}");
            }

            if (postBody != null)
            {
                if (postBody is string)
                {
                    request.Content = new StringContent(postBody as string, Encoding.UTF8, contentType);
                }
               
                else if (postBody is byte[])
                {
                    request.Content = new ByteArrayContent(postBody as byte[]);
                }
                else 
                {
                    request.Content = new StringContent(Serialize(postBody), Encoding.UTF8, contentType); 
                }
            }
            return request;
        }

        /// <summary>
        /// Check if generic object is a collection.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if object is a collection type</returns>
        private static bool IsCollection(object value)
        {
            return value is IList || value is ICollection;
        }
        #endregion
    }
}
