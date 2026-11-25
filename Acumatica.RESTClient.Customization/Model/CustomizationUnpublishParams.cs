using System.Collections.Generic;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// The request body of the UnpublishAll call.
    /// </summary>
    public partial class CustomizationUnpublishParams
    {
        /// <summary>
        /// The tenants to unpublish for: <c>Current</c>, <c>All</c> or <c>List</c>.
        /// </summary>
        public string? TenantMode { get; set; }

        /// <summary>
        /// The login names of the tenants to unpublish for. Used when <see cref="TenantMode"/> is <c>List</c>.
        /// </summary>
        public List<string>? TenantLoginNames { get; set; }
    }
}
