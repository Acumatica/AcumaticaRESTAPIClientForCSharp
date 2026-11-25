namespace Acumatica.RESTClient.CustomizationApi
{
    /// <summary>
    /// The tenants a customization is published for.
    /// </summary>
    public enum TenantMode
    {
        /// <summary>
        /// The customization projects are published for the tenant
        /// where the user is currently logged in.
        /// </summary>
        Current,
        /// <summary>
        /// The customization projects are published for all tenants.
        /// </summary>
        All,
        /// <summary>
        /// The customization projects are published for the tenants
        /// specified in the <c>tenantLoginNames</c> parameter.
        /// </summary>
        List
    }
}
