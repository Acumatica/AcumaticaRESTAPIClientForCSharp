using System.Threading.Tasks;

using Acumatica.RESTClient.Client;

using RestSharp;

namespace Acumatica.RESTClient.Api
{
    public class MaintenanceApi : BaseApi
    {
        public MaintenanceApi(Configuration configuration) : base(configuration)
        {

        }
        public void PutSchema(string endpointXML)
        {
               PutSchemaAsync(endpointXML)
            .GetAwaiter().GetResult();
        }
        public string GetSchema(string endpointName, string endpointVersion)
        {
            return 
               GetSchemaAsync(endpointName, endpointVersion)
            .GetAwaiter().GetResult();
        }
        public async Task PutSchemaAsync(string endpointXML)
        {
            var localVarPath = "/entity/maintenance/23.200/";

            // make the HTTP request
            RestResponse localVarResponse = await Configuration.ApiClient.CallApiAsync(
                localVarPath,
                Method.Post,
                ComposeEmptyQueryParams(),
                endpointXML,
                ComposeAcceptHeaders(HeaderContentType.Xml),
                ComposeEmptyFormParams(),
                ComposeEmptyFileParams(),
                ComposeEmptyPathParams(),
                ComposeContentHeaders(HeaderContentType.Xml));

            VerifyResponse(localVarResponse, "PutSchema");
        }

        public async Task<string> GetSchemaAsync(string endpointName, string endpointVersion)
        {
            var localVarPath = $"/entity/maintenance/23.200/{endpointName}/{endpointVersion}";

            // make the HTTP request
            RestResponse localVarResponse = await Configuration.ApiClient.CallApiAsync(
                localVarPath,
                Method.Get,
                ComposeEmptyQueryParams(),
                "",
                ComposeAcceptHeaders(HeaderContentType.Xml),
                ComposeEmptyFormParams(),
                ComposeEmptyFileParams(),
                ComposeEmptyPathParams(),
                ComposeContentHeaders(HeaderContentType.Xml));

            VerifyResponse(localVarResponse, "GetSchema"); 
            return DeserializeResponse<string>(localVarResponse).Data;
        }
    }
}
