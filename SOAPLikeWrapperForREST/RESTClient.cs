using Acumatica.Auth.Api;
using Acumatica.Auth.Model;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Model;
using AcumaticaSOAPWrapperForREST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLikeWrapperForREST
{

    public class RESTClient
    {
        Dictionary<string, DateTime> ProcessStartTime;

        protected AuthApi AuthorizationApi;
        protected Configuration CurrentConfiguration;

        public RESTClient(string siteURL, string endpointPath)
        {
            AuthorizationApi = new AuthApi(siteURL);
            ProcessStartTime = new Dictionary<string, DateTime>();
            CurrentConfiguration = new Configuration(siteURL + endpointPath);
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
        [Obsolete("Get method is for backward compatibility with SOAP only. Use one of the following REST methods instead: GetList, GetByKeys, GetByID")]
        public Entity Get<T>(T entity)
            where T : Entity
        {
            string expand = ComposeExpands(entity);
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
            if (entity.Id.HasValue)
            {
                return api.GetById(entity.Id, expand: expand);
            }
            string filter = ComposeFilter(entity);
            var result = api.GetList(filter: filter, expand: expand);
            if (result.Count > 1)
                throw new Exception("More than one entity satisfies the condition.");
            return result.FirstOrDefault();
        }

        private static string ComposeFilter<T>(T entity) where T : Entity
        {
            string filter = "";
            foreach (var field in entity.GetStringFields())
            {
                if (field.Value != null)
                {
                    filter += field.Name + " eq " + "'" + field.Value + "' and ";
                }
            }

            filter = filter.Substring(0, filter.Length - 4);
            return filter;
        }
        private static string ComposeExpands<T>(T entity) where T : Entity
        {
            string expand = "";
            foreach (DetailEntity detailEntity in entity.GetDetails())
            {
                foreach (var row in detailEntity.Details)
                {
                    if (row?.ReturnBehavior == ReturnBehavior.All || row?.ReturnBehavior == ReturnBehavior.Default)
                    {
                        expand += detailEntity.Name += ",";
                        break;
                    }
                }
            }
            foreach (LinkedEntity linkedEntity in entity.GetLinkedEntities())
            {
                if (linkedEntity?.Value?.ReturnBehavior == ReturnBehavior.All || linkedEntity?.Value?.ReturnBehavior == ReturnBehavior.Default)
                {
                    expand += linkedEntity.Name += ",";
                    break;
                }
            }

            expand = expand.TrimEnd(',');

            return expand;
        }


        public T Put<T>(T entity)
            where T : Entity
        {
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
            return api.PutEntity(entity);
        }
        public string Invoke<T>(EntityAction<T> action)
              where T : Entity
        {
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
            string invokeResult = api.InvokeAction(action);
            ProcessStartTime.Add(invokeResult, DateTime.Now);
            return invokeResult;
        }
        public ProcessResult GetProcessStatus(string invokeResult)
        {
            SOAPLikeEntityAPI<Entity> api = new SOAPLikeEntityAPI<Entity>(CurrentConfiguration);
            return new ProcessResult()
            {
                Status = (ProcessStatus)api.GetProcessStatus(invokeResult),
                Seconds = GetProcessingSeconds(invokeResult),
                Message = invokeResult
            };
        }
        int GetProcessingSeconds(string invokeResult)
        {
            if (ProcessStartTime.ContainsKey(invokeResult))
            {
                return (int)(DateTime.Now - ProcessStartTime[invokeResult]).TotalSeconds;
            }
            return 0;
        }
        public void Delete<T>(T entity)
              where T : Entity
        {
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
             api.DeleteById(entity.Id);
        }

        public List<T> GetList<T>(T entity)
            where T : Entity
        {
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
            var result = api.GetList();
           
            return result;
        }
    }
}
