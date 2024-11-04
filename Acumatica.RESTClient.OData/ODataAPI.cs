using System;
using System.Collections.Generic;
using System.Net.Http;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Auxiliary;
using Acumatica.RESTClient.Client;


namespace Acumatica.RESTClient.ODataApi
{
    public class ODataAPI : BaseApi
    {
        protected ODataVersion Version;
        protected string Tenant;

        public ODataAPI(ApiClient configuration, ODataVersion version, string tenant = null) : base(configuration)
        {
            Version = version;
            Tenant = tenant;
        }
        public ApiResponse<string> GetMetadata()
        {
            return GetOData("$metadata");
        }
        public ApiResponse<string> GetOData(string resource, string select = null, string filter = null, string expand = null, int? skip = null, int? top = null, string orderby = null)
        {
            //Oauth authentication
            HttpResponseMessage response = ApiClient.CallApiAsync(
                ConfigurePath(resource),
                HttpMethod.Get,
                ComposeQueryParamsOData(select, filter, expand, null, skip, top, orderby),
                null,
                HeaderContentType.Json,
                HeaderContentType.Json,
                ComposeAuthenticationHeaders()
            ).Result;

            VerifyResponse(response, nameof(GetOData));
            return DeserializeResponse<string>(response);
        }


        #region Implementation

        protected List<KeyValuePair<string, string>> ComposeQueryParamsOData(string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null, string orderby = null)
        {
            var queryParameters = ComposeQueryParams(select, filter, expand, custom, skip, top);
            if (!String.IsNullOrEmpty(orderby)) queryParameters.AddRange(ApiClient.ParameterToKeyValuePairs("", "$orderby", orderby));

            return queryParameters;
        }

        /// <summary>
        /// Configures the base path according to version of OData and tenant, if exists.
        /// </summary>
        private string ConfigurePath(string resource)
        {
            return string.IsNullOrEmpty(Tenant) 
                 ?
                 $"{Version}/{resource}" 
                 : 
                 $"{Version}/{Tenant}/{resource}";
        }

        private Dictionary<string, string> ComposeAuthenticationHeaders()
        {
            if (ApiClient.Token == null && (ApiClient.Username == null && ApiClient.Password == null))
            {
                throw new Exception("Either token or username/password  pair have to be provided");
            }

            //Basic authentication
            if (ApiClient.Token == null)
            {
                var customHeaders = new Dictionary<string, string>();

                customHeaders.Add("Authorization", $"Basic {ApiClientHelpers.Base64Encode($"{ApiClient.Username}:{ApiClient.Password}")}");
                return customHeaders;
            }
            else
            {
                // ApiClient will take care of Token-based authentication
                return null;
            }
        }

        #endregion
    }

}
