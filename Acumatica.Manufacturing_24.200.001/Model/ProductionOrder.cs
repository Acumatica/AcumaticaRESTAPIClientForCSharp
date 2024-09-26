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
		/// 
		/// Display Name:
		/// DAC Field Name: PreassignLotSerial 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AllowPreassigningLotSerialNumbers", EmitDefaultValue=false)]
		public BooleanValue? AllowPreassigningLotSerialNumbers { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AutoBackwardReporting 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AutoBackwardReporting", EmitDefaultValue=false)]
		public BooleanValue? AutoBackwardReporting { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BOMID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BOMRevisionID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BOMRevision", EmitDefaultValue=false)]
		public StringValue? BOMRevision { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: KeyID 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ConfigKey", EmitDefaultValue=false)]
		public StringValue? ConfigKey { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ConfigurationID 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue? ConfigurationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Revision 
		/// DAC: PX.Objects.AM.AMConfigurationResults 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ConfRevision", EmitDefaultValue=false)]
		public StringValue? ConfRevision { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ConstDate 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Constraint", EmitDefaultValue=false)]
		public DateTimeValue? Constraint { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CostMethod 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostingMethod", EmitDefaultValue=false)]
		public StringValue? CostingMethod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SchPriority 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DispatchPriority", EmitDefaultValue=false)]
		public ShortValue? DispatchPriority { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EndDate 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EstimateID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EstimateID", EmitDefaultValue=false)]
		public StringValue? EstimateID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EstimateRevisionID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EstimateRevision", EmitDefaultValue=false)]
		public StringValue? EstimateRevision { get; set; }

		[DataMember(Name="EventHistory", EmitDefaultValue=false)]
		public List<EventHistoryDetail>? EventHistory { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExcludeFromMRP 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExcludefromMRP", EmitDefaultValue=false)]
		public BooleanValue? ExcludefromMRP { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Hold 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="OrderAttributes", EmitDefaultValue=false)]
		public List<OrderAttributeDetail>? OrderAttributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProdDate 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderDate", EmitDefaultValue=false)]
		public DateTimeValue? OrderDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderDescription", EmitDefaultValue=false)]
		public StringValue? OrderDescription { get; set; }

		[DataMember(Name="OrderTotals", EmitDefaultValue=false)]
		public ProductionOrderTotals? OrderTotals { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderType 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ParentOrdID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ParentOrder", EmitDefaultValue=false)]
		public StringValue? ParentOrder { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ParentOrderType 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ParentOrderType", EmitDefaultValue=false)]
		public StringValue? ParentOrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductManagerID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductOrdID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductOrder", EmitDefaultValue=false)]
		public StringValue? ProductOrder { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductOrderType 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductOrderType", EmitDefaultValue=false)]
		public StringValue? ProductOrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductWorkgroupID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyComplete 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="QtyComplete", EmitDefaultValue=false)]
		public DecimalValue? QtyComplete { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyRemaining 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="QtyRemaining", EmitDefaultValue=false)]
		public DecimalValue? QtyRemaining { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtyScrapped 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="QtyScrapped", EmitDefaultValue=false)]
		public DecimalValue? QtyScrapped { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QtytoProd 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="QtytoProduce", EmitDefaultValue=false)]
		public DecimalValue? QtytoProduce { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ParentLotSerialRequired 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequireParentLotSerialNumber", EmitDefaultValue=false)]
		public StringValue? RequireParentLotSerialNumber { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScheduleStatus 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScheduleStatus", EmitDefaultValue=false)]
		public StringValue? ScheduleStatus { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SchedulingMethod 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SchedulingMethod", EmitDefaultValue=false)]
		public StringValue? SchedulingMethod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScrapLocationID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScrapLocation", EmitDefaultValue=false)]
		public StringValue? ScrapLocation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScrapOverride 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScrapOverride", EmitDefaultValue=false)]
		public BooleanValue? ScrapOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ScrapSiteID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ScrapWarehouse", EmitDefaultValue=false)]
		public StringValue? ScrapWarehouse { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrdLineRef 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SOLineNbr", EmitDefaultValue=false)]
		public IntValue? SOLineNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrdNbr 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue? SOOrderNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrdTypeRef 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SOOrderType", EmitDefaultValue=false)]
		public StringValue? SOOrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DetailSource 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BOMEffDate 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SourceDate", EmitDefaultValue=false)]
		public DateTimeValue? SourceDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SourceOrderType 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SourceOrderType", EmitDefaultValue=false)]
		public StringValue? SourceOrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SourceProductionNbr 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SourceProductionNbr", EmitDefaultValue=false)]
		public StringValue? SourceProductionNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StatusID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UOM 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UpdateProject 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UpdateProject", EmitDefaultValue=false)]
		public BooleanValue? UpdateProject { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FMLTime 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseFixedMfgLeadTimesforOrderDates", EmitDefaultValue=false)]
		public BooleanValue? UseFixedMfgLeadTimesforOrderDates { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FMLTMRPOrdorOP 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseOrderStartDateforMRP", EmitDefaultValue=false)]
		public BooleanValue? UseOrderStartDateforMRP { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WIPAcctID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WIPAccount", EmitDefaultValue=false)]
		public StringValue? WIPAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WIPSubID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WIPSubaccount", EmitDefaultValue=false)]
		public StringValue? WIPSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WIPVarianceAcctID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WIPVarianceAccount", EmitDefaultValue=false)]
		public StringValue? WIPVarianceAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WIPVarianceSubID 
		/// DAC: PX.Objects.AM.AMProdItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WIPVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? WIPVarianceSubaccount { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}