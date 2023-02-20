using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Auxiliary;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.CustomizationApi.Model;

using RestSharp;

namespace Acumatica.RESTClient.CustomizationApi
{
    public class CustomizationApi : BaseApi
    {
        public CustomizationApi(Configuration configuration) : base(configuration)
        {

        }
        public CustomizationPublishLog Import(Stream customizationPackageContent,
            string projectName,
            string projectDescription = "",
            bool replaceIfExists = true,
            int? level = null)
        {
            if (customizationPackageContent == null)
                ThrowMissingParameter("Import", nameof(customizationPackageContent));
            if (projectName == null)
                ThrowMissingParameter("Import", nameof(projectName));


            var localVarPath = "/CustomizationApi/Import";

            CustomizationImport customizationImport = new CustomizationImport();
            customizationImport.ProjectDescription = projectDescription;
            customizationImport.ProjectName = projectName;
            customizationImport.ProjectLevel = level;
            customizationImport.IsReplaceIfExists = replaceIfExists;
            customizationImport.ProjectContentBase64 = ConvertToBase64(customizationPackageContent);

            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                localVarPath,
                Method.Post,
                ComposeEmptyQueryParams(),
                ComposeBody(customizationImport),
                ComposeAcceptHeaders(HeaderContentType.Json),
                ComposeEmptyFormParams(),
                null,
                null,
                ComposeContentHeaders(HeaderContentType.Json)).Result;

            VerifyResponse(localVarResponse, "Import");
            return DeserializeResponse<CustomizationPublishLog>(localVarResponse).Data;
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
        public CustomizationPublishLog PublishBegin(string projectName,
            bool isMergeWithExistingPackages = true,
            bool isOnlyValidation = false,
            bool isOnlyDbUpdates = false,
            bool isReplayPreviouslyExecutedScripts = false,
            TenantMode tenantMode = TenantMode.Current
            )
        {
            if (projectName == null)
                ThrowMissingParameter("PublishBegin", nameof(projectName));
            var list = new List<string >();
            list.Add(projectName);
           return PublishBegin(list, 
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
        public CustomizationPublishLog PublishBegin(List<string> projectNames,
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


            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                localVarPath,
                Method.Post,
                ComposeEmptyQueryParams(),
                ComposeBody(publishParams),
                ComposeAcceptHeaders(HeaderContentType.Json),
                ComposeEmptyFormParams(),
                null,
                null,
                ComposeContentHeaders(HeaderContentType.Json)).Result;

            VerifyResponse(localVarResponse, "PublishBegin");
            return DeserializeResponse<CustomizationPublishLog>(localVarResponse).Data;
        }
        public CustomizationPublishEnd CustomizationPublishEnd()
        {
            RestResponse localVarResponse = Configuration.ApiClient.CallApiAsync(
                "/CustomizationApi/PublishEnd",
                Method.Post,
                ComposeEmptyQueryParams(),
                null,
                ComposeAcceptHeaders(HeaderContentType.Json),
                ComposeEmptyFormParams(),
                null,
                null,
                ComposeContentHeaders(HeaderContentType.Json)).Result;

            VerifyResponse(localVarResponse, "PublishEnd");
            return DeserializeResponse<CustomizationPublishEnd>(localVarResponse).Data;
        }

        public void WaitPublishingCompletion(int millisecondsInterval = 1000)
        {
            while (true)
            {
                var processResult = CustomizationPublishEnd();
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
