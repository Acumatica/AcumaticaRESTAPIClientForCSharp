namespace Acumatica.RESTClient.Auxiliary
{
    /// <summary>
    /// The mode for customization publishing. 
    /// </summary>
    public enum TenantMode
    {
        /// <summary>
        /// The customization projects should be 
        /// published for the tenant where the user is currently logged in.
        /// </summary>
        Current,
        /// <summary>
        /// The customization projects should be published for all tenants.
        /// </summary>
        All,
        /// <summary>
        /// The customization projects should be published for the 
        /// tenants specified in the tenantLoginNames parameter.
        /// </summary>
        List
    }
}
