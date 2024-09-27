using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM201500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ProductionOrder : Entity, ITopLevelEntity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<ProductionOrderAllocation>? Allocations { get; set; }

		/// <summary>
		/// Allow pre-assigning of lot/serial numbers
		/// DAC Field Name: PreassignLotSerial 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Allow Preassigning Lot/Serial Numbers 
		/// </summary>
		[DataMember(Name="AllowPreassigningLotSerialNumbers", EmitDefaultValue=false)]
		public BooleanValue? AllowPreassigningLotSerialNumbers { get; set; }

		/// <summary>
		/// Override Auto backward reporting value for the order.
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Automatic Backward Reporting 
		/// </summary>
		[DataMember(Name="AutoBackwardReporting", EmitDefaultValue=false)]
		public BooleanValue? AutoBackwardReporting { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: BOM ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// DAC Field Name: BOMRevisionID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: BOM Revision 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="BOMRevision", EmitDefaultValue=false)]
		public StringValue? BOMRevision { get; set; }

		/// <summary>
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// Configuration key ID which represents the key used/generated from the results of a finished configuration
		/// DAC Field Name: KeyID 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: Config. Key 
		/// SQL Type: nvarchar(120) 
		/// </summary>
		[DataMember(Name="ConfigKey", EmitDefaultValue=false)]
		public StringValue? ConfigKey { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: Configuration ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue? ConfigurationID { get; set; }

		/// <summary>
		/// DAC Field Name: Revision 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// Display Name: Conf. Revision 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ConfRevision", EmitDefaultValue=false)]
		public StringValue? ConfRevision { get; set; }

		/// <summary>
		/// DAC Field Name: ConstDate 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		[DataMember(Name="Constraint", EmitDefaultValue=false)]
		public DateTimeValue? Constraint { get; set; }

		/// <summary>
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// DAC Field Name: CostMethod 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Costing Method 
		/// </summary>
		[DataMember(Name="CostingMethod", EmitDefaultValue=false)]
		public StringValue? CostingMethod { get; set; }

		/// <summary>
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// Scheduling/dispatch priority from 1 (high) to 10 (low)
		/// DAC Field Name: SchPriority 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Dispatch Priority 
		/// </summary>
		[DataMember(Name="DispatchPriority", EmitDefaultValue=false)]
		public ShortValue? DispatchPriority { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: End Date 
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Estimate ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="EstimateID", EmitDefaultValue=false)]
		public StringValue? EstimateID { get; set; }

		/// <summary>
		/// DAC Field Name: EstimateRevisionID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Estimate Revision 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="EstimateRevision", EmitDefaultValue=false)]
		public StringValue? EstimateRevision { get; set; }

		[DataMember(Name="EventHistory", EmitDefaultValue=false)]
		public List<EventHistoryDetail>? EventHistory { get; set; }

		/// <summary>
		/// DAC Field Name: ExcludeFromMRP 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Exclude from MRP 
		/// </summary>
		[DataMember(Name="ExcludefromMRP", EmitDefaultValue=false)]
		public BooleanValue? ExcludefromMRP { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="OrderAttributes", EmitDefaultValue=false)]
		public List<OrderAttributeDetail>? OrderAttributes { get; set; }

		/// <summary>
		/// DAC Field Name: ProdDate 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Order Date 
		/// </summary>
		[DataMember(Name="OrderDate", EmitDefaultValue=false)]
		public DateTimeValue? OrderDate { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Order Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="OrderDescription", EmitDefaultValue=false)]
		public StringValue? OrderDescription { get; set; }

		[DataMember(Name="OrderTotals", EmitDefaultValue=false)]
		public ProductionOrderTotals? OrderTotals { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: ParentOrdID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Parent Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// </summary>
		[DataMember(Name="ParentOrder", EmitDefaultValue=false)]
		public StringValue? ParentOrder { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Parent Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="ParentOrderType", EmitDefaultValue=false)]
		public StringValue? ParentOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ProductManagerID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Product Manager 
		/// </summary>
		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// DAC Field Name: ProductOrdID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Product Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// </summary>
		[DataMember(Name="ProductOrder", EmitDefaultValue=false)]
		public StringValue? ProductOrder { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Product Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="ProductOrderType", EmitDefaultValue=false)]
		public StringValue? ProductOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: ProductWorkgroupID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Product Workgroup 
		/// </summary>
		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// Selected Project fot the Production Order
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Qty. Complete 
		/// </summary>
		[DataMember(Name="QtyComplete", EmitDefaultValue=false)]
		public DecimalValue? QtyComplete { get; set; }

		/// <summary>
		/// Quantity remaining to be completed on the production order
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Qty. Remaining 
		/// </summary>
		[DataMember(Name="QtyRemaining", EmitDefaultValue=false)]
		public DecimalValue? QtyRemaining { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Qty. Scrapped 
		/// </summary>
		[DataMember(Name="QtyScrapped", EmitDefaultValue=false)]
		public DecimalValue? QtyScrapped { get; set; }

		/// <summary>
		/// DAC Field Name: QtytoProd 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Qty. to Produce 
		/// </summary>
		[DataMember(Name="QtytoProduce", EmitDefaultValue=false)]
		public DecimalValue? QtytoProduce { get; set; }

		/// <summary>
		/// Parent lot number is/isn't required for material transactions
		/// DAC Field Name: ParentLotSerialRequired 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Require Parent Lot/Serial Number 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="RequireParentLotSerialNumber", EmitDefaultValue=false)]
		public StringValue? RequireParentLotSerialNumber { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Schedule Status 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ScheduleStatus", EmitDefaultValue=false)]
		public StringValue? ScheduleStatus { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Scheduling Method 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="SchedulingMethod", EmitDefaultValue=false)]
		public StringValue? SchedulingMethod { get; set; }

		/// <summary>
		/// DAC Field Name: ScrapLocationID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Scrap Location 
		/// </summary>
		[DataMember(Name="ScrapLocation", EmitDefaultValue=false)]
		public StringValue? ScrapLocation { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Scrap Override 
		/// </summary>
		[DataMember(Name="ScrapOverride", EmitDefaultValue=false)]
		public BooleanValue? ScrapOverride { get; set; }

		/// <summary>
		/// DAC Field Name: ScrapSiteID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Scrap Warehouse 
		/// </summary>
		[DataMember(Name="ScrapWarehouse", EmitDefaultValue=false)]
		public StringValue? ScrapWarehouse { get; set; }

		/// <summary>
		/// DAC Field Name: OrdLineRef 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: SO Line Nbr. 
		/// </summary>
		[DataMember(Name="SOLineNbr", EmitDefaultValue=false)]
		public IntValue? SOLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OrdNbr 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: SO Order Nbr 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OrdTypeRef 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: SO Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="SOOrderType", EmitDefaultValue=false)]
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// Indicates where the production detail source comes from.
		/// DAC Field Name: DetailSource 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// DAC Field Name: BOMEffDate 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Source Date 
		/// </summary>
		[DataMember(Name="SourceDate", EmitDefaultValue=false)]
		public DateTimeValue? SourceDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Source Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="SourceOrderType", EmitDefaultValue=false)]
		public StringValue? SourceOrderType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Source Production Nbr 
		/// SQL Type: nvarchar(19) 
		/// </summary>
		[DataMember(Name="SourceProductionNbr", EmitDefaultValue=false)]
		public StringValue? SourceProductionNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// DAC Field Name: StatusID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Update Project 
		/// </summary>
		[DataMember(Name="UpdateProject", EmitDefaultValue=false)]
		public BooleanValue? UpdateProject { get; set; }

		/// <summary>
		/// DAC Field Name: FMLTime 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Use Fixed Mfg Lead Times for Order Dates 
		/// </summary>
		[DataMember(Name="UseFixedMfgLeadTimesforOrderDates", EmitDefaultValue=false)]
		public BooleanValue? UseFixedMfgLeadTimesforOrderDates { get; set; }

		/// <summary>
		/// DAC Field Name: FMLTMRPOrdorOP 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: Use Order Start Date for MRP 
		/// </summary>
		[DataMember(Name="UseOrderStartDateforMRP", EmitDefaultValue=false)]
		public BooleanValue? UseOrderStartDateforMRP { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// DAC Field Name: WIPAcctID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: WIP Account 
		/// </summary>
		[DataMember(Name="WIPAccount", EmitDefaultValue=false)]
		public StringValue? WIPAccount { get; set; }

		/// <summary>
		/// DAC Field Name: WIPSubID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: WIP Subaccount 
		/// </summary>
		[DataMember(Name="WIPSubaccount", EmitDefaultValue=false)]
		public StringValue? WIPSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: WIPVarianceAcctID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: WIP Variance Account 
		/// </summary>
		[DataMember(Name="WIPVarianceAccount", EmitDefaultValue=false)]
		public StringValue? WIPVarianceAccount { get; set; }

		/// <summary>
		/// DAC Field Name: WIPVarianceSubID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// Display Name: WIP Variance Subaccount 
		/// </summary>
		[DataMember(Name="WIPVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? WIPVarianceSubaccount { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}