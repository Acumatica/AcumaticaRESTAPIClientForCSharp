using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Acumatica.RESTClient.DACBrowserApi.Model
{
    [DataContract]
    [DebuggerDisplay("{Namespace}.{Name}")]
    public class DACReference
    {
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

    }
}
