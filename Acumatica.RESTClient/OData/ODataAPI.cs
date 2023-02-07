using System;

using Acumatica.RESTClient.Client;

using RestSharp;
using RestSharp.Authenticators;

namespace Acumatica.RESTClient.OData
{

    public class ODataAPI : BaseApi
    {

        protected ODataVersion Version;
        protected string Tenant;

        public ODataAPI(Session session, ODataVersion version, string tenant = null) : base(session)
        {
            Version = version;
            Tenant = tenant;
        }


        public ApiResponse<string> Get(string resource = null, string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {
            var path = ConfigureResourcePath(ConfigurePath(), resource);

            if (Session.Token == null && Session.Username == null && Session.Password == null)
            {
                throw new Exception("Either token or username/password  pair have to be provided");
            }

            //Basic authentication
            if (Session.Token == null)
            {
                BasicAuthentication(Session.ApiClient.RestClient);
            }

            //Oauth authentication
            RestResponse response = (RestResponse)Session.ApiClient.CallApiAsync(path, Method.Get, ComposeQueryParams(select, filter, expand, custom, skip, top), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(), ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.Json)).Result;
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
                path = Session.BasePath + "/" + Version;
            }
            else
            {
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
            client.Authenticator = new HttpBasicAuthenticator(Session.Username, Session.Password);
        }


        #endregion
    }

}
