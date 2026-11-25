using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Acumatica.RESTClient.ODataApi.Model
{
    public class ODataResults
    {
        [JsonProperty("@odata.context")]
        public string Context;
        [JsonProperty("odata.metadata")]
        public string MetadataUrl;
        [JsonProperty("value")]
        public JObject[] Results;
    }
    [DebuggerDisplay("{Name}")]
    public class ODataObject 
    {
        public string Name;
        public string Url;
    }
}
