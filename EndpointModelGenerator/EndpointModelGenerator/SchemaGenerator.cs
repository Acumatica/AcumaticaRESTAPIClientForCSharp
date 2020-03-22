using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
                    string.Format(DefaultNamespaceTemplate, endpoint.Replace(".", "_")),
                    schema);
            }
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
        private static void WriteCSharp(string outputPath, string endpointNamespace,  Schema schema)
        {
            string modelFilesDirectory = outputPath + "\\Model\\";
            string apiFilesDirectory = outputPath + "\\Api\\";
            foreach (var entity in schema.Entities)
            {
                StreamWriter writer = new StreamWriter(modelFilesDirectory + entity.Key + ".cs");
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
            foreach (var entity in schema.Entities)
            {
                StreamWriter writer = new StreamWriter(apiFilesDirectory + entity.Key + "Api.cs");

                string result = String.Format(Templates.ApiTemplate, endpointNamespace, entity.Key);
                Console.WriteLine(entity.Key + "Api");
                writer.Write(result);
                writer.Close();
            }

            foreach (var action in schema.Actions)
            {
                if (schema.Parameters.ContainsKey(action.Key))
                {
                    StreamWriter writer = new StreamWriter(modelFilesDirectory + "Actions/" + action.Key + ".cs");
                   
                    string result = String.Format(Templates.ActionWithParametersTemplate, endpointNamespace, action.Key, action.Value);
                 
                    writer.Write(Templates.ActionUsingsTemplate + result);
                    writer.Close();

                    writer = new StreamWriter(modelFilesDirectory + "ActionParameters/" + action.Key + "Parameters.cs");

                    string content = "";
                    foreach (var parameter in  schema.Parameters[action.Key])
                    { 
                        String.Format(Templates.ParameterTemplate, parameter.Key, parameter.Value);
                    }
                    result = String.Format(Templates.ActionParametersTemplate, endpointNamespace, action.Key, content);
                    Console.WriteLine("ActionsWithParameters/" + action.Key);
                    writer.Write(result);
                    writer.Close();
                }
                else
                {
                    StreamWriter writer = new StreamWriter(modelFilesDirectory + "Actions/" + action.Key + ".cs");

                    string result = String.Format(Templates.ActionTemplate, endpointNamespace, action.Key, action.Value);
                    Console.WriteLine("Actions/" + action.Key);
                    writer.Write(Templates.ActionUsingsTemplate + result);
                    writer.Close();
                }
            }
        }

        private static Schema ComposeEndpointSchema(string input)
        {
            var schema = JsonConvert.DeserializeObject<Schema>(input);
            foreach (var item in IgnoreList)
            {
                schema.Definitions.Remove(item);
            }
            schema.Entities = new Dictionary<string, Dictionary<string, string>>();
            foreach (var item in schema.Definitions)
            {
                var res = ParseObject(item);
                if (res != null)
                    schema.Entities.Add(item.Key, ParseObject(item));
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
