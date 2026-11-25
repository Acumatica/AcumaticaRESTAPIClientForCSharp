using System;

namespace Acumatica.RESTClient.Api
{
    /// <summary>
    ///     The content types that can be used in the Content-Type and Accept headers. Values can be combined with <c>|</c>.
    /// </summary>
    [Flags]
    public enum HeaderContentType : short
    {
        /// <summary>No content type.</summary>
        None = 0,
        /// <summary>JSON (<c>application/json</c>).</summary>
        Json = 1,
        /// <summary>XML (<c>application/xml</c>).</summary>
        Xml = 2,
        /// <summary>Any content type (<c>*/*</c>).</summary>
        Any = 4,
        /// <summary>URL-encoded form data (<c>application/x-www-form-urlencoded</c>).</summary>
        WwwForm = 8,
        /// <summary>Binary data (<c>application/octet-stream</c>).</summary>
        OctetStream = 16, 
        /// <summary>PDF (<c>application/pdf</c>).</summary>
        PDF = 32,
        /// <summary>HTML (<c>text/html</c>).</summary>
        HTML = 64,
        /// <summary>Excel workbook (<c>.xlsx</c>).</summary>
        Excel = 128,
    };
}
