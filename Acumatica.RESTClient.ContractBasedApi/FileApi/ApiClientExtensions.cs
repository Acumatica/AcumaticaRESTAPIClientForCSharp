using System;
using System.Collections.Generic;
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
using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;

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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="entity"></param>
        /// <param name="filename"></param>
        /// <param name="content"></param>
        /// <param name="comment">Starting from Acumatica 2024r2 it is possible to specify the file comment.</param>
        public static void PutFile(this ApiClient client, Entity entity, string filename, byte[] content, string? comment = null)
        {
            Task.Run(() => PutFileAsync(client, entity, filename, content, comment)).GetAwaiter().GetResult();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="entity"></param>
        /// <param name="filename"></param>
        /// <param name="content"></param>
        /// <param name="comment">Starting from Acumatica 2024r2 it is possible to specify the file comment.</param>
        /// <returns></returns>
        public async static Task PutFileAsync(this ApiClient client, Entity entity, string filename, byte[] content, string? comment = null)
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
                HeaderContentType.OctetStream,
                ComposeFileUploadHeaders(comment));

            response.EnsureSuccessStatusCode();
        }
        private static Dictionary<string, string>? ComposeFileUploadHeaders(string? comment)
        {
            if (comment != null)
            {
                return new Dictionary<string, string>
                {
                    { "PX-CbFileComment", comment }
                };
            }
            return null;
        }
    }
}
