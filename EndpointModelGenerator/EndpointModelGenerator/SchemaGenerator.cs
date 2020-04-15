using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Build;
using Microsoft.Build.Evaluation;

namespace EndpointSchemaGenerator
{
    public partial class SchemaGenerator
    {
		#region setting
		static bool GenerateArraysInstedOfLists = false;
        const string OutputDirectoryTemplate = @"\Acumatica.{0}";
        const string EndpointSchemaDirectory = @"\EndpointDefinitions\";
        const string DefaultNamespaceTemplate = @"Acumatica.{0}";
        
        // List of entities that are shared between all endpoints
        public static string[] IgnoreList = new string[] { "StringValue", "LongValue", "CustomStringField",
        "CustomDecimalField", "CustomDateTimeField", "CustomBooleanField", "CustomIntField", "CustomLongField",
        "CustomShortField", "CustoByteField", "CustomDoubleField", "CustomGuidField", "CustomField",
        "DecimalValue", "DateTimeValue", "BooleanValue", "IntValue", "ShortValue", "ByteValue", "DoubleValue",
        "GuidValue", "FileLink", "Entity", "HttpError", "CustomByteField"};
        #endregion

        static void Main(string[] args)
        {
            string solutionFolderPath = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString()).ToString()).ToString();
            
            foreach (var file in Directory.GetFiles(solutionFolderPath + EndpointSchemaDirectory))
            {
                string endpoint = file.Replace(solutionFolderPath + EndpointSchemaDirectory, "");
                StreamReader reader = new StreamReader(file);
                string input = reader.ReadToEnd();
                reader.Close();

                Schema schema = ComposeEndpointSchema(input);

                WriteCSharp(
                    solutionFolderPath + string.Format(OutputDirectoryTemplate, endpoint),
                     endpoint,
                    schema);
            }
        }
        public static void Generate(string path, string endpointDefinitionJson)
        {
            Schema schema = ComposeEndpointSchema(endpointDefinitionJson);
            string directoryPath = Directory.GetParent(path).ToString();
            string endpointName = path.Replace(directoryPath, "").Replace(".csproj", "").Replace("Acumatica.", "").Replace("\\", "");
            WriteCSharp(directoryPath, endpointName, schema);
          
        }

        public static string ParseParentRef(JToken jsonObject)
        {
            var s = jsonObject.Children().First().Children().First().ToString();
            if (s.Contains("definitions/"))
            {
                s = s.Substring(s.IndexOf("definitions/") + 12);
                if (s.IndexOf("\"") > 0)
                {
                    s = s.Substring(0, s.IndexOf("\""));
                }
                return s;
            }
            else if (s.Contains("array"))
            {
                var k = jsonObject.ToString();
                if (k.Contains("definitions/"))
                {
                    k = k.Substring(k.IndexOf("definitions/") + 12);
                    if (k.IndexOf("\"") > 0)
                    {
                        k = k.Substring(0, k.IndexOf("\""));
                    }
                    if (GenerateArraysInstedOfLists)
                    {
                        return k + "[]";
                    }
                    else
                    {
                        return "List<" + k + ">";
                    }
                }
                else return "";
            }
            else
            {
                return "";
            }
        }
        public static string ParseParentRef(JObject jsonObject)
        {
            return ParseParentRef(jsonObject.Children().First());
        }
        private static void WriteCSharp(string outputPath, string endpointName, Schema schema)
        {
            string endpointNamespace = string.Format(DefaultNamespaceTemplate, endpointName.Replace(".", "_"));
            string modelFilesDirectory = outputPath + "\\Model\\";
            string modelActionsFilesDirectory = modelFilesDirectory + "\\Actions\\";
            string modelParametersFilesDirectory = modelFilesDirectory + "\\ActionParameters\\";
            string apiFilesDirectory = outputPath + "\\Api\\";
            string csprojPath = outputPath + "\\" + string.Format(DefaultNamespaceTemplate, endpointName) + ".csproj";
            Directory.CreateDirectory(outputPath);
            Directory.CreateDirectory(modelFilesDirectory);
            Directory.CreateDirectory(modelActionsFilesDirectory);
            Directory.CreateDirectory(modelParametersFilesDirectory);
            Directory.CreateDirectory(apiFilesDirectory);


            Project project = new Project(csprojPath);
            project.RemoveItems(project.GetItems("Compile"));

            foreach (var entity in schema.Entities)
            {
                StreamWriter writer = new StreamWriter(modelFilesDirectory + entity.Key + ".cs");
                project.AddItem("Compile", "Model\\" + entity.Key + ".cs");
                string body = "";
                foreach (var field in entity.Value)
                {
                    body += string.Format(Templates.FieldTemplate, field.Key, field.Value);
                }
                string result = String.Format(Templates.EntityTemplate, endpointNamespace, entity.Key, body);
                Console.WriteLine(entity.Key);
                writer.Write(Templates.EntityUsingsTemplate + result);
                writer.Close();
            }
            foreach (var entity in schema.TopLevelEntities)
            {
                StreamWriter writer = new StreamWriter(apiFilesDirectory + entity + "Api.cs");
                project.AddItem("Compile", "Api\\" + entity + "Api.cs");

                string result = String.Format(Templates.ApiTemplate, endpointNamespace, entity);
                Console.WriteLine(entity + "Api");
                writer.Write(result);
                writer.Close();
            }

            foreach (var action in schema.Actions)
            {
                if (schema.Parameters.ContainsKey(action.Key))
                {
                    StreamWriter writer = new StreamWriter(modelActionsFilesDirectory + action.Key + ".cs");
                    project.AddItem("Compile", "Model\\Actions\\" + action.Key + ".cs");
                    string content = "";
                    foreach (var parameter in schema.Parameters[action.Key])
                    {
                        content += String.Format(Templates.InActionParameterTemplate, parameter.Key, parameter.Value);
                    }
                    string result = String.Format(Templates.ActionWithParametersTemplate, endpointNamespace, action.Key, action.Value, content);

                    writer.Write(Templates.ActionUsingsTemplate + result);
                    writer.Close();

                    writer = new StreamWriter(modelParametersFilesDirectory + action.Key + "Parameters.cs");
                    project.AddItem("Compile", "Model\\ActionParameters\\" + action.Key + "Parameters.cs");

                    content = "";
                    foreach (var parameter in schema.Parameters[action.Key])
                    {
                        content += "\r\n" + String.Format(Templates.ParameterTemplate, parameter.Key, parameter.Value);
                    }
                    result = String.Format(Templates.ActionParametersTemplate, endpointNamespace, action.Key, content);
                    Console.WriteLine("ActionsWithParameters/" + action.Key);
                    writer.Write(result);
                    writer.Close();
                }
                else
                {
                    StreamWriter writer = new StreamWriter(modelActionsFilesDirectory + action.Key + ".cs");
                    project.AddItem("Compile", "Model\\Actions\\" + action.Key + ".cs");

                    string result = String.Format(Templates.ActionTemplate, endpointNamespace, action.Key, action.Value);
                    Console.WriteLine("Actions/" + action.Key);
                    writer.Write(Templates.ActionUsingsTemplate + result);
                    writer.Close();
                }
            }
            project.AddItem("Compile", "Properties\\AssemblyInfo.cs");
            project.Save();
        }

        private static Schema ComposeEndpointSchema(string input)
        {
            var schema = JsonConvert.DeserializeObject<Schema>(input);
            foreach (var item in IgnoreList)
            {
                schema.Definitions.Remove(item);
            }
            schema.Entities = new Dictionary<string, Dictionary<string, string>>();
            schema.TopLevelEntities = new HashSet<string>();
            foreach (var item in schema.Definitions)
            {
                var res = ParseObject(item);
                if (res != null)
                {
                    schema.Entities.Add(item.Key, res);
                    if (IsTopLevelEntity(schema, item.Key))
                    {
                        schema.TopLevelEntities.Add(item.Key);
                    }
                }
            }
            schema.Actions = new Dictionary<string, string>();
            foreach (var item in schema.Definitions)
            {
                string entityType = ParseAction(item);
                if (!String.IsNullOrEmpty(entityType))
                {
                    schema.Actions.Add(item.Key, entityType);
                }
            }
            schema.Parameters = new Dictionary<string, Dictionary<string, string>>();
            foreach (var item in schema.Definitions)
            {
                string entityType = ParseActionWithParameters(item);
                if (!String.IsNullOrEmpty(entityType))
                {
                    schema.Actions.Add(item.Key, entityType);
                    schema.Parameters.Add(item.Key, ParseParameters(item));
                }
            }
            Dictionary<string, Dictionary<string, string>> parameters = new Dictionary<string, Dictionary<string, string>>();
            foreach (var item in schema.Definitions)
            {
                //    entities.Add(item.Key, ParseObject(item));
            }
           
            return schema;
        }

        private static bool IsTopLevelEntity(Schema schema, string key)
        {
            return schema.Tags.Where(_ => _.Name == key).Any();
        }

        private static Dictionary<string, string> ParseObject(KeyValuePair<string, JObject> item)
        {
            var s = JsonConvert.DeserializeObject<EntitySchemaInternal>(item.Value.ToString());
            var res = new EntitySchema();
            res.ParentReference = ParseParentRef(item.Value);
            if (res.ParentReference == "Entity")
            {
                s.AllOf.Remove(null);
                if (s.AllOf.Count() > 0)
                {
                    var schema = s.AllOf.First();
                    foreach (var property in schema.Properties)
                    {
                        res.FieldsSchema.Add(property.Key, ParseParentRef(property.Value));
                    }
                }
                return res.FieldsSchema;
            }
            else return null;
        }

        private static string ParseAction(KeyValuePair<string, JObject> item)
        {
            var s = JsonConvert.DeserializeObject<EntitySchemaInternal>(item.Value.ToString());
            var k = JsonConvert.DeserializeObject<EntitySchemaInternal2>(item.Value.ToString());

            if (ParseParentRef(item.Value) == "" && s.Required != null && s.Required.Count() == 1) 
            {
                return ParseParentRef(k.Properties);
            }
            else return null;
        }
        private static string ParseActionWithParameters(KeyValuePair<string, JObject> item)
        {
            var s = JsonConvert.DeserializeObject<EntitySchemaInternal>(item.Value.ToString());
            var k = JsonConvert.DeserializeObject<EntitySchemaInternal2>(item.Value.ToString());
            if (ParseParentRef(item.Value) == "" && s.Required != null && s.Required.Count() == 2)
            {
                string entityName= ParseParentRef(k.Properties);
                //action with parameters
                return entityName;
            }
            else return null;
        }
        private static Dictionary<string, string> ParseParameters(KeyValuePair<string, JObject> item)
        {
            var s = JsonConvert.DeserializeObject<EntitySchemaInternal>(item.Value.ToString());
            var k = JsonConvert.DeserializeObject<EntitySchemaInternal2>(item.Value.ToString());
            if (ParseParentRef(item.Value) == "" && s.Required != null && s.Required.Count() == 2)
            {
                Dictionary<string, string> result = new Dictionary<string, string>();
               var parameters= JsonConvert.DeserializeObject<Dictionary<string, object>>(k.Properties.Last.Last.ToString());
               
                foreach (var node in (JObject)parameters["properties"])
                {
                    result.Add(node.Key, ParseParentRef(node.Value));
                }
                // k.Properties;
                //action with parameters
                return result;
            }
            else return null;
        }

    }
}
