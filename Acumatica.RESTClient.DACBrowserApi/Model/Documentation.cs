using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Acumatica.RESTClient.DACBrowserApi.Model
{
    [DataContract]
    public class Documentation
    {
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public string Summary { get; set; }

        [DataMember(Name = "remarks", EmitDefaultValue = false)]
        public string Remarks { get; set; }
    }
}
