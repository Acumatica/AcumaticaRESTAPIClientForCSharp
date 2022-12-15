using System;
using System.IO;

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
			return GetFile(fileLink.Href);
		}
		public Stream GetFile(Guid fileID, string endpointName, string endpointVersion)
		{
			throw new NotImplementedException();
		}
		public Stream GetFile(string href)
        {
			// make the HTTP request
			RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApiAsync(
				href,
                Method.Get, 
				ComposeEmptyQueryParams(), 
				null, 
				ComposeAcceptHeaders(HeaderContentType.OctetStream), 
				ComposeEmptyFormParams(),
				ComposeEmptyFileParams(),
				ComposeEmptyPathParams(),
				ComposeContentHeaders(HeaderContentType.Json)
				).Result;

            VerifyResponse<FileLink>(localVarResponse, "GetFile");
			MemoryStream stream = new MemoryStream(localVarResponse.RawBytes);
			return stream;
        }
    }
}
