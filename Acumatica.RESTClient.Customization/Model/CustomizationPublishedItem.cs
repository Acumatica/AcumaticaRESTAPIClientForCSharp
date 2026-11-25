namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// A customization item of a published project.
    /// </summary>
    public partial class CustomizationPublishedItem
    {
        /// <summary>
        /// The key of the item.
        /// </summary>
        public string? Key { get; set; }

        /// <summary>
        /// The ID of the screen the item belongs to.
        /// </summary>
        public string? ScreenId { get; set; }

        /// <summary>
        /// The type of the item.
        /// </summary>
        public string? Type { get; set; }
    }
}
