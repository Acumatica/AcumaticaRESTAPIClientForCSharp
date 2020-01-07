using Acumatica.Auth.Api;
using Acumatica.Auth.Model;
using Acumatica.DefaultEndpoint.Api;
using Acumatica.DefaultEndpoint.Model;
using Acumatica.RESTClient.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLikeWrapper
{
    public class RESTClient
    {
        protected AuthApi AuthorizationApi;
        protected Configuration CurrentConfiguration;

        public RESTClient(string siteURL)
        {
            AuthorizationApi = new AuthApi(siteURL);
            CurrentConfiguration = new Configuration(Default._18._200._001.EndpointHelper.CombineEndpointURL(siteURL));
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

        public Entity Get(Entity entity)
        {
            ShipmentApi api = new ShipmentApi(CurrentConfiguration);
            var keys = new List<string>();
            keys.Add(((Shipment)entity).ShipmentNbr.Value);
            return api.ShipmentGetByKeys(keys);
        }
    }
}
