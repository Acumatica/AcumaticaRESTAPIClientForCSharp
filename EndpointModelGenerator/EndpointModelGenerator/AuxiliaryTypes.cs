using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public class Components
    {
        public Dictionary<string, JObject> Schemas;
        public Dictionary<string, JObject> Parameters;

    }
    public class Schema
    {
        public Info Info { get; set; }
        public string BasePath { get; set; }
        public string? BaseEndpoint { get; set; }

        public List<NameDescrObject> Tags { get; set; }
     //   public Dictionary<string, Dictionary<string, object>> Paths { get; set; }
        public Dictionary<string, JObject> Definitions { get; set; }
        public Components Components { get; set; }
        public Dictionary<string, EntityDefinition> Entities { get; set; }
        public Dictionary<string, string> Actions { get; set; }
        public Dictionary<string, Dictionary<string, string>> Parameters { get; set; }
    }

    public class EntityDefinition
    {
        public bool IsTopLevel;
        public string? ScreenID;
        public HashSet<EntityField> Fields;
        public string? ParentReference;
        public EntityDefinition(bool isTopLevel, HashSet<EntityField> fields)
        {
            Fields = fields;
            IsTopLevel = isTopLevel;
        }
    }
    [DebuggerDisplay("{Name} {Type}")]
    public class EntityField
    {
        public string Type;
        public string Name;
        public string? View;
        public string? DACFieldName;
        public string? DAC;
        public string? DisplayName;
        public string? SqlType;
        public string? Summary;
        public string? Remarks;
        public bool? IsKey;

        public EntityField(string name, string type)
        {
            Name = name;
            Type = type;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
    public class FieldsSchema
    {
        public string? Type;
        public JObject? Properties;

        public Dictionary<string, object>? Parameters;
        public Dictionary<string, object>? Entity;
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
}
