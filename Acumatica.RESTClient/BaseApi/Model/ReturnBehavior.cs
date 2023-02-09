using System;

namespace Acumatica.RESTClient.Model
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
