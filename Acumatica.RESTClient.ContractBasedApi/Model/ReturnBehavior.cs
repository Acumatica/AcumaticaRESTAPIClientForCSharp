using System;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [Obsolete("Only for compatibility with SOAP")]
    public enum ReturnBehavior
    {
        Default,
        All,
        None,
        OnlySystem,
        OnlySpecified,
    }
}
