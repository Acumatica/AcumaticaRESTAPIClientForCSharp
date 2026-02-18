using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class SalesOrderDetailAllocation : Entity
	{

		public BooleanValue? Allocated { get; set; }

		public StringValue? AllocWarehouseID { get; set; }

		public BooleanValue? Completed { get; set; }

		public StringValue? CustomerOrderNbr { get; set; }

		public DateTimeValue? ExpirationDate { get; set; }

		public StringValue? InventoryID { get; set; }

		public IntValue? LineNbr { get; set; }

		public StringValue? LocationID { get; set; }

		public StringValue? LotSerialNbr { get; set; }

		public StringValue? OrderNbr { get; set; }

		public StringValue? OrderType { get; set; }

		public DecimalValue? Qty { get; set; }

		public DecimalValue? QtyOnShipments { get; set; }

		public DecimalValue? QtyReceived { get; set; }

		public StringValue? RelatedDocument { get; set; }

		public DateTimeValue? SchedOrderDate { get; set; }

		public DateTimeValue? ShipOn { get; set; }

		public IntValue? SplitLineNbr { get; set; }

		public StringValue? Subitem { get; set; }

		public StringValue? UOM { get; set; }

	}
}