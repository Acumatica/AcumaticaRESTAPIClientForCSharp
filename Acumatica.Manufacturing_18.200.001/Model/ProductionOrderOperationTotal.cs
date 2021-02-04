using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_18_200_001.Model
{
	[DataContract]
	public class ProductionOrderOperationTotal : Entity_v3
	{

		[DataMember(Name="ActualFixedOverhead", EmitDefaultValue=false)]
		public DecimalValue ActualFixedOverhead { get; set; }

		[DataMember(Name="ActualLabor", EmitDefaultValue=false)]
		public DecimalValue ActualLabor { get; set; }

		[DataMember(Name="ActualLaborTime", EmitDefaultValue=false)]
		public StringValue ActualLaborTime { get; set; }

		[DataMember(Name="ActualMachine", EmitDefaultValue=false)]
		public DecimalValue ActualMachine { get; set; }

		[DataMember(Name="ActualMaterial", EmitDefaultValue=false)]
		public DecimalValue ActualMaterial { get; set; }

		[DataMember(Name="ActualTool", EmitDefaultValue=false)]
		public DecimalValue ActualTool { get; set; }

		[DataMember(Name="ActualVariableOverhead", EmitDefaultValue=false)]
		public DecimalValue ActualVariableOverhead { get; set; }

		[DataMember(Name="Adjustments", EmitDefaultValue=false)]
		public DecimalValue Adjustments { get; set; }

		[DataMember(Name="FixedOverheadVariance", EmitDefaultValue=false)]
		public DecimalValue FixedOverheadVariance { get; set; }

		[DataMember(Name="LaborTimeVariance", EmitDefaultValue=false)]
		public StringValue LaborTimeVariance { get; set; }

		[DataMember(Name="LaborVariance", EmitDefaultValue=false)]
		public DecimalValue LaborVariance { get; set; }

		[DataMember(Name="MachineVariance", EmitDefaultValue=false)]
		public DecimalValue MachineVariance { get; set; }

		[DataMember(Name="MaterialVariance", EmitDefaultValue=false)]
		public DecimalValue MaterialVariance { get; set; }

		[DataMember(Name="MFGtoInventory", EmitDefaultValue=false)]
		public DecimalValue MFGtoInventory { get; set; }

		[DataMember(Name="PlanCostDate", EmitDefaultValue=false)]
		public DateTimeValue PlanCostDate { get; set; }

		[DataMember(Name="PlanFixedOverhead", EmitDefaultValue=false)]
		public DecimalValue PlanFixedOverhead { get; set; }

		[DataMember(Name="PlanLabor", EmitDefaultValue=false)]
		public DecimalValue PlanLabor { get; set; }

		[DataMember(Name="PlanLaborTime", EmitDefaultValue=false)]
		public StringValue PlanLaborTime { get; set; }

		[DataMember(Name="PlanMachine", EmitDefaultValue=false)]
		public DecimalValue PlanMachine { get; set; }

		[DataMember(Name="PlanMaterial", EmitDefaultValue=false)]
		public DecimalValue PlanMaterial { get; set; }

		[DataMember(Name="PlanQty", EmitDefaultValue=false)]
		public DecimalValue PlanQty { get; set; }

		[DataMember(Name="PlanTool", EmitDefaultValue=false)]
		public DecimalValue PlanTool { get; set; }

		[DataMember(Name="PlanTotal", EmitDefaultValue=false)]
		public DecimalValue PlanTotal { get; set; }

		[DataMember(Name="PlanVariableOverhead", EmitDefaultValue=false)]
		public DecimalValue PlanVariableOverhead { get; set; }

		[DataMember(Name="ScrapAmount", EmitDefaultValue=false)]
		public DecimalValue ScrapAmount { get; set; }

		[DataMember(Name="ToolVariance", EmitDefaultValue=false)]
		public DecimalValue ToolVariance { get; set; }

		[DataMember(Name="TotalVariance", EmitDefaultValue=false)]
		public DecimalValue TotalVariance { get; set; }

		[DataMember(Name="VariableOverheadVariance", EmitDefaultValue=false)]
		public DecimalValue VariableOverheadVariance { get; set; }

		[DataMember(Name="WIPBalance", EmitDefaultValue=false)]
		public DecimalValue WIPBalance { get; set; }

		[DataMember(Name="WIPTotal", EmitDefaultValue=false)]
		public DecimalValue WIPTotal { get; set; }

	}
}