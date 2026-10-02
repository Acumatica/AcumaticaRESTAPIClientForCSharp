using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class SalesOrderDetailAllocation : Entity
	{

		#region Fields
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

		public StringValue? UOM { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}