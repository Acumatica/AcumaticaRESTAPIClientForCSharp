using System.Net.Http;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;

namespace Acumatica.RESTClient.MaintenanceApi
{
    public static class MaintenanceApi
    {
        public static async Task PutSchemaAsync(this ApiClient client, string endpointXML)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                "/entity/maintenance/23.200/",
                HttpMethod.Post,
                null,
                endpointXML,
                HeaderContentType.Xml,
                HeaderContentType.Xml);

            response.EnsureSuccessStatusCode();
        }
        public static void PutSchema(this ApiClient client, string endpointXML)
        {
            Task.Run(() => PutSchemaAsync(client, endpointXML)).GetAwaiter().GetResult();
        }


        public static async Task<string> GetSchemaAsync(this ApiClient client, string endpointName, string endpointVersion)
        {
            HttpResponseMessage response =await client.CallApiAsync(
                $"/entity/maintenance/23.200/{endpointName}/{endpointVersion}",
                HttpMethod.Get,
                null,
                null,
                HeaderContentType.Xml,
                HeaderContentType.Xml);

            response.EnsureSuccessStatusCode();
            return (string)await DeserializeAsync<string>(response);
        }
        public static string GetSchema(this ApiClient client, string endpointName, string endpointVersion)
        {
            return Task.Run(() => GetSchemaAsync(client, endpointName, endpointVersion)).GetAwaiter().GetResult();
        }
    }
}