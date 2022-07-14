using System;
using System.Collections.Generic;
using Acumatica.RESTClient.Client;
using RestSharp;
using RestSharp.Authenticators;

namespace Acumatica.RESTClient.Api
{
   
    public class ODataAPI : BaseApi
    {
        RestClient client;
        string basePath;

        public ODataAPI(Configuration configuration) : base(configuration)
        {
            basePath = configuration.BasePath;
        }
        /*
        public string Get(string path, string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {
            ApiResponse<string> localVarResponse = GetWithHttpInfo(path, select, filter, expand, custom, skip, top);
            return localVarResponse.Data;
        }
        */
        public string Get(string version, string resource = null, Dictionary<string, string> parameters = null, string username = null, string password = null)
        {
            if(username != null && password != null)
            {
                //get for login
                basePath += "/" + version;
                client = new RestClient(basePath);
                client.Authenticator = new HttpBasicAuthenticator(username, password);
                var request = new RestRequest();
                var response = client.ExecuteAsync(request).Result;
                ApiResponse<string> apiresponse = DeserializeResponse<string>(response);
                return apiresponse.Data;
            }
            else
            {
                var request = new RestRequest(resource);
                if(parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        request.AddParameter(parameter.Key, parameter.Value);
                    }
                }
                var response = client.GetAsync(request);
                ApiResponse<string> apiresponse = DeserializeResponse<string>(response.Result);
                return apiresponse.Data;
                
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
