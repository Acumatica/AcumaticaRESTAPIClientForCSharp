using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class ShipmentDetail : Entity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<ShipmentDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsFree</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Free Item</para>
		/// </summary>
		[DataMember(Name="FreeItem", EmitDefaultValue=false)]
		public BooleanValue? FreeItem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OpenOrderQty</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Open Qty.</para>
		/// </summary>
		[DataMember(Name="OpenQty", EmitDefaultValue=false)]
		public DecimalValue? OpenQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigOrderQty</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// </summary>
		[DataMember(Name="OrderedQty", EmitDefaultValue=false)]
		public DecimalValue? OrderedQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigLineNbr</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Order Line Nbr.</para>
		/// </summary>
		[DataMember(Name="OrderLineNbr", EmitDefaultValue=false)]
		public IntValue? OrderLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigOrderNbr</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrigOrderType</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OriginalShippedQty</para>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Original Qty.</para>
		/// </summary>
		[DataMember(Name="OriginalQty", EmitDefaultValue=false)]
		public DecimalValue? OriginalQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Reason Code</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>Display Name: Shipped Qty.</para>
		/// </summary>
		[DataMember(Name="ShippedQty", EmitDefaultValue=false)]
		public DecimalValue? ShippedQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOShipLine</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.SO.SOShipment</para>
		/// <para>Display Name: Warehouse ID</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

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