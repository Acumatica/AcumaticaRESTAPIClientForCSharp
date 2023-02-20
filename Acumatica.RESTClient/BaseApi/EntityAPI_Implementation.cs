using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.FileApi.Model;
using Acumatica.RESTClient.Model;

using RestSharp;


namespace Acumatica.RESTClient.Api
{
    public abstract partial class EntityAPI<EntityType> : BaseApi
        where EntityType : Entity
    {
        #region Auxiliary
        protected virtual string GetEntityName()
        {
            return typeof(EntityType).Name;
        }
        private Dictionary<string, string> ConcatNullableDictionaries(Dictionary<string, string> dictionaryA, Dictionary<string, string> dictionaryB)
        {
            if (dictionaryA == null && dictionaryB == null)
                return null;
            else if (dictionaryA == null)
                return dictionaryB;
            else if (dictionaryB == null)
                return dictionaryA;
            else
                return dictionaryB.Concat(dictionaryA).ToDictionary(_ => _.Key, _ => _.Value);
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
        protected ApiResponse PutFileWithHttpInfo(IEnumerable<string> ids, string filename, byte[] content)
        {            
            if (ids == null)
                ThrowMissingParameter("PutFile", nameof(ids));
            if (filename == null)
                ThrowMissingParameter("PutFile", nameof(filename));

            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{string.Join("/", ids)}/files/{filename}",
                Method.Put, 
                ComposeEmptyQueryParams(), 
                content, 
                ComposeAcceptHeaders(HeaderContentType.Json), 
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.OctetStream)).Result ;

            VerifyResponse<EntityType>(localVarResponse, "PutFile");

            return ConvertRestResponeToApiResponse(localVarResponse);
        }

        /// <summary>
        /// Attaches a file to a record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <param name="filename">The name of the file that you are going to attach with the extension.</param>
        /// <returns>Task of ApiResponse</returns>
        protected async Task<ApiResponse> PutFileAsyncWithHttpInfo(IEnumerable<string> ids, string filename, byte[] content)
        {
            if (ids == null)
                ThrowMissingParameter("PutFile", nameof(ids));
            if (filename == null)
                ThrowMissingParameter("PutFile", nameof(filename));

            RestResponse localVarResponse = await Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{string.Join("/", ids)}/files/{filename}",
                Method.Put, 
                ComposeEmptyQueryParams(), 
                content, 
                ComposeAcceptHeaders(HeaderContentType.Json), 
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.OctetStream));

            VerifyResponse<EntityType>(localVarResponse, "PutFile");

            return ConvertRestResponeToApiResponse(localVarResponse);
        }
		#endregion

		#region InvokeAction
		/// <summary>
		/// Performs an action in the system. 
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="action">The record to which the action should be applied and the parameters of the action.</param>
		/// <returns>ApiResponse</returns>
		protected ApiResponse InvokeActionWithHttpInfo(
            EntityAction<EntityType> action,
            DateTime? businessDate = null,
            string branch = null)
        {            
            if (action == null)
                ThrowMissingParameter("InvokeAction", nameof(action));

            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{action.GetType().Name}",
                Method.Post, 
                ComposeEmptyQueryParams(), 
                ComposeBody(action), 
                ComposePutHeaders(HeaderContentType.Json, PutMethod.Any, businessDate, branch),
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.Json)).Result;

            VerifyResponse(localVarResponse, "InvokeAction");

            return ConvertRestResponeToApiResponse(localVarResponse);
        }

        /// <summary>
        /// Performs an action in the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The record to which the action should be applied and the parameters of the action.</param>
        /// <returns>Task of ApiResponse</returns>
        protected async Task<ApiResponse> InvokeActionAsyncWithHttpInfo(
            EntityAction<EntityType> action,
            DateTime? businessDate = null, 
            string branch = null)
        {
            if (action == null)
                ThrowMissingParameter("InvokeAction", nameof(action));

            RestResponse localVarResponse = await Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{action.GetType().Name}",
                Method.Post, 
                ComposeEmptyQueryParams(), 
                ComposeBody(action),
                ComposePutHeaders(HeaderContentType.Json, PutMethod.Any, businessDate, branch),
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.Json));

            VerifyResponse(localVarResponse, "InvokeAction");

            return ConvertRestResponeToApiResponse(localVarResponse);
        }
        protected ApiResponse GetProcessStatusWithHttpInfo(string locationRaw)
        {
            if (locationRaw == null)
                ThrowMissingParameter("GetProcessStatus", nameof(locationRaw));

            var parsedLocation = UrlParser.ParseActionLocation(locationRaw);
            if (parsedLocation.ActionName == null)
                return new ApiResponse(204, null);

            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                $"/{GetEndpointPath()}/{parsedLocation.EntityName}/{parsedLocation.ActionName}/{parsedLocation.Status}/{parsedLocation.ID}",
                Method.Get,
                ComposeEmptyQueryParams(),
                null,
                ComposeAcceptHeaders(HeaderContentType.Json),
                ComposeEmptyFormParams(),
                null,
                null,
                ComposeContentHeaders(HeaderContentType.None)).Result;

            VerifyResponse(localVarResponse, "GetProcessStatus");

            return ConvertRestResponeToApiResponse(localVarResponse);
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

            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}",
                Method.Put, 
                ComposeQueryParams(select, filter, expand, custom), 
                ComposeBody(entity),
                ComposePutHeaders(HeaderContentType.Json, method, businessDate, branch), 
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.Json)).Result;

            VerifyResponse<EntityType>(localVarResponse, "PutEntity");

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
        protected async Task<ApiResponse<EntityType>> PutEntityAsyncWithHttpInfo(EntityType entity, 
            string select = null, string filter = null, string expand = null, string custom = null, 
            PutMethod method = PutMethod.Any, DateTime? businessDate = null, string branch=null)
		{
			if (entity == null)
				ThrowMissingParameter("PutEntity", nameof(entity));

			RestResponse localVarResponse = await Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}",
				Method.Put, 
                ComposeQueryParams(select, filter, expand, custom), 
                ComposeBody(entity),
                ComposePutHeaders(HeaderContentType.Json, method, businessDate, branch), 
                ComposeEmptyFormParams(), 
                null,
				null, 
                ComposeContentHeaders(HeaderContentType.Json));

			VerifyResponse<EntityType>(localVarResponse, "PutEntity");

			return DeserializeResponse<EntityType>(localVarResponse);
		}

		private Dictionary<string, string> ComposePutHeaders(HeaderContentType acceptType, PutMethod method, DateTime? businessDate, string branch)
		{
			var headers = ComposeAcceptHeaders(acceptType);
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
		protected async Task<ApiResponse<EntityType>> GetByKeysAsyncWithHttpInfo(IEnumerable<string> ids, string select = null, string filter = null, string expand = null, string custom = null)
        {
            if (ids == null)
                ThrowMissingParameter("GetByKeys", nameof(ids));

            // make the HTTP request
            RestResponse localVarResponse = await Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{string.Join("/", ids)}",
                Method.Get, 
                ComposeQueryParams(select, filter, expand, custom), 
                null, 
                ComposeAcceptHeaders(HeaderContentType.Json), 
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse<EntityType>(localVarResponse, "GetByKeys");

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
            if (ids == null)
                ThrowMissingParameter("GetByKeys", nameof(ids));

            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{string.Join("/", ids)}",
                Method.Get, 
                ComposeQueryParams(select, filter, expand, custom), 
                null, 
                ComposeAcceptHeaders(HeaderContentType.Json), 
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.None)).Result;

            VerifyResponse<EntityType>(localVarResponse, "GetByKeys");

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
        protected async Task<ApiResponse<List<EntityType>>> GetListAsyncWithHttpInfo(
            string select = null, string filter = null, string expand = null, string custom = null,
            int? skip = null, int? top = null, Dictionary<string, string> customHeaders = null)
        {
            RestResponse localVarResponse = await Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}",
                Method.Get,
                ComposeQueryParams(select, filter, expand, custom, skip, top),
                null,
                ConcatNullableDictionaries(ComposeAcceptHeaders(HeaderContentType.Json), customHeaders),
                ComposeEmptyFormParams(),
                null,
                null,
                ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse<EntityType>(localVarResponse, "GetList");

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
        protected ApiResponse<List<EntityType>> GetListWithHttpInfo(
            string select = null, string filter = null, string expand = null, string custom = null, 
            int? skip = null, int? top = null, Dictionary<string, string> customHeaders = null)
        {
            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}",
                Method.Get,
                ComposeQueryParams(select, filter, expand, custom, skip, top), 
                null,
                ConcatNullableDictionaries(ComposeAcceptHeaders(HeaderContentType.Json), customHeaders),
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.None)).Result;

            VerifyResponse<EntityType>(localVarResponse, "GetList");

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
        protected async Task<ApiResponse<EntityType>> GetByIdAsyncWithHttpInfo(Guid? id, string select = null, string filter = null, string expand = null, string custom = null)
        {
            if (id == null)
                ThrowMissingParameter("GetById", nameof(id));

            RestResponse localVarResponse = await Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{id}",
                Method.Get, 
                ComposeQueryParams(select, filter, expand, custom), 
                null, 
                ComposeAcceptHeaders(HeaderContentType.Json), 
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse<EntityType>(localVarResponse, "GetById");

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
            if (id == null)
                ThrowMissingParameter("GetById", nameof(id));

            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{id}",
                Method.Get, 
                ComposeQueryParams(select, filter, expand, custom), 
                null, 
                ComposeAcceptHeaders(HeaderContentType.Json), 
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.None)).Result;

            VerifyResponse<EntityType>(localVarResponse, "GetById");

            return DeserializeResponse<EntityType>(localVarResponse);
        }
		#endregion

		#region GetAdHocSchema
		/// <summary>
		/// Retrieves the schema of custom fields of the entity from the system. 
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <returns>Task of ApiResponse (Entity)</returns>
		protected async Task<ApiResponse<EntityType>> GetAdHocSchemaAsyncWithHttpInfo()
        {

            RestResponse localVarResponse = await Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/$adHocSchema",
                Method.Get, 
                ComposeEmptyQueryParams(), 
                null, 
                ComposeAcceptHeaders(HeaderContentType.Json), 
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse<EntityType>(localVarResponse, "GetAdHocSchema");

            return DeserializeResponse<EntityType>(localVarResponse);
        }

        /// <summary>
        /// Retrieves the schema of custom fields of the entity from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Entity</returns>
        protected ApiResponse<EntityType> GetAdHocSchemaWithHttpInfo()
        {
            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/$adHocSchema",
                Method.Get, 
                ComposeEmptyQueryParams(), 
                null, 
                ComposeAcceptHeaders(HeaderContentType.Json), 
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.None)).Result;

            VerifyResponse<EntityType>(localVarResponse, "GetAdHocSchema");

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
		protected async Task<ApiResponse> DeleteByKeysAsyncWithHttpInfo(IEnumerable<string> ids)
        {
            if (ids == null)
                ThrowMissingParameter("DeleteByKeys", nameof(ids));

            RestResponse localVarResponse = await Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{string.Join("/", ids)}",
                Method.Delete, 
                ComposeEmptyQueryParams(), 
                null, 
                ComposeAcceptHeaders(HeaderContentType.Any), 
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse<EntityType>(localVarResponse, "DeleteByKeys");

            return ConvertRestResponeToApiResponse(localVarResponse);
        }

        /// <summary>
        /// Deletes the record by the values of its key fields. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        protected ApiResponse DeleteByKeysWithHttpInfo(IEnumerable<string> ids)
        {
            if (ids == null)
                ThrowMissingParameter("DeleteByKeys", nameof(ids));

            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{string.Join("/", ids)}",
                Method.Delete, 
                ComposeEmptyQueryParams(), 
                null, 
                ComposeAcceptHeaders(HeaderContentType.Any), 
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.None)).Result;

            VerifyResponse<EntityType>(localVarResponse, "DeleteByKeys");

            return ConvertRestResponeToApiResponse(localVarResponse);
        }

        /// <summary>
        /// Deletes the record by its session identifier. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <returns>Task of ApiResponse</returns>
        protected async Task<ApiResponse> DeleteByIdAsyncWithHttpInfo(Guid? id)
        {
            if (id == null)
                ThrowMissingParameter("DeleteById", nameof(id));

            RestResponse localVarResponse = await Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{id}",
                Method.Delete, 
                ComposeEmptyQueryParams(), 
                null, 
                ComposeAcceptHeaders(HeaderContentType.Any), 
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.None));

            VerifyResponse<EntityType>(localVarResponse, "DeleteById");

            return ConvertRestResponeToApiResponse(localVarResponse);
        }

        /// <summary>
        /// Deletes the record by its session identifier. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <returns>ApiResponse</returns>
        protected ApiResponse DeleteByIdWithHttpInfo(Guid? id)
        {
            if (id == null)
                ThrowMissingParameter("DeleteById", nameof(id));

            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{id}",
                Method.Delete, 
                ComposeEmptyQueryParams(), 
                null, 
                ComposeAcceptHeaders(HeaderContentType.Any), 
                ComposeEmptyFormParams(), 
                null,
                null, 
                ComposeContentHeaders(HeaderContentType.None)).Result;

            VerifyResponse<EntityType>(localVarResponse, "DeleteById");

            return ConvertRestResponeToApiResponse(localVarResponse);
        }
		#endregion
    }
}
