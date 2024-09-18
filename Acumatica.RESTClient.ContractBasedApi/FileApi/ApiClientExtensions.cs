using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi.FileApi.Model;
using Acumatica.RESTClient.ContractBasedApi.Model;
using Acumatica.RESTClient.FileApi.Model;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;

namespace Acumatica.RESTClient.FileApi
{
	public static class ApiClientExtensions 
	{
		public static Stream GetFile(this ApiClient client, FileLink fileLink)
		{
			return GetFile(client, fileLink.Href);
		}
        public static async Task<Stream> GetFileAsync(this ApiClient client, FileLink fileLink)
        {
            return await GetFileAsync(client, fileLink.Href);
        }

        public static Stream GetFile(this ApiClient client, string href)
        {
            var parsedLocation = UrlParser.ParseFileLocation(href);
            return GetFile(client, parsedLocation.ID, parsedLocation.EndpointName, parsedLocation.EndpointVersion);
        }
        public static async Task<Stream> GetFileAsync(this ApiClient client, string href)
        {
            var parsedLocation = UrlParser.ParseFileLocation(href);
            return await GetFileAsync(client, parsedLocation.ID, parsedLocation.EndpointName, parsedLocation.EndpointVersion);
        }

        public static Stream GetFile(this ApiClient client, Guid fileID, string endpointName, string endpointVersion)
        {
            return GetFile(client, fileID.ToString(), endpointName, endpointVersion);
        }
        public static async Task<Stream> GetFileAsync(this ApiClient client, Guid fileID, string endpointName, string endpointVersion)
        {
            return await GetFileAsync(client, fileID.ToString(), endpointName, endpointVersion);
        }

        public static Stream GetFile(this ApiClient client, string fileID, string endpointName, string endpointVersion)
		{
            return GetFileAsync(client, fileID, endpointName, endpointVersion).Result;
        }
        public async static Task<Stream> GetFileAsync(this ApiClient client, string fileID, string endpointName, string endpointVersion)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                $"/entity/{endpointName}/{endpointVersion}/files/{fileID}",
                HttpMethod.Get,
                null,
                null,
                HeaderContentType.OctetStream,
                HeaderContentType.Json
                );

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStreamAsync();
        }
        public static void PutFile(this ApiClient client, Entity entity, string filename, byte[] content)
        {
            Task.Run(() => PutFileAsync(client, entity, filename, content)).GetAwaiter().GetResult();
        }
        public async static Task PutFileAsync(this ApiClient client, Entity entity, string filename, byte[] content)
        {
            if (String.IsNullOrWhiteSpace(entity.Links?.FileUploadLink))
                ThrowMissingParameter(nameof(PutFileAsync), nameof(Links.FileUploadLink));
            FilePutLocation parsedLocation = UrlParser.ParseFilePutLocation(entity.Links!.FileUploadLink!);

            HttpResponseMessage response = await client.CallApiAsync(
                $"/entity/{parsedLocation.EndpointName}/{parsedLocation.EndpointVersion}/files/{parsedLocation.GraphType}/{parsedLocation.ViewName}/{parsedLocation.ID}/{filename}",
                HttpMethod.Put,
                null,
                content,
                HeaderContentType.Json,
                HeaderContentType.OctetStream);

            response.EnsureSuccessStatusCode(); 
        }
    }
}
