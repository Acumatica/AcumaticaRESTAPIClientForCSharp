using System;
using System.IO;
using System.Linq;
using System.Text;

namespace EndpointSchemaGenerator
{
    public static class SchemaGenerator
    {
        public static void WriteCSharp(string outputPath,
            string endpointName,
            Schema schema, 
            Action<string> writeLogDelegate, 
            string defaultNamespaceTemplate, 
            bool generateApis = true)
        {
            outputPath += "\\";
            string modelLocalPath = "Model\\";
            string actionsLocalPath = modelLocalPath + "Actions\\";
            string actionParametersLocalPath = modelLocalPath + "ActionParameters\\";
            string apiLocalPath = "Api\\";

            string modelFilesDirectory = outputPath + modelLocalPath;
            string modelActionsFilesDirectory = outputPath + actionsLocalPath;
            string modelParametersFilesDirectory = outputPath + actionParametersLocalPath;
            string apiFilesDirectory = outputPath + apiLocalPath;

            string endpointNamespace = GetEndpointNamespace(defaultNamespaceTemplate, endpointName);
            string csprojPath = GetCsprojPath(outputPath, endpointName, defaultNamespaceTemplate);
            string baseCsprojPath = string.IsNullOrEmpty(schema.BaseEndpoint) ? string.Empty : GetCsprojPath(string.Format(defaultNamespaceTemplate, schema.BaseEndpoint)+"\\", schema.BaseEndpoint, defaultNamespaceTemplate);

            RegenerateDirectories(outputPath, modelFilesDirectory, modelActionsFilesDirectory, modelParametersFilesDirectory, apiFilesDirectory);

            WriteCsProj(csprojPath, baseCsprojPath);

            WriteEntities(schema, writeLogDelegate, endpointNamespace, modelLocalPath, modelFilesDirectory, defaultNamespaceTemplate);
            if (generateApis)
            {
                WriteBaseApi(schema, writeLogDelegate, endpointNamespace, apiLocalPath, apiFilesDirectory);
                WriteApis(schema, writeLogDelegate, endpointNamespace, apiLocalPath, apiFilesDirectory);
            }
            WriteActions(schema, writeLogDelegate, endpointNamespace, actionsLocalPath, actionParametersLocalPath, modelActionsFilesDirectory, modelParametersFilesDirectory);

            writeLogDelegate.Invoke("Done!");
        }

        private static string GetCsprojPath(string outputPath, string endpointName, string defaultNamespaceTemplate)
        {
            return outputPath + string.Format(defaultNamespaceTemplate, endpointName) + ".csproj";
        }

        private static string GetEndpointNamespace(string defaultNamespaceTemplate,  string endpointName)
        {
            return string.Format(defaultNamespaceTemplate, endpointName.Replace(".", "_"));
        }
        private static void WriteCsProj(string csprojPath, string baseCsprojPath)
        {
            StringBuilder sectionsToPreserve = new StringBuilder();
            if (File.Exists(csprojPath))
            {
                StreamReader reader = new StreamReader(csprojPath);
                var existingProject = reader.ReadToEnd();
                reader.Close();
                sectionsToPreserve.AppendLine(ExtractSection("Version", existingProject));
                sectionsToPreserve.AppendLine(ExtractSection("Company", existingProject));
                sectionsToPreserve.AppendLine(ExtractSection("Description", existingProject));
                sectionsToPreserve.AppendLine(ExtractSection("Copyright", existingProject));
                sectionsToPreserve.AppendLine(ExtractSection("PackageProjectUrl", existingProject));
                sectionsToPreserve.AppendLine(ExtractSection("RepositoryUrl", existingProject));
                sectionsToPreserve.AppendLine(ExtractSection("PackageTags", existingProject));
                sectionsToPreserve.AppendLine(ExtractSection("PackageReleaseNotes", existingProject));
                sectionsToPreserve.AppendLine(ExtractSection("PackageLicenseExpression", existingProject));
                sectionsToPreserve.AppendLine(ExtractSection("Title", existingProject));
                sectionsToPreserve.AppendLine(ExtractSection("Authors", existingProject));
                sectionsToPreserve.AppendLine(ExtractSection("IncludeSymbols", existingProject));
                sectionsToPreserve.AppendLine(ExtractSection("SymbolPackageFormat", existingProject));
            }
            StreamWriter writer = new StreamWriter(csprojPath);
            writer.Write(Templates.ProjectTemplate, sectionsToPreserve,string.IsNullOrEmpty(baseCsprojPath)?"": $"<ProjectReference Include=\"..\\{baseCsprojPath}\" />");
            writer.Close();
        }

        private static string ExtractSection(string tag, string csProjXML)
        {
            //find Version xml tag in existing project
            int versionTagStart = csProjXML.IndexOf($"<{tag}>");
            int versionTagEnd = csProjXML.IndexOf($"</{tag}>");
            if (versionTagStart > 0 && versionTagEnd > 0)
            {
                return csProjXML.Substring(versionTagStart, versionTagEnd - versionTagStart + tag.Length + 3);
            }

            return "";
        }

        private static void WriteActions(Schema schema, 
            Action<string> writeLogDelegate, 
            string endpointNamespace, 
            string actionsLocalPath, 
            string actionParametersLocalPath, 
            string modelActionsFilesDirectory, 
            string modelParametersFilesDirectory)
        {
            foreach (var action in schema.Actions)
            {
                string filename = action.Key + ".cs";
                if (schema.Parameters.ContainsKey(action.Key))
                {
                    StreamWriter writer = new StreamWriter(modelActionsFilesDirectory + filename);

                    StringBuilder content = new StringBuilder();
                    foreach (var parameter in schema.Parameters[action.Key])
                    {
                        content.Append(String.Format(Templates.InActionParameterTemplate, parameter.Key, parameter.Value));
                    }
                    string result = String.Format(Templates.ActionWithParametersTemplate, endpointNamespace, action.Key, action.Value, content.ToString());

                    writer.Write(result);
                    writer.Close();

                    string paramFileName = action.Key + "Parameters.cs";
                    writer = new StreamWriter(modelParametersFilesDirectory + paramFileName);


                    content = new StringBuilder();
                    foreach (var parameter in schema.Parameters[action.Key])
                    {
                        content.Append("\r\n");
                        content.Append(String.Format(Templates.ParameterTemplate, parameter.Key, parameter.Value));
                    }
                    result = String.Format(Templates.ActionParametersTemplate, endpointNamespace, action.Key, content.ToString());
                    writeLogDelegate.Invoke("ActionsWithParameters/" + action.Key);
                    writer.Write(result);
                    writer.Close();
                }
                else
                {
                    StreamWriter writer = new StreamWriter(modelActionsFilesDirectory + filename);
                   
                    string result = String.Format(Templates.ActionTemplate, endpointNamespace, action.Key, action.Value);
                    writeLogDelegate.Invoke("Actions/" + action.Key);
                    writer.Write(result);
                    writer.Close();
                }
            }
        }
        private static void WriteBaseApi(Schema schema, 
            Action<string> writeLogDelegate, 
            string endpointNamespace, 
            string apiLocalPath, 
            string apiFilesDirectory)
        {
            string filename = "BaseEndpointApi.cs";
            StreamWriter writer = new StreamWriter(apiFilesDirectory + filename);
            string result = String.Format(Templates.BaseEndpointApiTemplate, endpointNamespace, schema.Info.Title);
            writeLogDelegate.Invoke("BaseEndpointApi");
            writer.Write(result);
            writer.Close();
        }
        private static void WriteApis(Schema schema, 
            Action<string> writeLogDelegate, 
            string endpointNamespace, 
            string apiLocalPath, 
            string apiFilesDirectory)
        {
			foreach (var entity in schema.Entities.Where(_=>_.Value.IsTopLevel))
			{
				string filename = entity.Key + "Api.cs";
				StreamWriter writer = new StreamWriter(apiFilesDirectory + filename);

				string result = String.Format(Templates.ApiTemplate, endpointNamespace, entity.Key);
				writeLogDelegate.Invoke(entity.Key + "Api");
				writer.Write(result);
				writer.Close();
			}
		}

        private static void WriteEntities(Schema schema,
            Action<string> writeLogDelegate,
            string endpointNamespace,
            string modelLocalPath,
            string modelFilesDirectory, 
            string defaultNamespaceTemplate)
        {
            foreach (var entity in schema.Entities)
            {
                string filename = entity.Key + ".cs";
                StreamWriter writer = new StreamWriter(modelFilesDirectory + filename);
                StringBuilder body = new StringBuilder();
                foreach (var field in entity.Value.Fields)
                {
                    body.Append(Templates.GenerateFieldCode(field.Name == entity.Key ? field.Name.ToLowerInvariant() : field.Name, field.Type, field.DAC, field.DACFieldName));
                }
                string result;
                bool isNotDerived = string.IsNullOrEmpty(schema.BaseEndpoint) || string.IsNullOrEmpty(entity.Value.ParentReference);
                string baseEntity = isNotDerived ? "Entity" : $"{GetEndpointNamespace(defaultNamespaceTemplate, schema.BaseEndpoint)}.Model.{entity.Value.ParentReference}";
                if (entity.Value.IsTopLevel)
                {
                    result = Templates.GenerateTopLevelEntityCode(
                        endpointNamespace, entity.Key, body.ToString(), schema.Info.Title, baseEntity, !isNotDerived, entity.Value.ScreenID);
                }
                else
                {
                    result = String.Format(Templates.EntityTemplate, endpointNamespace, entity.Key, body.ToString(), baseEntity, "");
                }
                writeLogDelegate.Invoke(entity.Key);
                writer.Write(result);
                writer.Close();
            }
        }

        private static void RegenerateDirectories(string outputPath, 
            string modelFilesDirectory, 
            string modelActionsFilesDirectory, 
            string modelParametersFilesDirectory, 
            string apiFilesDirectory)
        {
            Directory.CreateDirectory(outputPath);
            try
            {
                Directory.Delete(modelFilesDirectory, true);
            }
            catch { }
            Directory.CreateDirectory(modelFilesDirectory);
            Directory.CreateDirectory(modelActionsFilesDirectory);
            Directory.CreateDirectory(modelParametersFilesDirectory);
            try
            {
                Directory.Delete(apiFilesDirectory, true);
            }
            catch { }
            Directory.CreateDirectory(apiFilesDirectory);
        }
    }
}
