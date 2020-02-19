using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_18_200_001.Model;

namespace Acumatica.Default_18_200_001.Api
{
    public partial class ShipmentApi : EntityAPI<Shipment>
    {
        public ShipmentApi(Configuration configuration) : base(configuration)
        {
        }
        public string InvokeConfirmShipmentAction(Shipment shipment)
        {
            return InvokeAction(new ConfirmShipment(shipment));
        }
        public string InvokeCorrectShipmentAction(Shipment shipment)
        {
            return InvokeAction(new CorrectShipment(shipment));
        }
    }
}
