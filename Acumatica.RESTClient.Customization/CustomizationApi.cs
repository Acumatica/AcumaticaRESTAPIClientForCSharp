using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.CustomizationApi.Model;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;


namespace Acumatica.RESTClient.CustomizationApi
{
    /// <summary>
    /// Represents a collection of functions to interact with the Customization API:
    /// importing, downloading and deleting customization projects, and publishing them.
    /// </summary>
    public static class CustomizationApiExtensions
    {
        #region Import
        /// <summary>
        /// Uploads a customization package to the site.
        /// </summary>
        /// <param name="client">The API client.</param>
        /// <param name="customizationPackageContent">The content of the customization package (a zip archive).</param>
        /// <param name="projectName">Name of the customization project to create or replace.</param>
        /// <param name="projectDescription">Description of the customization project.</param>
        /// <param name="replaceIfExists">
        /// Indicates whether an existing project with the same name should be replaced.
        /// </param>
        /// <param name="level">The level of the customization project.</param>
        /// <param name="cancellationToken">Token to cancel the call.</param>
        /// <returns>The log of the operation.</returns>
        public static async Task<CustomizationResult> ImportAsync(this ApiClient client,
            Stream customizationPackageContent,
            string projectName,
            string projectDescription = "",
            bool replaceIfExists = true,
            int? level = null,
            CancellationToken cancellationToken = default)
        {
            if (customizationPackageContent == null)
                ThrowMissingParameter(nameof(ImportAsync), nameof(customizationPackageContent));
            if (projectName == null)
                ThrowMissingParameter(nameof(ImportAsync), nameof(projectName));

            var customizationImport = new CustomizationImport
            {
                ProjectName = projectName,
                ProjectDescription = projectDescription,
                ProjectLevel = level,
                IsReplaceIfExists = replaceIfExists,
                ProjectContentBase64 = await ReadAsBase64Async(customizationPackageContent!, cancellationToken).ConfigureAwait(false)
            };

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       "/CustomizationApi/Import",
                method:             HttpMethod.Post,
                acceptType:         HeaderContentType.Json,
                contentType:        HeaderContentType.Json,
                body:               customizationImport,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(ImportAsync)).ConfigureAwait(false);
            return await DeserializeRequiredAsync<CustomizationResult>(response, nameof(ImportAsync)).ConfigureAwait(false);
        }

        /// <inheritdoc cref="ImportAsync"/>
        public static CustomizationResult Import(this ApiClient client,
            Stream customizationPackageContent,
            string projectName,
            string projectDescription = "",
            bool replaceIfExists = true,
            int? level = null)
        {
            return ImportAsync(client, customizationPackageContent, projectName, projectDescription, replaceIfExists, level).GetAwaiter().GetResult();
        }
        #endregion

        #region Publish Begin
        /// <summary>
        /// Starts publishing of a single customization project. By default, the project is published
        /// together with the projects that are already published.
        /// </summary>
        /// <param name="client">The API client.</param>
        /// <param name="projectName">Name of the customization project to publish.</param>
        /// <param name="isMergeWithExistingPackages">
        /// Indicates whether the project should be published together with the currently published projects.
        /// If <c>false</c>, only this project is published. The default is <c>true</c>.
        /// </param>
        /// <param name="isOnlyValidation">Indicates whether only project validation should be performed.</param>
        /// <param name="isOnlyDbUpdates">
        /// Indicates whether the changes should be applied only to the database.
        /// Corresponds to the Apply Changes Only to Database check box in the UI.
        /// </param>
        /// <param name="isReplayPreviouslyExecutedScripts">
        /// Indicates whether database scripts that were previously applied should be executed again.
        /// Corresponds to the Execute All Database Scripts (Including Previously Executed) check box
        /// and the Publish with Clean Up menu command in the UI.
        /// </param>
        /// <param name="tenantMode">The tenants to publish the project for.</param>
        /// <param name="tenantLoginNames">
        /// The login names of the tenants to publish for. Required if <paramref name="tenantMode"/> is
        /// <see cref="TenantMode.List"/>, and must be omitted otherwise.
        /// </param>
        /// <param name="cancellationToken">Token to cancel the call.</param>
        /// <returns>
        /// If successful, the log contains the message "Publishing has started."
        /// Use <see cref="WaitPublishingCompletionAsync"/> to wait until the publishing is finished.
        /// </returns>
        public static async Task<CustomizationResult> PublishBeginAsync(this ApiClient client,
            string projectName,
            bool isMergeWithExistingPackages = true,
            bool isOnlyValidation = false,
            bool isOnlyDbUpdates = false,
            bool isReplayPreviouslyExecutedScripts = false,
            TenantMode tenantMode = TenantMode.Current,
            IEnumerable<string>? tenantLoginNames = null,
            CancellationToken cancellationToken = default)
        {
            if (projectName == null)
                ThrowMissingParameter(nameof(PublishBeginAsync), nameof(projectName));

            return await PublishBeginAsync(client,
                new List<string> { projectName! },
                isMergeWithExistingPackages,
                isOnlyValidation,
                isOnlyDbUpdates,
                isReplayPreviouslyExecutedScripts,
                tenantMode,
                tenantLoginNames,
                cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc cref="PublishBeginAsync(ApiClient, string, bool, bool, bool, bool, TenantMode, IEnumerable{string}, CancellationToken)"/>
        public static CustomizationResult PublishBegin(this ApiClient client,
            string projectName,
            bool isMergeWithExistingPackages = true,
            bool isOnlyValidation = false,
            bool isOnlyDbUpdates = false,
            bool isReplayPreviouslyExecutedScripts = false,
            TenantMode tenantMode = TenantMode.Current,
            IEnumerable<string>? tenantLoginNames = null)
        {
            return PublishBeginAsync(client, projectName, isMergeWithExistingPackages, isOnlyValidation,
                isOnlyDbUpdates, isReplayPreviouslyExecutedScripts, tenantMode, tenantLoginNames).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Starts publishing of multiple customization projects. By default, exactly the listed projects
        /// are published and the projects that are currently published are replaced.
        /// </summary>
        /// <param name="client">The API client.</param>
        /// <param name="projectNames">Names of the customization projects to publish.</param>
        /// <param name="isMergeWithExistingPackages">
        /// Indicates whether the listed projects should be published together with the currently published projects.
        /// If <c>false</c>, only the listed projects are published. The default is <c>false</c>.
        /// </param>
        /// <param name="isOnlyValidation">Indicates whether only project validation should be performed.</param>
        /// <param name="isOnlyDbUpdates">
        /// Indicates whether the changes should be applied only to the database.
        /// Corresponds to the Apply Changes Only to Database check box in the UI.
        /// </param>
        /// <param name="isReplayPreviouslyExecutedScripts">
        /// Indicates whether database scripts that were previously applied should be executed again.
        /// Corresponds to the Execute All Database Scripts (Including Previously Executed) check box
        /// and the Publish with Clean Up menu command in the UI.
        /// </param>
        /// <param name="tenantMode">The tenants to publish the projects for.</param>
        /// <param name="tenantLoginNames">
        /// The login names of the tenants to publish for. Required if <paramref name="tenantMode"/> is
        /// <see cref="TenantMode.List"/>, and must be omitted otherwise.
        /// </param>
        /// <param name="cancellationToken">Token to cancel the call.</param>
        /// <returns>
        /// If successful, the log contains the message "Publishing has started."
        /// Use <see cref="WaitPublishingCompletionAsync"/> to wait until the publishing is finished.
        /// </returns>
        public static async Task<CustomizationResult> PublishBeginAsync(this ApiClient client,
            IEnumerable<string> projectNames,
            bool isMergeWithExistingPackages = false,
            bool isOnlyValidation = false,
            bool isOnlyDbUpdates = false,
            bool isReplayPreviouslyExecutedScripts = false,
            TenantMode tenantMode = TenantMode.Current,
            IEnumerable<string>? tenantLoginNames = null,
            CancellationToken cancellationToken = default)
        {
            if (projectNames == null)
                ThrowMissingParameter(nameof(PublishBeginAsync), nameof(projectNames));

            List<string>? tenants = ResolveTenants(tenantMode, tenantLoginNames, nameof(PublishBeginAsync));

            var publishParams = new CustomizationPublishParams
            {
                ProjectNames = projectNames!.ToList(),
                IsMergeWithExistingPackages = isMergeWithExistingPackages,
                IsOnlyValidation = isOnlyValidation,
                IsOnlyDbUpdates = isOnlyDbUpdates,
                IsReplayPreviouslyExecutedScripts = isReplayPreviouslyExecutedScripts,
                TenantMode = ToApiValue(tenantMode),
                TenantLoginNames = tenants
            };

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       "/CustomizationApi/PublishBegin",
                method:             HttpMethod.Post,
                acceptType:         HeaderContentType.Json,
                contentType:        HeaderContentType.Json,
                body:               publishParams,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(PublishBeginAsync)).ConfigureAwait(false);
            return await DeserializeRequiredAsync<CustomizationResult>(response, nameof(PublishBeginAsync)).ConfigureAwait(false);
        }

        /// <inheritdoc cref="PublishBeginAsync(ApiClient, IEnumerable{string}, bool, bool, bool, bool, TenantMode, IEnumerable{string}, CancellationToken)"/>
        public static CustomizationResult PublishBegin(this ApiClient client,
            IEnumerable<string> projectNames,
            bool isMergeWithExistingPackages = false,
            bool isOnlyValidation = false,
            bool isOnlyDbUpdates = false,
            bool isReplayPreviouslyExecutedScripts = false,
            TenantMode tenantMode = TenantMode.Current,
            IEnumerable<string>? tenantLoginNames = null)
        {
            return PublishBeginAsync(client, projectNames, isMergeWithExistingPackages, isOnlyValidation,
                isOnlyDbUpdates, isReplayPreviouslyExecutedScripts, tenantMode, tenantLoginNames).GetAwaiter().GetResult();
        }
        #endregion

        #region Publish End
        /// <summary>
        /// Gets the current state of the publishing that was started with <c>PublishBegin</c>.
        /// </summary>
        /// <param name="client">The API client.</param>
        /// <param name="cancellationToken">Token to cancel the call.</param>
        /// <returns>
        /// The state of the publishing: whether it is completed, whether it failed, and the log so far.
        /// </returns>
        public static async Task<CustomizationPublishEnd> PublishEndAsync(this ApiClient client, CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       "/CustomizationApi/PublishEnd",
                method:             HttpMethod.Post,
                acceptType:         HeaderContentType.Json,
                contentType:        HeaderContentType.Json,
                body:               new Dictionary<string, object>(), // the server rejects a request without a body (415)
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(PublishEndAsync)).ConfigureAwait(false);
            return await DeserializeRequiredAsync<CustomizationPublishEnd>(response, nameof(PublishEndAsync)).ConfigureAwait(false);
        }

        /// <inheritdoc cref="PublishEndAsync"/>
        public static CustomizationPublishEnd PublishEnd(this ApiClient client)
        {
            return PublishEndAsync(client).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Waits until the publishing started with <c>PublishBegin</c> is finished,
        /// checking its state at the given interval.
        /// </summary>
        /// <param name="client">The API client.</param>
        /// <param name="pollingInterval">How often to check the state of the publishing. The default is one second.</param>
        /// <param name="timeout">How long to wait at most. If omitted, waits until the publishing finishes.</param>
        /// <param name="cancellationToken">Token to cancel the waiting.</param>
        /// <exception cref="CustomizationPublishException">The publishing failed. The exception contains the log.</exception>
        /// <exception cref="TimeoutException">The publishing did not finish within <paramref name="timeout"/>.</exception>
        public static async Task WaitPublishingCompletionAsync(this ApiClient client,
            TimeSpan? pollingInterval = null,
            TimeSpan? timeout = null,
            CancellationToken cancellationToken = default)
        {
            TimeSpan interval = pollingInterval ?? TimeSpan.FromSeconds(1);
            if (interval <= TimeSpan.Zero)
                throw new ArgumentOutOfRangeException(nameof(pollingInterval), "The polling interval must be positive.");

            var stopwatch = Stopwatch.StartNew();
            while (true)
            {
                CustomizationPublishEnd state = await client.PublishEndAsync(cancellationToken).ConfigureAwait(false);

                // A failure is checked first: a failed publishing must never be reported as a success.
                if (state.IsFailed == true)
                    throw new CustomizationPublishException(state.Log);
                if (state.IsCompleted == true)
                    return;

                TimeSpan delay = interval;
                if (timeout.HasValue)
                {
                    TimeSpan remaining = timeout.Value - stopwatch.Elapsed;
                    if (remaining <= TimeSpan.Zero)
                        throw new TimeoutException($"Publishing did not finish within {timeout.Value}.");
                    if (remaining < delay)
                        delay = remaining;
                }
                await Task.Delay(delay, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc cref="WaitPublishingCompletionAsync"/>
        /// <param name="client">The API client.</param>
        /// <param name="millisecondsInterval">How often to check the state of the publishing, in milliseconds.</param>
        /// <param name="millisecondsTimeout">How long to wait at most, in milliseconds. If omitted, waits until the publishing finishes.</param>
        public static void WaitPublishingCompletion(this ApiClient client, int millisecondsInterval = 1000, int? millisecondsTimeout = null)
        {
            WaitPublishingCompletionAsync(
                client,
                TimeSpan.FromMilliseconds(millisecondsInterval),
                millisecondsTimeout.HasValue ? TimeSpan.FromMilliseconds(millisecondsTimeout.Value) : (TimeSpan?)null
            ).GetAwaiter().GetResult();
        }
        #endregion

        #region Get Published
        /// <summary>
        /// Gets the customization projects and items that are currently published.
        /// </summary>
        /// <param name="client">The API client.</param>
        /// <param name="cancellationToken">Token to cancel the call.</param>
        /// <returns>The published projects and the items they contain.</returns>
        public static async Task<CustomizationPublished> GetPublishedAsync(this ApiClient client, CancellationToken cancellationToken = default)
        {
            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       "/CustomizationApi/GetPublished",
                method:             HttpMethod.Post,
                acceptType:         HeaderContentType.Json,
                contentType:        HeaderContentType.Json,
                body:               new Dictionary<string, object>(),
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(GetPublishedAsync)).ConfigureAwait(false);
            return await DeserializeRequiredAsync<CustomizationPublished>(response, nameof(GetPublishedAsync)).ConfigureAwait(false);
        }

        /// <inheritdoc cref="GetPublishedAsync"/>
        public static CustomizationPublished GetPublished(this ApiClient client)
        {
            return GetPublishedAsync(client).GetAwaiter().GetResult();
        }
        #endregion

        #region Get Project
        /// <summary>
        /// Downloads a customization project as a customization package.
        /// </summary>
        /// <param name="client">The API client.</param>
        /// <param name="projectName">Name of the customization project to download.</param>
        /// <param name="isAutoResolveConflicts">Indicates whether conflicts should be resolved automatically.</param>
        /// <param name="cancellationToken">Token to cancel the call.</param>
        /// <returns>
        /// The project. Use <see cref="CustomizationProject.GetContent"/> to get the package as bytes.
        /// </returns>
        public static async Task<CustomizationProject> GetProjectAsync(this ApiClient client,
            string projectName,
            bool isAutoResolveConflicts = false,
            CancellationToken cancellationToken = default)
        {
            if (projectName == null)
                ThrowMissingParameter(nameof(GetProjectAsync), nameof(projectName));

            var getProjectParams = new CustomizationGetProjectParams
            {
                ProjectName = projectName,
                IsAutoResolveConflicts = isAutoResolveConflicts
            };

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       "/CustomizationApi/GetProject",
                method:             HttpMethod.Post,
                acceptType:         HeaderContentType.Json,
                contentType:        HeaderContentType.Json,
                body:               getProjectParams,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(GetProjectAsync)).ConfigureAwait(false);
            return await DeserializeRequiredAsync<CustomizationProject>(response, nameof(GetProjectAsync)).ConfigureAwait(false);
        }

        /// <inheritdoc cref="GetProjectAsync"/>
        public static CustomizationProject GetProject(this ApiClient client, string projectName, bool isAutoResolveConflicts = false)
        {
            return GetProjectAsync(client, projectName, isAutoResolveConflicts).GetAwaiter().GetResult();
        }
        #endregion

        #region Delete Project
        /// <summary>
        /// Deletes a customization project from the site.
        /// </summary>
        /// <param name="client">The API client.</param>
        /// <param name="projectName">Name of the customization project to delete.</param>
        /// <param name="cancellationToken">Token to cancel the call.</param>
        /// <returns>The log of the operation.</returns>
        public static async Task<CustomizationResult> DeleteProjectAsync(this ApiClient client,
            string projectName,
            CancellationToken cancellationToken = default)
        {
            if (projectName == null)
                ThrowMissingParameter(nameof(DeleteProjectAsync), nameof(projectName));

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       "/CustomizationApi/Delete",
                method:             HttpMethod.Post,
                acceptType:         HeaderContentType.Json,
                contentType:        HeaderContentType.Json,
                body:               new CustomizationDeleteParams { ProjectName = projectName },
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(DeleteProjectAsync)).ConfigureAwait(false);
            return await DeserializeRequiredAsync<CustomizationResult>(response, nameof(DeleteProjectAsync)).ConfigureAwait(false);
        }

        /// <inheritdoc cref="DeleteProjectAsync"/>
        public static CustomizationResult DeleteProject(this ApiClient client, string projectName)
        {
            return DeleteProjectAsync(client, projectName).GetAwaiter().GetResult();
        }
        #endregion

        #region Unpublish All
        /// <summary>
        /// Unpublishes all published customization projects.
        /// </summary>
        /// <param name="client">The API client.</param>
        /// <param name="tenantMode">The tenants to unpublish the projects for.</param>
        /// <param name="tenantLoginNames">
        /// The login names of the tenants to unpublish for. Required if <paramref name="tenantMode"/> is
        /// <see cref="TenantMode.List"/>, and must be omitted otherwise.
        /// </param>
        /// <param name="cancellationToken">Token to cancel the call.</param>
        /// <returns>The log of the operation.</returns>
        public static async Task<CustomizationResult> UnpublishAllAsync(this ApiClient client,
            TenantMode tenantMode = TenantMode.Current,
            IEnumerable<string>? tenantLoginNames = null,
            CancellationToken cancellationToken = default)
        {
            var unpublishParams = new CustomizationUnpublishParams
            {
                TenantMode = ToApiValue(tenantMode),
                TenantLoginNames = ResolveTenants(tenantMode, tenantLoginNames, nameof(UnpublishAllAsync))
            };

            HttpResponseMessage response = await client.CallApiAsync(
                resourcePath:       "/CustomizationApi/UnpublishAll",
                method:             HttpMethod.Post,
                acceptType:         HeaderContentType.Json,
                contentType:        HeaderContentType.Json,
                body:               unpublishParams,
                cancellationToken:  cancellationToken
            ).ConfigureAwait(false);

            await VerifyResponseAsync(response, nameof(UnpublishAllAsync)).ConfigureAwait(false);
            return await DeserializeRequiredAsync<CustomizationResult>(response, nameof(UnpublishAllAsync)).ConfigureAwait(false);
        }

        /// <inheritdoc cref="UnpublishAllAsync"/>
        public static CustomizationResult UnpublishAll(this ApiClient client,
            TenantMode tenantMode = TenantMode.Current,
            IEnumerable<string>? tenantLoginNames = null)
        {
            return UnpublishAllAsync(client, tenantMode, tenantLoginNames).GetAwaiter().GetResult();
        }
        #endregion

        #region Helpers
        /// <summary>
        /// Checks that <paramref name="tenantLoginNames"/> is given exactly when <paramref name="tenantMode"/> is
        /// <see cref="TenantMode.List"/>, and returns the names to send.
        /// </summary>
        private static List<string>? ResolveTenants(TenantMode tenantMode, IEnumerable<string>? tenantLoginNames, string methodName)
        {
            List<string>? tenants = tenantLoginNames?.ToList();
            if (tenantMode == TenantMode.List)
            {
                if (tenants == null || tenants.Count == 0)
                    ThrowMissingParameter(methodName, nameof(tenantLoginNames));
                return tenants;
            }

            if (tenants != null && tenants.Count > 0)
            {
                throw new ArgumentException(
                    $"{nameof(tenantLoginNames)} can only be specified when {nameof(tenantMode)} is {nameof(TenantMode)}.{nameof(TenantMode.List)}.",
                    nameof(tenantLoginNames));
            }
            return null;
        }

        private static string ToApiValue(TenantMode tenantMode)
        {
            switch (tenantMode)
            {
                case TenantMode.Current: return "Current";
                case TenantMode.All: return "All";
                case TenantMode.List: return "List";
                default:
                    throw new ArgumentOutOfRangeException(nameof(tenantMode), tenantMode, $"Invalid tenantMode value: {tenantMode}.");
            }
        }

        private static async Task<string> ReadAsBase64Async(Stream stream, CancellationToken cancellationToken)
        {
            using (var memoryStream = new MemoryStream())
            {
                await stream.CopyToAsync(memoryStream, 81920, cancellationToken).ConfigureAwait(false);
                return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
            }
        }

        private static async Task<T> DeserializeRequiredAsync<T>(HttpResponseMessage response, string methodName) where T : class
        {
            T? result = await DeserializeAsync<T>(response).ConfigureAwait(false);
            if (result == null)
            {
                throw new ApiException((int)response.StatusCode, $"Error calling {methodName}: the server returned an empty response.");
            }
            return result;
        }

        /// <summary>
        /// Throws an <see cref="ApiException"/> carrying the status code and the response body
        /// when the request did not succeed. The body is the only place where the server explains the failure.
        /// </summary>
        private static async Task VerifyResponseAsync(HttpResponseMessage response, string methodName)
        {
            if (response.IsSuccessStatusCode)
            {
                return;
            }

            string responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            throw new ApiException(
                (int)response.StatusCode,
                $"Error {(int)response.StatusCode} calling {methodName}: {response.ReasonPhrase}{Environment.NewLine}{responseBody}");
        }
        #endregion
    }
}
