namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// The request body of the GetProject call.
    /// </summary>
    public partial class CustomizationGetProjectParams
    {
        /// <summary>
        /// The name of the customization project.
        /// </summary>
        public string? ProjectName { get; set; }

        /// <summary>
        /// Indicates whether conflicts should be resolved automatically.
        /// </summary>
        public bool? IsAutoResolveConflicts { get; set; }
    }
}
