using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.DeviceHub_19_200_001.Model;

namespace Acumatica.DeviceHub_19_200_001.Api
{
    public partial class ScannerApi : EntityAPI<Scanner>
    {
        public ScannerApi() : base()
        {
        }
        public ScannerApi(Configuration configuration) : base(configuration)
        {
        }
        public string InvokeUpdatePrinterListAction(Scanner scanner)
        {
            return InvokeAction(new UpdateScannerList(scanner));
        }
    }
}
