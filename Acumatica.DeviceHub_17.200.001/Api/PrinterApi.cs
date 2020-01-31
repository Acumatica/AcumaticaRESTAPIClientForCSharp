using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.DeviceHub_17_200_001.Model;

namespace Acumatica.DeviceHub_17_200_001.Api
{
    public partial class PrinterApi : EntityAPI<Printer>
    {
        public PrinterApi() : base()
        {
        }
        public PrinterApi(Configuration configuration) : base(configuration)
        {
        }
        public string InvokeUpdatePrinterListAction(Printer printer)
        {
            return InvokeAction(new UpdatePrinterList(printer));
        }
    }
}
