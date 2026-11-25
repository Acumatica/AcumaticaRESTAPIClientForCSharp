using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.RESTClient.CustomizationApi.Model
{
    /// <summary>
    /// The request body of the UnpublishAll call.
    /// </summary>
    [DataContract]
    public partial class CustomizationUnpublishParams
    {
        /// <summary>
        /// The tenants to unpublish for: <c>Current</c>, <c>All</c> or <c>List</c>.
        /// </summary>
        [DataMember(Name = "tenantMode", EmitDefaultValue = false)]
        public string? TenantMode { get; set; }

        /// <summary>
        /// The login names of the tenants to unpublish for. Used when <see cref="TenantMode"/> is <c>List</c>.
        /// </summary>
        [DataMember(Name = "tenantLoginNames", EmitDefaultValue = false)]
        public List<string>? TenantLoginNames { get; set; }
    }
}
