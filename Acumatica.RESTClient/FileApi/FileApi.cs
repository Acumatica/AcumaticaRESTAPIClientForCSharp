using System;
using System.IO;
using System.Net.Http;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.FileApi.Model;


namespace Acumatica.RESTClient.FileApi
{
	public class FileApi : BaseApi
	{
		public FileApi(ApiClient configuration) : base(configuration)
		{
		}

		public Stream GetFile(FileLink fileLink)
		{
			return GetFile(fileLink.Href);
		}
        public Stream GetFile(string href)
        {
            var parsedLocation = UrlParser.ParseFileLocation(href);
            return GetFile(parsedLocation.ID, parsedLocation.EndpointName, parsedLocation.EndpointVersion);
        }
        public Stream GetFile(Guid fileID, string endpointName, string endpointVersion)
        {
            return GetFile(fileID.ToString(), endpointName, endpointVersion);
        }
        public Stream GetFile(string fileID, string endpointName, string endpointVersion)
		{
            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                $"/entity/{endpointName}/{endpointVersion}/files/{fileID}",
                HttpMethod.Get,
                ComposeEmptyQueryParams(),
                null,
                ComposeAcceptHeaders(HeaderContentType.OctetStream),
                ComposeContentHeaders(HeaderContentType.Json)
                ).Result;

            VerifyResponse(localVarResponse, nameof(GetFile));
            return localVarResponse.Content.ReadAsStreamAsync().Result;
        }

    }
}
