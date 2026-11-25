using System;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// A customization project returned by GetProject.
    /// </summary>
    public partial class CustomizationProject : CustomizationResult
    {
        /// <summary>
        /// The customization package (a zip archive), encoded as Base64.
        /// </summary>
        public string? ProjectContentBase64 { get; set; }

        /// <summary>
        /// Indicates whether the project has conflicts.
        /// </summary>
        public bool? HasConflicts { get; set; }

        /// <summary>
        /// Gets the customization package (a zip archive) as bytes.
        /// </summary>
        /// <returns>The package, or <c>null</c> if the server did not return any content.</returns>
        public byte[]? GetContent()
        {
            return string.IsNullOrEmpty(ProjectContentBase64) ? null : Convert.FromBase64String(ProjectContentBase64);
        }
    }
}
