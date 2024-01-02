using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Auxiliary;
using Acumatica.RESTClient.Client;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;

namespace Acumatica.RESTClient.ODataApi
{
    public static class ODataAPIHelper
    {
        public static string GetOdataMetadata(ApiClient client, ODataVersion version, string? tenant = null)
        {
            return GetOdataMetadataAsync(client, version, tenant).Result;
        }
        public static async Task<string> GetOdataMetadataAsync(this ApiClient client, ODataVersion version, string? tenant = null)
        {
            return await GetODataAsync(client, version, "$metadata", tenant);
        }
        public static string GetOData(this ApiClient client, ODataVersion version, string resource, string? tenant = null, string? select = null, string? filter = null, string? expand = null, int? skip = null, int? top = null)
        {
            return GetODataAsync(client, version, resource, tenant, select, filter, expand, skip, top).Result;
        }
        
        public static async Task<string> GetODataAsync(this ApiClient client, ODataVersion version, string resource, string? tenant = null, string? select = null, string? filter = null, string? expand = null, int? skip = null, int? top = null)
        {
            //Oauth authentication
            HttpResponseMessage response = await client.CallApiAsync(
                ConfigurePath(resource, tenant, version),
                HttpMethod.Get,
                ComposeQueryParams(select, filter, expand, null, skip, top),
                null,
                HeaderContentType.Json,
                HeaderContentType.Json,
                ComposeAuthenticationHeaders(client)
            );

            response.EnsureSuccessStatusCode();
            return  (string)await DeserializeAsync<string>(response);
        }

        #region Implementation

        /// <summary>
        /// Configures the base path according to version of OData and tenant, if exists.
        /// </summary>
        private static string ConfigurePath(string resource, string? tenant, ODataVersion version)
        {
            return string.IsNullOrEmpty(tenant) 
                 ?
                 $"{version}/{resource}" 
                 : 
                 $"{version}/{tenant}/{resource}";
        }

        private static Dictionary<string, string>? ComposeAuthenticationHeaders(ApiClient client)
        {
            if (client.Token == null && (client.Username == null && client.Password == null))
            {
                throw new Exception("Either token or username/password  pair have to be provided");
            }

            //Basic authentication
            if (client.Token == null)
            {
                var customHeaders = new Dictionary<string, string>
                {
                    { "Authorization", $"Basic {ApiClientHelpers.Base64Encode($"{client.Username}:{client.Password}")}" }
                };
                return customHeaders;
            }
            else
            {
                // ApiClient will take care of Token-based authentication
                return null;
            }
        }

        #endregion
    }

}
