using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acumatica.RESTClient.Api
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
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(
				href,
                Method.GET, 
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
