using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.FileApi.Model;
using Acumatica.RESTClient.ContractBasedApi.Model;
using Acumatica.RESTClient.Api;

namespace Acumatica.RESTClient.ContractBasedApi
{
    public abstract partial class EntityAPI<EntityType> : BaseApi
        where EntityType : Entity, new()
    {
        #region Auxiliary
        protected virtual string GetEntityName()
        {
            return typeof(EntityType).Name;
        }
        protected override void VerifyResponse(HttpResponseMessage response, string methodName)
        {
            if (!response.IsSuccessStatusCode)
            {
                string responseMessage = null;
                try
                {
                    responseMessage = DeserializeResponse<EntityType>(response).Data.Error;
                    // TODO iterate through fields and find all errors
                }
                catch (Newtonsoft.Json.JsonReaderException) { }
                if (string.IsNullOrEmpty(responseMessage))
                {
                    try
                    {
                        responseMessage = DeserializeResponse<ErrorMessage>(response).Data.ToString();
                    }
                    catch (Newtonsoft.Json.JsonReaderException) { }
                }
                if (string.IsNullOrEmpty(responseMessage))
                {
                    //it should be html at that point
                    //remove tags from html
                    responseMessage = System.Text.RegularExpressions.Regex.Replace(response.Content.ReadAsStringAsync().Result.Replace('\r',' ').Replace('\n', ' '), "<.*?>", string.Empty);
                }
                throw new ApiException(
                (int)response.StatusCode,
                $"Error {(int)response.StatusCode} calling {methodName}: {response.ReasonPhrase} \r\n {responseMessage}");
            }
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

            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{string.Join("/", ids)}/files/{filename}",
                HttpMethod.Put,
                null,
                content, 
                HeaderContentType.Json, 
                HeaderContentType.OctetStream).Result ;

            VerifyResponse(localVarResponse, "PutFile");

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

            HttpResponseMessage localVarResponse = await ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{string.Join("/", ids)}/files/{filename}",
                HttpMethod.Put,
                null,
                content, 
                HeaderContentType.Json, 
                HeaderContentType.OctetStream);

            VerifyResponse(localVarResponse, "PutFile");

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

            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{action.GetType().Name}",
                HttpMethod.Post,
                null,
                action, 
                HeaderContentType.Json,
                HeaderContentType.Json,
                ComposePutHeaders(PutMethod.Any, businessDate, branch)).Result;

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

            HttpResponseMessage localVarResponse = await ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{action.GetType().Name}",
                HttpMethod.Post,
                null,
                action,
                HeaderContentType.Json,
                HeaderContentType.Json,
                ComposePutHeaders(PutMethod.Any, businessDate, branch));

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

            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                $"/{GetEndpointPath()}/{parsedLocation.EntityName}/{parsedLocation.ActionName}/{parsedLocation.Status}/{parsedLocation.ID}",
                HttpMethod.Get,
                null,
                null,
                HeaderContentType.Json,
                HeaderContentType.None).Result;

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

            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}",
                HttpMethod.Put,
                ComposeQueryParams(select, filter, expand, custom),
                entity,
                HeaderContentType.Json,
                HeaderContentType.Json,
                ComposePutHeaders(method, businessDate, branch)).Result;

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
        protected async Task<ApiResponse<EntityType>> PutEntityAsyncWithHttpInfo(EntityType entity, 
            string select = null, string filter = null, string expand = null, string custom = null, 
            PutMethod method = PutMethod.Any, DateTime? businessDate = null, string branch=null)
		{
			if (entity == null)
				ThrowMissingParameter("PutEntity", nameof(entity));

			HttpResponseMessage localVarResponse = await ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}",
				HttpMethod.Put, 
                ComposeQueryParams(select, filter, expand, custom),
                entity,
                HeaderContentType.Json,
                HeaderContentType.Json,
                ComposePutHeaders(method, businessDate, branch));

			VerifyResponse(localVarResponse, "PutEntity");

			return DeserializeResponse<EntityType>(localVarResponse);
		}

		private Dictionary<string, string> ComposePutHeaders(PutMethod method, DateTime? businessDate, string branch)
		{
            var headers = new Dictionary<string, string>();
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

            HttpResponseMessage localVarResponse = await ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{string.Join("/", ids)}",
                HttpMethod.Get,
                ComposeQueryParams(select, filter, expand, custom),
                null, 
                HeaderContentType.Json, 
                HeaderContentType.None);

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
            if (ids == null)
                ThrowMissingParameter("GetByKeys", nameof(ids));

            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{string.Join("/", ids)}",
                HttpMethod.Get,
                ComposeQueryParams(select, filter, expand, custom),
                null, 
                HeaderContentType.Json,     
                HeaderContentType.None).Result;

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
        protected async Task<ApiResponse<List<EntityType>>> GetListAsyncWithHttpInfo(
            string select = null, string filter = null, string expand = null, string custom = null,
            int? skip = null, int? top = null, Dictionary<string, string> customHeaders = null)
        {
            HttpResponseMessage localVarResponse = await ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}",
                HttpMethod.Get,
                ComposeQueryParams(select, filter, expand, custom),
                null,
                HeaderContentType.Json,
                HeaderContentType.None,
                customHeaders);

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
        protected ApiResponse<List<EntityType>> GetListWithHttpInfo(
            string select = null, string filter = null, string expand = null, string custom = null, 
            int? skip = null, int? top = null, Dictionary<string, string> customHeaders = null)
        {
            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}",
                HttpMethod.Get,
                ComposeQueryParams(select, filter, expand, custom),
                null,
                HeaderContentType.Json,
                HeaderContentType.None,
                customHeaders).Result;

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
        protected async Task<ApiResponse<EntityType>> GetByIdAsyncWithHttpInfo(Guid? id, string select = null, string filter = null, string expand = null, string custom = null)
        {
            if (id == null)
                ThrowMissingParameter("GetById", nameof(id));

            HttpResponseMessage localVarResponse = await ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{id}",
                HttpMethod.Get,
                ComposeQueryParams(select, filter, expand, custom),
                null, 
                HeaderContentType.Json, 
                HeaderContentType.None);

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
            if (id == null)
                ThrowMissingParameter("GetById", nameof(id));

            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{id}",
                HttpMethod.Get,
                ComposeQueryParams(select, filter, expand, custom),
                null, 
                HeaderContentType.Json, 
                HeaderContentType.None).Result;

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
		protected async Task<ApiResponse<EntityType>> GetAdHocSchemaAsyncWithHttpInfo()
        {

            HttpResponseMessage localVarResponse = await ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/$adHocSchema",
                HttpMethod.Get,
                null,
                null, 
                HeaderContentType.Json, 
                HeaderContentType.None);

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
            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/$adHocSchema",
                HttpMethod.Get,
                null,
                null, 
                HeaderContentType.Json, 
                HeaderContentType.None).Result;

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
		protected async Task<ApiResponse> DeleteByKeysAsyncWithHttpInfo(IEnumerable<string> ids)
        {
            if (ids == null)
                ThrowMissingParameter("DeleteByKeys", nameof(ids));

            HttpResponseMessage localVarResponse = await ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{string.Join("/", ids)}",
                HttpMethod.Delete,
                null,
                null, 
                HeaderContentType.Any, 
                HeaderContentType.None);

            VerifyResponse(localVarResponse, "DeleteByKeys");

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

            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{string.Join("/", ids)}",
                HttpMethod.Delete,
                null,
                null, 
                HeaderContentType.Any, 
                HeaderContentType.None).Result;

            VerifyResponse(localVarResponse, "DeleteByKeys");

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

            HttpResponseMessage localVarResponse = await ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{id}",
                HttpMethod.Delete,
                null,
                null, 
                HeaderContentType.Any, 
                HeaderContentType.None);

            VerifyResponse(localVarResponse, "DeleteById");

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

            HttpResponseMessage localVarResponse = ApiClient.CallApiAsync(
                $"{GetEndpointPath()}/{GetEntityName()}/{id}",
                HttpMethod.Delete,
                null,
                null, 
                HeaderContentType.Any, 
                HeaderContentType.None).Result;

            VerifyResponse(localVarResponse, "DeleteById");

            return ConvertRestResponeToApiResponse(localVarResponse);
        }
		#endregion
    }
}
