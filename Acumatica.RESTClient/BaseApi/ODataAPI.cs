using System;
using System.Collections.Generic;
using System.Linq;
using Acumatica.RESTClient.Client;
using RestSharp;
using RestSharp.Authenticators;


namespace Acumatica.RESTClient.Api
{
   
    public class ODataAPI
    {
        RestClient client;
        readonly string username;
        readonly string password;
        string basePath;
        ODataVersion version;
        string tenant;
        Auth.Model.Token token;
        
        //for oauth initialization
        public ODataAPI(Configuration configuration, ODataVersion version, string tenant=null) 
        {
            username = configuration.Username;
            password = configuration.Password;
            basePath = configuration.BasePath;
            this.version = version;
            this.tenant = tenant;
            token = configuration.Token;
            

        }
        
        //for basic authentication
        public ODataAPI(string username, string password, string basePath, ODataVersion version, string tenant = null)
        {
            this.username = username;
            this.password = password;
            this.basePath = basePath;
            this.version = version;
            this.tenant = tenant;
        }
      
        public string Get(string resource = null, string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {
            RestRequest request;
            RestResponse response;
            var path = ConfigurePath(version.ToString(), tenant);
            client = new RestClient(path);
            //Oauth authentication
            if (token != null)
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


        /// <summary>
        /// Composes Query Parameters for API Request. 
        /// </summary>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="filter">The conditions that determine which records should be selected from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <param name="skip">The number of records to be skipped from the list of returned records. (optional)</param>
        /// <param name="top">The number of records to be returned from the system. (optional)</param>
        public void AddParameters(RestRequest request, string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
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


        #region Implementation
        private string ConfigurePath(string version, string tenant = null)
        {
           string path; 
           if(tenant== null)
            {
                path = basePath + "/" + version;
            }
            else
            {
                path = basePath + "/" + version + "/" + tenant;
            }
            return path;
        }

        private RestRequest GetOauthAuthentication(RestClient client)
        {
            var request = new RestRequest();
            client.Authenticator = new JwtAuthenticator(token.Access_token);
            return request;
        }

        private RestRequest GetBasicAuthentication(RestClient client, string resource = null)
        {
            client.Authenticator = new HttpBasicAuthenticator(username, password);
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



    public enum ODataVersion
    {
        OData, ODatav4
    } 

}
