using System;
using System.Collections.Generic;
using System.Linq;

using Acumatica.Auth.Model;
using Acumatica.RESTClient.Client;

using RestSharp;
using RestSharp.Authenticators;


namespace Acumatica.RESTClient.Api
{

    public class ODataAPI
    {
        protected readonly string Username;
        protected readonly string Password;
        protected string BasePath;
        protected ODataVersion Version;
        protected string Tenant;
        protected Token Token;
        
        //for oauth initialization
        public ODataAPI(Configuration configuration, ODataVersion version, string tenant=null) 
        {
            Username = configuration.Username;
            Password = configuration.Password;
            BasePath = configuration.BasePath;
            Version = version;
            Tenant = tenant;
            Token = configuration.Token;
            

        }
        
        //for basic authentication
        public ODataAPI(string username, string password, string basePath, ODataVersion version, string tenant = null)
        {
            Username = username;
            Password = password;
            BasePath = basePath;
            Version = version;
            Tenant = tenant;
        }
      
        public string Get(string resource = null, string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {
            RestRequest request;
            RestResponse response;
            var path = ConfigurePath(Version.ToString(), Tenant);
            RestClient client = new RestClient(path);
            //Oauth authentication
            if (Token != null)
            {
                request = GetOauthAuthentication(client);
            }   

            //Basic authentication
            else
            {
                request = GetBasicAuthentication(client, resource);                
            }
            AddParameters(request, select, filter, expand, custom, skip, top);
            response = client.ExecuteAsync(request).Result;

            ApiResponse<string> apiresponse = new ApiResponse<string>((int)response.StatusCode, response.Headers
                            .Where(x => x.Name != "Set-Cookie")
                            .ToDictionary(x => x.Name, x => x.Value.ToString()),
                            response.Content);

            return apiresponse.Data;
        }




        #region Implementation


        /// <summary>
        /// Composes Query Parameters for API Request. 
        /// </summary>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="filter">The conditions that determine which records should be selected from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <param name="skip">The number of records to be skipped from the list of returned records. (optional)</param>
        /// <param name="top">The number of records to be returned from the system. (optional)</param>
        protected void AddParameters(RestRequest request, string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {

            var queryParameters = new Dictionary<string, string>();
            queryParameters.Add("$format", "json");
            if (!String.IsNullOrEmpty(select)) queryParameters.Add("$select", select); // query parameter
            if (!String.IsNullOrEmpty(filter)) queryParameters.Add("$filter", filter); // query parameter
            if (!String.IsNullOrEmpty(expand)) queryParameters.Add("$expand", expand); // query parameter
            if (!String.IsNullOrEmpty(custom)) queryParameters.Add("$custom", custom); // query parameter
            if (skip != null) queryParameters.Add("$skip", skip.ToString()); // query parameter
            if (top != null) queryParameters.Add("$top", top.ToString()); // query parameter
            foreach (var parameter in queryParameters)
            {
                request.AddParameter(parameter.Key, parameter.Value);
            }

        }

        private string ConfigurePath(string version, string tenant = null)
        {
            string path;
            if (tenant == null)
            {
                path = BasePath + "/" + version;
            }
            else
            {
                path = BasePath + "/" + version + "/" + tenant;
            }
            return path;
        }

        private RestRequest GetOauthAuthentication(RestClient client)
        {
            var request = new RestRequest();
            client.Authenticator = new JwtAuthenticator(Token.Access_token);
            return request;
        }

        private RestRequest GetBasicAuthentication(RestClient client, string resource = null)
        {
            client.Authenticator = new HttpBasicAuthenticator(Username, Password);
            RestRequest request;
            if (resource != null)
            {
                request = new RestRequest(resource);
            }
            else
            {
                request = new RestRequest();
            }
            return request;


        }

        #endregion
    }

}
