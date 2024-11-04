using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Auxiliary;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ODataApi.Model;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;

namespace Acumatica.RESTClient.ODataApi
{
    public static class ApiClientExtensions
    {
        public static IEnumerable<ODataObject> GetOdataObjects(this ApiClient client, ODataVersion version, string? tenant = null)
        {
            return Task.Run(() => GetOdataObjectsAsync(client, version, tenant)).GetAwaiter().GetResult();
        }
        public static async Task<IEnumerable<ODataObject>> GetOdataObjectsAsync(this ApiClient client, ODataVersion version, string? tenant = null)
        {
            return (await GetODataAsync(client, version, "", tenant)).Select(_=> _.ToObject<ODataObject>());
        }

        public static IEnumerable<JObject> GetOData(this ApiClient client, ODataVersion version, string resource, string? tenant = null, string? select = null, string? filter = null, string? expand = null, int? skip = null, int? top = null, string? orderby = null)
        {
            return Task.Run(() => GetODataAsync(client, version, resource, tenant, select, filter, expand, skip, top, orderby)).GetAwaiter().GetResult();
        }
        
        public static async Task<IEnumerable<JObject>> GetODataAsync(this ApiClient client, ODataVersion version, string resource, string? tenant = null, string? select = null, string? filter = null, string? expand = null, int? skip = null, int? top = null, string? orderby = null)
        {
            //Oauth authentication
            HttpResponseMessage response = await client.CallApiAsync(
                ConfigurePath(resource, tenant, version),
                HttpMethod.Get,
                ComposeQueryParamsOData(select, filter, expand, null, skip, top, orderby),
                null,
                HeaderContentType.Json,
                HeaderContentType.Json,
                ComposeAuthenticationHeaders(client)
            );
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Status code: {response.StatusCode}:{response.ReasonPhrase}, Error: {await response.Content.ReadAsStringAsync()}");
            }
            return JsonConvert.DeserializeObject<ODataResults>(await response.Content.ReadAsStringAsync()).Results; 
        }

        #region Implementation

        public static List<KeyValuePair<string, string>> ComposeQueryParamsOData(string? select = null, string? filter = null, string? expand = null, string? custom = null, int? skip = null, int? top = null, string? orderby = null)
        {
            var queryParameters = ComposeQueryParams(select, filter, expand, custom, skip, top);
            if (!String.IsNullOrEmpty(orderby)) queryParameters.AddRange(ParameterToKeyValuePairs("", "$orderby", orderby!));

            return queryParameters;
        }

        /// <summary>
        /// Configures the base path according to version of OData and tenant, if exists.
        /// </summary>
        private static string ConfigurePath(string resource, string? tenant, ODataVersion version)
        {
            switch (version)
            {
                case ODataVersion.GIBasedOData:
                    return $"/t/{tenant ?? "Company"}/api/odata/gi/{resource}";
                case ODataVersion.DACBasedOData:
                    return $"/t/{tenant ?? "Company"}/api/odata/dac/{resource}";
                case ODataVersion.OData:
                    return string.IsNullOrEmpty(tenant)
                            ?
                            $"odata/{resource}"
                            :
                            $"odata/{tenant}/{resource}";
                case ODataVersion.ODatav4:
                    return string.IsNullOrEmpty(tenant)
                            ?
                            $"odatav4/{resource}"
                            :
                            $"odatav4/{tenant}/{resource}";
                default:
                    throw new Exception("Unsupported OData version");
            }
        }

        private static Dictionary<string, string>? ComposeAuthenticationHeaders(ApiClient client)
        {
            if (client.HasToken())
            {
                // ApiClient will take care of Token-based authentication
                return null;
            }
            else if (client.Username != null && client.Password != null)
            {
                //Basic authentication
                var customHeaders = new Dictionary<string, string>
                {
                    { "Authorization", $"Basic {ApiClientHelpers.Base64Encode($"{client.Username}:{client.Password}")}" }
                };
                return customHeaders;
            }
            else
            { 
                throw new Exception("Either token or username/password pair have to be provided");
            }
        }
        #endregion
    }
}
