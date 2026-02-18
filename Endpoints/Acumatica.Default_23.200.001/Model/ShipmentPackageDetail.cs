using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class ShipmentPackageDetail : Entity
	{

		public StringValue? InventoryID { get; set; }

		public StringValue? LotSerialNbr { get; set; }

		public StringValue? OrigOrderNbr { get; set; }

		public StringValue? OrigOrderType { get; set; }

		public DecimalValue? Quantity { get; set; }

		public IntValue? ShipmentSplitLineNbr { get; set; }

		public StringValue? Subitem { get; set; }

		public StringValue? UOM { get; set; }

	}
}