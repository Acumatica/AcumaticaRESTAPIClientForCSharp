using System.Runtime.Serialization;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// CustomizationImport
    /// </summary>
    [DataContract]
    public partial class CustomizationPublishLog
    {
        public CustomizationPublishLog()
        {
        }


        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public string? Timestamp { get; set; }

        [DataMember(Name = "logType", EmitDefaultValue = false)]
        public string? LogType { get; set; }

        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string? Message { get; set; }

    }
}
