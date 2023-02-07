using System;
using System.Collections.Generic;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Model;

using RestSharp;

namespace Acumatica.RESTClient.Api
{
    public abstract partial class EntityAPI<EntityType> : BaseApi
        where EntityType : Entity
    {
        #region Auxiliary
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

        public static Location ParseLocation(string location)
        {
            string entityKeyword = "/entity/";
            char[] pathSeparators = new char[] { '/' };

            var result = new Location();
            var parts = location.Split(pathSeparators, StringSplitOptions.RemoveEmptyEntries);
            result.ID = parts[parts.Length - 1];

            int indexOfEntity = location.IndexOf(entityKeyword, StringComparison.OrdinalIgnoreCase);
            if (indexOfEntity < 0)
                throw new Exception("Incorrect location");
            if (location.Substring(indexOfEntity + entityKeyword.Length).IndexOf(entityKeyword, StringComparison.OrdinalIgnoreCase) >= 0)
                throw new Exception("Location cannot be parsed as it contains more than 1 entity keyword");
            result.Site = location.Substring(0, indexOfEntity);
            string restOfLocation = location.Substring(indexOfEntity);
            parts = restOfLocation.Split(pathSeparators, StringSplitOptions.RemoveEmptyEntries);

            result.EndpointName = parts[1];
            result.EndpointVersion = parts[2];
            result.EntityName = parts[3];
            if (parts.Length == 7)
            {
                result.ActionName = parts[4];
                result.Status = parts[5];
            }

            return result;
        }

        protected virtual string GetEntityName()
        {
            return typeof(EntityType).Name;
        }

        protected override void VerifyResponse(RestResponse response, string methodName)
        {
            if (!response.IsSuccessStatusCode)
                throw new ApiException<EntityType>((int)response.StatusCode, methodName);
            if (!response.IsSuccessful)
                throw new ApiException((int)response.StatusCode, methodName);
        }

        protected int GetProcessStatusWithHttpInfo(string locationRaw)
        {
            if (locationRaw == null)
                ThrowMissingParameter("GetProcessStatus", nameof(locationRaw));

            var parsedLocation = ParseLocation(locationRaw);
            if (parsedLocation.ActionName == null)
                return 204;
            var localVarPath = "/" + GetEndpointPath() + "/" + parsedLocation.EntityName + "/" + parsedLocation.ActionName + "/" + parsedLocation.Status + "/" + parsedLocation.ID;

            var localVarFileParams = new Dictionary<String, FileParameter>();

            // make the HTTP request
            RestResponse localVarResponse = Session.ApiClient.CallApiAsync(localVarPath,
                Method.Get, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), localVarFileParams,
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.None)).Result;

            VerifyResponse(localVarResponse, "GetProcessStatus");

            return (int)localVarResponse.StatusCode;
        }

      
        protected Dictionary<string, string> ComposeIDPathParams(Guid? id = null)
        {
            Dictionary<string, string> pathParams = ComposeEmptyPathParams();

            if (id != null) pathParams.Add("id", this.Session.ApiClient.ParameterToString(id)); // path parameter
            return pathParams;
        }

        protected Dictionary<string, string> ComposeIDsPathParams(IEnumerable<string> ids, string filename = null)
        {
            var pathParams = ComposeEmptyPathParams();

            if (ids != null) pathParams.Add("ids", this.Session.ApiClient.ParameterToString(ids)); // path parameter
            if (filename != null) pathParams.Add("filename", this.Session.ApiClient.ParameterToString(filename)); // path parameter
            return pathParams;
        }
        #endregion

        #region PutFile
        /// <summary>
        /// Attaches a file to a record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <param name="filename">The name of the file that you are going to attach with the extension.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        protected ApiResponse<Object> PutFileWithHttpInfo(IEnumerable<string> ids, string filename, byte[] content)
        {            
            // verify the required parameter 'ids' is set
            if (ids == null)
                ThrowMissingParameter("PutFile", nameof(ids));
            // verify the required parameter 'filename' is set
            if (filename == null)
                ThrowMissingParameter("PutFile", nameof(filename));

            var localVarPath = GetEndpointPath() + "/" + GetEntityName() + "/{ids}/files/{filename}";

            var fileParams = ComposeEmptyFileParams();
            fileParams.Add(filename, FileParameter.Create(filename, content, filename));

            // make the HTTP request
            RestResponse localVarResponse = Session.ApiClient.CallApiAsync(localVarPath,
                Method.Put, ComposeEmptyQueryParams(), content, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), fileParams,
                ComposeIDsPathParams(ids, filename), ComposeContentHeaders(HeaderContentType.None)).Result ;

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
        protected async System.Threading.Tasks.Task<ApiResponse<Object>> PutFileAsyncWithHttpInfo(IEnumerable<string> ids, string filename, byte[] content)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                ThrowMissingParameter("PutFile", nameof(ids));
            // verify the required parameter 'filename' is set
            if (filename == null)
                ThrowMissingParameter("PutFile", nameof(filename));

            var localVarPath = GetEndpointPath() + "/" + GetEntityName() + "/{ids}/files/{filename}";

            var fileParams = ComposeEmptyFileParams();
            fileParams.Add(filename, FileParameter.Create(filename, content, filename));

            // make the HTTP request
            RestResponse localVarResponse = await Session.ApiClient.CallApiAsync(localVarPath,
                Method.Put, ComposeEmptyQueryParams(), content, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), fileParams,
                ComposeIDsPathParams(ids, filename), ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse(localVarResponse, "PutFile");

            return GetResponseHeaders(localVarResponse);
        }
		#endregion

		#region InvokeAction
		/// <summary>
		/// Performs an action in the system. 
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="action">The record to which the action should be applied and the parameters of the action.</param>
		/// <returns>ApiResponse of Object(void)</returns>
		protected ApiResponse<Object> InvokeActionWithHttpInfo(EntityAction<EntityType> action)
        {            // verify the required parameter 'action' is set
            if (action == null)
                ThrowMissingParameter("InvokeAction", nameof(action));

            var localVarPath = GetEndpointPath() + "/" + GetEntityName() + "/" + action.GetType().Name;

            // make the HTTP request
            RestResponse localVarResponse = Session.ApiClient.CallApiAsync(localVarPath,
                Method.Post, ComposeEmptyQueryParams(), ComposeBody(action), ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.Json)).Result;

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

            var localVarPath = GetEndpointPath() + "/" + GetEntityName() + "/" + action.GetType().Name;

            // make the HTTP request
            RestResponse localVarResponse = await Session.ApiClient.CallApiAsync(localVarPath,
                Method.Post, ComposeEmptyQueryParams(), ComposeBody(action), ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.Json));

            VerifyResponse(localVarResponse, "InvokeAction");

            return GetResponseHeaders(localVarResponse);
        }
        #endregion

        #region Put

        protected const string PutMethodInsertHeader = "If-None-Match";
        protected const string PutMethodUpdateHeader = "If-Match";

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
        protected ApiResponse<EntityType> PutEntityWithHttpInfo(EntityType entity, 
            string select = null, string filter = null, string expand = null, string custom = null, 
            PutMethod method = PutMethod.Any, DateTime? businessDate = null, string branch = null)
        {
            if (entity == null)
                ThrowMissingParameter("PutEntity", nameof(entity));

            var localVarPath = GetEndpointPath() + "/" + GetEntityName();
            Dictionary<string, string> headers = ComposePutHeaders(method, businessDate, branch);

            // make the HTTP request
            RestResponse localVarResponse = Session.ApiClient.CallApiAsync(localVarPath,
                Method.Put, ComposeQueryParams(select, filter, expand, custom), ComposeBody(entity), headers, ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.Json)).Result;

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
        protected async System.Threading.Tasks.Task<ApiResponse<EntityType>> PutEntityAsyncWithHttpInfo(EntityType entity, 
            string select = null, string filter = null, string expand = null, string custom = null, 
            PutMethod method = PutMethod.Any, DateTime? businessDate = null, string branch=null)
		{
			// verify the required parameter 'entity' is set
			if (entity == null)
				ThrowMissingParameter("PutEntity", nameof(entity));

			var localVarPath = GetEndpointPath() + "/" + GetEntityName();
			Dictionary<string, string> headers = ComposePutHeaders(method, businessDate, branch);

			// make the HTTP request
			RestResponse localVarResponse = await Session.ApiClient.CallApiAsync(localVarPath,
				Method.Put, ComposeQueryParams(select, filter, expand, custom), ComposeBody(entity), headers, ComposeEmptyFormParams(), ComposeEmptyFileParams(),
				ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.Json));

			VerifyResponse(localVarResponse, "PutEntity");

			return DeserializeResponse<EntityType>(localVarResponse);
		}

		private Dictionary<string, string> ComposePutHeaders(PutMethod method, DateTime? businessDate, string branch)
		{
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
				headers.Add("PX-CbApiBusinessDate", businessDate?.ToString(System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat));
			}
            if (!String.IsNullOrEmpty(branch))
            {
                headers.Add("PX-CbApiBranch", branch);
            }

            return headers;
		}
		#endregion

		#region Get
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
		protected async System.Threading.Tasks.Task<ApiResponse<EntityType>> GetByKeysAsyncWithHttpInfo(IEnumerable<string> ids, string select = null, string filter = null, string expand = null, string custom = null)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                ThrowMissingParameter("GetByKeys", nameof(ids));

            var localVarPath = GetEndpointPath() + "/" + GetEntityName() + "/{ids}";

            // make the HTTP request
            RestResponse localVarResponse = await Session.ApiClient.CallApiAsync(localVarPath,
                Method.Get, ComposeQueryParams(select, filter, expand, custom), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
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
        protected ApiResponse<EntityType> GetByKeysWithHttpInfo(IEnumerable<string> ids, string select = null, string filter = null, string expand = null, string custom = null)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                ThrowMissingParameter("GetByKeys", nameof(ids));

            var localVarPath = GetEndpointPath() + "/" + GetEntityName() + "/{ids}";

            // make the HTTP request
            RestResponse localVarResponse = Session.ApiClient.CallApiAsync(localVarPath,
                Method.Get, ComposeQueryParams(select, filter, expand, custom), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeIDsPathParams(ids), ComposeContentHeaders(HeaderContentType.None)).Result;

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
            var localVarPath = GetEndpointPath() + "/" + GetEntityName();

            // make the HTTP request
            RestResponse localVarResponse = await Session.ApiClient.CallApiAsync(localVarPath,
                Method.Get, ComposeQueryParams(select, filter, expand, custom, skip, top), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
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
            var localVarPath = GetEndpointPath() + "/" + GetEntityName();

            // make the HTTP request
            RestResponse localVarResponse = Session.ApiClient.CallApiAsync(localVarPath,
                Method.Get, ComposeQueryParams(select, filter, expand, custom, skip, top), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.None)).Result;

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

            var localVarPath = GetEndpointPath() + "/" + GetEntityName() + "/{id}";

            // make the HTTP request
            RestResponse localVarResponse = await Session.ApiClient.CallApiAsync(localVarPath,
                Method.Get, ComposeQueryParams(select, filter, expand, custom), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
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

            var localVarPath = GetEndpointPath() + "/" + GetEntityName() + "/{id}";

            // make the HTTP request
            RestResponse localVarResponse = Session.ApiClient.CallApiAsync(localVarPath,
                Method.Get, ComposeQueryParams(select, filter, expand, custom), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeIDPathParams(id), ComposeContentHeaders(HeaderContentType.None)).Result;

            VerifyResponse(localVarResponse, "GetById");

            return DeserializeResponse<EntityType>(localVarResponse);
        }
		#endregion

		#region GetAdHocSchema
		/// <summary>
		/// Retrieves the schema of custom fields of the entity from the system. 
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (Entity)</returns>
		protected async System.Threading.Tasks.Task<ApiResponse<EntityType>> GetAdHocSchemaAsyncWithHttpInfo()
        {
            var localVarPath = GetEndpointPath() + "/" + GetEntityName() + "/$adHocSchema";

            // make the HTTP request
            RestResponse localVarResponse = await Session.ApiClient.CallApiAsync(localVarPath,
                Method.Get, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
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

            var localVarPath = GetEndpointPath() + "/" + GetEntityName() + "/$adHocSchema";

            // make the HTTP request
            RestResponse localVarResponse = Session.ApiClient.CallApiAsync(localVarPath,
                Method.Get, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Json), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeEmptyPathParams(), ComposeContentHeaders(HeaderContentType.None)).Result;

            VerifyResponse(localVarResponse, "GetAdHocSchema");

            return DeserializeResponse<EntityType>(localVarResponse);
        }
		#endregion

		#region Delete
		/// <summary>
		/// Deletes the record by the values of its key fields. 
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="ids">The values of the key fields of the record.</param>
		/// <returns>Task of ApiResponse</returns>
		protected async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteByKeysAsyncWithHttpInfo(IEnumerable<string> ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                ThrowMissingParameter("DeleteByKeys", nameof(ids));

            var localVarPath = GetEndpointPath() + "/" + GetEntityName() + "/{ids}";

            // make the HTTP request
            RestResponse localVarResponse = await Session.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Any), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
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
        protected ApiResponse<Object> DeleteByKeysWithHttpInfo(IEnumerable<string> ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                ThrowMissingParameter("DeleteByKeys", nameof(ids));

            var localVarPath = GetEndpointPath() + "/" + GetEntityName() + "/{ids}";

            // make the HTTP request
            RestResponse localVarResponse = Session.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Any), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeIDsPathParams(ids), ComposeContentHeaders(HeaderContentType.None)).Result;

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

            var localVarPath = GetEndpointPath() + "/" + GetEntityName() + "/{id}";
            // make the HTTP request
            RestResponse localVarResponse = await Session.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Any), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
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

            var localVarPath = GetEndpointPath() + "/" + GetEntityName() + "/{id}";

            // make the HTTP request
            RestResponse localVarResponse = Session.ApiClient.CallApiAsync(localVarPath,
                Method.Delete, ComposeEmptyQueryParams(), null, ComposeAcceptHeaders(HeaderContentType.Any), ComposeEmptyFormParams(), ComposeEmptyFileParams(),
                ComposeIDPathParams(id), ComposeContentHeaders(HeaderContentType.None)).Result;

            VerifyResponse(localVarResponse, "DeleteById");

            return GetResponseHeaders(localVarResponse);
        }
		#endregion
    }
}
