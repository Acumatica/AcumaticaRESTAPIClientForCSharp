using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ProductionOrder : Entity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<ProductionOrderAllocation> Allocations { get; set; }

		[DataMember(Name="AllowPreassigningLotSerialNumbers", EmitDefaultValue=false)]
		public BooleanValue AllowPreassigningLotSerialNumbers { get; set; }

		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue BOMID { get; set; }

		[DataMember(Name="BOMRevision", EmitDefaultValue=false)]
		public StringValue BOMRevision { get; set; }

		[DataMember(Name="ConfigKey", EmitDefaultValue=false)]
		public StringValue ConfigKey { get; set; }

		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue ConfigurationID { get; set; }

		[DataMember(Name="ConfRevision", EmitDefaultValue=false)]
		public StringValue ConfRevision { get; set; }

		[DataMember(Name="Constraint", EmitDefaultValue=false)]
		public DateTimeValue Constraint { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="CostingMethod", EmitDefaultValue=false)]
		public StringValue CostingMethod { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue CustomerName { get; set; }

		[DataMember(Name="DispatchPriority", EmitDefaultValue=false)]
		public ShortValue DispatchPriority { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="EstimateID", EmitDefaultValue=false)]
		public StringValue EstimateID { get; set; }

		[DataMember(Name="EstimateRevision", EmitDefaultValue=false)]
		public StringValue EstimateRevision { get; set; }

		[DataMember(Name="EventHistory", EmitDefaultValue=false)]
		public List<EventHistoryDetail> EventHistory { get; set; }

		[DataMember(Name="ExcludefromMRP", EmitDefaultValue=false)]
		public BooleanValue ExcludefromMRP { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="OrderAttributes", EmitDefaultValue=false)]
		public List<OrderAttributeDetail> OrderAttributes { get; set; }

		[DataMember(Name="OrderDate", EmitDefaultValue=false)]
		public DateTimeValue OrderDate { get; set; }

		[DataMember(Name="OrderDescription", EmitDefaultValue=false)]
		public StringValue OrderDescription { get; set; }

		[DataMember(Name="OrderTotals", EmitDefaultValue=false)]
		public ProductionOrderTotals OrderTotals { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="ParentOrder", EmitDefaultValue=false)]
		public StringValue ParentOrder { get; set; }

		[DataMember(Name="ParentOrderType", EmitDefaultValue=false)]
		public StringValue ParentOrderType { get; set; }

		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue ProductionNbr { get; set; }

		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue ProductManager { get; set; }

		[DataMember(Name="ProductOrder", EmitDefaultValue=false)]
		public StringValue ProductOrder { get; set; }

		[DataMember(Name="ProductOrderType", EmitDefaultValue=false)]
		public StringValue ProductOrderType { get; set; }

		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue ProductWorkgroup { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="QtyComplete", EmitDefaultValue=false)]
		public DecimalValue QtyComplete { get; set; }

		[DataMember(Name="QtyRemaining", EmitDefaultValue=false)]
		public DecimalValue QtyRemaining { get; set; }

		[DataMember(Name="QtyScrapped", EmitDefaultValue=false)]
		public DecimalValue QtyScrapped { get; set; }

		[DataMember(Name="QtytoProduce", EmitDefaultValue=false)]
		public DecimalValue QtytoProduce { get; set; }

		[DataMember(Name="RequireParentLotSerialNumber", EmitDefaultValue=false)]
		public StringValue RequireParentLotSerialNumber { get; set; }

		[DataMember(Name="ScheduleStatus", EmitDefaultValue=false)]
		public StringValue ScheduleStatus { get; set; }

		[DataMember(Name="SchedulingMethod", EmitDefaultValue=false)]
		public StringValue SchedulingMethod { get; set; }

		[DataMember(Name="ScrapLocation", EmitDefaultValue=false)]
		public StringValue ScrapLocation { get; set; }

		[DataMember(Name="ScrapOverride", EmitDefaultValue=false)]
		public BooleanValue ScrapOverride { get; set; }

		[DataMember(Name="ScrapWarehouse", EmitDefaultValue=false)]
		public StringValue ScrapWarehouse { get; set; }

		[DataMember(Name="SOLineNbr", EmitDefaultValue=false)]
		public IntValue SOLineNbr { get; set; }

		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue SOOrderNbr { get; set; }

		[DataMember(Name="SOOrderType", EmitDefaultValue=false)]
		public StringValue SOOrderType { get; set; }

		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue Source { get; set; }

		[DataMember(Name="SourceDate", EmitDefaultValue=false)]
		public DateTimeValue SourceDate { get; set; }

		[DataMember(Name="SourceOrderType", EmitDefaultValue=false)]
		public StringValue SourceOrderType { get; set; }

		[DataMember(Name="SourceProductionNbr", EmitDefaultValue=false)]
		public StringValue SourceProductionNbr { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="UpdateProject", EmitDefaultValue=false)]
		public BooleanValue UpdateProject { get; set; }

		[DataMember(Name="UseFixedMfgLeadTimesforOrderDates", EmitDefaultValue=false)]
		public BooleanValue UseFixedMfgLeadTimesforOrderDates { get; set; }

		[DataMember(Name="UseOrderStartDateforMRP", EmitDefaultValue=false)]
		public BooleanValue UseOrderStartDateforMRP { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

		[DataMember(Name="WIPAccount", EmitDefaultValue=false)]
		public StringValue WIPAccount { get; set; }

		[DataMember(Name="WIPSubaccount", EmitDefaultValue=false)]
		public StringValue WIPSubaccount { get; set; }

		[DataMember(Name="WIPVarianceAccount", EmitDefaultValue=false)]
		public StringValue WIPVarianceAccount { get; set; }

		[DataMember(Name="WIPVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue WIPVarianceSubaccount { get; set; }

	}
}