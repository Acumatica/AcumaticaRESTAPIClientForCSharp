using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Acumatica.RESTClient.DACBrowserApi.Model
{
    [DataContract]
    public class Field
    {
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "isKey", EmitDefaultValue = false)]
        public bool IsKey { get; set; }

        [DataMember(Name = "dacName", EmitDefaultValue = false)]
        public string DacName { get; set; }

        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        [DataMember(Name = "sqlType", EmitDefaultValue = false)]
        public string SqlType { get; set; }

        [DataMember(Name = "documentation", EmitDefaultValue = false)]
        public Documentation? Documentation { get; set; }

    }
}
