namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// The state of the publishing started with PublishBegin.
    /// </summary>
    public partial class CustomizationPublishEnd : CustomizationResult
    {
        /// <summary>
        /// Indicates whether the publishing is finished.
        /// </summary>
        public bool? IsCompleted { get; set; }

        /// <summary>
        /// Indicates whether the publishing failed.
        /// </summary>
        public bool? IsFailed { get; set; }
    }
}
