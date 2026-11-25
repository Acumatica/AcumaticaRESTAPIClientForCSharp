namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// The request body of the Import call: a customization package and how to import it.
    /// </summary>
    public partial class CustomizationImport
    {
        /// <summary>
        /// The level of the customization project.
        /// </summary>
        public int? ProjectLevel { get; set; }

        /// <summary>
        /// Indicates whether an existing project with the same name should be replaced.
        /// </summary>
        public bool? IsReplaceIfExists { get; set; }

        /// <summary>
        /// The name of the customization project.
        /// </summary>
        public string? ProjectName { get; set; }

        /// <summary>
        /// The description of the customization project.
        /// </summary>
        public string? ProjectDescription { get; set; }

        /// <summary>
        /// The content of the customization package (a zip archive), encoded as Base64.
        /// </summary>
        public string? ProjectContentBase64 { get; set; }
    }
}
