using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ShipmentDetail : Entity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<ShipmentDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.SO.SOShipLine 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: ExpireDate 
		/// DAC: PX.Objects.SO.SOShipLine 
		/// Display Name: Expiration Date 
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// DAC Field Name: IsFree 
		/// DAC: PX.Objects.SO.SOShipLine 
		/// Display Name: Free Item 
		/// </summary>
		[DataMember(Name="FreeItem", EmitDefaultValue=false)]
		public BooleanValue? FreeItem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipLine 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipLine 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipLine 
		/// Display Name: Location 
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipLine 
		/// Display Name: Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OpenOrderQty 
		/// DAC: PX.Objects.SO.SOShipLine 
		/// Display Name: Open Qty. 
		/// </summary>
		[DataMember(Name="OpenQty", EmitDefaultValue=false)]
		public DecimalValue? OpenQty { get; set; }

		/// <summary>
		/// DAC Field Name: OrigOrderQty 
		/// DAC: PX.Objects.SO.SOShipLine 
		/// </summary>
		[DataMember(Name="OrderedQty", EmitDefaultValue=false)]
		public DecimalValue? OrderedQty { get; set; }

		/// <summary>
		/// DAC Field Name: OrigLineNbr 
		/// DAC: PX.Objects.SO.SOShipLine 
		/// Display Name: Order Line Nbr. 
		/// </summary>
		[DataMember(Name="OrderLineNbr", EmitDefaultValue=false)]
		public IntValue? OrderLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OrigOrderNbr 
		/// DAC: PX.Objects.SO.SOShipLine 
		/// Display Name: Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OrigOrderType 
		/// DAC: PX.Objects.SO.SOShipLine 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: OriginalShippedQty 
		/// DAC: PX.Objects.SO.SOShipLine 
		/// Display Name: Original Qty. 
		/// </summary>
		[DataMember(Name="OriginalQty", EmitDefaultValue=false)]
		public DecimalValue? OriginalQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipLine 
		/// Display Name: Reason Code 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipLine 
		/// Display Name: Shipped Qty. 
		/// </summary>
		[DataMember(Name="ShippedQty", EmitDefaultValue=false)]
		public DecimalValue? ShippedQty { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.SO.SOShipLine 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOShipLine 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.SO.SOShipment 
		/// Display Name: Warehouse ID 
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

	}
}