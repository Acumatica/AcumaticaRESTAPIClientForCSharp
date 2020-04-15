using Acumatica.Auth.Api;
using Acumatica.Auth.Model;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace SOAPLikeWrapperForREST
{
    public class SOAPLikeClient
    {
        #region Constructor
        public SOAPLikeClient(string siteURL, string endpointPath)
        {
            AuthorizationApi = new AuthApi(siteURL);
            ProcessStartTime = new Dictionary<string, DateTime>();
            CurrentConfiguration = new Configuration(siteURL + endpointPath);
        }
        #endregion

        #region Public Methods
        public void SetBusinessDate(DateTime now)
        {
            BusinessDate = now;
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
        public T Get<T>(T entity)
            where T : Entity
        {
            string expand = ComposeExpands(entity);
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
            if (entity.ID.HasValue)
            {
                return api.GetById(entity.ID, expand: expand);
            }
            string filter = ComposeFilter(entity);
            var result = api.GetList(filter: filter);
            if (result.Count > 1)
            {
                throw new Exception("More than one entity satisfies the condition.");
            }

            return api.GetById(result.FirstOrDefault().ID, expand: expand);
        }
        public T[] GetList<T>(T entity, int? top = null, int? skip = null)
 where T : Entity
        {
            string expand = ComposeExpands(entity);
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);

            string filter = ComposeFilterForGetList(entity);
            var result = api.GetList(filter: filter, expand: expand, skip: skip, top: top);

            return result.ToArray();
        }
        public T Put<T>(T entity)
            where T : Entity
        {
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
            return api.PutEntity(entity, expand: ComposeExpands(entity), businessDate: BusinessDate);
        }
        [Obsolete("PutFiles method is for backward compatibility with SOAP only. Use one of the following REST methods instead: PutFile, PutFileAsync")]
        public void PutFiles<T>(List<string> keys, File[] files)
            where T : Entity
        {
            if (files.Length > 1)
            {
                throw new NotImplementedException("Only one file attachment at a time is supported.");
            }
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
            api.PutFile(keys, files[0].Name, files[0].Content);
        }

        [Obsolete("Delete method is for backward compatibility with SOAP only. Use one of the following REST methods instead: DeleteByID, DeleteByKeys")]
        public void Delete<T>(T entity)
            where T : Entity
        {
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
            if (entity.ID != null)
            {
                api.DeleteById(entity.ID);
            }
            else
            {
                api.DeleteById(Get(entity).ID);
            }
        }

        public string Invoke<T>(EntityAction<T> action)
              where T : Entity
        {
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
            string invokeResult = api.InvokeAction(action);
            if (ProcessStartTime.ContainsKey(invokeResult))
            { }
            else
            {
                ProcessStartTime.Add(invokeResult, DateTime.Now);
            }
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

        public string Invoke<T>(T entity, EntityAction<T> action)
            where T : Entity
        {
            action.Entity = entity;
            return Invoke(action);
        }
        public ProcessResult WaitInvoke<T>(T entity, EntityAction<T> action)
            where T : Entity
        {
            action.Entity = entity;
            return WaitInvoke(action);
        }
        public ProcessResult WaitInvoke<T>(EntityAction<T> action)
        where T : Entity
        {
            InvokeResult invokeResult = Invoke(action);

            while (true)
            {
                ProcessResult processResult = GetProcessStatus(invokeResult);

                System.Threading.Thread.Sleep(100);

                switch (processResult.Status)
                {
                    case ProcessStatus.NotExists:
                    case ProcessStatus.Aborted:
                        throw new SystemException("Process status: " +
                                                  processResult.Status + "; Error: " +
                                                  processResult.Message);
                    case ProcessStatus.Completed:
                    case ProcessStatus.OK:
                        return processResult;
                    case ProcessStatus.InProcess:
                        if (processResult.Seconds > 30)
                            throw new TimeoutException();
                        continue;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        #endregion

        #region Implementation
        Dictionary<string, DateTime> ProcessStartTime;

        protected AuthApi AuthorizationApi;
        protected Configuration CurrentConfiguration;
        protected DateTime? BusinessDate;


        protected IEnumerable<EntityField> GetSearchFields<T, SearchType>(T entity)
            where T : Entity
        {
            Type[] searchTypes = new Type[] { typeof(SearchType) };

            foreach (var field in entity.GetType().GetProperties())
            {
                if (field.GetValue(entity) != null)
                {
                    if (searchTypes.Contains(field.GetValue(entity).GetType()))
                    {
                        yield return new EntityField(field.GetValue(entity).GetType(), (SearchType)field.GetValue(entity), field.Name);
                    }
                }
            }
            foreach (var linkedEntity in GetLinkedEntities(entity))
            {
                if (linkedEntity.Value != null)
                {
                    foreach (var field in linkedEntity.Value.GetType().GetProperties())
                    {
                        if (field.GetValue(linkedEntity.Value) != null)
                        {
                            if (searchTypes.Contains(field.GetValue(linkedEntity.Value).GetType()))
                            {
                                yield return new EntityField(field.GetValue(linkedEntity.Value).GetType(), (SearchType)field.GetValue(linkedEntity.Value), linkedEntity.Name + "/" + field.Name);
                            }
                        }
                    }
                }
            }
        }

        protected IEnumerable<EntityField> GetPossibleKeyFields<T>(T entity)
            where T : Entity
        {
            foreach (var field in entity.GetType().GetProperties())
            {
                if (field.PropertyType == typeof(StringValue))
                {
                    yield return new EntityField(field.PropertyType, ((StringValue)field.GetValue(entity))?.Value, field.Name);
                }
                if (field.PropertyType == typeof(IntValue))
                {
                    yield return new EntityField(field.PropertyType, ((IntValue)field.GetValue(entity))?.Value, field.Name);
                }
                if (field.PropertyType == typeof(LongValue))
                {
                    yield return new EntityField(field.PropertyType, ((LongValue)field.GetValue(entity))?.Value, field.Name);
                }
            }
        }
        protected IEnumerable<DetailEntity> GetDetails<T>(T entity)
                        where T : Entity
        {
            foreach (var field in entity.GetType().GetProperties())
            {
                if (typeof(IEnumerable).IsAssignableFrom(field.PropertyType)
                    && field.Name != "Custom"
                    && field.Name != "Files"
                    && field.PropertyType != typeof(CustomField[])
                    && field.PropertyType != typeof(String)
                    // && ((IEnumerable)field.GetValue(entity)) != null
                    )
                {
                    yield return new DetailEntity(field.PropertyType, ((IEnumerable)field.GetValue(entity)), field.Name);
                }
            }
        }

        protected IEnumerable<LinkedEntity> GetLinkedEntities<T>(T entity)
                                    where T : Entity
        {
            foreach (var field in entity.GetType().GetProperties())
            {
                if (typeof(Entity).IsAssignableFrom(field.PropertyType))
                {
                    yield return new LinkedEntity(field.PropertyType, (Entity)field.GetValue(entity), field.Name);
                }
            }
        }
        protected string ComposeFilterForGetList<T>(T entity) where T : Entity
        {
            string filter = "";
            foreach (var field in GetSearchFields<T, StringSearch>(entity))
            {
                if (field.Value != null)
                {
                    filter += field.Name + " eq " + "'" + ((StringSearch)field.Value).Value.ToString() + "' and ";
                }
            }
            foreach (var field in GetSearchFields<T, IntSearch>(entity))
            {
                if (field.Value != null)
                {
                    filter += field.Name + " eq " + ((IntSearch)field.Value).Value.ToString() + " and ";
                }
            }
            if (!string.IsNullOrEmpty(filter))
                filter = filter.Substring(0, filter.Length - 4);
            return filter;
        }
        protected string ComposeFilter<T>(T entity) where T : Entity
        {
            string filter = "";
            foreach (var field in GetPossibleKeyFields(entity))
            {
                if (field.Value != null)
                {
                    if (field.Type == typeof(StringValue))
                        filter += field.Name + " eq " + "'" + field.Value.ToString() + "' and ";
                    else
                        filter += field.Name + " eq " + field.Value.ToString() + " and ";
                }
            }

            filter = filter.Substring(0, filter.Length - 4);
            return filter;
        }
        protected string ComposeExpands<T>(T entity) where T : Entity
        {
            string expand = "";
            foreach (DetailEntity detailEntity in GetDetails(entity))
            {
                if (entity.ReturnBehavior == ReturnBehavior.All)
                {
                    expand += detailEntity.Name += ",";
                }
                else if (detailEntity.Details != null)
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
            }
            foreach (LinkedEntity linkedEntity in GetLinkedEntities(entity))
            {
                if (entity.ReturnBehavior == ReturnBehavior.All || linkedEntity?.Value?.ReturnBehavior == ReturnBehavior.All || linkedEntity?.Value?.ReturnBehavior == ReturnBehavior.Default)
                {
                    expand += linkedEntity.Name += ",";
                }
            }

            expand = expand.TrimEnd(',');

            return expand;
        }
        protected int GetProcessingSeconds(string invokeResult)
        {
            if (ProcessStartTime.ContainsKey(invokeResult))
            {
                return (int)(DateTime.Now - ProcessStartTime[invokeResult]).TotalSeconds;
            }
            return 0;
        }
        #endregion
    }
}
