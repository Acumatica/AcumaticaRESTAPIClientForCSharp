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
            var localVarPath = "/entity/maintenance/23.200/";

            // make the HTTP request
            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                localVarPath,
                Method.Post,
                ComposeEmptyQueryParams(),
                endpointXML,
                ComposeAcceptHeaders(HeaderContentType.Xml),
                ComposeEmptyFormParams(),
                ComposeEmptyFileParams(),
                ComposeEmptyPathParams(),
                ComposeContentHeaders(HeaderContentType.Xml)).Result;

            VerifyResponse(localVarResponse, "PutSchema");
        }

        public string GetSchema(string endpointName, string endpointVersion)
        {
            var localVarPath = $"/entity/maintenance/23.200/{endpointName}/{endpointVersion}";

            // make the HTTP request
            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                localVarPath,
                Method.Get,
                ComposeEmptyQueryParams(),
                null,
                ComposeAcceptHeaders(HeaderContentType.Xml),
                ComposeEmptyFormParams(),
                ComposeEmptyFileParams(),
                ComposeEmptyPathParams(),
                ComposeContentHeaders(HeaderContentType.Xml)).Result;

            VerifyResponse(localVarResponse, "GetSchema"); 
            return DeserializeResponse<string>(localVarResponse).Data;
        }
    }
}
