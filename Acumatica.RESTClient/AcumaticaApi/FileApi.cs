using System;
using System.IO;
using System.Threading.Tasks;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Model;

using RestSharp;

namespace Acumatica.RESTClient.Api
{
	public class FileApi : BaseApi
	{
		public FileApi(Configuration configuration) : base(configuration)
		{
		}
        public Stream GetFile(FileLink fileLink)
        {
             return   GetFileAsync(fileLink)
             .GetAwaiter().GetResult();
        }
        public Stream GetFile(Guid fileID, string endpointName, string endpointVersion)
        {
            return
                GetFileAsync(fileID, endpointName, endpointVersion)
             .GetAwaiter().GetResult();
        }
        public Stream GetFile(string href)
        {
            return 
                GetFileAsync(href)
             .GetAwaiter().GetResult();
        }

        public async Task<Stream> GetFileAsync(FileLink fileLink)
		{
			return await GetFileAsync(fileLink.Href);
		}
        public async Task<Stream> GetFileAsync(Guid fileID, string endpointName, string endpointVersion)
        {
            // make the HTTP request
            RestResponse localVarResponse = await Configuration.ApiClient.CallApiAsync(
                $"/entity/{endpointName}/{endpointVersion}/files/{fileID}",
                Method.Get,
                ComposeEmptyQueryParams(),
                null,
                ComposeAcceptHeaders(HeaderContentType.OctetStream),
                ComposeEmptyFormParams(),
                ComposeEmptyFileParams(),
                ComposeEmptyPathParams(),
                ComposeContentHeaders(HeaderContentType.Json)
                );

            VerifyResponse<FileLink>(localVarResponse, "GetFile");
            MemoryStream stream = new MemoryStream(localVarResponse.RawBytes);
            return stream;
        }
		public async Task<Stream> GetFileAsync(string href)
        {
			// make the HTTP request
			RestResponse localVarResponse = await Configuration.ApiClient.CallApiAsync(
				href,
                Method.Get, 
				ComposeEmptyQueryParams(), 
				null, 
				ComposeAcceptHeaders(HeaderContentType.OctetStream), 
				ComposeEmptyFormParams(),
				ComposeEmptyFileParams(),
				ComposeEmptyPathParams(),
				ComposeContentHeaders(HeaderContentType.Json)
				);

            VerifyResponse<FileLink>(localVarResponse, "GetFile");
			MemoryStream stream = new MemoryStream(localVarResponse.RawBytes);
			return stream;
        }
    }
}
