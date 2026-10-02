using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class ShipmentDetail : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Warehouse ID</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigOrderType</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigOrderNbr</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigLineNbr</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Order Line Nbr.</para>
		/// </summary>
		public IntValue? OrderLineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsFree</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Free Item</para>
		/// </summary>
		public BooleanValue? FreeItem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Shipped Qty.</para>
		/// </summary>
		public DecimalValue? ShippedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OriginalShippedQty</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Original Qty.</para>
		/// </summary>
		public DecimalValue? OriginalQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigOrderQty</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// </summary>
		public DecimalValue? OrderedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OpenOrderQty</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Open Qty.</para>
		/// </summary>
		public DecimalValue? OpenQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Reason Code</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		#endregion

		#region Details
		public List<ShipmentDetailAllocation>? Allocations { get; set; }

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
			public const string Allocations = "Allocations";

			//Intentionally excluded
			//public const string All = "Files,Allocations";
		}
	}
}