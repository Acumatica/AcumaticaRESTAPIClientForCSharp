using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Acumatica.RESTClient.DACBrowserApi.Model
{
    [DataContract]
    public class DAC
    {
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string Namespace { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
       
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        [DataMember(Name = "isHidden", EmitDefaultValue = false)]
        public bool IsHidden { get; set; }

        [DataMember(Name = "existsInDb", EmitDefaultValue = false)]
        public bool ExistsInDb { get; set; }

        [DataMember(Name = "primaryScreens", EmitDefaultValue = false)]
        public PrimaryScreen[] PrimaryScreens { get; set; }

        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public Field[] Fields { get; set; }

        [DataMember(Name = "documentation", EmitDefaultValue = false)]
        public Documentation? Documentation { get; set; }

    }
}
