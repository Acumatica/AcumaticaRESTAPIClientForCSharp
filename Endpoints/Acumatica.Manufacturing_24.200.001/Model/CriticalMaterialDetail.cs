using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class CriticalMaterialDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: IsAllocated</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// </summary>
		[DataMember(Name="Allocated", EmitDefaultValue=false)]
		public BooleanValue? Allocated { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Batch Size</para>
		/// </summary>
		[DataMember(Name="BatchSize", EmitDefaultValue=false)]
		public DecimalValue? BatchSize { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsByproduct2</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: By-product</para>
		/// </summary>
		[DataMember(Name="Byproduct", EmitDefaultValue=false)]
		public BooleanValue? Byproduct { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsStockItem</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Is stock</para>
		/// </summary>
		[DataMember(Name="Isstock", EmitDefaultValue=false)]
		public BooleanValue? Isstock { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LineID</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POCreate</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Mark for PO</para>
		/// </summary>
		[DataMember(Name="MarkforPO", EmitDefaultValue=false)]
		public BooleanValue? MarkforPO { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdCreate</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Mark for Production</para>
		/// </summary>
		[DataMember(Name="MarkforProduction", EmitDefaultValue=false)]
		public BooleanValue? MarkforProduction { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Material Type</para>
		/// </summary>
		[DataMember(Name="MaterialType", EmitDefaultValue=false)]
		public StringValue? MaterialType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Operation ID</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProdItemFilter</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: PO Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
		public StringValue? POOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Preferred Vendor ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="PreferredVendorID", EmitDefaultValue=false)]
		public StringValue? PreferredVendorID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.ProdItemFilter</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyAvail</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Qty. Available</para>
		/// </summary>
		[DataMember(Name="QtyAvailable", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailable { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyHardAvail</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Qty. Hard Available</para>
		/// </summary>
		[DataMember(Name="QtyHardAvailable", EmitDefaultValue=false)]
		public DecimalValue? QtyHardAvailable { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Qty On Hand</para>
		/// </summary>
		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHand { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Qty. Production Demand</para>
		/// </summary>
		[DataMember(Name="QtyProductionDemand", EmitDefaultValue=false)]
		public DecimalValue? QtyProductionDemand { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Qty. Production Demand Prepared</para>
		/// </summary>
		[DataMember(Name="QtyProductionDemandPrepared", EmitDefaultValue=false)]
		public DecimalValue? QtyProductionDemandPrepared { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Qty. Production Supply</para>
		/// </summary>
		[DataMember(Name="QtyProductionSupply", EmitDefaultValue=false)]
		public DecimalValue? QtyProductionSupply { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Qty. Production Supply Prepared</para>
		/// </summary>
		[DataMember(Name="QtyProductionSupplyPrepared", EmitDefaultValue=false)]
		public DecimalValue? QtyProductionSupplyPrepared { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Qty Remaining</para>
		/// </summary>
		[DataMember(Name="QtyRemaining", EmitDefaultValue=false)]
		public DecimalValue? QtyRemaining { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Qty Short</para>
		/// </summary>
		[DataMember(Name="QtyShort", EmitDefaultValue=false)]
		public DecimalValue? QtyShort { get; set; }

		/// <summary>
		/// Replenishment source
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Replenishment Source</para>
		/// <para>SQL Type: nvarchar(1)</para>
		/// </summary>
		[DataMember(Name="ReplenishmentSource", EmitDefaultValue=false)]
		public StringValue? ReplenishmentSource { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Required Date</para>
		/// </summary>
		[DataMember(Name="RequiredDate", EmitDefaultValue=false)]
		public DateTimeValue? RequiredDate { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMOrderType</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Sub. Assy. Order Type</para>
		/// <para>SQL Type: nchar(2)</para>
		/// </summary>
		[DataMember(Name="SubAssyOrderType", EmitDefaultValue=false)]
		public StringValue? SubAssyOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Sub. Assy. Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		[DataMember(Name="SubAssyProductionNbr", EmitDefaultValue=false)]
		public StringValue? SubAssyProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Subcontract Source</para>
		/// </summary>
		[DataMember(Name="SubcontractSource", EmitDefaultValue=false)]
		public StringValue? SubcontractSource { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TotalQtyRequired</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Total Required</para>
		/// </summary>
		[DataMember(Name="TotalRequired", EmitDefaultValue=false)]
		public DecimalValue? TotalRequired { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PreferredVendorID_Vendor_AcctName</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// </summary>
		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}