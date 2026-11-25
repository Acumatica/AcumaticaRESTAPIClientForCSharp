using System.Runtime.Serialization;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// A customization item of a published project.
    /// </summary>
    [DataContract]
    public partial class CustomizationPublishedItem
    {
        /// <summary>
        /// The key of the item.
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string? Key { get; set; }

        /// <summary>
        /// The ID of the screen the item belongs to.
        /// </summary>
        [DataMember(Name = "screenId", EmitDefaultValue = false)]
        public string? ScreenId { get; set; }

        /// <summary>
        /// The type of the item.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string? Type { get; set; }
    }
}
