using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.CustomizationApi.Model;

using static Acumatica.RESTClient.Auxiliary.ApiClientHelpers;


namespace Acumatica.RESTClient.CustomizationApi
{
    public static class CustomizationApi
    {
        public static CustomizationPublishLog Import(this ApiClient client, Stream customizationPackageContent,
            string projectName,
            string projectDescription = "",
            bool replaceIfExists = true,
            int? level = null)
        {
            if (customizationPackageContent == null)
                ThrowMissingParameter("Import", nameof(customizationPackageContent));
            if (projectName == null)
                ThrowMissingParameter("Import", nameof(projectName));

            CustomizationImport customizationImport = new CustomizationImport();
            customizationImport.ProjectDescription = projectDescription;
            customizationImport.ProjectName = projectName;
            customizationImport.ProjectLevel = level;
            customizationImport.IsReplaceIfExists = replaceIfExists;
            customizationImport.ProjectContentBase64 = ConvertToBase64(customizationPackageContent);

            HttpResponseMessage response = client.CallApiAsync(
                "/CustomizationApi/Import",
                HttpMethod.Post,
                null,
                customizationImport,
                HeaderContentType.Json,
                HeaderContentType.Json).Result;

            response.EnsureSuccessStatusCode();
            return (CustomizationPublishLog)DeserializeAsync<CustomizationPublishLog>(response).Result;
        }

        private static string ConvertToBase64(Stream stream)
        {
            byte[] bytes;
            using (var memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                bytes = memoryStream.ToArray();
            }

            return Convert.ToBase64String(bytes);
        }

        /// <summary>
        /// Starts publishing of a customization package.
        /// </summary>
        /// <param name="projectName">Name of the customization project to publish.</param>
        /// <param name="isMergeWithExistingPackages">
        /// Indicator of whether the currently published projects should be merged 
        /// with the customization projects listed in the projectNames parameter. 
        /// If true, the projects will be merged and published together. 
        /// If false, only the project specified in the projectNames parameter 
        /// will be the published projects.
        /// Default value is <c>true</c></param>
        /// <param name="isOnlyValidation">
        /// Indicator of whether only project validation should be performed.</param>
        /// <param name="isOnlyDbUpdates">
        /// Indicator of whether the changes should be applied only to the database. 
        /// Corresponds to the Apply Changes Only to Database check box in the UI.</param>
        /// <param name="isReplayPreviouslyExecutedScripts">
        /// Indicator of whether database scripts that were previously applied 
        /// should be executed again. Corresponds to the 
        /// Execute All Database Scripts (Including Prevously Executed) check box 
        /// and Publish with Clean Up menu command in the UI.</param>
        /// <param name="tenantMode">
        /// <returns>
        /// If sucessfull, returns log record with the following message: 
        /// "Publishing has started."
        /// </returns>
        public static CustomizationPublishLog PublishBegin(this ApiClient client, 
            string projectName,
            bool isMergeWithExistingPackages = true, 
            bool isOnlyValidation = false,
            bool isOnlyDbUpdates = false,
            bool isReplayPreviouslyExecutedScripts = false,
            TenantMode tenantMode = TenantMode.Current
            )
        {
            if (projectName == null)
                ThrowMissingParameter("PublishBegin", nameof(projectName));
            var list = new List<string>
            {
                projectName
            };
            return PublishBegin(client,
               list, 
               isMergeWithExistingPackages, 
               isOnlyValidation,
               isOnlyDbUpdates,
               isReplayPreviouslyExecutedScripts,
               tenantMode);
        }

        /// <summary>
        /// Starts publishing of multiple customization packages.
        /// </summary>
        /// <param name="projectName">Name of the customization project to publish.</param>
        /// <param name="isMergeWithExistingPackages">
        /// Indicator of whether the currently published projects should be merged 
        /// with the customization projects listed in the projectNames parameter. 
        /// If true, the projects will be merged and published together. 
        /// If false, only the project specified in the projectNames parameter 
        /// will be the published projects.
        /// Default value is <c>false</c></param>
        /// <param name="isOnlyValidation">
        /// Indicator of whether only project validation should be performed.</param>
        /// <param name="isOnlyDbUpdates">
        /// Indicator of whether the changes should be applied only to the database. 
        /// Corresponds to the Apply Changes Only to Database check box in the UI.</param>
        /// <param name="isReplayPreviouslyExecutedScripts">
        /// Indicator of whether database scripts that were previously applied 
        /// should be executed again. Corresponds to the 
        /// Execute All Database Scripts (Including Prevously Executed) check box 
        /// and Publish with Clean Up menu command in the UI.</param>
        /// <param name="tenantMode">
        /// <returns>
        /// If sucessfull, returns log record with the following message: 
        /// "Publishing has started."
        /// </returns>
        public static CustomizationPublishLog PublishBegin(this ApiClient client,
            List<string> projectNames,
            bool isMergeWithExistingPackages = false,
            bool isOnlyValidation = false,
            bool isOnlyDbUpdates = false,
            bool isReplayPreviouslyExecutedScripts = false,
           TenantMode tenantMode = TenantMode.Current
            )
        {
            if (projectNames == null)
                ThrowMissingParameter("PublishBegin", nameof(projectNames));


            var localVarPath = "/CustomizationApi/PublishBegin";

            CustomizationPublishParams publishParams = new CustomizationPublishParams();
            publishParams.ProjectNames = projectNames;
            publishParams.IsMergeWithExistingPackages = isMergeWithExistingPackages;
            publishParams.IsOnlyValidation = isOnlyValidation;
            publishParams.IsOnlyDbUpdates = isOnlyDbUpdates;
            publishParams.IsReplayPreviouslyExecutedScripts = isReplayPreviouslyExecutedScripts;
            switch (tenantMode)
            {
                case TenantMode.Current: publishParams.TenantMode = "Current"; break;
                case TenantMode.List: throw new NotImplementedException(); break;
                case TenantMode.All: publishParams.TenantMode = "All"; break;
            }

            HttpResponseMessage response = client.CallApiAsync(
                localVarPath,
                HttpMethod.Post,
                null,
                publishParams,
                HeaderContentType.Json,
                HeaderContentType.Json).Result;

            response.EnsureSuccessStatusCode();
            return (CustomizationPublishLog)DeserializeAsync<CustomizationPublishLog>(response).Result;
        }
        public static CustomizationPublishEnd CustomizationPublishEnd(this ApiClient client)
        {
            HttpResponseMessage response = client.CallApiAsync(
                "/CustomizationApi/PublishEnd",
                HttpMethod.Post,
                null,
                null,
                HeaderContentType.Json,
                HeaderContentType.Json).Result;

            response.EnsureSuccessStatusCode();
            return (CustomizationPublishEnd)DeserializeAsync<CustomizationPublishEnd>(response).Result;
        }

        public static void WaitPublishingCompletion(this ApiClient client, int millisecondsInterval = 1000)
        {
            while (true)
            {
                var processResult = CustomizationPublishEnd(client);
                if (processResult.IsCompleted)
                {
                    return;
                }
                else if (processResult.isFailed)
                {
                    StringBuilder log = new StringBuilder();
                    processResult.Log.ForEach(_ => log.Append(_.Message).Append(Environment.NewLine));
                    throw new Exception(log.ToString());
                }
                else
                {
                    Thread.Sleep(millisecondsInterval);
                }
            }
        }
    }
}
