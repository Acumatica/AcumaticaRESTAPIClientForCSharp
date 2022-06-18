using System;
using System.Collections.Generic;
using System.Text;

using Acumatica.RESTClient.Client;

using RestSharp;

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
