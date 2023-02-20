using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.FileApi.Model;
using Acumatica.RESTClient.Model;

using RestSharp;


namespace Acumatica.RESTClient.Api
{
    public abstract partial class EntityAPI<EntityType> : BaseApi
        where EntityType : Entity
    {
        #region Obsolete
        //TODO remove
        [Obsolete()]
        public struct Location
        {
            public string Site;
            public string Status;
            public string EndpointName;
            public string EndpointVersion;
            public string EntityName;
            public string ActionName;
            public string ID;
        }
        //TODO remove
        [Obsolete()]
        public static Location ParseLocation(string location)
        {
            var locationParsed = UrlParser.ParseActionLocation(location);
            return new Location()
            {
                ID = locationParsed.ID,
                Site = locationParsed.Site,
                Status = locationParsed.Status,
                EndpointName = locationParsed.EndpointName,
                EndpointVersion = locationParsed.EndpointVersion,
                ActionName = locationParsed.ActionName,
                EntityName = locationParsed.EntityName
            };
        }
        //TODO remove
        [Obsolete]
        protected Dictionary<string, string> ComposeIDPathParams(Guid? id = null)
        {
            Dictionary<string, string> pathParams = ComposeEmptyPathParams();

            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            return pathParams;
        }

        //TODO remove
        [Obsolete]
        protected Dictionary<string, string> ComposeIDsPathParams(IEnumerable<string> ids, string filename = null)
        {
            var pathParams = ComposeEmptyPathParams();

            if (ids != null) pathParams.Add("ids", this.Configuration.ApiClient.ParameterToString(ids)); // path parameter
            if (filename != null) pathParams.Add("filename", this.Configuration.ApiClient.ParameterToString(filename)); // path parameter
            return pathParams;
        }
        #endregion
    }
}
