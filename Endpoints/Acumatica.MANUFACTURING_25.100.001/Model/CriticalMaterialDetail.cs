using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class CriticalMaterialDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: IsAllocated</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// </summary>
		public BooleanValue? Allocated { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Batch Size</para>
		/// </summary>
		public DecimalValue? BatchSize { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsByproduct2</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: By-product</para>
		/// </summary>
		public BooleanValue? Byproduct { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsStockItem</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Is stock</para>
		/// </summary>
		public BooleanValue? Isstock { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LineID</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: POCreate</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Mark for PO</para>
		/// </summary>
		public BooleanValue? MarkforPO { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdCreate</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Mark for Production</para>
		/// </summary>
		public BooleanValue? MarkforProduction { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Material Type</para>
		/// </summary>
		public StringValue? MaterialType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Operation ID</para>
		/// Key Field
		/// </summary>
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProdItemFilter</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: PO Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? POOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Preferred Vendor ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? PreferredVendorID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.ProdItemFilter</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyAvail</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Available Qty.</para>
		/// </summary>
		public DecimalValue? QtyAvailable { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtyHardAvail</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Qty. Hard Available</para>
		/// </summary>
		public DecimalValue? QtyHardAvailable { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Qty. On Hand</para>
		/// </summary>
		public DecimalValue? QtyOnHand { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Qty. Production Demand</para>
		/// </summary>
		public DecimalValue? QtyProductionDemand { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Qty. Production Demand Prepared</para>
		/// </summary>
		public DecimalValue? QtyProductionDemandPrepared { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Qty. Production Supply</para>
		/// </summary>
		public DecimalValue? QtyProductionSupply { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Prepared Production Supply Qty.</para>
		/// </summary>
		public DecimalValue? QtyProductionSupplyPrepared { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Remaining Qty.</para>
		/// </summary>
		public DecimalValue? QtyRemaining { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Shortage Qty.</para>
		/// </summary>
		public DecimalValue? QtyShort { get; set; }

		/// <summary>
		/// Replenishment source
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Replenishment Source</para>
		/// <para>SQL Type: nvarchar(1)</para>
		/// </summary>
		public StringValue? ReplenishmentSource { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Required Date</para>
		/// </summary>
		public DateTimeValue? RequiredDate { get; set; }

		/// <summary>
		/// Specifies (if set to true) that a user has selected the record in the table on the form for processing.
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// </summary>
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMOrderType</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Sub. Assy. Order Type</para>
		/// <para>SQL Type: nchar(2)</para>
		/// </summary>
		public StringValue? SubAssyOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AMProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Sub. Assy. Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		public StringValue? SubAssyProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Subcontract Source</para>
		/// </summary>
		public StringValue? SubcontractSource { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TotalQtyRequired</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>Display Name: Total Required</para>
		/// </summary>
		public DecimalValue? TotalRequired { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PreferredVendorID_Vendor_AcctName</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// </summary>
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.SelectedProdMatl</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

	}
}