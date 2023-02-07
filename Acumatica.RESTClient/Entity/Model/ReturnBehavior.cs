using System;

namespace Acumatica.RESTClient.Model
{
    [Obsolete("Only for SOAP compatibility.")]
    public enum ReturnBehavior
    {
        Default,
        All,
        None,
        OnlySystem,
        OnlySpecified,
    }
}
