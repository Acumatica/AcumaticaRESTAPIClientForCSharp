using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;

using RestSharp;

namespace Acumatica.RESTClient.MaintenanceApi
{
    public class MaintenanceApi : BaseApi
    {
        public MaintenanceApi(Configuration configuration) : base(configuration)
        {

        }
     
        public void PutSchema(string endpointXML)
        {
            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                "/entity/maintenance/23.200/",
                Method.Post,
                ComposeEmptyQueryParams(),
                endpointXML,
                ComposeAcceptHeaders(HeaderContentType.Xml),
                ComposeEmptyFormParams(),
                null,
                null,
                ComposeContentHeaders(HeaderContentType.Xml)).Result;

            VerifyResponse(localVarResponse, "PutSchema");
        }

        public string GetSchema(string endpointName, string endpointVersion)
        {

            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                $"/entity/maintenance/23.200/{endpointName}/{endpointVersion}",
                Method.Get,
                ComposeEmptyQueryParams(),
                null,
                ComposeAcceptHeaders(HeaderContentType.Xml),
                ComposeEmptyFormParams(),
                null,
                null,
                ComposeContentHeaders(HeaderContentType.Xml)).Result;

            VerifyResponse(localVarResponse, "GetSchema"); 
            return DeserializeResponse<string>(localVarResponse).Data;
        }
    }
}
