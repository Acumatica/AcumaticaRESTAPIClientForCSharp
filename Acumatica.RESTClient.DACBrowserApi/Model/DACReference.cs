using System.Diagnostics;

namespace Acumatica.RESTClient.DACBrowserApi.Model
{
    [DebuggerDisplay("{Namespace}.{Name}")]
    public class DACReference
    {
        public string Name { get; set; }

        public string Namespace { get; set; }

    }
}
