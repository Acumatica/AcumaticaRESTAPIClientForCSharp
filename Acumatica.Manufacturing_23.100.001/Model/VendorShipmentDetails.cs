using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class VendorShipmentDetails : Entity
	{

		/// <summary>
		/// DAC Field Name: InventoryID_description 
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: ExpireDate 
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// Display Name: Expiration Date 
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// Display Name: Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// DAC Field Name: MatlLineID 
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// Display Name: Material Line Nbr. 
		/// </summary>
		[DataMember(Name="MaterialLineNbr", EmitDefaultValue=false)]
		public IntValue? MaterialLineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// Display Name: Operation ID 
		/// </summary>
		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// Display Name: PO Line Nbr. 
		/// </summary>
		[DataMember(Name="POLineNbr", EmitDefaultValue=false)]
		public IntValue? POLineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// Display Name: PO Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
		public StringValue? POOrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// Display Name: Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// </summary>
		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// </summary>
		[DataMember(Name="Released", EmitDefaultValue=false)]
		public BooleanValue? Released { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// Display Name: Tran Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="TranDescription", EmitDefaultValue=false)]
		public StringValue? TranDescription { get; set; }

		/// <summary>
		/// DAC Field Name: LineType 
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipLine 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}