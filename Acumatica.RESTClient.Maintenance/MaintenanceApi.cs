using System.Net.Http;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;

namespace Acumatica.RESTClient.MaintenanceApi
{
    public static class MaintenanceApi
    {
        public static void PutSchema(this ApiClient client, string endpointXML)
        {
            HttpResponseMessage response = client.CallApiAsync(
                "/entity/maintenance/23.200/",
                HttpMethod.Post,
                null,
                endpointXML,
                HeaderContentType.Xml,
                HeaderContentType.Xml).Result;

            response.EnsureSuccessStatusCode();
        }

        public static string GetSchema(this ApiClient client, string endpointName, string endpointVersion)
        {

            HttpResponseMessage response = client.CallApiAsync(
                $"/entity/maintenance/23.200/{endpointName}/{endpointVersion}",
                HttpMethod.Get,
                null,
                null,
                HeaderContentType.Xml,
                HeaderContentType.Xml).Result;

            response.EnsureSuccessStatusCode();
            return (string)Deserialize<string>(response);
        }
    }
}