using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// CustomizationImport
    /// </summary>
    [DataContract]
    public partial class CustomizationPublishEnd
    {

        [DataMember(Name = "isCompleted", EmitDefaultValue = false)]
        public bool? IsCompleted { get; set; }

        [DataMember(Name = "isFailed", EmitDefaultValue = false)]
        public bool? isFailed { get; set; }

        [DataMember(Name = "log", EmitDefaultValue = false)]
        public List<CustomizationPublishLog>? Log { get; set; }

    }
}
