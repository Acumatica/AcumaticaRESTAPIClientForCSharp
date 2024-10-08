using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndpointSchemaGenerator
{
	public static class JsonSchemaParser
	{
        #region setting
        public static bool GenerateArraysInstedOfLists = false;

        // List of entities that are shared between all endpoints
        public static string[] IgnoreList = new string[] { "StringValue", "LongValue", "CustomStringField",
        "CustomDecimalField", "CustomDateTimeField", "CustomBooleanField", "CustomIntField", "CustomLongField",
        "CustomShortField", "CustoByteField", "CustomDoubleField", "CustomGuidField", "CustomField",
        "DecimalValue", "DateTimeValue", "BooleanValue", "IntValue", "ShortValue", "ByteValue", "DoubleValue",
        "GuidValue", "FileLink", "Entity", "HttpError", "CustomByteField"};
        #endregion


        public static Schema ComposeEndpointSchema(string input)
        {
            Schema schema = JsonConvert.DeserializeObject<Schema>(input)!;
            foreach (string item in IgnoreList.Union((schema.Definitions ?? schema.Components.Schemas).Keys.Where(s => s.EndsWith("CustomAction"))).ToArray())
            {
                (schema.Definitions ?? schema.Components.Schemas).Remove(item);
            }

            schema.Entities = new Dictionary<string, EntityDefinition>();
            foreach (var item in (schema.Definitions ?? schema.Components.Schemas))
            {
                var fieldsSchema = ParseFieldsSchema(item);
                if (fieldsSchema != null)
                {
                    schema.Entities.Add(item.Key, new EntityDefinition(IsTopLevelEntity(schema, item.Key), fieldsSchema));
                }
            }
            schema.Actions = new Dictionary<string, string>();
            foreach (var item in (schema.Definitions ?? schema.Components.Schemas))
            {
                string entityType = ParseAction(item);
                if (!String.IsNullOrEmpty(entityType))
                {
                    schema.Actions.Add(item.Key, entityType);
                }
            }
            schema.Parameters = new Dictionary<string, Dictionary<string, string>>();
            foreach (var item in (schema.Definitions ?? schema.Components.Schemas))
            {
                string entityType = ParseActionWithParameters(item);
                if (!String.IsNullOrEmpty(entityType))
                {
                    schema.Actions.Add(item.Key, entityType);
                    schema.Parameters.Add(item.Key, ParseParameters(item));
                }
            }
            //Dictionary<string, Dictionary<string, string>> parameters = new Dictionary<string, Dictionary<string, string>>();
            //foreach (var item in (schema.Definitions ?? schema.Components.Schemas))
            //{
            //    //    entities.Add(item.Key, ParseObject(item));
            //}

            return schema;
        }

        private static bool IsTopLevelEntity(Schema schema, string key)
        {
            return schema.Tags.Where(_ => _.Name == key).Any();
        }

        public static string ParseParentRef(JToken jsonObject)
        {
            const string definitions= "definitions/";
            const string components = "components/schemas/";
            var s = jsonObject.Children().First().Children().First().ToString();
            if (s.Contains(definitions))
            {
                s = s.Substring(s.IndexOf(definitions) + definitions.Length);
                if (s.IndexOf("\"") > 0)
                {
                    s = s.Substring(0, s.IndexOf("\""));
                }
                return s;
            }
            else if (s.Contains(components))
            {
                s = s.Substring(s.IndexOf(components) + components.Length);
                if (s.IndexOf("\"") > 0)
                {
                    s = s.Substring(0, s.IndexOf("\""));
                }
                return s;
            }
            else if (s.Contains("array"))
            {
                var k = jsonObject.ToString();
                if (k.Contains(definitions))
                {
                    k = k.Substring(k.IndexOf(definitions) + definitions.Length);
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
                else if (k.Contains(components))
                {
                    k = k.Substring(k.IndexOf(components) + components.Length);
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
        public static string? TryParseParentRef(JObject jsonObject)
        {
            try
            {
                return ParseParentRef(jsonObject.Children().First());
            }
            catch { return null; }
        }
        private static HashSet<EntityField>? ParseFieldsSchema(KeyValuePair<string, JObject> item)
        {
            var s = JsonConvert.DeserializeObject<EntitySchemaInternal>(item.Value.ToString());
            var fieldsSchema = new HashSet<EntityField>();
            if (TryParseParentRef(item.Value) == "Entity")
            {
                s.AllOf.Remove(null);
                if (s.AllOf.Count() > 0)
                {
                    var schema = s.AllOf.First();
                    if (schema?.Properties != null)
                    {
                        foreach (var property in schema.Properties)
                        {
                            fieldsSchema.Add(new EntityField(property.Key, ParseParentRef(property.Value)));
                        }
                    }
                }
                return fieldsSchema;
            }
            else return null;
        }

        private static string? ParseAction(KeyValuePair<string, JObject> item)
        {
            var s = JsonConvert.DeserializeObject<EntitySchemaInternal>(item.Value.ToString());
            var k = JsonConvert.DeserializeObject<EntitySchemaInternal2>(item.Value.ToString());

            if (ParseParentRef(item.Value) == "" && s.Required != null && s.Required.Count() == 1)
            {
                return ParseParentRef(k.Properties);
            }
            else return null;
        }
        private static string? ParseActionWithParameters(KeyValuePair<string, JObject> item)
        {
            var s = JsonConvert.DeserializeObject<EntitySchemaInternal>(item.Value.ToString());
            var k = JsonConvert.DeserializeObject<EntitySchemaInternal2>(item.Value.ToString());
            if (ParseParentRef(item.Value) == "" && s.Required != null && s.Required.Count() == 2)
            {
                string entityName = ParseParentRef(k.Properties);
                //action with parameters
                return entityName;
            }
            else return null;
        }
        private static Dictionary<string, string>? ParseParameters(KeyValuePair<string, JObject> item)
        {
            var s = JsonConvert.DeserializeObject<EntitySchemaInternal>(item.Value.ToString());
            var k = JsonConvert.DeserializeObject<EntitySchemaInternal2>(item.Value.ToString());
            if (ParseParentRef(item.Value) == "" && s.Required != null && s.Required.Count() == 2)
            {
                Dictionary<string, string> result = new Dictionary<string, string>();
                var parameters = JsonConvert.DeserializeObject<Dictionary<string, object>>(k.Properties.Last.Last.ToString());

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
