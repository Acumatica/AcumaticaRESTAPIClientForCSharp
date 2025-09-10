using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Auxiliary;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ODataApi.Model;
using Acumatica.RESTClient.RootApi.Model;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;

namespace Acumatica.RESTClient.ODataApi
{
    public static class ApiClientExtensions
    {
        #region DACs
        public static IEnumerable<ODataObject> GetListOfAvailableDACs(this ApiClient client, string? tenant = null)
        {
            return GetListOfAvailableDACsAsync(client, tenant).GetAwaiter().GetResult();
        }
        public static async Task<IEnumerable<ODataObject>> GetListOfAvailableDACsAsync(this ApiClient client, string? tenant = null)
        {
            return GetOdataObjectsAsync(client, version, tenant);
        }

        public static IEnumerable<ODataObject> GetDACsMetadata(this ApiClient client, string? tenant = null)
        {
            return GetDACsMetadataAsync(client, tenant).GetAwaiter().GetResult();
        }
        public static async Task<IEnumerable<ODataObject>> GetDACsMetadataAsync(this ApiClient client, string? tenant = null)
        {
            return GetOdataObjectsAsync(client, tenant);
        }

        public static IEnumerable<ODataObject> GetDACRecords(this ApiClient client, string dac, string? tenant = null)
        {
            return GetDACRecordsAsync(client, version, tenant).GetAwaiter().GetResult();
        }
        public static async Task<IEnumerable<ODataObject>> GetDACRecordsAsync(this ApiClient client, string dac, string? tenant = null)
        {
            return GetOdataObjectsAsync(client, version, tenant).GetAwaiter().GetResult();
        }

        public static IEnumerable<ODataObject> GetDeletedRecords(this ApiClient client, string dac, string? tenant = null)
        {
            return GetDeletedRecordsAsync(client, version, tenant).GetAwaiter().GetResult();
        }

        public static async Task<IEnumerable<ODataObject>> GetDeletedRecordsAsync(this ApiClient client, string dac, string? tenant = null, CancellationToken cancellationToken = default)
        {
            return (await GetODataAsync(client, version, "", tenant).ConfigureAwait(false)).Select(_ => _.ToObject<ODataObject>());
        }

        #endregion
        #region GIs
        public static IEnumerable<ODataObject> GetListOfAvailableGIs(this ApiClient client, string? tenant = null)
        {
            return GetListOfAvailableGIsAsync(client, tenant).GetAwaiter().GetResult();
        }
        public static async Task<IEnumerable<ODataObject>> GetListOfAvailableGIsAsync(this ApiClient client, string? tenant = null)
        {
            return GetOdataObjectsAsync(client, version, tenant).GetAwaiter().GetResult();
        }
        public static IEnumerable<ODataObject> GetGIsMetadata(this ApiClient client, string? tenant = null)
        {
            return GetGIsMetadataAsync(client, tenant).GetAwaiter().GetResult();
        }
        public static async Task<IEnumerable<ODataObject>> GetGIsMetadataAsync(this ApiClient client, string? tenant = null)
        {
            return GetOdataObjectsAsync(client, version, tenant).GetAwaiter().GetResult();
        }
        public static IEnumerable<ODataObject> GetGIResults(this ApiClient client, string gi, string? tenant = null)
        {
            return GetGIResultsAsync(client, version, tenant).GetAwaiter().GetResult();
        }
        public static async Task<IEnumerable<ODataObject>> GetGIResultsAsync(this ApiClient client, string gi, string? tenant = null)
        {
            return GetOdataObjectsAsync(client, version, tenant).GetAwaiter().GetResult();
        }
        #endregion

        #region Backward Compatibility
        [Obsolete("Use GetGI or GET DAC instead")]

        public static IEnumerable<ODataObject> GetOdataObjects(this ApiClient client, ODataVersion version, string? tenant = null)
        {
            return GetOdataObjectsAsync(client, version, tenant).GetAwaiter().GetResult();
        }
        [Obsolete("Use GetGI or GET DAC instead")]
        public static async Task<IEnumerable<ODataObject>> GetOdataObjectsAsync(this ApiClient client, ODataVersion version, string? tenant = null)
        {
            return (await GetODataAsync(client, version, "", tenant).ConfigureAwait(false)).Select(_ => _.ToObject<ODataObject>());
        }
        [Obsolete("Use GetGI or GET DAC instead")]
        public static IEnumerable<JObject> GetOData(this ApiClient client, ODataVersion version, string resource, string? tenant = null, string? select = null, string? filter = null, string? expand = null, int? skip = null, int? top = null, string? orderby = null)
        {
            return GetODataAsync(client, version, resource, tenant, select, filter, expand, skip, top, orderby).GetAwaiter().GetResult();
        }
        [Obsolete("Use GetGI or GET DAC instead")]
        public static async Task<IEnumerable<JObject>> GetODataAsync(
            this ApiClient client,
            ODataVersion version,
            string resource,
            string? tenant = null,
            string? select = null, string? filter = null, string? expand = null, int? skip = null, int? top = null, string? orderby = null,
            CancellationToken cancellationToken = default)
        {
            //Oauth authentication
            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath: ConfigurePath(resource, tenant, version),
                method: HttpMethod.Get,
                acceptType: HeaderContentType.Json,
                contentType: HeaderContentType.Json,
                queryParams: ComposeQueryParamsOData(select, filter, expand, null, skip, top, orderby),
                customHeaders: ComposeAuthenticationHeaders(client),
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApiException(((int)response.StatusCode), $"Status code: {response.StatusCode}:{response.ReasonPhrase}, Error: {await response.Content.ReadAsStringAsync().ConfigureAwait(false)}");
            }
            return JsonConvert.DeserializeObject<ODataResults>(await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Results;
        }

        [Obsolete]
        public static List<KeyValuePair<string, string>> ComposeQueryParamsOData(string? select = null, string? filter = null, string? expand = null, string? custom = null, int? skip = null, int? top = null, string? orderby = null)
        {
           return ComposeQueryParams(select, filter, expand, custom, skip, top, orderby);
        }
        #endregion

        #region Implementation

        private static async Task<IEnumerable<JObject>> GetODataResultAsync(
          this ApiClient client,
          string resource,
          ODataType type,
          string? tenant = null,
          string? select = null, string? filter = null, string? expand = null, int? skip = null, int? top = null, string? orderby = null,
          CancellationToken cancellationToken = default)
        {
            //Oauth authentication
            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath: ConfigurePath(resource, tenant, type),
                method: HttpMethod.Get,
                acceptType: HeaderContentType.Json,
                contentType: HeaderContentType.Json,
                queryParams: ComposeQueryParamsOData(select, filter, expand, null, skip, top, orderby),
                customHeaders: ComposeAuthenticationHeaders(client),
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApiException(((int)response.StatusCode), $"Status code: {response.StatusCode}:{response.ReasonPhrase}, Error: {await response.Content.ReadAsStringAsync().ConfigureAwait(false)}");
            }
            return JsonConvert.DeserializeObject<ODataResults>(await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Results;
        }

        private static List<KeyValuePair<string, string>> ComposeQueryParams(string? select = null, string? filter = null, string? expand = null, string? custom = null, int? skip = null, int? top = null, string? orderby = null)
        {
            var queryParameters = ComposeQueryParams(select, filter, expand, custom, skip, top);
            if (!String.IsNullOrEmpty(orderby)) queryParameters.AddRange(ParameterToKeyValuePairs("", "$orderby", orderby!));

            return queryParameters;
        }
        /// <summary>
        /// Configures the base path according to type of OData and tenant, if exists.
        /// </summary>
        private static string ConfigurePath(string resource, string? tenant, ODataType type)
        {
            switch (type)
            {
                case ODataType.GIBasedOData:
                    return $"/t/{tenant ?? "Company"}/api/odata/gi/{resource}";
                case ODataType.DACBasedOData:
                    return $"/t/{tenant ?? "Company"}/api/odata/dac/{resource}";
                default:
                    throw new Exception("Unsupported OData type");
            }
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
