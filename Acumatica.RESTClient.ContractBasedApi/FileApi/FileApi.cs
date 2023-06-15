using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.FileApi.Model;


namespace Acumatica.RESTClient.FileApi
{
	public static class FileApi 
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

    }
}
