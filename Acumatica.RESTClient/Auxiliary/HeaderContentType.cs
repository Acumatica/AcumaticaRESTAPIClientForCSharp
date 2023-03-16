using System;

namespace Acumatica.RESTClient.Api
{
    [Flags]
    public enum HeaderContentType : short
    {
        None = 0,
        Json = 1,
        Xml = 2,
        Any = 4,
        WwwForm = 8,
        OctetStream = 16
    };
}
