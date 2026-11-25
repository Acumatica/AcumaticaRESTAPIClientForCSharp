using System.Runtime.Serialization;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// The request body of the GetProject call.
    /// </summary>
    [DataContract]
    public partial class CustomizationGetProjectParams
    {
        /// <summary>
        /// The name of the customization project.
        /// </summary>
        [DataMember(Name = "projectName", EmitDefaultValue = false)]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Indicates whether conflicts should be resolved automatically.
        /// </summary>
        [DataMember(Name = "isAutoResolveConflicts", EmitDefaultValue = false)]
        public bool? IsAutoResolveConflicts { get; set; }
    }
}
