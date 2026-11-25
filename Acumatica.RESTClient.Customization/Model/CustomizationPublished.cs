using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// What is currently published on the site, as returned by GetPublished.
    /// </summary>
    [DataContract]
    public partial class CustomizationPublished : CustomizationResult
    {
        /// <summary>
        /// The published customization projects.
        /// </summary>
        [DataMember(Name = "projects", EmitDefaultValue = false)]
        public List<CustomizationPublishedProject>? Projects { get; set; }

        /// <summary>
        /// The customization items of the published projects.
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<CustomizationPublishedItem>? Items { get; set; }
    }
}
