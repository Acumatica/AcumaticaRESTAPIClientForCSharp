using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;

using Newtonsoft.Json.Linq;

namespace Acumatica.RESTClient.ODataApi.Model
{
    [DataContract]
    public class ODataResults
    {
        [DataMember(Name = "@odata.context", EmitDefaultValue = false)]
        public string Context;
        [DataMember(Name = "odata.metadata", EmitDefaultValue = false)]
        public string MetadataUrl;
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public JObject[] Results;
    }
    [DebuggerDisplay("{Name}")]
    [DataContract]
    public class ODataObject 
    {
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name;
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url;
    }
}
