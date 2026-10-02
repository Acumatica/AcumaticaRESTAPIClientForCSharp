using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using EndpointModelGenerator;

namespace EndpointSchemaGenerator
{
    public static class SchemaGenerator
    {
        public static void WriteCSharp(string outputPath,
            string endpointName,
            Schema schema, 
            Action<string> writeLogDelegate,
			GeneratorSettings settings)
        {
            outputPath += "\\";
            string modelLocalPath = "Model\\";
            string actionsLocalPath = modelLocalPath + "Actions\\";
            string reportsLocalPath = modelLocalPath + "Reports\\";
            string actionParametersLocalPath = modelLocalPath + "ActionParameters\\";
            string apiLocalPath = "Api\\";

            string modelFilesDirectory = outputPath + modelLocalPath;
            string modelActionsFilesDirectory = outputPath + actionsLocalPath;
            string modelReportsFilesDirectory = outputPath + reportsLocalPath;
            string modelParametersFilesDirectory = outputPath + actionParametersLocalPath;
            string apiFilesDirectory = outputPath + apiLocalPath;

            string endpointNamespace = GetEndpointNamespace(settings.DefaultNamespaceTemplate, endpointName);
            string csprojPath = GetCsprojPath(outputPath, endpointName, settings.DefaultNamespaceTemplate);
            string baseCsprojPath = string.IsNullOrEmpty(schema.BaseEndpoint) ? string.Empty : GetCsprojPath(string.Format(settings.DefaultNamespaceTemplate, schema.BaseEndpoint)+"\\", schema.BaseEndpoint, settings.DefaultNamespaceTemplate);

            RegenerateDirectories(outputPath, modelFilesDirectory, modelActionsFilesDirectory, modelReportsFilesDirectory, modelParametersFilesDirectory, apiFilesDirectory);

            WriteCsProj(csprojPath, baseCsprojPath);

            WriteEntities(schema, writeLogDelegate, endpointNamespace, modelLocalPath, modelFilesDirectory, settings);
            if (settings.GenerateAPISectionForBackWardCompatibility)
            {
                WriteBaseApi(schema, writeLogDelegate, endpointNamespace, apiLocalPath, apiFilesDirectory, settings);
                WriteApis(schema, writeLogDelegate, endpointNamespace, apiLocalPath, apiFilesDirectory);
            }
            WriteActions(schema, writeLogDelegate, endpointNamespace, modelActionsFilesDirectory, modelParametersFilesDirectory, settings);
            WriteReports(schema, writeLogDelegate, endpointNamespace, modelReportsFilesDirectory, settings);

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
        private static void WriteReports(Schema schema,
            Action<string> writeLogDelegate,
            string endpointNamespace,
            string modelReportsFilesDirectory, 
            GeneratorSettings settings)
        {
            foreach (var report in schema.Reports)
            {
                string filename = report + ".cs";
                StreamWriter writer = new StreamWriter(modelReportsFilesDirectory + filename);

                StringBuilder content = new StringBuilder();
               
                foreach (var parameter in schema.ReportParameters.GetValueOrDefault(report))
                {
                    content.Append("\r\n");
                    content.Append(String.Format(Templates.ParameterTemplate, parameter.Key, parameter.Value));
                }
                var result = String.Format(Templates.ReportTemplate(settings), endpointNamespace, report, content.ToString(), schema.Info.Title);
                writeLogDelegate.Invoke("Reports/" + report);
                writer.Write(result);
                writer.Close();

            }
        }
        private static void WriteActions(Schema schema, 
            Action<string> writeLogDelegate, 
            string endpointNamespace, 
            string modelActionsFilesDirectory, 
            string modelParametersFilesDirectory, 
            GeneratorSettings settings)
        {
            foreach (var action in schema.Actions)
            {
                string filename = action.Key + ".cs";
                if (schema.Parameters.ContainsKey(action.Key))
                {
                    StreamWriter writer = new StreamWriter(modelActionsFilesDirectory + filename);

                    string result = Templates.GenerateActionWithParametersCode(endpointNamespace, action.Key, action.Value, settings);

                    writer.Write(result);
                    writer.Close();

                    string paramFileName = action.Key + "Parameters.cs";
                    writer = new StreamWriter(modelParametersFilesDirectory + paramFileName);


					StringBuilder content = new StringBuilder();
                    foreach (var parameter in schema.Parameters[action.Key])
                    {
                        content.Append("\r\n");
                        content.Append(String.Format(Templates.ParameterTemplate, parameter.Key, parameter.Value));
                    }
                    result = Templates.GenerateActionParametersCode(endpointNamespace, action.Key, content.ToString(), settings);
                    writeLogDelegate.Invoke("ActionsWithParameters/" + action.Key);
                    writer.Write(result);
                    writer.Close();
                }
                else
                {
                    StreamWriter writer = new StreamWriter(modelActionsFilesDirectory + filename);

                    string result = Templates.GenerateActionCode(endpointNamespace, action.Key, action.Value, settings);
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
            string apiFilesDirectory, 
            GeneratorSettings settings)
        {
            string filename = "BaseEndpointApi.cs";
            StreamWriter writer = new StreamWriter(apiFilesDirectory + filename);
            string result = String.Format(Templates.BaseEndpointApiTemplate(settings), endpointNamespace, schema.Info.Title);
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
            GeneratorSettings settings)
        {
            foreach (var entity in schema.Entities)
            {
                string filename = entity.Key + ".cs";
                StreamWriter writer = new StreamWriter(modelFilesDirectory + filename);
                StringBuilder body = new StringBuilder(BuildFieldRegions(entity.Key, entity.Value.Fields));
                bool nestedExpandSyntax = UsesNestedExpandSyntax(schema);
                List<string> expandsAppend = nestedExpandSyntax
                    ? CollectDirectExpands(schema, entity.Key, entity.Value)
                    : CollectExpands(schema, entity.Value);

                string result;
                bool isNotDerived = string.IsNullOrEmpty(schema.BaseEndpoint) || string.IsNullOrEmpty(entity.Value.ParentReference);
                string baseEntity = isNotDerived ? "Entity" : $"{GetEndpointNamespace(settings.DefaultNamespaceTemplate, schema.BaseEndpoint)}.Model.{entity.Value.ParentReference}";
                // A derived entity inherits the base endpoint's nested Expand class, so it must not redeclare one.
                string expands = isNotDerived && expandsAppend.Count > 0
                    ? Templates.GetExpands(expandsAppend, nestedExpandSyntax)
                    : "";
                if (entity.Value.IsTopLevel)
                {
                    result = Templates.GenerateTopLevelEntityCode(
                        endpointNamespace: endpointNamespace,
                        entityName: entity.Key,
                        content: body.ToString(),
                        endpointPath: schema.Info.Title,
                        parentReference: baseEntity,
                        isDerived: !isNotDerived,
                        settings: settings,
                        screenID: entity.Value.ScreenID,
                        expands,
                        entity.Value.Fields.Where(_=>_.IsKey==true).OrderBy(_=>_.ScreenOrder ?? int.MaxValue)
                        );
                }
                else
                {
                    // Before system contract 5 a nested entity could only be reached through the
                    // top level entity's Parent/Child expand names, so only top level entities
                    // declared an Expand class.
                    result = Templates.GenerateEntityCode(endpointNamespace, entity.Key, body.ToString(), baseEntity, settings,
                        nestedExpandSyntax ? expands : "");
                }
                writeLogDelegate.Invoke(entity.Key);
                writer.Write(result);
                writer.Close();
            }
        }

        /// <summary>
        /// The DAC-field wrapper types (see Acumatica.RESTClient.ContractBasedApi.Model.FieldTypes) that back
        /// a plain scalar entity field, as opposed to a nested entity reference or a detail collection.
        /// </summary>
        private static readonly HashSet<string> ScalarFieldTypes = new HashSet<string>
        {
            "BooleanValue", "ByteValue", "DateOnlyValue", "DateTimeValue", "DecimalValue", "DoubleValue",
            "GuidValue", "IntSingleSelectValue", "IntValue", "LongValue", "ShortValue",
            "StringMultiSelectValue", "StringSingleSelectValue", "StringValue"
        };

        /// <summary>
        /// True for a field whose type is a child collection (<c>List&lt;T&gt;</c>, or <c>T[]</c> when
        /// <see cref="JsonSchemaParser.GenerateArraysInstedOfLists"/> is enabled).
        /// </summary>
        private static bool IsDetailFieldType(string type)
        {
            return type != null && (type.StartsWith("List<") || type.EndsWith("[]"));
        }

        /// <summary>
        /// Splits an entity's fields into the <c>Fields</c> / <c>LinkedEntities</c> / <c>Details</c> regions
        /// the generated class is organized into. <c>Fields</c> holds the plain DAC-field wrapper types
        /// (StringValue, DecimalValue, ...), ordered with key fields first and then by each field's position
        /// on the Acumatica screen (see <see cref="EntityField.ScreenOrder"/>) rather than alphabetically.
        /// <c>Details</c> holds child collections (<c>List&lt;T&gt;</c>); everything else is a reference to a
        /// single nested entity (<c>LinkedEntities</c>) and keeps its original relative order.
        /// </summary>
        private static string BuildFieldRegions(string entityName, IEnumerable<EntityField> fields)
        {
            var scalarFields = fields
                .Where(f => ScalarFieldTypes.Contains(f.Type))
                .OrderBy(f => f.IsKey == true ? 0 : 1)
                .ThenBy(f => f.ScreenOrder ?? int.MaxValue)
                .ToList();
            var detailFields = fields.Where(f => IsDetailFieldType(f.Type)).ToList();
            var linkedEntityFields = fields
                .Where(f => !ScalarFieldTypes.Contains(f.Type) && !IsDetailFieldType(f.Type))
                .ToList();

            string Render(IEnumerable<EntityField> group) =>
                string.Concat(group.Select(f => Templates.GenerateFieldCode(entityName, f)));

            var body = new StringBuilder();
            if (scalarFields.Count > 0)
            {
                body.Append(Templates.GenerateRegion("Fields", Render(scalarFields)));
            }
            if (linkedEntityFields.Count > 0)
            {
                body.Append(Templates.GenerateRegion("LinkedEntities", Render(linkedEntityFields)));
            }
            if (detailFields.Count > 0)
            {
                body.Append(Templates.GenerateRegion("Details", Render(detailFields)));
            }
            return body.ToString();
        }

        /// <summary>
        /// System contract 5 replaced the flattened <c>$expand=Parent/Child</c> syntax with
        /// <c>$expand=Parent($expand=Child)</c>, so a nested name is no longer a value the caller
        /// can pass on the parent entity.
        /// </summary>
        private static bool UsesNestedExpandSyntax(Schema schema)
        {
            return int.TryParse(schema.Info?.Version, out int systemContractVersion)
                && systemContractVersion >= NestedExpandSyntaxSystemContract;
        }

        private const int NestedExpandSyntaxSystemContract = 5;

        /// <summary>
        /// Collects only the names that can be expanded directly on <paramref name="entity"/>.
        /// Under the nested syntax every entity declares its own names, and the caller composes
        /// them, so recursing into nested entities here would produce values the server rejects.
        /// </summary>
        private static List<string> CollectDirectExpands(Schema schema, string entityName, EntityDefinition entity)
        {
            List<string> expandsAppend = new List<string>();
            if (SupportsFilesExpand(schema, entityName, entity))
            {
                expandsAppend.Add("Files");
            }
            if (entity.IsTopLevel)
            {
                expandsAppend.Add("Translations");
            }
            foreach (var field in entity.Fields)
            {
                if (!NonExpandableTypes.Types.Contains(field.Type))
                {
                    expandsAppend.Add(field.Name);
                }
            }

            return expandsAppend;
        }

        /// <summary>
        /// Mirrors the rule the flattened collector applies at each call site: files are expandable
        /// on a top level entity and on a detail, but not on a linked entity, which usually has no
        /// files of its own, nor on attribute values.
        /// </summary>
        private static bool SupportsFilesExpand(Schema schema, string entityName, EntityDefinition entity)
        {
            if (entityName == AttributeValueEntity)
            {
                return false;
            }
            if (entity.IsTopLevel)
            {
                return true;
            }

            string detailType = $"List<{entityName}>";
            return schema.Entities.Any(_ => _.Value.Fields.Any(field => field.Type == detailType));
        }

        private const string AttributeValueEntity = "AttributeValue";

        private static List<string> CollectExpands(Schema schema, EntityDefinition entity, bool addFiles = true, bool addTranslations = true)
        {
            List<string> expandsAppend = new List<string>();
            if(addFiles)
            {
                expandsAppend.Add("Files");
            }
            if(entity.IsTopLevel && addTranslations)
            {
                expandsAppend.Add("Translations");
            }
            foreach (var field in entity.Fields)
            {
                if (!NonExpandableTypes.Types.Contains(field.Type))
                {
                    expandsAppend.Add(field.Name);
                    bool isDetail = field.Type.StartsWith("List<");

                    string fieldType = ExtractFieldType(field.Type);
                    if (schema.Entities.ContainsKey(fieldType))
                    {
                        //we do not want to add files expand for linked entities as usually they don't have their own files
                        //and Attributes do not have files either
                        expandsAppend.AddRange(CollectExpands(schema, schema.Entities[fieldType], isDetail && fieldType != "AttributeValue" && field.Name!="Attributes", false).Select(_ => $"{field.Name}/{_}"));
                    }
                }
            }

            return expandsAppend;
        }

        private static string ExtractFieldType(string type)
        {
            if (type.StartsWith("List<"))
                return type.Substring(5).TrimEnd('>');
            else return type;
        }

        private static void RegenerateDirectories(string outputPath, 
            string modelFilesDirectory, 
            string modelActionsFilesDirectory,
            string modelReportsFilesDirectory,
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
            Directory.CreateDirectory(modelReportsFilesDirectory);
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
