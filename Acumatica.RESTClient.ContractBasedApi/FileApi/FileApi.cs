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

		public System.IO.Stream GetFile(FileLink fileLink)
		{
			return GetFile(fileLink.Href);
		}
		public System.IO.Stream GetFile(Guid fileID, string endpointName, string endpointVersion)
		{
			throw new NotImplementedException();
		}
		public System.IO.Stream GetFile(string href)
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
