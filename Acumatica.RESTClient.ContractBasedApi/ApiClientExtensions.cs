using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi.Model;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;
using static Acumatica.RESTClient.ContractBasedApi.EntityStructureHelper;

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
                this ApiClient client, 
                EntityAction<EntityType> action, 
                string? endpointPath = null, 
                DateTime? businessDate = null, 
                string? branch = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            return InvokeActionAsync(client, action, endpointPath, businessDate, branch).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Performs an action in the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="action">The record to which the action should be applied and the parameters of the action.</param>
        /// <returns>Task of void</returns>
        public static async Task<string> InvokeActionAsync<EntityType>(
                this ApiClient client, 
                EntityAction<EntityType> action, 
                string? endpointPath = null, 
                DateTime? businessDate = null, 
                string? branch = null, 
                CancellationToken cancellationToken = default)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            if (action == null)
                ThrowMissingParameter(nameof(InvokeActionAsync), nameof(action));

            if (endpointPath == null)
                endpointPath = GetEndpointPath<EntityType>();

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"{endpointPath}/{GetEntityName(typeof(EntityType))}/{action!.GetType().Name}",
                method:             HttpMethod.Post,
                body:               action,
                acceptType:         HeaderContentType.Json,
                contentType:        HeaderContentType.Json,
                customHeaders:      ComposePutHeaders(PutMethod.Any, businessDate, branch),
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(InvokeActionAsync)).ConfigureAwait(false);

            return response.Headers.GetValues("Location").First();
        }

        /// <summary>
        /// Queries the system with the specified <paramref name="millisecondsInterval"/> 
        /// to get status of a running operation
        /// untill the operation status is Completed.
        /// </summary>
        /// <param name="location">
        /// Value of the Location header returned 
        /// from <see cref="InvokeAction(EntityAction{EntityType})"/> or
        /// <see cref="InvokeActionAsync(EntityAction{EntityType})"/>
        /// </param>
        /// <param name="millisecondsInterval">
        /// Time that the system waits between querying for the operation status in milliseconds.
        /// Default value is <c>1000</c>.
        /// </param>
        /// <param name="secondsTimeout">
        /// Time that the system waits for the process completion. 
        /// Default value is <c>360</c>.
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// Throws the the exception if the operation finishes with a status code not indicating 
        /// successful completion.
        /// </exception>
        /// <exception cref="TimeoutException">
        /// Throws the the exception if the operation did not finish in specified timeout interval. 
        /// </exception>
        public static async Task WaitActionCompletionAsync(
            this ApiClient client, 
            string location, 
            int millisecondsInterval = 1000, 
            int secondsTimeout = 360, 
            CancellationToken cancellationToken = default)
        {
            while (true)
            {
                var startTime = DateTime.Now;
                var processResult = await GetProcessStatusAsync(client, location, cancellationToken).ConfigureAwait(false);

                switch (processResult)
                {
                    case HttpStatusCode.NotFound:
                        throw new ApiException(404, "Process Not Found. Probably it has been started in another session.");
                    case HttpStatusCode.NoContent:
                        return;
                    case HttpStatusCode.Accepted:
                        if ((startTime - DateTime.Now).Seconds > secondsTimeout)
                        {
                            throw new TimeoutException();
                        }
                        else
                        {
                            await Task.Delay(millisecondsInterval).ConfigureAwait(false);
                            continue;
                        }
                    default:
                        throw new InvalidOperationException($"Process status: {processResult}");
                }
            }
        }

        /// <summary>
        /// Queries the system with the specified <paramref name="millisecondsInterval"/> 
        /// to get status of a running operation
        /// untill the operation status is Completed.
        /// </summary>
        /// <param name="location">
        /// Value of the Location header returned 
        /// from <see cref=" InvokeAction{EntityType}(ApiClient, EntityAction{EntityType}, string?, DateTime?, string?)"/> or
        /// <see cref="InvokeActionAsync{EntityType}(ApiClient, EntityAction{EntityType}, string?, DateTime?, string?)"/>
        /// </param>
        /// <param name="millisecondsInterval">
        /// Time that the system waits between querying for the operation status in milliseconds.
        /// Default value is <c>1000</c>.
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// Throws the the exception if the operation finishes with a status code not indicating 
        /// successful completion.
        /// </exception>
        public static void WaitActionCompletion(this ApiClient client, string location, int millisecondsInterval = 1000)
        {
            WaitActionCompletionAsync(client, location, millisecondsInterval).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the status of an operation started by invoking an action.
        /// </summary>
        /// <param name="location">
        /// Value of the Location header returned 
        /// from <see cref="InvokeAction{EntityType}(ApiClient, EntityAction{EntityType}, string?, DateTime?, string?)"/> or
        /// <see cref="InvokeActionAsync{EntityType}(ApiClient, EntityAction{EntityType}, string?, DateTime?, string?)"/>
        /// </param>
        /// <returns>Returns HTTP status code of the running operation.</returns>
        public static HttpStatusCode GetProcessStatus(this ApiClient client, string location)
        {
            return GetProcessStatusAsync(client, location).GetAwaiter().GetResult();
        }
        /// <summary>
        /// Gets the status of an operation started by invoking an action.
        /// </summary>
        /// <param name="location">
        /// Value of the Location header returned 
        /// from <see cref="InvokeAction{EntityType}(ApiClient, EntityAction{EntityType}, string?, DateTime?, string?)"/> or
        /// <see cref="InvokeActionAsync{EntityType}(ApiClient, EntityAction{EntityType}, string?, DateTime?, string?)"/>
        /// </param>
        /// <returns>Returns HTTP status code of the running operation.</returns>
        public static async Task<HttpStatusCode> GetProcessStatusAsync(this ApiClient client, string location, CancellationToken cancellationToken = default)
        {
            if (location == null)
                ThrowMissingParameter(nameof(GetProcessStatusAsync), nameof(location));

            var parsedLocation = UrlParser.ParseActionLocation(location!);
            if (parsedLocation.ActionName == null)
                return HttpStatusCode.NoContent;

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"/entity/{parsedLocation.EndpointName}/{parsedLocation.EndpointVersion}/{parsedLocation.EntityName}/{parsedLocation.ActionName}/{parsedLocation.Status}/{parsedLocation.ID}",
                method:             HttpMethod.Get, 
                acceptType:         HeaderContentType.Json, 
                contentType:        HeaderContentType.None,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(GetProcessStatusAsync)).ConfigureAwait(false);

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
            string? endpointPath = null,
            string? select = null, string? filter = null, string? expand = null, string? custom = null,
            PutMethod method = PutMethod.Any, DateTime? businessDate = null, string? branch = null)
            where EntityType : Entity, ITopLevelEntity
        {
            return PutAsync(client, entity, endpointPath, select, filter, expand, custom, method, businessDate, branch).GetAwaiter().GetResult();
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
            string? endpointPath = null,
            string? select = null, string? filter = null, string? expand = null, string? custom = null,
            PutMethod method = PutMethod.Any, DateTime? businessDate = null, string? branch = null,
            CancellationToken cancellationToken = default)
            where EntityType : Entity, ITopLevelEntity
        {
            if (entity == null)
                ThrowMissingParameter(nameof(PutAsync), nameof(entity));
            if (endpointPath == null)
                endpointPath = GetEndpointPath(entity!);

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"{endpointPath}/{GetEntityName(entity!)}",
                method:             HttpMethod.Put,
                acceptType:         HeaderContentType.Json,
                contentType:        HeaderContentType.Json,
                body:               entity,
                queryParams:        ComposeQueryParams(select, filter, expand, custom),
                customHeaders:      ComposePutHeaders(method, businessDate, branch),
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync<EntityType>(response, nameof(PutAsync)).ConfigureAwait(false);

            return await DeserializeAsync<EntityType>(response).ConfigureAwait(false);
        }
        #endregion
        #region PutFile
        /// <summary>
        /// Attaches a file to a record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> The id of the record.</param>
        /// <param name="filename">The name of the file that you are going to attach with the extension.</param>
        [Obsolete("Use Acumatica.RESTClient.FileApi.FileApi.PutFile method instead")]
        public static void PutFile<EntityType>(
            this ApiClient client, string id, string filename, byte[] content,
            string? endpointPath = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            PutFileAsync<EntityType>(client, new List<string>() { id }, filename, content, endpointPath).GetAwaiter().GetResult();
        }
        /// <summary>
        /// Attaches a file to a record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The id of the record.</param>
        /// <param name="filename">The name of the file that you are going to attach with the extension.</param>
        [Obsolete("Use Acumatica.RESTClient.FileApi.FileApi.PutFileAsync method instead")]
        public static async Task PutFileAsync<EntityType>(
            this ApiClient client, string id, string filename, byte[] content,
            string? endpointPath = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            await PutFileAsync<EntityType>(client, new List<string>() { id }, filename, content, endpointPath).ConfigureAwait(false);
        }
        /// <summary>
        /// Attaches a file to a record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <param name="filename">The name of the file that you are going to attach with the extension.</param>
        [Obsolete("Use Acumatica.RESTClient.FileApi.FileApi.PutFile method instead")]
        public static void PutFile<EntityType>(
            this ApiClient client, IEnumerable<string> ids, string filename, byte[] content,
            string? endpointPath = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            PutFileAsync<EntityType>(client, ids, filename, content, endpointPath).GetAwaiter().GetResult();
        }
        /// <summary>
        /// Attaches a file to a record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <param name="filename">The name of the file that you are going to attach with the extension.</param>
        [Obsolete("Use Acumatica.RESTClient.FileApi.FileApi.PutFileAsync method instead")]
        public static async Task PutFileAsync<EntityType>(
            this ApiClient client, IEnumerable<string> ids, string filename, byte[] content,
            string? endpointPath = null, 
            CancellationToken cancellationToken = default)
            where EntityType : ITopLevelEntity, new()
        {
            if (ids == null)
                ThrowMissingParameter(nameof(PutFileAsync), nameof(ids));
            if (filename == null)
                ThrowMissingParameter(nameof(PutFileAsync), nameof(filename));
            if (endpointPath == null)
                endpointPath = GetEndpointPath<EntityType>();

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"{endpointPath}/{GetEntityName(typeof(EntityType))}/{string.Join("/", ids)}/files/{filename}",
                method:             HttpMethod.Put,
                acceptType:         HeaderContentType.Json,
                contentType:        HeaderContentType.OctetStream,
                body:               content,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(PutFileAsync)).ConfigureAwait(false);
        }
        #endregion
        #region Get
        /// <summary>
        /// Retrieves a record by the values of its key fields from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The values of the key field of the record.</param>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <returns>Task of Entity</returns>
        public static async Task<EntityType> GetByKeysAsync<EntityType>(
            this ApiClient client, string key,
            string? endpointPath = null,
            string? select = null, string? expand = null, string? custom = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            return await GetByKeysAsync<EntityType>(client, new List<string> { key }, endpointPath, select, expand, custom).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves a record by the values of its key fields from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <returns>Task of Entity</returns>
        public static async Task<EntityType> GetByKeysAsync<EntityType>(
                this ApiClient client, IEnumerable<string> ids,
                string? endpointPath = null,
                string? select = null, string? expand = null, string? custom = null,
                CancellationToken cancellationToken = default)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            if (ids == null)
                ThrowMissingParameter(nameof(GetByKeysAsync), nameof(ids));
            if (endpointPath == null)
                endpointPath = GetEndpointPath<EntityType>();

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"{endpointPath}/{GetEntityName(typeof(EntityType))}/{string.Join("/", ids)}", 
                method:             HttpMethod.Get, 
                queryParams:        ComposeQueryParams(select, null, expand, custom), 
                acceptType:         HeaderContentType.Json, 
                contentType:        HeaderContentType.None,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(GetByKeysAsync)).ConfigureAwait(false);

            return await DeserializeAsync<EntityType>(response).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves a record by the values of its key fields from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">The value of the key field of the record.</param>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <returns>Entity</returns>
        public static EntityType GetByKeys<EntityType>(
            this ApiClient client, string key,
            string? endpointPath = null,
            string? select = null, string? expand = null, string? custom = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            return GetByKeysAsync<EntityType>(client, key, endpointPath, select, expand, custom).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieves a record by the values of its key fields from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <returns>Entity</returns>
        public static EntityType GetByKeys<EntityType>(
            this ApiClient client, IEnumerable<string> ids,
            string? endpointPath = null,
            string? select = null, string? expand = null, string? custom = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            return GetByKeysAsync<EntityType>(client, ids, endpointPath, select, expand, custom).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieves a record by the value of the session entity ID from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="entity">The record from which the ID will be taken.</param>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <returns>Task of Entity</returns>
        public static async Task<EntityType> GetByIdAsync<EntityType>(
            this ApiClient client, EntityType entity,
            string? endpointPath = null,
            string? select = null, string? expand = null, string? custom = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            if (entity == null)
                ThrowMissingParameter(nameof(GetById), nameof(entity));
            if (entity!.ID == null)
                ThrowMissingParameter(nameof(GetById), nameof(entity.ID));
            return await GetByIdAsync<EntityType>(client, entity.ID, endpointPath, select, expand, custom).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves a record by the value of the session entity ID from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <returns>Task of Entity</returns>
        public static async Task<EntityType> GetByIdAsync<EntityType>(
                this ApiClient client, 
                Guid? id,
                string? endpointPath = null,
                string? select = null, string? expand = null, string? custom = null,
                CancellationToken cancellationToken = default)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            if (id == null)
                ThrowMissingParameter(nameof(GetByIdAsync), nameof(id));
            if (endpointPath == null)
                endpointPath = GetEndpointPath<EntityType>();

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"{endpointPath}/{GetEntityName(typeof(EntityType))}/{id}", 
                method:             HttpMethod.Get, 
                acceptType:         HeaderContentType.Json, 
                contentType:        HeaderContentType.None,
                queryParams:        ComposeQueryParams(select, null, expand, custom),
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(GetByIdAsync)).ConfigureAwait(false);

            return await DeserializeAsync<EntityType>(response).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves a record by the value of the session entity ID from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <returns>Entity</returns>
        public static EntityType GetById<EntityType>(this ApiClient client, EntityType entity,
            string? endpointPath = null,
            string? select = null, string? expand = null, string? custom = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            return GetByIdAsync<EntityType>(client, entity, endpointPath, select, expand, custom).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Retrieves a record by the value of the session entity ID from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <param name="select">The fields of the entity to be returned from the system. (optional)</param>
        /// <param name="expand">The linked and detail entities that should be expanded. (optional)</param>
        /// <param name="custom">The fields that are not defined in the contract of the endpoint to be returned from the system. (optional)</param>
        /// <returns>Entity</returns>
        public static EntityType GetById<EntityType>(this ApiClient client, Guid? id,
            string? endpointPath = null,
            string? select = null, string? expand = null, string? custom = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            return GetByIdAsync<EntityType>(client, id, endpointPath, select, expand, custom).GetAwaiter().GetResult();
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
                string? endpointPath = null,
                string? select = null, string? filter = null, string? expand = null, string? custom = null,
                int? skip = null, int? top = null, Dictionary<string, string>? customHeaders = null, 
                CancellationToken cancellationToken = default)
            where EntityType : ITopLevelEntity, new()
        {

            if (endpointPath == null)
                endpointPath = GetEndpointPath<EntityType>();

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"{endpointPath}/{GetEntityName(typeof(EntityType))}",
                method:             HttpMethod.Get,
                acceptType:         HeaderContentType.Json,
                contentType:        HeaderContentType.None,
                queryParams:        ComposeQueryParams(select, filter, expand, custom, skip, top),
                customHeaders:      customHeaders, 
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(GetListAsync)).ConfigureAwait(false);

            return await DeserializeAsync<List<EntityType>>(response).ConfigureAwait(false);
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
            string? endpointPath = null,
            string? select = null, string? filter = null, string? expand = null, string? custom = null,
            int? skip = null, int? top = null, Dictionary<string, string>? customHeaders = null)
            where EntityType : ITopLevelEntity, new()
        {
            return GetListAsync<EntityType>(client, endpointPath, select, filter, expand, custom, skip, top, customHeaders).GetAwaiter().GetResult();
        }
        #endregion
        #region GetSchema

        public static string GetSwagger(this ApiClient client, string endpointPath)
        {
            return GetSwaggerAsync(client, endpointPath).GetAwaiter().GetResult();
        }
        public async static Task<string> GetSwaggerAsync(this ApiClient client, string endpointPath, CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"{endpointPath}/swagger.json",
                method:             HttpMethod.Get,
                acceptType:         HeaderContentType.Json,
                contentType:        HeaderContentType.None, 
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(GetSwaggerAsync)).ConfigureAwait(false);

            return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves the schema of custom fields of the entity from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Entity</returns>
        public async static Task<EntityType> GetAdHocSchemaAsync<EntityType>(this ApiClient client,
                string? endpointPath = null, 
                CancellationToken cancellationToken = default)
            where EntityType : Entity, ITopLevelEntity, new()
        {

            if (endpointPath == null)
                endpointPath = GetEndpointPath<EntityType>();

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"{endpointPath}/{GetEntityName(typeof(EntityType))}/$adHocSchema",
                method:             HttpMethod.Get,
                acceptType:         HeaderContentType.Json,
                contentType:        HeaderContentType.None, 
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(GetAdHocSchemaAsync)).ConfigureAwait(false);

            return await DeserializeAsync<EntityType>(response).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves the schema of custom fields of the entity from the system. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>Entity</returns>
        public static EntityType GetAdHocSchema<EntityType>(this ApiClient client,
            string? endpointPath = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            return GetAdHocSchemaAsync<EntityType>(client, endpointPath).GetAwaiter().GetResult();
        }
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the record by the values of its key fields. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <returns></returns>
        public static void DeleteByKeys<EntityType>(this ApiClient client, IEnumerable<string> ids,
            string? endpointPath = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            DeleteByKeysAsync<EntityType>(client, ids, endpointPath).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes the record by the values of its key fields. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids">The values of the key fields of the record.</param>
        /// <returns>Task of void</returns>
        public static async Task DeleteByKeysAsync<EntityType>(this ApiClient client, IEnumerable<string> ids,
                string? endpointPath = null,
                CancellationToken cancellationToken = default)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            if (ids == null)
                ThrowMissingParameter(nameof(DeleteByKeysAsync), nameof(ids));

            if (endpointPath == null)
                endpointPath = GetEndpointPath<EntityType>();

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"{endpointPath}/{GetEntityName(typeof(EntityType))}/{string.Join("/", ids)}",
                method:             HttpMethod.Delete,
                acceptType:         HeaderContentType.Any,
                contentType:        HeaderContentType.None,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(DeleteByKeysAsync)).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="entity">The record.</param>
        public static void Delete<EntityType>(
            this ApiClient client, EntityType entity,
            string? endpointPath = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            DeleteAsync(client, entity, endpointPath).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes the record. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="entity">The record.</param>
        public static async Task DeleteAsync<EntityType>(
                this ApiClient client, EntityType entity,
                string? endpointPath = null, 
                CancellationToken cancellationToken = default)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            if (entity == null || entity.ID == null)
                ThrowMissingParameter(nameof(DeleteAsync), nameof(entity));


            if (endpointPath == null)
                endpointPath = GetEndpointPath(entity!);

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"{endpointPath}/{GetEntityName(typeof(EntityType))}/{entity!.ID}",
                method:             HttpMethod.Delete,
                acceptType:         HeaderContentType.Any,
                contentType:        HeaderContentType.None, 
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(DeleteAsync)).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the record by its session identifier. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <returns></returns>
        public static void DeleteById<EntityType>(this ApiClient client, Guid? id,
            string? endpointPath = null)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            DeleteByIdAsync<EntityType>(client, id, endpointPath).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deletes the record by its session identifier. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The session ID of the record.</param>
        /// <returns>Task of void</returns>
        public static async Task DeleteByIdAsync<EntityType>(this ApiClient client, Guid? id,
            string? endpointPath = null,
            CancellationToken cancellationToken = default)
            where EntityType : Entity, ITopLevelEntity, new()
        {
            if (id == null)
                ThrowMissingParameter(nameof(DeleteByIdAsync), nameof(id));
            if (endpointPath == null)
                endpointPath = GetEndpointPath<EntityType>();

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       $"{endpointPath}/{GetEntityName(typeof(EntityType))}/{id}",
                method:             HttpMethod.Delete,
                acceptType:         HeaderContentType.Any,
                contentType:        HeaderContentType.None,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(DeleteByIdAsync)).ConfigureAwait(false);
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
        private static async Task VerifyResponseAsync(HttpResponseMessage response, string methodName)
        {
            if (!response.IsSuccessStatusCode)
            {
                string? responseMessage = null;
                if (string.IsNullOrEmpty(responseMessage))
                {
                    responseMessage = await GetErrorMessageFromErrorAsync(response).ConfigureAwait(false);
                }
                if (string.IsNullOrEmpty(responseMessage))
                {
                    responseMessage = await GetErrorMessageFromErrorAsync(response).ConfigureAwait(false);
                }
                if (string.IsNullOrEmpty(responseMessage))
                {
                    //it should be html at that point
                    //remove tags from html
                    responseMessage = System.Text.RegularExpressions.Regex.Replace((await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Replace('\r', ' ').Replace('\n', ' '), "<.*?>", string.Empty);
                }
                throw new ApiException(
                  (int)response.StatusCode,
                  $"Error {(int)response.StatusCode} calling {methodName}: {response.ReasonPhrase} \r\n {responseMessage}");
            }
        }

        private static async Task<string?> GetErrorMessageFromErrorAsync(HttpResponseMessage response)
        {
            string? responseMessage = null;
            try
            {
                ErrorMessage? error = await DeserializeAsync<ErrorMessage>(response).ConfigureAwait(false);
                if (error == null || (String.IsNullOrEmpty(error.message) && String.IsNullOrEmpty(error.exceptionMessage)))
                {
                }
                else
                {
                    responseMessage = $"{error.message} : {error.exceptionMessage} : {error.innerException}";
                }
            }
            catch (Newtonsoft.Json.JsonReaderException) { }

            return responseMessage;
        }

        private static async Task VerifyResponseAsync<EntityType>(HttpResponseMessage response, string methodName)
            where EntityType : Entity
        {
            if (!response.IsSuccessStatusCode)
            {
                string? responseMessage = null;
                responseMessage = await GetErrorMessageFromEntityAsync<EntityType>(response).ConfigureAwait(false);
                if (string.IsNullOrEmpty(responseMessage))
                {
                    responseMessage = await GetErrorMessageFromErrorAsync(response).ConfigureAwait(false);
                }
                if (string.IsNullOrEmpty(responseMessage))
                {
                    //it should be html at that point
                    responseMessage = await GetErrorMessageFromHTMLAsync(response).ConfigureAwait(false);
                }
                throw new ApiException(
                  (int)response.StatusCode,
                  $"Error {(int)response.StatusCode} calling {methodName}: {response.ReasonPhrase} \r\n {responseMessage}");
            }
        }

        private static async Task<string> GetErrorMessageFromHTMLAsync(HttpResponseMessage response)
        {
            //remove tags from html
            return System.Text.RegularExpressions.Regex.Replace((await response.Content.ReadAsStringAsync().ConfigureAwait(false)).Replace('\r', ' ').Replace('\n', ' '), "<.*?>", string.Empty);
        }

        private static async Task<string?> GetErrorMessageFromEntityAsync<EntityType>(HttpResponseMessage response)
            where EntityType : Entity
        {
            string? responseMessage = null;
            try
            {
                EntityType? entity = await DeserializeAsync<EntityType>(response).ConfigureAwait(false);
                responseMessage = CollectErrorsFromEntity(entity);
            }
            catch (Newtonsoft.Json.JsonReaderException) { }

            return responseMessage;
        }

        private static string? CollectErrorsFromEntity(Entity? entity)
        {
            if (entity == null)
            {
                return null;
            }

            StringBuilder responseMessage = new StringBuilder();
            responseMessage.Append(entity.Error);
            foreach (var field in entity.GetType().GetProperties())
            {
                if (typeof(RestFieldWithError).IsAssignableFrom(field.PropertyType))
                {
                    string? errorMessage = (field.GetValue(entity) as RestFieldWithError)?.Error;
                    if (errorMessage != null)
                    {
                        responseMessage.Append($"\r\n{field.Name} : {errorMessage}");
                    }
                }
                else if (IsDetail(field))
                {
                    if (field.GetValue(entity) is System.Collections.IEnumerable detailList)
                    {
                        foreach (var line in detailList)
                        {
                            if (line is Entity lineEntity)
                            {
                                var errors = CollectErrorsFromEntity(lineEntity);
                                if (!String.IsNullOrWhiteSpace(errors))
                                {
                                    responseMessage.Append($"\r\n{field.Name}[{lineEntity.ID}]:{{{errors}}}");
                                }
                            }
                        }
                    }
                }
                else if (IsLinkedEntity(field))
                {
                    if (field.GetValue(entity) is Entity linkedEntity)
                    {
                        responseMessage.Append(CollectErrorsFromEntity(linkedEntity));
                    }
                }
            }
            return responseMessage.ToString();
        }
        #endregion

        #region Put
        private static Dictionary<string, string> ComposePutHeaders(PutMethod method, DateTime? businessDate, string? branch)
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
                headers.Add("PX-CbApiBusinessDate", businessDate.Value.ToString(System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat));
            }
            if (!String.IsNullOrEmpty(branch))
            {
                headers.Add("PX-CbApiBranch", branch!);
            }

            return headers;
        }
        #endregion
        #endregion
    }
}
