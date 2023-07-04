using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Acumatica.RESTClient.Client;

using Acumatica.RESTClient.ContractBasedApi.Model;
using System.Net;
using System.Linq;
using Acumatica.RESTClient.Api;
using System.Net.Http;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;

namespace Acumatica.RESTClient.ContractBasedApi
{
    public static class ApiClientExtensions
    {
        #region Public Methods
        #region Action

        /// <summary>
        /// Performs an action in the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The action that should be executed.</param>
        /// <returns>
        /// Returns value of Location header. The value can be used to 
        /// query the status of running operation using <see cref="GetProcessStatus(string)"/>
        /// </returns>
        public static string InvokeAction<EntityType>(
            this ApiClient client, EntityAction<EntityType> action, DateTime? businessDate = null, string branch = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            return InvokeActionAsync(client, action, businessDate, branch).Result;
        }

        /// <summary>
        /// Performs an action in the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The record to which the action should be applied and the parameters of the action.</param>
        /// <returns>Task of void</returns>
        public static async Task<string> InvokeActionAsync<EntityType>(
            this ApiClient client, EntityAction<EntityType> action, DateTime? businessDate = null, string branch = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            if (action == null)
                ThrowMissingParameter(nameof(InvokeActionAsync), nameof(action));

            HttpResponseMessage response = await client.CallApiAsync(
                $"{GetEndpointPath<EntityType>()}/{GetEntityName(typeof(EntityType))}/{action.GetType().Name}",
                HttpMethod.Post,
                null,
                action,
                HeaderContentType.Json,
                HeaderContentType.Json,
                ComposePutHeaders(PutMethod.Any, businessDate, branch));

            VerifyResponse(response, nameof(InvokeActionAsync));

            return response.Headers.GetValues("Location").First();
        }
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
        public static void WaitActionCompletion(this ApiClient client, string locationRaw, int millisecondsInterval = 1000)
        {
            while (true)
            {
                var processResult = GetProcessStatus(client, locationRaw);

                switch (processResult)
                {
                    case HttpStatusCode.NoContent:
                        return;
                    case HttpStatusCode.Accepted:
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
        public static HttpStatusCode GetProcessStatus(this ApiClient client, string locationRaw)
        {
            return GetProcessStatusAsync(client, locationRaw).Result;
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
        public static async Task<HttpStatusCode> GetProcessStatusAsync(this ApiClient client, string locationRaw)
        {
            if (locationRaw == null)
                ThrowMissingParameter(nameof(GetProcessStatusAsync), nameof(locationRaw));

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

            VerifyResponse(response, nameof(GetProcessStatusAsync));

            return response.StatusCode;
        }
        #endregion
        #region Put
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
        public static EntityType Put<EntityType>(
            this ApiClient client, EntityType entity,
            string select = null, string filter = null, string expand = null, string custom = null,
            PutMethod method = PutMethod.Any, DateTime? businessDate = null, string branch = null)
            where EntityType : ITopLevelEntity
        {
            return PutAsync(client, entity,
                select, filter, expand, custom,
                method, businessDate, branch).Result;
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
        public static async Task<EntityType> PutAsync<EntityType>(this ApiClient client,
            EntityType entity,
            string select = null, string filter = null, string expand = null, string custom = null,
            PutMethod method = PutMethod.Any, DateTime? businessDate = null, string branch = null)
            where EntityType : ITopLevelEntity
        {
            if (entity == null)
                ThrowMissingParameter(nameof(PutAsync), nameof(entity));

            HttpResponseMessage response = await client.CallApiAsync(
                $"{GetEndpointPath(entity)}/{GetEntityName(entity)}",
                HttpMethod.Put,
                ComposeQueryParams(select, filter, expand, custom),
                entity,
                HeaderContentType.Json,
                HeaderContentType.Json,
                ComposePutHeaders(method, businessDate, branch));

            VerifyResponse(response, nameof(PutAsync));

            return (EntityType)Deserialize<EntityType>(response);
        }
        #endregion
        #region PutFile
        /// <summary>
        /// Attaches a file to a record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> The id of the record.</param>
        /// <param name="filename">The name of the file that you are going to attach with the extension.</param>
        /// <returns></returns>
        public static void PutFile<EntityType>(
            this ApiClient client, string id, string filename, byte[] content)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            PutFileAsync<EntityType>(client, new List<string>() { id }, filename, content).RunSynchronously();
        }
        /// <summary>
        /// Attaches a file to a record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the record.</param>
        /// <param name="filename">The name of the file that you are going to attach with the extension.</param>
        /// <returns></returns>
        public static async Task PutFileAsync<EntityType>(
            this ApiClient client, string id, string filename, byte[] content)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            await PutFileAsync<EntityType>(client, new List<string>() { id }, filename, content);
        }
        /// <summary>
        /// Attaches a file to a record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <param name="filename">The name of the file that you are going to attach with the extension.</param>
        /// <returns></returns>
        public static void PutFile<EntityType>(
            this ApiClient client, IEnumerable<string> ids, string filename, byte[] content)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            PutFileAsync<EntityType>(client, ids, filename, content).RunSynchronously();
        }
        /// <summary>
        /// Attaches a file to a record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <param name="filename">The name of the file that you are going to attach with the extension.</param>
        /// <returns>Task of void</returns>
        public static async Task PutFileAsync<EntityType>(
            this ApiClient client, IEnumerable<string> ids, string filename, byte[] content)
            where EntityType: ITopLevelEntity, new()
        {
            if (ids == null)
                ThrowMissingParameter(nameof(PutFileAsync), nameof(ids));
            if (filename == null)
                ThrowMissingParameter(nameof(PutFileAsync), nameof(filename));

            HttpResponseMessage response = await client.CallApiAsync(
                $"{GetEndpointPath<EntityType>()}/{GetEntityName(typeof(EntityType))}/{string.Join("/", ids)}/files/{filename}",
                HttpMethod.Put,
                null,
                content,
                HeaderContentType.Json,
                HeaderContentType.OctetStream);

            VerifyResponse(response, nameof(PutFileAsync));
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
        /// <returns>Task of Entity</returns>
        public static async Task<EntityType> GetByKeysAsync<EntityType>(
            this ApiClient client, IEnumerable<string> ids, string select = null, string filter = null, string expand = null, string custom = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            if (ids == null)
                ThrowMissingParameter(nameof(GetByKeysAsync), nameof(ids));

            HttpResponseMessage response = await client.CallApiAsync(
                $"{GetEndpointPath<EntityType>()}/{GetEntityName(typeof(EntityType))}/{string.Join("/", ids)}",
                HttpMethod.Get,
                ComposeQueryParams(select, filter, expand, custom),
                null,
                HeaderContentType.Json,
                HeaderContentType.None);

            VerifyResponse(response, nameof(GetByKeysAsync));

            return (EntityType)Deserialize<EntityType>(response);
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
        public static EntityType GetByKeys<EntityType>(
            this ApiClient client, IEnumerable<string> ids, string select = null, string filter = null, string expand = null, string custom = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            return GetByKeysAsync<EntityType>(client, ids, select, filter, expand, custom).Result;
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
        public static async Task<EntityType> GetByIdAsync<EntityType>(
            this ApiClient client, Guid? id, string select = null, string filter = null, string expand = null, string custom = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            if (id == null)
                ThrowMissingParameter(nameof(GetByIdAsync), nameof(id));

            HttpResponseMessage response = await client.CallApiAsync(
                $"{GetEndpointPath<EntityType>()}/{GetEntityName(typeof(EntityType))}/{id}",
                HttpMethod.Get,
                ComposeQueryParams(select, filter, expand, custom),
                null,
                HeaderContentType.Json,
                HeaderContentType.None);

            VerifyResponse(response, nameof(GetByIdAsync));

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
        /// <returns>Entity</returns>
        public static EntityType GetById<EntityType>(this ApiClient client, Guid? id, string select = null, string filter = null, string expand = null, string custom = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            return GetByIdAsync<EntityType>(client, id, select, filter, expand, custom).Result;
        }
        #endregion
        #region GetList
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
        public static async Task<List<EntityType>> GetListAsync<EntityType>(
            this ApiClient client, 
            string select = null, string filter = null, string expand = null, string custom = null,
            int? skip = null, int? top = null, Dictionary<string, string> customHeaders = null)
            where EntityType : ITopLevelEntity, new()
        {
            HttpResponseMessage response = await client.CallApiAsync(
              $"{GetEndpointPath<EntityType>()}/{GetEntityName(typeof(EntityType))}",
              HttpMethod.Get,
              ComposeQueryParams(select, filter, expand, custom, skip, top),
              null,
              HeaderContentType.Json,
              HeaderContentType.None,
              customHeaders);

            VerifyResponse(response, nameof(GetListAsync));

            return (List<EntityType>)Deserialize<List<EntityType>>(response);
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
        public static List<EntityType> GetList<EntityType>(
            this ApiClient client,
            string select = null, string filter = null, string expand = null, string custom = null,
            int? skip = null, int? top = null, Dictionary<string, string> customHeaders = null)
            where EntityType : ITopLevelEntity, new()
        {
            return GetListAsync<EntityType>(client, select, filter, expand, custom, skip, top, customHeaders).Result;
        }
        #endregion
        #region GetAdHocSchema
        /// <summary>
        /// Retrieves the schema of custom fields of the entity from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Entity</returns>
        public async static Task<EntityType> GetAdHocSchemaAsync<EntityType>(this ApiClient client)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            HttpResponseMessage response = await client.CallApiAsync(
               $"{GetEndpointPath<EntityType>()}/{GetEntityName(typeof(EntityType))}/$adHocSchema",
               HttpMethod.Get,
               null,
               null,
               HeaderContentType.Json,
               HeaderContentType.None);

            VerifyResponse(response, nameof(GetAdHocSchemaAsync));

            return (EntityType)Deserialize<EntityType>(response);
        }
        /// <summary>
        /// Retrieves the schema of custom fields of the entity from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Entity</returns>
        public static EntityType GetAdHocSchema<EntityType>(this ApiClient client)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            return GetAdHocSchemaAsync<EntityType>(client).Result;
        }
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the record by the values of its key fields. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <returns></returns>
        public static void DeleteByKeys<EntityType>(this ApiClient client, IEnumerable<string> ids)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            DeleteByKeysAsync<EntityType>(client, ids).RunSynchronously();
        }

        /// <summary>
        /// Deletes the record by the values of its key fields. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <returns>Task of void</returns>
        public static async Task DeleteByKeysAsync<EntityType>(this ApiClient client, IEnumerable<string> ids)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            if (ids == null)
                ThrowMissingParameter(nameof(DeleteByKeysAsync), nameof(ids));

            HttpResponseMessage localVarResponse = await client.CallApiAsync(
                $"{GetEndpointPath<EntityType>()}/{GetEntityName(typeof(EntityType))}/{string.Join("/", ids)}",
                HttpMethod.Delete,
                null,
                null,
                HeaderContentType.Any,
                HeaderContentType.None);

            VerifyResponse(localVarResponse, nameof(DeleteByKeysAsync));
        }

        /// <summary>
        /// Deletes the record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="entity">The record.</param>
        public static void Delete<EntityType>(
            this ApiClient client, EntityType entity)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            DeleteAsync(client, entity).RunSynchronously();
        }

        /// <summary>
        /// Deletes the record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="entity">The record.</param>
        public static async Task DeleteAsync<EntityType>(
            this ApiClient client, EntityType entity)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            if (entity == null || entity.ID == null)
                ThrowMissingParameter(nameof(DeleteAsync), nameof(entity));

            HttpResponseMessage localVarResponse = await client.CallApiAsync(
                $"{GetEndpointPath(entity)}/{GetEntityName(typeof(EntityType))}/{entity.ID}",
                HttpMethod.Delete,
                null,
                null,
                HeaderContentType.Any,
                HeaderContentType.None);

            VerifyResponse(localVarResponse, nameof(DeleteAsync));
        }

        /// <summary>
        /// Deletes the record by its session identifier. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <returns></returns>
        public static void DeleteById<EntityType>(this ApiClient client, Guid? id)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            DeleteByIdAsync<EntityType>(client, id).RunSynchronously();
        }

        /// <summary>
        /// Deletes the record by its session identifier. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <returns>Task of void</returns>
        public static async Task DeleteByIdAsync<EntityType>(this ApiClient client, Guid? id)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            if (id == null)
                ThrowMissingParameter(nameof(DeleteByIdAsync), nameof(id));

            HttpResponseMessage localVarResponse = await client.CallApiAsync(
                $"{GetEndpointPath<EntityType>()}/{GetEntityName(typeof(EntityType))}/{id}",
                HttpMethod.Delete,
                null,
                null,
                HeaderContentType.Any,
                HeaderContentType.None);

            VerifyResponse(localVarResponse, nameof(DeleteByIdAsync));
        }
        #endregion
        #endregion

        #region Implementation
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
        #endregion

        #region Error Handling
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
            where EntityType : Entity
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

        #region Put
        private static Dictionary<string, string> ComposePutHeaders(PutMethod method, DateTime? businessDate, string branch)
        {
            var headers = new Dictionary<string, string>();
            if (method == PutMethod.Insert)
            {
                headers.Add("If-None-Match", "*");
            }
            else if (method == PutMethod.Update)
            {
                headers.Add("If-Match", "*");
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
        #endregion
    }
}
