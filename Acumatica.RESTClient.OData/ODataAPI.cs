using System;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;

using RestSharp;
using RestSharp.Authenticators;

namespace Acumatica.RESTClient.ODataApi
{
    public class ODataAPI : BaseApi
    {
        protected ODataVersion Version;
        protected string Tenant;

        public ODataAPI(Configuration configuration, ODataVersion version, string tenant = null) : base(configuration)
        {
            Version = version;
            Tenant = tenant;
        }
        public ApiResponse<string> GetMetadata()
        {
            return GetOData("$metadata");
        }
        public ApiResponse<string> GetOData(string resource, string select = null, string filter = null, string expand = null, int? skip = null, int? top = null)
        {
            if (Configuration.Token == null && (Configuration.Username == null && Configuration.Password == null))
            {
                throw new Exception("Either token or username/password  pair have to be provided");
            }

            //Basic authentication
            if (Configuration.Token == null)
            {
                BasicAuthentication(Configuration.ApiClient.RestClient);
            }

            //Oauth authentication
            RestResponse response = Configuration.ApiClient.CallApiAsync(
                ConfigurePath(resource), 
                Method.Get, 
                ComposeQueryParams(select, filter, expand, null, skip, top), 
                null, 
                ComposeAcceptHeaders(HeaderContentType.Json), 
                ComposeEmptyFormParams(), 
                ComposeEmptyFileParams(), 
                ComposeEmptyPathParams(), 
                ComposeContentHeaders(HeaderContentType.Json)
            ).Result;

            VerifyResponse(response, nameof(GetOData));
            return DeserializeResponse<string>(response);
        }

        [Obsolete("Use GetOdata and GetMetadata methods instead" )]
        public ApiResponse<string> Get(string resource = null, string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {
            if(Configuration.Token==null && (Configuration.Username == null && Configuration.Password == null))
            {
                throw new Exception("Either token or username/password  pair have to be provided");
            }

            //Basic authentication
            if (Configuration.Token == null)
            {
                BasicAuthentication(Configuration.ApiClient.RestClient);
            }
            
            //Oauth authentication
            RestResponse response = Configuration.ApiClient.CallApiAsync(ConfigurePath(resource), Method.Get, ComposeQueryParams(select, filter, expand, custom, skip, top), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(), ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.Json)).Result;
            VerifyResponse(response, nameof(Get));
            return DeserializeResponse<string>(response);
        }


        #region Implementation

        /// <summary>
		/// Configures the base path according to version of OData and tenant, if exists.
		/// </summary>
        private string ConfigurePath(string resource)
        {
            return string.IsNullOrEmpty(Tenant) 
                 ?
                 $"{Configuration.BasePath}/{Version}/{resource}" 
                 : 
                 $"{Configuration.BasePath}/{Version}/{Tenant}/{resource}";
        }
 
        private void BasicAuthentication(RestClient client)
        {
            client.Authenticator = new HttpBasicAuthenticator(Configuration.Username, Configuration.Password);
        }
        

        #endregion
    }

}
