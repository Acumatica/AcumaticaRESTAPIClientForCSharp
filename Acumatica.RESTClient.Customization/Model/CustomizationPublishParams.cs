using System.Collections.Generic;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// The request body of the PublishBegin call: which projects to publish and how.
    /// </summary>
    public partial class CustomizationPublishParams
    {
        /// <summary>
        /// Indicates whether the listed projects should be published together with the currently published projects.
        /// </summary>
        public bool? IsMergeWithExistingPackages { get; set; }

        /// <summary>
        /// Indicates whether only project validation should be performed.
        /// </summary>
        public bool? IsOnlyValidation { get; set; }

        /// <summary>
        /// Indicates whether the changes should be applied only to the database.
        /// </summary>
        public bool? IsOnlyDbUpdates { get; set; }

        /// <summary>
        /// Indicates whether database scripts that were previously applied should be executed again.
        /// </summary>
        public bool? IsReplayPreviouslyExecutedScripts { get; set; }

        /// <summary>
        /// The names of the customization projects to publish.
        /// </summary>
        public List<string>? ProjectNames { get; set; }

        /// <summary>
        /// The tenants to publish for: <c>Current</c>, <c>All</c> or <c>List</c>.
        /// </summary>
        public string? TenantMode { get; set; }

        /// <summary>
        /// The login names of the tenants to publish for. Used when <see cref="TenantMode"/> is <c>List</c>.
        /// </summary>
        public List<string>? TenantLoginNames { get; set; }
    }
}
