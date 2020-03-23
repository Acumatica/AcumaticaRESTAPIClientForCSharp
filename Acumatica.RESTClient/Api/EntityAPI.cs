using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Acumatica.RESTClient.Client;
using System.Threading;
using Acumatica.RESTClient.Model;

namespace Acumatica.RESTClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public abstract class EntityAPI<EntityType> : BaseApi
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
        public EntityAPI(Configuration configuration) : base(configuration)
        { }
		#endregion

		#region Public Methods
		public void WaitActionCompletion(string invokeResult)
        {
            while (true)
            {
                var processResult = GetProcessStatus(invokeResult);

                switch (processResult)
                {
                    case 204:
                        return;
                    case 202:
                        Thread.Sleep(1000);
                        continue;
                    default:
                        throw new InvalidOperationException();
                }
            }
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
        public async System.Threading.Tasks.Task<List<EntityType>> GetListAsync(string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {
            ApiResponse<List<EntityType>> localVarResponse = await GetListAsyncWithHttpInfo(select, filter, expand, custom, skip, top);
            return localVarResponse.Data;

        }

        protected const string PutMethodInsertHeader = "If-None-Match";
        protected const string PutMethodUpdateHeader = "If-Match";
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
        /// <returns>EntityType</returns>
        public EntityType PutEntity(EntityType entity, string select = null, string filter = null, string expand = null, string custom = null, PutMethod method = PutMethod.Any, DateTime? businessDate = null)
        {
            ApiResponse<EntityType> localVarResponse = PutEntityWithHttpInfo(entity, select, filter, expand, custom, method, businessDate);
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
        /// <returns>Task of Entity</returns>
        public async System.Threading.Tasks.Task<EntityType> PutEntityAsync(EntityType entity, string select = null, string filter = null, string expand = null, string custom = null, PutMethod method = PutMethod.Any)
        {
            ApiResponse<EntityType> localVarResponse = await PutEntityAsyncWithHttpInfo(entity, select, filter, expand, custom, method);
            return localVarResponse.Data;
        }

        public void PutFile(string id, string filename, byte[] content)
        {
            PutFileWithHttpInfo(new List<string>() { id }, filename, content);
        }
        public async System.Threading.Tasks.Task PutFileAsync(string id, string filename, byte[] content)
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
        public void PutFile(List<string> ids, string filename, byte[] content)
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
        public async System.Threading.Tasks.Task PutFileAsync(List<string> ids, string filename, byte[] content)
        {
            await PutFileAsyncWithHttpInfo(ids, filename, content);

        }

        /// <summary>
        /// Performs an action in the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The action that should be executed.</param>
        /// <returns></returns>
        public string InvokeAction(EntityAction<EntityType> action)
        {
            var result = InvokeActionWithHttpInfo(action);
            return result.Headers["Location"];
        }

        /// <summary>
        /// Performs an action in the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The record to which the action should be applied and the parameters of the action.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task InvokeActionAsync(EntityAction<EntityType> action)
        {
            await InvokeActionAsyncWithHttpInfo(action);
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
        public async System.Threading.Tasks.Task<EntityType> GetByKeysAsync(List<string> ids, string select = null, string filter = null, string expand = null, string custom = null)
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
        public List<EntityType> GetList(string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {
            ApiResponse<List<EntityType>> localVarResponse = GetListWithHttpInfo(select, filter, expand, custom, skip, top);
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
        public EntityType GetByKeys(List<string> ids, string select = null, string filter = null, string expand = null, string custom = null)
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
        public async System.Threading.Tasks.Task<EntityType> GetByIdAsync(Guid? id, string select = null, string filter = null, string expand = null, string custom = null)
        {
            ApiResponse<EntityType> localVarResponse = await GetByIdAsyncWithHttpInfo(id, select, filter, expand, custom);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the schema of custom fields of the entity from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Entity</returns>
        public async System.Threading.Tasks.Task<EntityType> GetAdHocSchemaAsync()
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
        public void DeleteByKeys(List<string> ids)
        {
            DeleteByKeysWithHttpInfo(ids);
        }

        /// <summary>
        /// Deletes the record by the values of its key fields. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteByKeysAsync(List<string> ids)
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

        #region Implementation
        private struct Location
        {
            public string Site;
            public string Entity;
            public string EndpointName;
            public string EndpointVersion;
            public string EntityName;
            public string ActionName;
            public string Status;
            public string ID;
        }
        private Location ParseLocation(string location)
        {
            var result = new Location();

            var parts = location.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            result.Site = parts[0];
            result.Entity = parts[1];
            result.EndpointName = parts[2];
            result.EndpointVersion = parts[3];
            result.EntityName = parts[4];
            if (parts.Length == 6)
            {
                result.ID = parts[5];
                return result;
            }

            result.ActionName = parts[5];
            result.Status = parts[6];
            result.ID = parts[7];
            return result;
        }

        protected virtual string GetEntityName()
        {
            return typeof(EntityType).Name;
        }

        public int GetProcessStatus(string invokeResult)
        {
            if (invokeResult == null)
                ThrowMissingParameter("GetProcessStatus", nameof(invokeResult));

            var parsedLocation = ParseLocation(invokeResult);
            var localVarPath = "/" + parsedLocation.EntityName + "/" + parsedLocation.ActionName + "/" + parsedLocation.Status + "/" + parsedLocation.ID;
            
            var localVarFileParams = new Dictionary<String, FileParameter>();

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), localVarFileParams,
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "GetProcessStatus");

            return (int)localVarResponse.StatusCode;
        }

        /// <summary>
        /// Attaches a file to a record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <param name="filename">The name of the file that you are going to attach with the extension.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        protected ApiResponse<Object> PutFileWithHttpInfo(List<string> ids, string filename, byte[] content)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                ThrowMissingParameter("PutFile", nameof(ids));
            // verify the required parameter 'filename' is set
            if (filename == null)
                ThrowMissingParameter("PutFile", nameof(filename));

            var localVarPath = "/" + GetEntityName() + "/{ids}/files/{filename}";

            var fileParams = ComposeEmptyFileParams();
            fileParams.Add(filename, FileParameter.Create(filename, content, filename));
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, ComposeEmptyQueryParams(), content, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(),
                fileParams,
                ComposeIDsPathParams(ids, filename), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "PutFile");

            return GetResponseHeaders(localVarResponse);
        }

        /// <summary>
        /// Attaches a file to a record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <param name="filename">The name of the file that you are going to attach with the extension.</param>
        /// <returns>Task of ApiResponse</returns>
        protected async System.Threading.Tasks.Task<ApiResponse<Object>> PutFileAsyncWithHttpInfo(List<string> ids, string filename, byte[] content)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                ThrowMissingParameter("PutFile", nameof(ids));
            // verify the required parameter 'filename' is set
            if (filename == null)
                ThrowMissingParameter("PutFile", nameof(filename));

            var localVarPath = "/" + GetEntityName() + "/{ids}/files/{filename}";

            var fileParams = ComposeEmptyFileParams();
            fileParams.Add(filename, FileParameter.Create(filename, content, filename));

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, ComposeEmptyQueryParams(), content, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), fileParams,
                ComposeIDsPathParams(ids, filename), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "PutFile");

            return GetResponseHeaders(localVarResponse);
        }

        /// <summary>
        /// Performs an action in the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The record to which the action should be applied and the parameters of the action.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        protected ApiResponse<Object> InvokeActionWithHttpInfo(EntityAction<EntityType> action)
        {
            // verify the required parameter 'action' is set
            if (action == null)
                ThrowMissingParameter("InvokeAction", nameof(action));

            var localVarPath = "/" + GetEntityName() + "/" + action.GetType().Name;            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, ComposeEmptyQueryParams(), ComposeBody(action), ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.Json));

            VerifyResponse(localVarResponse, "InvokeAction");

            return GetResponseHeaders(localVarResponse);
        }

        /// <summary>
        /// Performs an action in the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The record to which the action should be applied and the parameters of the action.</param>
        /// <returns>Task of ApiResponse</returns>
        protected async System.Threading.Tasks.Task<ApiResponse<Object>> InvokeActionAsyncWithHttpInfo(EntityAction<EntityType> action)
        {
            // verify the required parameter 'action' is set
            if (action == null)
                ThrowMissingParameter("InvokeAction", nameof(action));

            var localVarPath = "/" + GetEntityName() + "/" + action.GetType().Name;

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, ComposeEmptyQueryParams(), ComposeBody(action), ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.Json));

            VerifyResponse(localVarResponse, "InvokeAction");

            return GetResponseHeaders(localVarResponse);
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
        /// <returns>ApiResponse of Entity</returns>
        protected ApiResponse<EntityType> PutEntityWithHttpInfo(EntityType entity, string select = null, string filter = null, string expand = null, string custom = null, PutMethod method = PutMethod.Any, DateTime? businessDate = null)
        {
            if (entity == null)
                ThrowMissingParameter("PutEntity", nameof(entity));

            var localVarPath = "/" + GetEntityName();
            var headers = ComposeAcceptHeaders(HeaderContentType.Json);
            if (method == PutMethod.Insert)
            {
                headers.Add(PutMethodInsertHeader, "*");
            }
            else if (method == PutMethod.Update)
            {
                headers.Add(PutMethodUpdateHeader, "*");
            }
            if (businessDate != null)
            {
                headers.Add("PX-CbApiBusinessDate", businessDate.ToString());
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, ComposeQueryParams(select, filter, expand, custom), ComposeBody(entity), headers, ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.Json));

            VerifyResponse(localVarResponse, "PutEntity");

            return DeserializeResponse<EntityType>(localVarResponse);
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
        /// <returns>Task of ApiResponse (Entity)</returns>
        protected async System.Threading.Tasks.Task<ApiResponse<EntityType>> PutEntityAsyncWithHttpInfo(EntityType entity, string select = null, string filter = null, string expand = null, string custom = null, PutMethod method = PutMethod.Any)
        {
            // verify the required parameter 'entity' is set
            if (entity == null)
                ThrowMissingParameter("PutEntity", nameof(entity));

            var localVarPath = "/" + GetEntityName();
            var headers = ComposeAcceptHeaders(HeaderContentType.Json);
            if (method == PutMethod.Insert)
            {
                headers.Add(PutMethodInsertHeader, "*");
            }
            else if (method == PutMethod.Update)
            {
                headers.Add(PutMethodUpdateHeader, "*");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, ComposeQueryParams(select, filter, expand, custom), ComposeBody(entity), headers, ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.Json));

            VerifyResponse(localVarResponse, "PutEntity");

            return DeserializeResponse<EntityType>(localVarResponse);
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
        protected List<KeyValuePair<string, string>> ComposeQueryParams(string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {
            var queryParameters = ComposeEmptyQueryParams();
            if (!String.IsNullOrEmpty(select)) queryParameters.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "$select", select)); // query parameter
            if (!String.IsNullOrEmpty(filter)) queryParameters.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "$filter", filter)); // query parameter
            if (!String.IsNullOrEmpty(expand)) queryParameters.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "$expand", expand)); // query parameter
            if (!String.IsNullOrEmpty(custom)) queryParameters.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "$custom", custom)); // query parameter
            if (skip != null) queryParameters.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "$skip", skip)); // query parameter
            if (top != null) queryParameters.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "$top", top)); // query parameter

            return queryParameters;
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
        /// <returns>Task of ApiResponse (Entity)</returns>
        protected async System.Threading.Tasks.Task<ApiResponse<EntityType>> GetByKeysAsyncWithHttpInfo(List<string> ids, string select = null, string filter = null, string expand = null, string custom = null)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                ThrowMissingParameter("GetByKeys", nameof(ids));

            var localVarPath = "/" + GetEntityName() + "/{ids}";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, ComposeQueryParams(select, filter, expand, custom), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeIDsPathParams(ids), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "GetByKeys");

            return DeserializeResponse<EntityType>(localVarResponse);
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
        /// <returns>ApiResponse of Entity</returns>
        protected ApiResponse<EntityType> GetByKeysWithHttpInfo(List<string> ids, string select = null, string filter = null, string expand = null, string custom = null)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                ThrowMissingParameter("GetByKeys", nameof(ids));

            var localVarPath = "/" + GetEntityName() + "/{ids}";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, ComposeQueryParams(select, filter, expand, custom), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeIDsPathParams(ids), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "GetByKeys");

            return DeserializeResponse<EntityType>(localVarResponse);
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
        /// <returns>Task of ApiResponse (List&lt;Entity&gt;)</returns>
        protected async System.Threading.Tasks.Task<ApiResponse<List<EntityType>>> GetListAsyncWithHttpInfo(string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {
            var localVarPath = "/" + GetEntityName();

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, ComposeQueryParams(select, filter, expand, custom), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "GetList");

            return DeserializeResponse<List<EntityType>>(localVarResponse);
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
        /// <returns>ApiResponse of List&lt;Entity&gt;</returns>
        protected ApiResponse<List<EntityType>> GetListWithHttpInfo(string select = null, string filter = null, string expand = null, string custom = null, int? skip = null, int? top = null)
        {
            var localVarPath = "/" + GetEntityName();

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, ComposeQueryParams(select, filter, expand, custom, skip, top), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "GetList");

            return DeserializeResponse<List<EntityType>>(localVarResponse);
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
        /// <returns>Task of ApiResponse (Entity)</returns>
        protected async System.Threading.Tasks.Task<ApiResponse<EntityType>> GetByIdAsyncWithHttpInfo(Guid? id, string select = null, string filter = null, string expand = null, string custom = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                ThrowMissingParameter("GetById", nameof(id));

            var localVarPath = "/" + GetEntityName() + "/{id}";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, ComposeQueryParams(select, filter, expand, custom), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeIDPathParams(id), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "GetById");

            return DeserializeResponse<EntityType>(localVarResponse);
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
        /// <returns>ApiResponse of Entity</returns>
        protected ApiResponse<EntityType> GetByIdWithHttpInfo(Guid? id, string select = null, string filter = null, string expand = null, string custom = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                ThrowMissingParameter("GetById", nameof(id));

            var localVarPath = "/" + GetEntityName() + "/{id}";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, ComposeQueryParams(select, filter, expand, custom), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeIDPathParams(id), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "GetById");

            return DeserializeResponse<EntityType>(localVarResponse);
        }

        /// <summary>
        /// Retrieves the schema of custom fields of the entity from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Entity)</returns>
        protected async System.Threading.Tasks.Task<ApiResponse<EntityType>> GetAdHocSchemaAsyncWithHttpInfo()
        {
            var localVarPath = "/" + GetEntityName() + "/$adHocSchema";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "GetAdHocSchema");

            return DeserializeResponse<EntityType>(localVarResponse);
        }

        /// <summary>
        /// Retrieves the schema of custom fields of the entity from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Entity</returns>
        protected ApiResponse<EntityType> GetAdHocSchemaWithHttpInfo()
        {

            var localVarPath = "/" + GetEntityName() + "/$adHocSchema";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "GetAdHocSchema");

            return DeserializeResponse<EntityType>(localVarResponse);
        }

        /// <summary>
        /// Deletes the record by the values of its key fields. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <returns>Task of ApiResponse</returns>
        protected async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteByKeysAsyncWithHttpInfo(List<string> ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                ThrowMissingParameter("DeleteByKeys", nameof(ids));

            var localVarPath = "/" + GetEntityName() + "/{ids}";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Any), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeIDsPathParams(ids), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "DeleteByKeys");

            return GetResponseHeaders(localVarResponse);
        }

        /// <summary>
        /// Deletes the record by the values of its key fields. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        protected ApiResponse<Object> DeleteByKeysWithHttpInfo(List<string> ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                ThrowMissingParameter("DeleteByKeys", nameof(ids));

            var localVarPath = "/" + GetEntityName() + "/{ids}";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Any), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeIDsPathParams(ids), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "DeleteByKeys");

            return GetResponseHeaders(localVarResponse);
        }

        /// <summary>
        /// Deletes the record by its session identifier. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <returns>Task of ApiResponse</returns>
        protected async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteByIdAsyncWithHttpInfo(Guid? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                ThrowMissingParameter("DeleteById", nameof(id));

            var localVarPath = "/" + GetEntityName() + "/{id}";
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Any), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeIDPathParams(id), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "DeleteById");

            return GetResponseHeaders(localVarResponse);
        }

        /// <summary>
        /// Deletes the record by its session identifier. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        protected ApiResponse<Object> DeleteByIdWithHttpInfo(Guid? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                ThrowMissingParameter("DeleteById", nameof(id));

            var localVarPath = "/" + GetEntityName() + "/{id}";

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Any), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeIDPathParams(id), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "DeleteById");

            return GetResponseHeaders(localVarResponse);
        }

        protected Dictionary<string, string> ComposeIDPathParams(Guid? id = null)
        {
            Dictionary<string, string> pathParams = ComposeEmptyPathParams();

            if (id != null) pathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            return pathParams;
        }

        protected Dictionary<string, string> ComposeIDsPathParams(List<string> ids, string filename = null)
        {
            var pathParams = ComposeEmptyPathParams();

            if (ids != null) pathParams.Add("ids", this.Configuration.ApiClient.ParameterToString(ids)); // path parameter
            if (filename != null) pathParams.Add("filename", this.Configuration.ApiClient.ParameterToString(filename)); // path parameter
            return pathParams;
        }
        #endregion
    }
}
