using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.FileApi.Model;
using Acumatica.RESTClient.ContractBasedApi.Model;
using Acumatica.RESTClient.Api;
using System.Net;
using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;

namespace Acumatica.RESTClient.ContractBasedApi
{
    public static partial class ApiClientExtensions
    {
        #region Auxiliary
        private static string GetEndpointPath(ITopLevelEntity entity)
        {
            return entity.GetEndpointPath();
        }
        private static string GetEndpointPath<EntityType>()
            where EntityType : ITopLevelEntity, new()
        {
            return new EntityType().GetEndpointPath();
        }

        private static string GetEntityName(Type entityType)
        {
            return entityType.Name;
        }

        private static string GetEntityName(ITopLevelEntity entity) => GetEntityName(entity.GetType());


        private static void VerifyResponse(HttpResponseMessage response, string methodName)
        {
            if (!response.IsSuccessStatusCode)
            {
                string responseMessage = null;
                if (string.IsNullOrEmpty(responseMessage))
                {
                    responseMessage = GetErrorMessageFromError(response, responseMessage);
                }
                if (string.IsNullOrEmpty(responseMessage))
                {
                    //it should be html at that point
                    //remove tags from html
                    responseMessage = System.Text.RegularExpressions.Regex.Replace(response.Content.ReadAsStringAsync().Result.Replace('\r', ' ').Replace('\n', ' '), "<.*?>", string.Empty);
                }
                throw new ApiException(
                  (int)response.StatusCode,
                  $"Error {(int)response.StatusCode} calling {methodName}: {response.ReasonPhrase} \r\n {responseMessage}");
            }
        }

        private static string GetErrorMessageFromError(HttpResponseMessage response, string responseMessage)
        {
            try
            {
                ErrorMessage error = (ErrorMessage)Deserialize<ErrorMessage>(response);
                responseMessage = $"{error.message} : {error.exceptionMessage} : {error.innerException}";
            }
            catch (Newtonsoft.Json.JsonReaderException) { }

            return responseMessage;
        }

        private static void VerifyResponse<EntityType>(HttpResponseMessage response, string methodName)
            where EntityType: Entity
        {
            if (!response.IsSuccessStatusCode)
            {
                string responseMessage = null;
                responseMessage = GetErrorMessageFromEntity<EntityType>(response, responseMessage);
                if (string.IsNullOrEmpty(responseMessage))
                {
                    responseMessage = GetErrorMessageFromError(response, responseMessage);
                }
                if (string.IsNullOrEmpty(responseMessage))
                {
                    //it should be html at that point
                    responseMessage = GetErrorMessageFromHTML(response);
                }
                throw new ApiException(
                  (int)response.StatusCode,
                  $"Error {(int)response.StatusCode} calling {methodName}: {response.ReasonPhrase} \r\n {responseMessage}");
            }
        }

        private static string GetErrorMessageFromHTML(HttpResponseMessage response)
        {
            //remove tags from html
            return System.Text.RegularExpressions.Regex.Replace(response.Content.ReadAsStringAsync().Result.Replace('\r', ' ').Replace('\n', ' '), "<.*?>", string.Empty);
        }

        private static string GetErrorMessageFromEntity<EntityType>(HttpResponseMessage response, string responseMessage)
            where EntityType : Entity
        {
            try
            {
                responseMessage = ((EntityType)Deserialize<EntityType>(response)).Error;
                // TODO iterate through fields and find all errors
            }
            catch (Newtonsoft.Json.JsonReaderException) { }

            return responseMessage;
        }
        #endregion

		#region InvokeAction
 
        private static async Task<HttpStatusCode> GetProcessStatusAsyncWithHttpInfo(ApiClient client, string locationRaw)
        {
            if (locationRaw == null)
                ThrowMissingParameter("GetProcessStatus", nameof(locationRaw));

            var parsedLocation = UrlParser.ParseActionLocation(locationRaw);
            if (parsedLocation.ActionName == null)
                return HttpStatusCode.NoContent;

            HttpResponseMessage response = await client.CallApiAsync(
                $"/{parsedLocation.EndpointName}/{parsedLocation.EndpointVersion}/{parsedLocation.EntityName}/{parsedLocation.ActionName}/{parsedLocation.Status}/{parsedLocation.ID}",
                HttpMethod.Get,
                null,
                null,
                HeaderContentType.Json,
                HeaderContentType.None);

            VerifyResponse(response, "GetProcessStatus");

            return response.StatusCode;
        }
        #endregion

        #region Put

        const string PutMethodInsertHeader = "If-None-Match";
        const string PutMethodUpdateHeader = "If-Match";

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
        private static async Task<EntityType> PutEntityAsyncWithHttpInfo<EntityType>(
            ApiClient client, EntityType entity, 
            string select = null, string filter = null, string expand = null, string custom = null, 
            PutMethod method = PutMethod.Any, DateTime? businessDate = null, string branch=null)
            where EntityType : ITopLevelEntity
        {
			if (entity == null)
				ThrowMissingParameter("PutEntity", nameof(entity));

			HttpResponseMessage response = await client.CallApiAsync(
                $"{GetEndpointPath(entity)}/{GetEntityName(entity)}",
				HttpMethod.Put, 
                ComposeQueryParams(select, filter, expand, custom),
                entity,
                HeaderContentType.Json,
                HeaderContentType.Json,
                ComposePutHeaders(method, businessDate, branch));

			VerifyResponse(response, "PutEntity");

			return (EntityType)Deserialize<EntityType>(response);
		}

        private static Dictionary<string, string> ComposePutHeaders(PutMethod method, DateTime? businessDate, string branch)
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
        private static async Task<EntityType> GetByKeysAsyncWithHttpInfo<EntityType>(ApiClient client, IEnumerable<string> ids, string select = null, string filter = null, string expand = null, string custom = null)
            where EntityType : ITopLevelEntity, new()
        {
            if (ids == null)
                ThrowMissingParameter("GetByKeys", nameof(ids));

            HttpResponseMessage response = await client.CallApiAsync(
                $"{GetEndpointPath<EntityType>()}/{GetEntityName(typeof(EntityType))}/{string.Join("/", ids)}",
                HttpMethod.Get,
                ComposeQueryParams(select, filter, expand, custom),
                null, 
                HeaderContentType.Json, 
                HeaderContentType.None);

            VerifyResponse(response, "GetByKeys");

            return (EntityType)Deserialize<EntityType>(response);
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
        private static async Task<EntityType> GetByIdAsyncWithHttpInfo<EntityType>(
            ApiClient client, Guid? id, string select = null, string filter = null, string expand = null, string custom = null)
            where EntityType : ITopLevelEntity, new()
        {
            if (id == null)
                ThrowMissingParameter("GetById", nameof(id));

            HttpResponseMessage response = await client.CallApiAsync(
                $"{GetEndpointPath<EntityType>()}/{GetEntityName(typeof(EntityType))}/{id}",
                HttpMethod.Get,
                ComposeQueryParams(select, filter, expand, custom),
                null, 
                HeaderContentType.Json, 
                HeaderContentType.None);

            VerifyResponse(response, "GetById");

            return (EntityType)Deserialize<EntityType>(response);
        }
        #endregion

        #region GetAdHocSchema
        /// <summary>
        /// Retrieves the schema of custom fields of the entity from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Entity)</returns>
        private static async Task<EntityType> GetAdHocSchemaAsyncWithHttpInfo<EntityType>(ApiClient client)
            where EntityType : ITopLevelEntity, new()
        {
            HttpResponseMessage response = await client.CallApiAsync(
                $"{GetEndpointPath<EntityType>()}/{GetEntityName(typeof(EntityType))}/$adHocSchema",
                HttpMethod.Get,
                null,
                null, 
                HeaderContentType.Json, 
                HeaderContentType.None);

            VerifyResponse(response, "GetAdHocSchema");

            return (EntityType)Deserialize<EntityType>(response);
        }
        #endregion

        #region Delete
        /// <summary>
        /// Deletes the record by the values of its key fields. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <returns>Task of ApiResponse</returns>
        private static async Task DeleteByKeysAsyncWithHttpInfo<EntityType>(ApiClient client, IEnumerable<string> ids)
            where EntityType : ITopLevelEntity, new()
        {
            if (ids == null)
                ThrowMissingParameter("DeleteByKeys", nameof(ids));

            HttpResponseMessage localVarResponse = await client.CallApiAsync(
                $"{GetEndpointPath<EntityType>()}/{GetEntityName(typeof(EntityType))}/{string.Join("/", ids)}",
                HttpMethod.Delete,
                null,
                null,
                HeaderContentType.Any,
                HeaderContentType.None);

            VerifyResponse(localVarResponse, "DeleteByKeys");
        }
        /// <summary>
        /// Deletes the record by its session identifier. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <returns>Task of ApiResponse</returns>
        private static async Task DeleteAsyncWithHttpInfo<EntityType>(ApiClient client, EntityType entity)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            if (entity == null || entity.ID == null)
                ThrowMissingParameter("Delete", nameof(entity));

            HttpResponseMessage localVarResponse = await client.CallApiAsync(
                $"{GetEndpointPath(entity)}/{GetEntityName(typeof(EntityType))}/{entity.ID}",
                HttpMethod.Delete,
                null,
                null,
                HeaderContentType.Any,
                HeaderContentType.None);

            VerifyResponse(localVarResponse, "DeleteById");
        }

        /// <summary>
        /// Deletes the record by its session identifier. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <returns>Task of ApiResponse</returns>
        private static async Task DeleteByIdAsyncWithHttpInfo<EntityType>(ApiClient client, Guid? id)
            where EntityType : ITopLevelEntity, new()
        {
            if (id == null)
                ThrowMissingParameter("DeleteById", nameof(id));

            HttpResponseMessage localVarResponse = await client.CallApiAsync(
                $"{GetEndpointPath<EntityType>()}/{GetEntityName(typeof(EntityType))}/{id}",
                HttpMethod.Delete,
                null,
                null, 
                HeaderContentType.Any, 
                HeaderContentType.None);

            VerifyResponse(localVarResponse, "DeleteById");
        }
		#endregion
    }
}
