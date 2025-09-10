using System;
using System.Net.Http;
using System.Threading;
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
            return GetAllDACsAsync(client).GetAwaiter().GetResult();
        }

        public async static Task<ItemsRoot> GetAllDACsAsync(this ApiClient client, CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"/dacBrowser",
                method:             HttpMethod.Get,
                acceptType:         HeaderContentType.Json,
                contentType:        HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            return await DeserializeAsync<ItemsRoot>(response).ConfigureAwait(false);
        }
        public static DAC GetDAC(this ApiClient client, string DACNamespace, string DACName)
        {
            return GetDACAsync(client, DACNamespace, DACName).GetAwaiter().GetResult();
        }

        public async static Task<DAC> GetDACAsync(this ApiClient client, string DACNamespace, string DACName,
            CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"/dacBrowser/{DACNamespace}/{DACName}", 
                method:             HttpMethod.Get, 
                acceptType:         HeaderContentType.Json, 
                contentType:        HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            return await DeserializeAsync<DAC>(response).ConfigureAwait(false);
        }
        public static Field GetField(this ApiClient client, string DACNamespace, string DACName, string fieldName)
        {
            return GetFieldAsync(client, DACNamespace, DACName, fieldName).GetAwaiter().GetResult();
        }

        public async static Task<Field> GetFieldAsync(this ApiClient client, string DACNamespace, string DACName, string fieldName,
            CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"/dacBrowser/{DACNamespace}/{DACName}/{fieldName}", 
                method:             HttpMethod.Get, 
                acceptType:         HeaderContentType.Json, 
                contentType:        HeaderContentType.Json | HeaderContentType.Xml | HeaderContentType.WwwForm, 
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();
            return await DeserializeAsync<Field>(response).ConfigureAwait(false);
        }
    }
}
