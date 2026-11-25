using System.Runtime.Serialization;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// The request body of the Delete call.
    /// </summary>
    [DataContract]
    public partial class CustomizationDeleteParams
    {
        /// <summary>
        /// The name of the customization project to delete.
        /// </summary>
        [DataMember(Name = "projectName", EmitDefaultValue = false)]
        public string? ProjectName { get; set; }
    }
}
