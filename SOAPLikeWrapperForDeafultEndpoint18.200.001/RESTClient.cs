using Acumatica.Auth.Api;
using Acumatica.Auth.Model;
using Acumatica.DefaultEndpoint_18_200_001.Api;
using Acumatica.DefaultEndpoint_18_200_001.Model;
using Acumatica.RESTClient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLikeWrapperForDeafultEndpoint_18_200_001
{
    public class RESTClient
    {
        protected AuthApi AuthorizationApi;
        protected Configuration CurrentConfiguration;

        public RESTClient(string siteURL)
        {
            AuthorizationApi = new AuthApi(siteURL);
            CurrentConfiguration = new Configuration(DefaultEndpoint_18_200_001.EndpointHelper.CombineEndpointURL(siteURL));
        }

        public void Login(string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            var cookieContainer = new CookieContainer();
            AuthorizationApi.Configuration.ApiClient.RestClient.CookieContainer = cookieContainer;
            AuthorizationApi.AuthLogin(new Credentials(username, password, tenant, branch, locale));

            //share cookie container between API clients because we use different client for authentication and interaction with endpoint
            CurrentConfiguration.ApiClient.RestClient.CookieContainer = AuthorizationApi.Configuration.ApiClient.RestClient.CookieContainer;
        }
        public void Logout()
        {
            AuthorizationApi.AuthLogout();
        }
        [Obsolete]
        public Entity Get(Entity entity)
        {
            ShipmentApi api = new ShipmentApi(CurrentConfiguration);
            var keys = new List<string>();
            keys.Add(((Shipment)entity).ShipmentNbr.Value);
            return api.GetByKeys(keys);
        }
    }
}
