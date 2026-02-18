using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class VendorShipmentDetails : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: InventoryID_description</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MatlLineID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// <para>Display Name: Material Line Nbr.</para>
		/// </summary>
		public IntValue? MaterialLineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// <para>Display Name: Operation ID</para>
		/// </summary>
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// <para>Display Name: PO Line Nbr.</para>
		/// </summary>
		public IntValue? POLineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// <para>Display Name: PO Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? POOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// </summary>
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// </summary>
		public BooleanValue? Released { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// <para>Display Name: Tran Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? TranDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LineType</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMVendorShipLine</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMVendorShipment</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

	}
}