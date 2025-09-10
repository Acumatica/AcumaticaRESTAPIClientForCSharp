using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;

namespace Acumatica.RESTClient.MaintenanceApi
{
    public static class MaintenanceApi
    {
        public static async Task PutSchemaAsync(this ApiClient client, string endpointXML, CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       "/entity/maintenance/23.200/",
                method:             HttpMethod.Post,
                acceptType:         HeaderContentType.Xml,
                contentType:        HeaderContentType.Xml,
                body:               endpointXML,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
        }
        public static void PutSchema(this ApiClient client, string endpointXML)
        {
            PutSchemaAsync(client, endpointXML).GetAwaiter().GetResult();
        }


        public static async Task<string> GetSchemaAsync(this ApiClient client, string endpointName, string endpointVersion, 
            CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response =await client.CallApiAsync(
                resourcePath:       $"/entity/maintenance/23.200/{endpointName}/{endpointVersion}",
                method:             HttpMethod.Get,
                acceptType:         HeaderContentType.Xml,
                contentType:        HeaderContentType.Xml, 
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync().ConfigureAwait(false); 
        }
        public static string GetSchema(this ApiClient client, string endpointName, string endpointVersion)
        {
            return GetSchemaAsync(client, endpointName, endpointVersion).GetAwaiter().GetResult();
        }
    }
}