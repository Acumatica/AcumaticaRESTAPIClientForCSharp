using System.Net.Http;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;

namespace Acumatica.RESTClient.MaintenanceApi
{
    public class MaintenanceApi : BaseApi
    {
        public MaintenanceApi(ApiClient configuration) : base(configuration)
        {

        }
     
        public void PutSchema(string endpointXML)
        {
            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                "/entity/maintenance/23.200/",
                HttpMethod.Post,
                endpointXML,
                ComposeAcceptHeaders(HeaderContentType.Xml),
                ComposeContentHeaders(HeaderContentType.Xml)).Result;

            VerifyResponse(localVarResponse, "PutSchema");
        }

        public string GetSchema(string endpointName, string endpointVersion)
        {

            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                $"/entity/maintenance/23.200/{endpointName}/{endpointVersion}",
                HttpMethod.Get,
                null,
                ComposeAcceptHeaders(HeaderContentType.Xml),
                ComposeContentHeaders(HeaderContentType.Xml)).Result;

            VerifyResponse(localVarResponse, "GetSchema"); 
            return DeserializeResponse<string>(localVarResponse).Data;
        }
    }
}
