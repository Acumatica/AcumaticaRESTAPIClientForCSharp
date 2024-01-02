using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;

using Acumatica.RESTClient.Client;

using Newtonsoft.Json;

using static Acumatica.RESTClient.Auxiliary.Constants;

namespace Acumatica.RESTClient.Auxiliary
{
    public static class ApiClientHelpers
    {
        /// <summary>
        /// Composes Query Parameters for API Request. 
        /// </summary>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="filter">The conditions that determine which records should be selected from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <param name="skip">The number of records to be skipped from the list of returned records. (optional)</param>
        /// <param name="top">The number of records to be returned from the system. (optional)</param>
        public static List<KeyValuePair<string, string>> ComposeQueryParams(string? select = null, string? filter = null, string? expand = null, string? custom = null, int? skip = null, int? top = null)
        {
            var queryParameters = new List<KeyValuePair<string, string>>();
            if (!String.IsNullOrEmpty(select)) queryParameters.AddRange(ParameterToKeyValuePairs("", "$select", select!));
            if (!String.IsNullOrEmpty(filter)) queryParameters.AddRange(ParameterToKeyValuePairs("", "$filter", filter!));
            if (!String.IsNullOrEmpty(expand)) queryParameters.AddRange(ParameterToKeyValuePairs("", "$expand", expand!));
            if (!String.IsNullOrEmpty(custom)) queryParameters.AddRange(ParameterToKeyValuePairs("", "$custom", custom!));
            if (skip != null) queryParameters.AddRange(ParameterToKeyValuePairs("", "$skip", skip));
            if (top != null) queryParameters.AddRange(ParameterToKeyValuePairs("", "$top", top));

            return queryParameters;
        }
        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public static async Task<object?> DeserializeAsync<T>(HttpResponseMessage response)
        {
            if (typeof(T) == typeof(byte[])) // return byte array
            {
                return response.Content.ReadAsByteArrayAsync();
            }

            if (typeof(T).Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(await response.Content.ReadAsStringAsync(), null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (typeof(T) == typeof(String)) // return primitive type
            {
                return (String)await response.Content.ReadAsStringAsync();
            }

            if (typeof(T).Name.StartsWith("System.Nullable"))
            {
                return Convert.ChangeType(response.Content, typeof(T));
            }

            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
            };

            return JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync(), typeof(T), serializerSettings);
        }
        public static string ComposeContentHeaders(HeaderContentType contentTypes)
        {
            return SelectHeaderContentType(ApiClientHelpers.ComposeHeadersArray(contentTypes));
        }
        /// <summary>
        /// Serialize an input (model) into JSON string
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        public static String? Serialize(object obj)
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
        private static String SelectHeaderContentType(IEnumerable<string> contentTypes)
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

        public static string ComposeAcceptHeaders(HeaderContentType contentTypes)
        {
            return string.Join(",", ApiClientHelpers.ComposeHeadersArray(contentTypes));
        }


        /// <summary>
        /// Convert params to key/value pairs. 
        /// Use collectionFormat to properly format lists and collections.
        /// </summary>
        /// <param name="name">Key name.</param>
        /// <param name="value">Value object.</param>
        /// <returns>A list of KeyValuePairs</returns>
        private static IEnumerable<KeyValuePair<string, string>> ParameterToKeyValuePairs(string collectionFormat, string name, object value)
        {
            var parameters = new List<KeyValuePair<string, string>>();

            if (ApiClientHelpers.IsCollection(value) && collectionFormat == "multi")
            {
                var valueCollection = value as IEnumerable;
                parameters.AddRange(from object item in valueCollection select new KeyValuePair<string, string>(name, item.ToString()));
            }
            else
            {
                parameters.Add(new KeyValuePair<string, string>(name, value.ToString()));
            }

            return parameters;
        }
        public static void ThrowMissingParameter(string methodName, string paramName)
        {
            throw new ApiException(400, $"Missing required parameter '{paramName}' when calling {methodName}");
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
        /// Check if generic object is a collection.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if object is a collection type</returns>
        private static bool IsCollection(object value)
        {
            return value is IList || value is ICollection;
        }
        /// <summary>
        ///Check if the given MIME is a JSON MIME.
        ///JSON MIME examples:
        ///    application/json
        ///    application/json; charset=UTF8
        ///    APPLICATION/JSON
        ///    application/vnd.company+json
        /// </summary>
        /// <param name="mime">MIME</param>
        /// <returns>Returns True if MIME type is json.</returns>
        private static bool IsJsonMime(String mime)
        {
            var jsonRegex = new Regex("(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$");
            return mime != null && (jsonRegex.IsMatch(mime) || mime.Equals("application/json-patch+json"));
        }
        public async static Task<string> ToFormUrlEncodedAsync(IDictionary<string, string> keyValueContent)
        {
            var formUrlEncodedContent = new FormUrlEncodedContent(keyValueContent);
            return await formUrlEncodedContent.ReadAsStringAsync();
        }
        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">String to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }
    }
}