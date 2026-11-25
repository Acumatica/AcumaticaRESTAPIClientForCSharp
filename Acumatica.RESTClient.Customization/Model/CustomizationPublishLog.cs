using System.Runtime.Serialization;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// A record of the publishing log.
    /// </summary>
    [DataContract]
    public partial class CustomizationPublishLog
    {
        /// <summary>
        /// When the record was created, as returned by the server.
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public string? Timestamp { get; set; }

        /// <summary>
        /// The kind of the record, as returned by the server: trace, information, warning, error or html.
        /// </summary>
        [DataMember(Name = "logType", EmitDefaultValue = false)]
        public string? LogType { get; set; }

        /// <summary>
        /// The text of the record.
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string? Message { get; set; }
    }
}
