using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_18_200_001.Model
{
	[DataContract]
	public class OrderOperationDetail : Entity_v3
	{

		[DataMember(Name="ActualEndDate", EmitDefaultValue=false)]
		public DateTimeValue ActualEndDate { get; set; }

		[DataMember(Name="ActualStartDate", EmitDefaultValue=false)]
		public DateTimeValue ActualStartDate { get; set; }

		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue BackflushLabor { get; set; }

		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public StringValue MachineTime { get; set; }

		[DataMember(Name="MachineUnits", EmitDefaultValue=false)]
		public DecimalValue MachineUnits { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public List<OrderMaterialDetail> Material { get; set; }

		[DataMember(Name="MoveTime", EmitDefaultValue=false)]
		public StringValue MoveTime { get; set; }

		[DataMember(Name="OperationDescription", EmitDefaultValue=false)]
		public StringValue OperationDescription { get; set; }

		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue OperationNbr { get; set; }

		[DataMember(Name="OperationStatus", EmitDefaultValue=false)]
		public StringValue OperationStatus { get; set; }

		[DataMember(Name="OperationTotal", EmitDefaultValue=false)]
		public ProductionOrderOperationTotal OperationTotal { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<OrderOverheadDetail> Overheads { get; set; }

		[DataMember(Name="PhantomBomID", EmitDefaultValue=false)]
		public StringValue PhantomBomID { get; set; }

		[DataMember(Name="PhantomBOMLineID", EmitDefaultValue=false)]
		public IntValue PhantomBOMLineID { get; set; }

		[DataMember(Name="PhantomBOMOperNbr", EmitDefaultValue=false)]
		public StringValue PhantomBOMOperNbr { get; set; }

		[DataMember(Name="PhantomLevel", EmitDefaultValue=false)]
		public IntValue PhantomLevel { get; set; }

		[DataMember(Name="PhantomMatlLineID", EmitDefaultValue=false)]
		public IntValue PhantomMatlLineID { get; set; }

		[DataMember(Name="PhantomMatlOperNbr", EmitDefaultValue=false)]
		public StringValue PhantomMatlOperNbr { get; set; }

		[DataMember(Name="PhantomPriorLevelQty", EmitDefaultValue=false)]
		public DecimalValue PhantomPriorLevelQty { get; set; }

		[DataMember(Name="PlanEndDate", EmitDefaultValue=false)]
		public DateTimeValue PlanEndDate { get; set; }

		[DataMember(Name="PlanStartDate", EmitDefaultValue=false)]
		public DateTimeValue PlanStartDate { get; set; }

		[DataMember(Name="QtyComplete", EmitDefaultValue=false)]
		public DecimalValue QtyComplete { get; set; }

		[DataMember(Name="QtyRemaining", EmitDefaultValue=false)]
		public DecimalValue QtyRemaining { get; set; }

		[DataMember(Name="QtyScrapped", EmitDefaultValue=false)]
		public DecimalValue QtyScrapped { get; set; }

		[DataMember(Name="QtytoProduce", EmitDefaultValue=false)]
		public DecimalValue QtytoProduce { get; set; }

		[DataMember(Name="QueueTime", EmitDefaultValue=false)]
		public StringValue QueueTime { get; set; }

		[DataMember(Name="RunTime", EmitDefaultValue=false)]
		public StringValue RunTime { get; set; }

		[DataMember(Name="RunUnits", EmitDefaultValue=false)]
		public DecimalValue RunUnits { get; set; }

		[DataMember(Name="ScrapAction", EmitDefaultValue=false)]
		public StringValue ScrapAction { get; set; }

		[DataMember(Name="SetupTime", EmitDefaultValue=false)]
		public StringValue SetupTime { get; set; }

		[DataMember(Name="Steps", EmitDefaultValue=false)]
		public List<OrderStepDetail> Steps { get; set; }

		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public List<OrderToolDetail> Tools { get; set; }

		[DataMember(Name="TotalQty", EmitDefaultValue=false)]
		public DecimalValue TotalQty { get; set; }

		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue WorkCenter { get; set; }

	}
}