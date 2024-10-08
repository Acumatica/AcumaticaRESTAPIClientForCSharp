using System.Runtime.Serialization;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// CustomizationImport
    /// </summary>
    [DataContract]
    public partial class CustomizationImport
    {
        public CustomizationImport()
        {
        }


        [DataMember(Name= "projectLevel", EmitDefaultValue=false)]
        public int? ProjectLevel { get; set; }

        [DataMember(Name = "isReplaceIfExists", EmitDefaultValue = false)]
        public bool? IsReplaceIfExists { get; set; }

        [DataMember(Name = "projectName", EmitDefaultValue = false)]
        public string? ProjectName { get; set; }

        [DataMember(Name = "projectDescription", EmitDefaultValue = false)]
        public string? ProjectDescription { get; set; }

        [DataMember(Name = "projectContentBase64", EmitDefaultValue = false)]
        public string? ProjectContentBase64 { get; set; }

    }
}
