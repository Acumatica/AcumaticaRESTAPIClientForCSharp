using System.Collections.Generic;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// What is currently published on the site, as returned by GetPublished.
    /// </summary>
    public partial class CustomizationPublished : CustomizationResult
    {
        /// <summary>
        /// The published customization projects.
        /// </summary>
        public List<CustomizationPublishedProject>? Projects { get; set; }

        /// <summary>
        /// The customization items of the published projects.
        /// </summary>
        public List<CustomizationPublishedItem>? Items { get; set; }
    }
}
