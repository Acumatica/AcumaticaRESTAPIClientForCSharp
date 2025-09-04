using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	[DataContract]
	public class CriticalMaterialDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: IsAllocated 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// </summary>
		[DataMember(Name="Allocated", EmitDefaultValue=false)]
		public BooleanValue? Allocated { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Batch Size 
		/// </summary>
		[DataMember(Name="BatchSize", EmitDefaultValue=false)]
		public DecimalValue? BatchSize { get; set; }

		/// <summary>
		/// DAC Field Name: IsByproduct2 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: By-product 
		/// </summary>
		[DataMember(Name="Byproduct", EmitDefaultValue=false)]
		public BooleanValue? Byproduct { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: IsStockItem 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Is stock 
		/// </summary>
		[DataMember(Name="Isstock", EmitDefaultValue=false)]
		public BooleanValue? Isstock { get; set; }

		/// <summary>
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Item Class 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// DAC Field Name: LineID 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: POCreate 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Mark for PO 
		/// </summary>
		[DataMember(Name="MarkforPO", EmitDefaultValue=false)]
		public BooleanValue? MarkforPO { get; set; }

		/// <summary>
		/// DAC Field Name: ProdCreate 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Mark for Production 
		/// </summary>
		[DataMember(Name="MarkforProduction", EmitDefaultValue=false)]
		public BooleanValue? MarkforProduction { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Material Type 
		/// </summary>
		[DataMember(Name="MaterialType", EmitDefaultValue=false)]
		public StringValue? MaterialType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Operation ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProdItemFilter 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: PO Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
		public StringValue? POOrderNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Preferred Vendor ID 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="PreferredVendorID", EmitDefaultValue=false)]
		public StringValue? PreferredVendorID { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.ProdItemFilter 
		/// Display Name: Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC Field Name: QtyAvail 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Qty. Available 
		/// </summary>
		[DataMember(Name="QtyAvailable", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailable { get; set; }

		/// <summary>
		/// DAC Field Name: QtyHardAvail 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Qty. Hard Available 
		/// </summary>
		[DataMember(Name="QtyHardAvailable", EmitDefaultValue=false)]
		public DecimalValue? QtyHardAvailable { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Qty On Hand 
		/// </summary>
		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHand { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Qty. Production Demand 
		/// </summary>
		[DataMember(Name="QtyProductionDemand", EmitDefaultValue=false)]
		public DecimalValue? QtyProductionDemand { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Qty. Production Demand Prepared 
		/// </summary>
		[DataMember(Name="QtyProductionDemandPrepared", EmitDefaultValue=false)]
		public DecimalValue? QtyProductionDemandPrepared { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Qty. Production Supply 
		/// </summary>
		[DataMember(Name="QtyProductionSupply", EmitDefaultValue=false)]
		public DecimalValue? QtyProductionSupply { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Qty. Production Supply Prepared 
		/// </summary>
		[DataMember(Name="QtyProductionSupplyPrepared", EmitDefaultValue=false)]
		public DecimalValue? QtyProductionSupplyPrepared { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Qty Remaining 
		/// </summary>
		[DataMember(Name="QtyRemaining", EmitDefaultValue=false)]
		public DecimalValue? QtyRemaining { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Qty Short 
		/// </summary>
		[DataMember(Name="QtyShort", EmitDefaultValue=false)]
		public DecimalValue? QtyShort { get; set; }

		/// <summary>
		/// Replenishment source
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Replenishment Source 
		/// SQL Type: nvarchar(1) 
		/// </summary>
		[DataMember(Name="ReplenishmentSource", EmitDefaultValue=false)]
		public StringValue? ReplenishmentSource { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Required Date 
		/// </summary>
		[DataMember(Name="RequiredDate", EmitDefaultValue=false)]
		public DateTimeValue? RequiredDate { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// DAC Field Name: AMOrderType 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Sub. Assy. Order Type 
		/// SQL Type: nchar(2) 
		/// </summary>
		[DataMember(Name="SubAssyOrderType", EmitDefaultValue=false)]
		public StringValue? SubAssyOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: AMProdOrdID 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Sub. Assy. Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// </summary>
		[DataMember(Name="SubAssyProductionNbr", EmitDefaultValue=false)]
		public StringValue? SubAssyProductionNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Subcontract Source 
		/// </summary>
		[DataMember(Name="SubcontractSource", EmitDefaultValue=false)]
		public StringValue? SubcontractSource { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: TotalQtyRequired 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// Display Name: Total Required 
		/// </summary>
		[DataMember(Name="TotalRequired", EmitDefaultValue=false)]
		public DecimalValue? TotalRequired { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: PreferredVendorID_Vendor_AcctName 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// </summary>
		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.SelectedProdMatl 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}