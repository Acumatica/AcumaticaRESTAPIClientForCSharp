using System.Runtime.Serialization;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// The request body of the Import call: a customization package and how to import it.
    /// </summary>
    [DataContract]
    public partial class CustomizationImport
    {
        /// <summary>
        /// The level of the customization project.
        /// </summary>
        [DataMember(Name = "projectLevel", EmitDefaultValue = false)]
        public int? ProjectLevel { get; set; }

        /// <summary>
        /// Indicates whether an existing project with the same name should be replaced.
        /// </summary>
        [DataMember(Name = "isReplaceIfExists", EmitDefaultValue = false)]
        public bool? IsReplaceIfExists { get; set; }

        /// <summary>
        /// The name of the customization project.
        /// </summary>
        [DataMember(Name = "projectName", EmitDefaultValue = false)]
        public string? ProjectName { get; set; }

        /// <summary>
        /// The description of the customization project.
        /// </summary>
        [DataMember(Name = "projectDescription", EmitDefaultValue = false)]
        public string? ProjectDescription { get; set; }

        /// <summary>
        /// The content of the customization package (a zip archive), encoded as Base64.
        /// </summary>
        [DataMember(Name = "projectContentBase64", EmitDefaultValue = false)]
        public string? ProjectContentBase64 { get; set; }
    }
}
