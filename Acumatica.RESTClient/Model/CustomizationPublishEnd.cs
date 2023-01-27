using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// CustomizationImport
    /// </summary>
    [DataContract]
    public partial class CustomizationPublishEnd
    {
        public CustomizationPublishEnd()
        {
        }


        [DataMember(Name = "isCompleted", EmitDefaultValue = false)]
        public bool IsCompleted { get; set; }

        [DataMember(Name = "isFailed", EmitDefaultValue = false)]
        public bool isFailed { get; set; }

        [DataMember(Name = "log", EmitDefaultValue = false)]
        public List<CustomizationPublishLog> Log { get; set; }

    }
}
