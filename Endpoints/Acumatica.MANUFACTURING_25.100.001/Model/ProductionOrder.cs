using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM201500</c> in the Acumatica ERP
	/// <para>Key Fields: OrderType, ProductionNbr</para>
	/// </summary>
	public class ProductionOrder : Entity, ITopLevelEntity
	{

		public List<ProductionOrderAllocation>? Allocations { get; set; }

		/// <summary>
		/// Allow pre-assigning of lot/serial numbers
		/// <para>DAC Field Name: PreassignLotSerial</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Allow Preassigning Lot/Serial Numbers</para>
		/// </summary>
		public BooleanValue? AllowPreassigningLotSerialNumbers { get; set; }

		/// <summary>
		/// Override Auto backward reporting value for the order.
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Automatic Backward Reporting</para>
		/// </summary>
		public BooleanValue? AutoBackwardReporting { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BOMRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: BOM Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? BOMRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// Configuration key ID which represents the key used/generated from the results of a finished configuration
		/// <para>DAC Field Name: KeyID</para>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: Config. Key</para>
		/// <para>SQL Type: nvarchar(120)</para>
		/// </summary>
		public StringValue? ConfigKey { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: Configuration ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ConfigurationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Revision</para>
		/// <para>DAC: PX.Objects.AM.AMConfigurationResults</para>
		/// <para>Display Name: Conf. Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ConfRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ConstDate</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public DateTimeValue? Constraint { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostMethod</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Costing Method</para>
		/// </summary>
		public StringValue? CostingMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Customer { get; set; }

		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// Scheduling/dispatch priority from 1 (high) to 10 (low)
		/// <para>DAC Field Name: SchPriority</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Dispatch Priority</para>
		/// </summary>
		public ShortValue? DispatchPriority { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Estimate ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? EstimateID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EstimateRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Estimate Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? EstimateRevision { get; set; }

		public List<EventHistoryDetail>? EventHistory { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExcludeFromMRP</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Exclude from MRP</para>
		/// </summary>
		public BooleanValue? ExcludefromMRP { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Location { get; set; }

		public List<OrderAttributeDetail>? OrderAttributes { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdDate</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Order Date</para>
		/// </summary>
		public DateTimeValue? OrderDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Order Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? OrderDescription { get; set; }

		public ProductionOrderTotals? OrderTotals { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// Key Field
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Parent Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		public StringValue? ParentOrder { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Parent Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? ParentOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// Key Field
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductManagerID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Product Manager</para>
		/// </summary>
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductOrdID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Product Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		public StringValue? ProductOrder { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Product Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? ProductOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductWorkgroupID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Product Workgroup</para>
		/// </summary>
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// Selected Project fot the Production Order
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Completed Qty.</para>
		/// </summary>
		public DecimalValue? QtyComplete { get; set; }

		/// <summary>
		/// Quantity remaining to be completed on the production order
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Remaining Qty.</para>
		/// </summary>
		public DecimalValue? QtyRemaining { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Scrapped Qty.</para>
		/// </summary>
		public DecimalValue? QtyScrapped { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QtytoProd</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Qty. to Produce</para>
		/// </summary>
		public DecimalValue? QtytoProduce { get; set; }

		/// <summary>
		/// Parent lot number is/isn't required for material transactions
		/// <para>DAC Field Name: ParentLotSerialRequired</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Require Parent Lot/Serial Number</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? RequireParentLotSerialNumber { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Schedule Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ScheduleStatus { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Scheduling Method</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? SchedulingMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScrapLocationID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Scrap Location</para>
		/// </summary>
		public StringValue? ScrapLocation { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Scrap Override</para>
		/// </summary>
		public BooleanValue? ScrapOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ScrapSiteID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Scrap Warehouse</para>
		/// </summary>
		public StringValue? ScrapWarehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrdLineRef</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: SO Line Nbr.</para>
		/// </summary>
		public IntValue? SOLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrdNbr</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Sales Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OrdTypeRef</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Sales Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// Indicates where the production detail source comes from.
		/// <para>DAC Field Name: DetailSource</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Source { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BOMEffDate</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Source Date</para>
		/// </summary>
		public DateTimeValue? SourceDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Source Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? SourceOrderType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Source Production Nbr</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		public StringValue? SourceProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StatusID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Update Project</para>
		/// </summary>
		public BooleanValue? UpdateProject { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FMLTime</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Use Fixed Mfg Lead Times for Order Dates</para>
		/// </summary>
		public BooleanValue? UseFixedMfgLeadTimesforOrderDates { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FMLTMRPOrdorOP</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: Use Order Start Date for MRP</para>
		/// </summary>
		public BooleanValue? UseOrderStartDateforMRP { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPAcctID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: WIP Account</para>
		/// </summary>
		public StringValue? WIPAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPSubID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: WIP Subaccount</para>
		/// </summary>
		public StringValue? WIPSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPVarianceAcctID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: WIP Variance Account</para>
		/// </summary>
		public StringValue? WIPVarianceAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPVarianceSubID</para>
		/// <para>DAC: PX.Objects.AM.AMProdItem</para>
		/// <para>Display Name: WIP Variance Subaccount</para>
		/// </summary>
		public StringValue? WIPVarianceSubaccount { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Allocations = "Allocations";
			public const string Allocations_Files = "Allocations/Files";
			public const string EventHistory = "EventHistory";
			public const string EventHistory_Files = "EventHistory/Files";
			public const string OrderAttributes = "OrderAttributes";
			public const string OrderAttributes_Files = "OrderAttributes/Files";
			public const string OrderTotals = "OrderTotals";

			//Intentionally excluded
			//public const string All = "Files,Translations,Allocations,Allocations/Files,EventHistory,EventHistory/Files,OrderAttributes,OrderAttributes/Files,OrderTotals";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/25.100.001";
		}
	}
}