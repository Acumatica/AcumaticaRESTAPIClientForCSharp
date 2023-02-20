using System;
using System.IO;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.FileApi.Model;

using RestSharp;

namespace Acumatica.RESTClient.FileApi
{
	public class FileApi : BaseApi
	{
		public FileApi(Configuration configuration) : base(configuration)
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
            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                $"/entity/{endpointName}/{endpointVersion}/files/{fileID}",
                Method.Get,
                ComposeEmptyQueryParams(),
                null,
                ComposeAcceptHeaders(HeaderContentType.OctetStream),
                ComposeEmptyFormParams(),
                null,
                null,
                ComposeContentHeaders(HeaderContentType.Json)
                ).Result;

            VerifyResponse(localVarResponse, nameof(GetFile));
            MemoryStream stream = new MemoryStream(localVarResponse.RawBytes);
            return stream;
        }

    }
}
