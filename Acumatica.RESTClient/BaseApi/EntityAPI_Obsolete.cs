using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.FileApi.Model;
using Acumatica.RESTClient.Model;



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
        #endregion
    }
}
