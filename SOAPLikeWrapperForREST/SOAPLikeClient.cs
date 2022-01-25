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
        public SOAPLikeClient(string siteURL, string endpointPath, int timeout = 10000)
        {
            AuthorizationApi = new AuthApi(siteURL);
            ProcessStartTime = new Dictionary<string, DateTime>();
            CurrentConfiguration = new Configuration(siteURL + endpointPath, timeout);
        }
        #endregion

        #region Public Methods
        public void SetBusinessDate(DateTime now)
        {
            BusinessDate = now;
        }

        public void Login(string username, string password, string tenant = null, string branch = null, string locale = null)
        {
            AuthorizationApi.LogIn(new Credentials(username, password, tenant, branch, locale));

             CurrentConfiguration.ApiClient.RestClient.CookieContainer.Add(
                 AuthorizationApi.Configuration.ApiClient.RestClient.CookieContainer.GetCookies(new Uri(AuthorizationApi.Configuration.BasePath)));
        }
        public void Logout()
        {
            AuthorizationApi.TryLogout();
            BusinessDate = null;
        }

        public T GetById<T>(Guid? id, string select = null, string filter = null, string expand = null, string custom = null)
            where T : Entity
        {
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
            return api.GetById(id, select, filter, expand, custom);
        }
        public T GetByKeys<T>(IEnumerable<string> ids, string select = null, string filter = null, string expand = null, string custom = null)
            where T : Entity
        {
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
            return api.GetByKeys(ids, select, filter, expand, custom);
        }

        [Obsolete("Get method is for backward compatibility with SOAP only. Use one of the following REST methods instead: GetList, GetByKeys, GetByID")]
        public T Get<T>(T entity)
            where T : Entity
        {
            string expand = ComposeExpands(entity);
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
            if (entity.ID.HasValue)
            {
                T resultByID = api.GetById(entity.ID, expand: expand);
                resultByID.ReturnBehavior = entity.ReturnBehavior;
                return resultByID;
            }
            string filter = ComposeFilter(entity);
            var list = api.GetList(filter: filter);
            if (list.Count > 1)
            {
                throw new Exception("More than one entity satisfies the condition.");
            }
            if (list.Count == 0)
            {
                throw new Exception("No entities satisfy the condition.");
            }
            T result = api.GetById(list[0].ID, expand: expand);
            result.ReturnBehavior = entity.ReturnBehavior;
            return result;
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
            var result = api.PutEntity(entity, expand: ComposeExpands(entity), businessDate: BusinessDate);
            result.ReturnBehavior = entity.ReturnBehavior;
            return result;
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
        [Obsolete("GetFiles method is for backward compatibility with SOAP only. Use one of the following REST methods instead: FileApi.GetFile")]
        public File[] GetFiles<T>(T entity)
            where T : Entity
        {
            FileApi api = new FileApi(CurrentConfiguration);

            return new File[] { };
        }

        [Obsolete("Delete method is for backward compatibility with SOAP only. Use one of the following REST methods instead: DeleteByID, DeleteByKeys")]
        public void Delete<T>(T entity)
            where T : Entity
        {
            if (entity.ID != null) DeleteById<T>(entity.ID);
            else DeleteById<T>(Get(entity).ID);
        }

        /// <summary>
        /// Deletes the record by its session identifier. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <returns></returns>
        public void DeleteById<T>(Guid? id) where T : Entity
        {
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
            api.DeleteById(id);
        }

        /// <summary>
        /// Deletes the record by its keys. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <returns></returns>
        public void DeleteByKeys<T>(IEnumerable<string> ids)
            where T : Entity
        {
            SOAPLikeEntityAPI<T> api = new SOAPLikeEntityAPI<T>(CurrentConfiguration);
            api.DeleteByKeys(ids);
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
        public ProcessResult WaitInvoke<T>(EntityAction<T> action, bool throwOnFail = true)
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
                        if (throwOnFail)
                            throw new SystemException("Process status: " +
                                                      processResult.Status + "; Error: " +
                                                      processResult.Message);
                        return processResult;
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

        protected IEnumerable<string> GetSubEntitiesWithReturnBehavior(Type entityType, Entity entity, bool returnAll = false)
        {
            List<string> result = new List<string>();
            foreach (var field in entityType.GetProperties())
            {
                if (typeof(IEnumerable).IsAssignableFrom(field.PropertyType)
                    && field.Name != "Custom"
                    && field.Name != "Files"
                    && field.PropertyType != typeof(CustomField[])
                    && field.PropertyType != typeof(String)
                    )
                {
                    if (returnAll || (entity != null && entity.ReturnBehavior == ReturnBehavior.All))
                    {
                        foreach (var subentity in GetSubEntitiesWithReturnBehavior(field.PropertyType.GetElementType(), null, true))
                        {
                            result.Add(field.Name + "/" + subentity);
                        }
                        result.Add(field.Name);
                    }
                    else
                    {
                        Entity item = null;
                        if (entity != null && field.GetValue(entity) != null)
                        {
                            foreach (var detail in (IEnumerable)field.GetValue(entity))
                            {
                                if (detail != null)
                                {
                                    item = (Entity)detail;
                                    if (item != null && item.ReturnBehavior == ReturnBehavior.All)
                                    {
                                        foreach (var subentity in GetSubEntitiesWithReturnBehavior(field.PropertyType.GetElementType(), null, true))
                                        {
                                            result.Add(field.Name + "/" + subentity);
                                        }
                                        result.Add(field.Name);
                                    }
                                    else if (item != null && item.ReturnBehavior == ReturnBehavior.Default)
                                    {
                                        foreach (var subentity in GetSubEntitiesWithReturnBehavior(field.PropertyType.GetElementType(), item))
                                        {
                                            result.Add(field.Name + "/" + subentity);
                                        }
                                        result.Add(field.Name);
                                    }
                                }
                            }
                        }
                    }
                }
                else if (typeof(Entity).IsAssignableFrom(field.PropertyType))
                {
                    Entity item = null;
                    if (entity != null)
                    {
                        item = (Entity)field.GetValue(entity);
                    }
                    if (returnAll || (entity != null && entity.ReturnBehavior == ReturnBehavior.All) || (item != null && item.ReturnBehavior == ReturnBehavior.All))
                    {
                        foreach (var subentity in GetSubEntitiesWithReturnBehavior(field.PropertyType, null, true))
                        {
                            result.Add(field.Name + "/" + subentity);
                        }
                        result.Add(field.Name);
                    }
                    else if (item != null && item.ReturnBehavior == ReturnBehavior.Default)
                    {
                        foreach (var subentity in GetSubEntitiesWithReturnBehavior(field.PropertyType, item))
                        {
                            result.Add(field.Name + "/" + subentity);
                        }
                        result.Add(field.Name);
                    }
                }
            }

            return result.Distinct();
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
            List<string> filters = new List<string>();

            filters.AddRange(GetSearchFields<T, StringSearch>(entity)
                .Select(GetFilterByStringCond));

            filters.AddRange(GetSearchFields<T, IntSearch>(entity)
                .Select(field => field.Name + " eq " + ((IntSearch)field.Value).Value.ToString()));

            filters.AddRange(GetSearchFields<T, BooleanSearch>(entity)
                .Select(field => field.Name + " eq " + ((BooleanSearch)field.Value).Value.ToString().ToLower()));

            filters.AddRange(GetSearchFields<T, DateTimeSearch>(entity)
                .Select(GetFilterByDateTimeCond));

            return string.Join(" and ", filters);
        }

        private string GetFilterByStringCond(EntityField field)
        {
            StringSearch search = (StringSearch)field.Value;

            switch (search.Condition)
            {
                case StringCondition.IsNotNull: return field.Name + " ne null";
                case StringCondition.Contains: return "substringof('" + search.Value.ToString() + "', " + field.Name + ")";
                case StringCondition.StartsWith: return "startswith(" + field.Name + ", '" + search.Value.ToString() + "')";
                case StringCondition.NotEqual: return field.Name + " ne '" + search.Value.ToString() + "'";
                case StringCondition.DoesNotContain: return "substringof('" + search.Value.ToString() + "', " + field.Name + ") eq false";
                case StringCondition.Equal: return field.Name + " eq '" + search.Value.ToString() + "'";
                default: throw new NotImplementedException($"Condition {search.Condition} is not implemented");
            }
        }

        private static string GetFilterByDateTimeCond(EntityField field)
        {
            DateTimeSearch search = (DateTimeSearch)field.Value;

            switch (search.Condition)
            {
                case DateTimeCondition.Equal: return field.Name + " eq datetimeoffset'" + search.Value?.ToString("o") + "'";
                case DateTimeCondition.IsGreaterThan: return field.Name + " gt datetimeoffset'" + search.Value?.ToString("o") + "'";
                default: throw new NotImplementedException($"Condition {search.Condition} is not implemented");
            }
        }

        protected string ComposeFilter<T>(T entity) where T : Entity
        {
            return string.Join(" and ", GetPossibleKeyFields(entity)
                .Where(f => f.Value != null)
                .Select(field =>
                {
                    if (field.Type == typeof(StringValue))
                        return field.Name + " eq " + "'" + field.Value.ToString() + "'";
                    else
                        return field.Name + " eq " + field.Value.ToString();
                }));
        }

        protected string ComposeExpands<T>(T entity) where T : Entity
        {
            return string.Join(",", GetSubEntitiesWithReturnBehavior(entity.GetType(), entity));
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