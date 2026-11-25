using System.Runtime.Serialization;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// A published customization project.
    /// </summary>
    [DataContract]
    public partial class CustomizationPublishedProject
    {
        /// <summary>
        /// The name of the project.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string? Name { get; set; }
    }
}
