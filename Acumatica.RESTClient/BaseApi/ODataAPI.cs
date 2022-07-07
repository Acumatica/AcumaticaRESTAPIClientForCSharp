using System;
using System.Collections.Generic;
using Acumatica.RESTClient.Client;
using RestSharp;
using RestSharp.Authenticators;

namespace Acumatica.RESTClient.Api
{
   
    public class ODataAPI : BaseApi
    {
        
        public ODataAPI(Configuration configuration) : base(configuration)
        {
        }
        public string Get(string path, string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {
            ApiResponse<string> localVarResponse = GetWithHttpInfo(path, select, filter, expand, custom, skip, top);
            return localVarResponse.Data;
        }

        public string GetV3(string path, string resource=null, List<string> parameters=null, string username=null, string password=null)
        {
            if(username != null && password != null && resource==null)
            {
                RestClient client =  new RestClient(path);
                client.Authenticator = new HttpBasicAuthenticator(username, password);
                var request = new RestRequest();
                var response = client.ExecuteAsync(request).Result;
                ApiResponse<string> apiresponse = DeserializeResponse<string>(response); 
                return apiresponse.Data;
            }
            else
            {
                //var request = new RestRequest("/Customer%20Contacts");
                return null;
            }
        }

        protected ApiResponse<string> GetWithHttpInfo(string path, string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {
            if (String.IsNullOrEmpty(path))
                ThrowMissingParameter(nameof(GetWithHttpInfo), nameof(path));

            var localVarPath = "OData" + "/" + path;

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)this.Configuration.ApiClient.CallApiAsync(
                localVarPath,
                Method.Get, 
                ComposeQueryParams(select, filter, expand, custom, top, skip), 
                null, 
                ComposeAcceptHeaders(HeaderContentType.Json), 
                ComposeEmptyFormParams(), 
                ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), 
                ComposeContentHeaders(HeaderContentType.None)).Result;

            VerifyResponse<string>(localVarResponse, nameof(GetWithHttpInfo));

            return DeserializeResponse<string>(localVarResponse);
        }

    }
}
