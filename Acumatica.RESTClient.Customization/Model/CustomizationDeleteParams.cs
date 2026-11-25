namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// The request body of the Delete call.
    /// </summary>
    public partial class CustomizationDeleteParams
    {
        /// <summary>
        /// The name of the customization project to delete.
        /// </summary>
        public string? ProjectName { get; set; }
    }
}
