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

    public class Info
    {

        public string Version { get; set; }
        public string Title { get; set; }
    }
    public class NameDescrObject
    {
        public string Name;
        public string Description;
    }
    public class Schema
    {
        public Info Info { get; set; }
        public string BasePath { get; set; }

        public List<NameDescrObject> Tags;
        public Dictionary<string, Dictionary<string, object>> Paths { get; set; }
        public Dictionary<string, JObject> Definitions { get; set; }
        public HashSet<string> TopLevelEntities { get; set; }
        public Dictionary<string, Dictionary<string, string>> Entities { get; set; }
        public Dictionary<string, string> Actions { get; set; }
        public Dictionary<string, Dictionary<string, string>> Parameters { get; set; }
    }

    public class FieldsSchema
    {
        public string Type;
        public JObject Properties;

        public Dictionary<string, object> Parameters;
        public Dictionary<string, object> Entity;
    }

    public class EntitySchemaInternal
    {
        public List<string> Required = new List<string>();
        public FieldsSchema Properties;
        public List<FieldsSchema> AllOf = new List<FieldsSchema>();
    }
    public class EntitySchemaInternal2
    {
        public JObject Properties;
    }
    public class EntitySchema
    {
        public string ParentReference;
        public Dictionary<string, string> FieldsSchema = new Dictionary<string, string>();
    }
}
