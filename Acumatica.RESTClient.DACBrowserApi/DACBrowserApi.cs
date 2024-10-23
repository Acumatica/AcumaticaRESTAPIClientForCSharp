using System;
using System.Net.Http;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.DACBrowserApi.Model;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;

namespace Acumatica.RESTClient.DACBrowserApi
{
    public static class DACBrowserApiExtensions
    {
        public static ItemsRoot GetAllDACs(this ApiClient client)
        {
            return Task.Run(() => GetAllDACsAsync(client)).GetAwaiter().GetResult();
        }

        public async static Task<ItemsRoot> GetAllDACsAsync(this ApiClient client)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                $"/dacBrowser",
                HttpMethod.Get,
                null,
                null,
                HeaderContentType.Json,
                HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm);

            response.EnsureSuccessStatusCode();
            return await DeserializeAsync<ItemsRoot>(response);
        }
        public static DAC GetDAC(this ApiClient client, string DACNamespace, string DACName)
        {
            return Task.Run(() => GetDACAsync(client, DACNamespace, DACName)).GetAwaiter().GetResult();
        }

        public async static Task<DAC> GetDACAsync(this ApiClient client, string DACNamespace, string DACName)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                $"/dacBrowser/{DACNamespace}/{DACName}",
                HttpMethod.Get,
                null,
                null,
                HeaderContentType.Json,
                HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm);

            response.EnsureSuccessStatusCode();
            return await DeserializeAsync<DAC>(response);
        }
        public static Field GetField(this ApiClient client, string DACNamespace, string DACName, string fieldName)
        {
            return Task.Run(() => GetFieldAsync(client, DACNamespace, DACName, fieldName)).GetAwaiter().GetResult();
        }

        public async static Task<Field> GetFieldAsync(this ApiClient client, string DACNamespace, string DACName, string fieldName)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                $"/dacBrowser/{DACNamespace}/{DACName}/{fieldName}",
                HttpMethod.Get,
                null,
                null,
                HeaderContentType.Json,
                HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm);

            response.EnsureSuccessStatusCode();
            return await DeserializeAsync<Field>(response);
        }
    }
}
