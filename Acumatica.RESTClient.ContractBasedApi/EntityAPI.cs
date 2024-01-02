using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi.Model;

using static Acumatica.RESTClient.ContractBasedApi.ApiClientExtensions;

namespace Acumatica.RESTClient.ContractBasedApi
{
    [Obsolete("For backward compatibility")]
    public abstract class EntityAPI<EntityType>
        where EntityType : Entity, ITopLevelEntity, new()
    {
        protected readonly ApiClient Client;
        public EntityAPI(ApiClient client) 
        {
            Client = client;
        }

        public abstract string GetEndpointPath();

        public void WaitActionCompletion(string locationRaw, int millisecondsInterval = 1000)
            => ApiClientExtensions.WaitActionCompletion(Client, locationRaw, millisecondsInterval);

        public int GetProcessStatus(string locationRaw)
            => ((int)ApiClientExtensions.GetProcessStatus(Client, locationRaw));

        public async Task<List<EntityType>> GetListAsync(string? select = null, string? filter = null, string? expand = null, string? custom = null, int? skip = null, int? top = null, Dictionary<string, string>? customHeaders = null)
            => await ApiClientExtensions.GetListAsync<EntityType>(Client, GetEndpointPath(), select, filter, expand, custom, skip, top, customHeaders);

        public EntityType PutEntity(EntityType entity, string? select = null, string? filter = null, string? expand = null, string? custom = null, PutMethod method = PutMethod.Any, DateTime? businessDate = null, string? branch = null)
            => ApiClientExtensions.Put(Client, entity, GetEndpointPath(), select, filter, expand, custom, method, businessDate, branch);

        public async Task<EntityType> PutEntityAsync(EntityType entity, string? select = null, string? filter = null, string? expand = null, string? custom = null, PutMethod method = PutMethod.Any, DateTime? businessDate = null, string? branch = null)
            => await ApiClientExtensions.PutAsync(Client, entity, GetEndpointPath(), select, filter, expand, custom, method, businessDate, branch);


        public void PutFile(string id, string filename, byte[] content)
            => ApiClientExtensions.PutFile<EntityType>(Client, id, filename, content, GetEndpointPath());

        public async Task PutFileAsync(string id, string filename, byte[] content)
            => await ApiClientExtensions.PutFileAsync<EntityType>(Client, id, filename, content, GetEndpointPath());


        public void PutFile(IEnumerable<string> ids, string filename, byte[] content)
            => ApiClientExtensions.PutFile<EntityType>(Client, ids, filename, content, GetEndpointPath());

        public async Task PutFileAsync(IEnumerable<string> ids, string filename, byte[] content)
            => await ApiClientExtensions.PutFileAsync<EntityType>(Client, ids, filename, content, GetEndpointPath());

        public string InvokeAction(EntityAction<EntityType> action, DateTime? businessDate = null, string? branch = null)
            => ApiClientExtensions.InvokeAction(Client, action, GetEndpointPath(), businessDate, branch);

        public async Task<string> InvokeActionAsync(EntityAction<EntityType> action, DateTime? businessDate = null, string? branch = null)
            => await ApiClientExtensions.InvokeActionAsync(Client, action, GetEndpointPath(), businessDate, branch);

        public async Task<EntityType> GetByKeysAsync(IEnumerable<string> ids, string? select = null, string? expand = null, string? custom = null)
            => await ApiClientExtensions.GetByKeysAsync<EntityType>(Client, ids, GetEndpointPath(), select, expand, custom);

        public List<EntityType> GetList(string? select = null, string? filter = null, string? expand = null, string? custom = null, int? skip = null, int? top = null, Dictionary<string, string>? customHeaders = null)
            => ApiClientExtensions.GetList<EntityType>(Client, GetEndpointPath(), select, filter, expand, custom, skip, top, customHeaders);

        public EntityType GetByKeys(IEnumerable<string> ids, string? select = null, string? expand = null, string? custom = null)
            => ApiClientExtensions.GetByKeys<EntityType>(Client, ids, GetEndpointPath(), select, expand, custom);

        public async Task<EntityType> GetByIdAsync(Guid? id, string? select = null, string? expand = null, string? custom = null)
            => await ApiClientExtensions.GetByIdAsync<EntityType>(Client, id, GetEndpointPath(), select, expand, custom);

        public async Task<EntityType> GetAdHocSchemaAsync()
            => await ApiClientExtensions.GetAdHocSchemaAsync<EntityType>(Client, GetEndpointPath());

        public EntityType GetById(Guid? id, string? select = null, string? filter = null, string? expand = null, string? custom = null)
            => ApiClientExtensions.GetById<EntityType>(Client, id, GetEndpointPath(), select,  expand, custom);


        public void DeleteByKeys(IEnumerable<string> ids)
            => ApiClientExtensions.DeleteByKeys<EntityType>(Client, ids, GetEndpointPath());

        public async Task DeleteByKeysAsync(IEnumerable<string> ids)
            => await ApiClientExtensions.DeleteByKeysAsync<EntityType>(Client, ids, GetEndpointPath());


        public EntityType GetAdHocSchema()
            => ApiClientExtensions.GetAdHocSchema<EntityType>(Client, GetEndpointPath());


        public void DeleteById(Guid? id)
            => ApiClientExtensions.DeleteById<EntityType>(Client, id, GetEndpointPath());

        public async Task DeleteByIdAsync(Guid? id)
            => await ApiClientExtensions.DeleteByIdAsync<EntityType>(Client, id, GetEndpointPath());
    }
}
