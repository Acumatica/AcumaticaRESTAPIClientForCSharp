using System;

namespace Acumatica.RESTClient.ODataApi
{
    public enum ODataVersion
    {
        [Obsolete("Starting from Acumatica 2024r2, use GIBasedOData instead.")]
        OData,
        [Obsolete("Starting from Acumatica 2024r2, use DACBasedOData instead.")]
        ODatav4, 
        GIBasedOData, 
        DACBasedOData
    } 

}
