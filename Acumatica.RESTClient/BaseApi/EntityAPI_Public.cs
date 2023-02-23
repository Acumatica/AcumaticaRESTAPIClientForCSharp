using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Model;

namespace Acumatica.RESTClient.Api
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public abstract partial class EntityAPI<EntityType> : BaseApi
        where EntityType : Entity
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityAPI"/> class.
        /// </summary>
        /// <returns></returns>
        public EntityAPI(String basePath) : base(basePath)
        { }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityAPI"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EntityAPI(ApiClient configuration) : base(configuration)
        { }
        #endregion

        #region Public Methods
        /// <summary>
        /// Returns relative endpoint path startnig with <c>entity</c> keyword, 
        /// e.g. <c>entity/Default/22.200.001</c>
        /// </summary>
        public abstract string GetEndpointPath();

        /// <summary>
        /// Queries the system with the specified <paramref name="millisecondsInterval"/> 
        /// to get status of a running operation
        /// untill the operation status is Completed.
        /// </summary>
        /// <param name="locationRaw">
        /// Value of the Location header returned 
        /// from <see cref="InvokeAction(EntityAction{EntityType})"/> or
        /// <see cref="InvokeActionAsync(EntityAction{EntityType})"/>
        /// </param>
        /// <param name="millisecondsInterval">
        /// Time that the system waits between querying for the operation status in milliseconds.
        /// Default value is <c>1000</c>.
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// Throws the the exception if the operation finishes with a status code not indicating 
        /// successful completion.
        /// </exception>
        public void WaitActionCompletion(string locationRaw, int millisecondsInterval = 1000)
        {
            while (true)
            {
                var processResult = GetProcessStatus(locationRaw);

                switch (processResult)
                {
                    case 204:
                        return;
                    case 202:
                        Thread.Sleep(millisecondsInterval);
                        continue;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        /// <summary>
        /// Gets the status of an operation started by invoking an action.
        /// </summary>
        /// <param name="locationRaw">
        /// Value of the Location header returned 
        /// from <see cref="InvokeAction(EntityAction{EntityType})"/> or
        /// <see cref="InvokeActionAsync(EntityAction{EntityType})"/>
        /// </param>
        /// <returns>Returns HTTP status code of the running operation.</returns>
        public int GetProcessStatus(string locationRaw)
        {
            return GetProcessStatusWithHttpInfo(locationRaw).StatusCode;
        }

        /// <summary>
        /// Retrieves records that satisfy the specified conditions from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="filter">The conditions that determine which records should be selected from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <param name="skip">The number of records to be skipped from the list of returned records. (optional)</param>
        /// <param name="top">The number of records to be returned from the system. (optional)</param>
        /// <returns>Task of List&lt;Entity&gt;</returns>
        public async Task<List<EntityType>> GetListAsync(
            string select = null, string filter = null, string expand = null, string custom = null, 
            int? skip = null, int? top = null, Dictionary<string, string> customHeaders = null)
        {
            ApiResponse<List<EntityType>> localVarResponse = await GetListAsyncWithHttpInfo(select, filter, expand, custom, skip, top, customHeaders);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Put method that can be used to determine operation Api Call executes.
        /// Supported starting from Acumatica ERP version 2019 R2.
        /// </summary>
        public enum PutMethod
        {
            Insert,
            Update,
            Any
        }

        /// <summary>
        /// Creates a record or updates an existing record if <paramref name="entity"/> can be mathed to an existing record by
        /// <c>id</c> field value or key fields values.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="entity">The record to be passed to the system.</param>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="filter">The conditions that determine which records should be selected from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <param name="method">
        /// Optional. Used to determine whether the system should <see cref="PutMethod.Insert"/> a new record
        /// or <see cref="PutMethod.Update"/> an existing record. 
        /// If not specifified the default behavior is <see cref="PutMethod.Any">Any/Upsert</see>. 
        /// </param>
        /// <param name="businessDate">
        /// Optional. Specifies the new business date. If you omit this header, 
        /// the current date is used as the business date.
        /// </param>
        /// <param name="branch">
        /// Optional. Specifies the new current branch. 
        /// The branch should be specified as a branch name. 
        /// If you omit this header, the branch that you specified when signing in is used as the current branch.
        /// </param>
        /// <returns>Object of <typeparamref name="EntityType"/> type.</returns>
        public EntityType PutEntity(EntityType entity, 
            string select = null, string filter = null, string expand = null, string custom = null, 
            PutMethod method = PutMethod.Any, DateTime? businessDate = null, string branch = null)
        {
            ApiResponse<EntityType> localVarResponse = PutEntityWithHttpInfo(entity, 
                select, filter, expand, custom, 
                method, businessDate, branch);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a record or updates an existing record if <paramref name="entity"/> can be mathed to an existing record by
        /// <c>id</c> field value or key fields values. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="entity">The record to be passed to the system.</param>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="filter">The conditions that determine which records should be selected from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <param name="method">
        /// Optional. Used to determine whether the system should <see cref="PutMethod.Insert"/> a new record
        /// or <see cref="PutMethod.Update"/> an existing record. 
        /// If not specifified the default behavior is <see cref="PutMethod.Any">Any/Upsert</see>. 
        /// </param>
        /// <param name="businessDate">
        /// Optional. Specifies the new business date. If you omit this header, 
        /// the current date is used as the business date.
        /// </param>
        /// <param name="branch">
        /// Optional. Specifies the new current branch. 
        /// The branch should be specified as a branch name. 
        /// If you omit this header, the branch that you specified when signing in is used as the current branch.
        /// </param>
        /// <returns><see cref="Task"/> of <typeparamref name="EntityType"/></returns>
        public async Task<EntityType> PutEntityAsync(EntityType entity, 
            string select = null, string filter = null, string expand = null, string custom = null, 
            PutMethod method = PutMethod.Any, DateTime? businessDate = null, string branch=null)
        {
            ApiResponse<EntityType> localVarResponse = await PutEntityAsyncWithHttpInfo(entity, 
                select, filter, expand, custom, 
                method, businessDate, branch);
            return localVarResponse.Data;
        }

        public void PutFile(string id, string filename, byte[] content)
        {
            PutFileWithHttpInfo(new List<string>() { id }, filename, content);
        }
        public async Task PutFileAsync(string id, string filename, byte[] content)
        {
            await PutFileAsyncWithHttpInfo(new List<string>() { id }, filename, content);
        }
        /// <summary>
        /// Attaches a file to a record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <param name="filename">The name of the file that you are going to attach with the extension.</param>
        /// <returns></returns>
        public void PutFile(IEnumerable<string> ids, string filename, byte[] content)
        {
            PutFileWithHttpInfo(ids, filename, content);
        }
        /// <summary>
        /// Attaches a file to a record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <param name="filename">The name of the file that you are going to attach with the extension.</param>
        /// <returns>Task of void</returns>
        public async Task PutFileAsync(IEnumerable<string> ids, string filename, byte[] content)
        {
            await PutFileAsyncWithHttpInfo(ids, filename, content);
        }

        /// <summary>
        /// Performs an action in the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The action that should be executed.</param>
        /// <returns>
        /// Returns value of Location header. The value can be used to 
        /// query the status of running operation using <see cref="GetProcessStatus(string)"/>
        /// </returns>
        public string InvokeAction(EntityAction<EntityType> action, DateTime? businessDate = null, string branch = null)
        {
            var result = InvokeActionWithHttpInfo(action, businessDate, branch);
            return result.Headers["Location"];
        }

        /// <summary>
        /// Performs an action in the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The record to which the action should be applied and the parameters of the action.</param>
        /// <returns>Task of void</returns>
        public async Task<string> InvokeActionAsync(EntityAction<EntityType> action, DateTime? businessDate = null, string branch = null)
        {
            var result = await InvokeActionAsyncWithHttpInfo(action, businessDate, branch);
            return result.Headers["Location"];
        }

        /// <summary>
        /// Retrieves a record by the values of its key fields from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="filter">The conditions that determine which records should be selected from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <returns>Task of Entity</returns>
        public async Task<EntityType> GetByKeysAsync(IEnumerable<string> ids, string select = null, string filter = null, string expand = null, string custom = null)
        {
            ApiResponse<EntityType> localVarResponse = await GetByKeysAsyncWithHttpInfo(ids, select, filter, expand, custom);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves records that satisfy the specified conditions from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="filter">The conditions that determine which records should be selected from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <param name="skip">The number of records to be skipped from the list of returned records. (optional)</param>
        /// <param name="top">The number of records to be returned from the system. (optional)</param>
        /// <returns>List&lt;Entity&gt;</returns>
        public List<EntityType> GetList(
            string select = null, string filter = null, string expand = null, string custom = null, 
            int? skip = null, int? top = null, Dictionary<string, string> customHeaders = null)
        {
            ApiResponse<List<EntityType>> localVarResponse = GetListWithHttpInfo(select, filter, expand, custom, skip, top, customHeaders);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a record by the values of its key fields from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="filter">The conditions that determine which records should be selected from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <returns>Entity</returns>
        public EntityType GetByKeys(IEnumerable<string> ids, string select = null, string filter = null, string expand = null, string custom = null)
        {
            ApiResponse<EntityType> localVarResponse = GetByKeysWithHttpInfo(ids, select, filter, expand, custom);
            return localVarResponse.Data;
        }


        /// <summary>
        /// Retrieves a record by the value of the session entity ID from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="filter">The conditions that determine which records should be selected from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <returns>Task of Entity</returns>
        public async Task<EntityType> GetByIdAsync(Guid? id, string select = null, string filter = null, string expand = null, string custom = null)
        {
            ApiResponse<EntityType> localVarResponse = await GetByIdAsyncWithHttpInfo(id, select, filter, expand, custom);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the schema of custom fields of the entity from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Entity</returns>
        public async Task<EntityType> GetAdHocSchemaAsync()
        {
            ApiResponse<EntityType> localVarResponse = await GetAdHocSchemaAsyncWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a record by the value of the session entity ID from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="filter">The conditions that determine which records should be selected from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <returns>Entity</returns>
        public EntityType GetById(Guid? id, string select = null, string filter = null, string expand = null, string custom = null)
        {
            ApiResponse<EntityType> localVarResponse = GetByIdWithHttpInfo(id, select, filter, expand, custom);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Deletes the record by the values of its key fields. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <returns></returns>
        public void DeleteByKeys(IEnumerable<string> ids)
        {
            DeleteByKeysWithHttpInfo(ids);
        }

        /// <summary>
        /// Deletes the record by the values of its key fields. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteByKeysAsync(IEnumerable<string> ids)
        {
            await DeleteByKeysAsyncWithHttpInfo(ids);
        }

        /// <summary>
        /// Retrieves the schema of custom fields of the entity from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Entity</returns>
        public EntityType GetAdHocSchema()
        {
            ApiResponse<EntityType> localVarResponse = GetAdHocSchemaWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Deletes the record by its session identifier. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <returns></returns>
        public void DeleteById(Guid? id)
        {
            DeleteByIdWithHttpInfo(id);
        }

        /// <summary>
        /// Deletes the record by its session identifier. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteByIdAsync(Guid? id)
        {
            await DeleteByIdAsyncWithHttpInfo(id);
        }
        #endregion
    }
}
