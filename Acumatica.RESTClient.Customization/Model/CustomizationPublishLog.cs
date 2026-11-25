namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// A record of the publishing log.
    /// </summary>
    public partial class CustomizationPublishLog
    {
        /// <summary>
        /// When the record was created, as returned by the server.
        /// </summary>
        public string? Timestamp { get; set; }

        /// <summary>
        /// The kind of the record, as returned by the server: trace, information, warning, error or html.
        /// </summary>
        public string? LogType { get; set; }

        /// <summary>
        /// The text of the record.
        /// </summary>
        public string? Message { get; set; }
    }
}
