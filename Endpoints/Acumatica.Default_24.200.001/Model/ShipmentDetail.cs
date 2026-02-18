using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ShipmentDetail : Entity
	{

		public List<ShipmentDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsFree</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Free Item</para>
		/// </summary>
		public BooleanValue? FreeItem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OpenOrderQty</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Open Qty.</para>
		/// </summary>
		public DecimalValue? OpenQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigOrderQty</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// </summary>
		public DecimalValue? OrderedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigLineNbr</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Order Line Nbr.</para>
		/// </summary>
		public IntValue? OrderLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigOrderNbr</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigOrderType</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OriginalShippedQty</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Original Qty.</para>
		/// </summary>
		public DecimalValue? OriginalQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Reason Code</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Shipped Qty.</para>
		/// </summary>
		public DecimalValue? ShippedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Warehouse ID</para>
		/// </summary>
		public StringValue? WarehouseID { get; set; }

	}
}