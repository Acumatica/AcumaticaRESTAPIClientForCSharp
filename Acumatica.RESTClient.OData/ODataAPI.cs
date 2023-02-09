using System;

using Acumatica.RESTClient.Client;

using RestSharp;
using RestSharp.Authenticators;

namespace Acumatica.RESTClient.Api
{

    public class ODataAPI : BaseApi
    {
      
        protected ODataVersion Version;
        protected string Tenant;
        
        public ODataAPI(Configuration configuration, ODataVersion version, string tenant=null): base(configuration)
        {
            Version = version;
            Tenant = tenant;
        }
      
       
        public ApiResponse<string> Get(string resource = null, string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {
            var path = ConfigureResourcePath(ConfigurePath(), resource);

            if(this.Configuration.Token==null && (this.Configuration.Username == null && this.Configuration.Password == null))
            {
                throw new Exception("Either token or username/password  pair have to be provided");
            }

            //Basic authentication
            if (this.Configuration.Token == null)
            {
                BasicAuthentication(this.Configuration.ApiClient.RestClient);
            }
            
            //Oauth authentication
            RestResponse response = (RestResponse)Configuration.ApiClient.CallApiAsync(path, Method.Get, ComposeQueryParams(select, filter, expand, custom, skip, top), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(), ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.Json)).Result;         
            return DeserializeResponse<string>(response);
        }


        #region Implementation

        /// <summary>
		/// Configures the base path according to version of OData and tenant, if exists.
		/// </summary>
        private string ConfigurePath()
        {
            string path;
            if (Tenant == null)
            {
                path = this.Configuration.BasePath + "/" + Version;
            }
            else
            {;
                path = GetBasePath() + "/" + Version + "/" + Tenant;
            }
            return path;
        }

        private string ConfigureResourcePath(string path, string resource = null)
        {
            if (resource != null)
            {
                path = path + "/" + resource;
            }
            return path;
        }
 
        private void BasicAuthentication(RestClient client)
        {
            client.Authenticator = new HttpBasicAuthenticator(this.Configuration.Username, this.Configuration.Password);
        }
        

        #endregion
    }

}
