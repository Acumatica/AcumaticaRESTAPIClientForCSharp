using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class EstimateOperation : Entity, ITopLevelEntity
	{

		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue BackflushLabor { get; set; }

		[DataMember(Name="ControlPoint", EmitDefaultValue=false)]
		public BooleanValue ControlPoint { get; set; }

		[DataMember(Name="DropShippedtoVendor", EmitDefaultValue=false)]
		public BooleanValue DropShippedtoVendor { get; set; }

		[DataMember(Name="EstimateID", EmitDefaultValue=false)]
		public StringValue EstimateID { get; set; }

		[DataMember(Name="FinishTime", EmitDefaultValue=false)]
		public IntValue FinishTime { get; set; }

		[DataMember(Name="FixedLaborOverride", EmitDefaultValue=false)]
		public BooleanValue FixedLaborOverride { get; set; }

		[DataMember(Name="FixedOverheadOverride", EmitDefaultValue=false)]
		public BooleanValue FixedOverheadOverride { get; set; }

		[DataMember(Name="FixLaborCost", EmitDefaultValue=false)]
		public DecimalValue FixLaborCost { get; set; }

		[DataMember(Name="FixOverheadCost", EmitDefaultValue=false)]
		public DecimalValue FixOverheadCost { get; set; }

		[DataMember(Name="MachineCost", EmitDefaultValue=false)]
		public DecimalValue MachineCost { get; set; }

		[DataMember(Name="MachineOverride", EmitDefaultValue=false)]
		public BooleanValue MachineOverride { get; set; }

		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public IntValue MachineTime { get; set; }

		[DataMember(Name="MachineUnits", EmitDefaultValue=false)]
		public DecimalValue MachineUnits { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public List<EstimateMaterialDetail> Material { get; set; }

		[DataMember(Name="MaterialCost", EmitDefaultValue=false)]
		public DecimalValue MaterialCost { get; set; }

		[DataMember(Name="MaterialOverride", EmitDefaultValue=false)]
		public BooleanValue MaterialOverride { get; set; }

		[DataMember(Name="MoveTime", EmitDefaultValue=false)]
		public IntValue MoveTime { get; set; }

		[DataMember(Name="OperationDescription", EmitDefaultValue=false)]
		public StringValue OperationDescription { get; set; }

		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue OperationNbr { get; set; }

		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue OutsideProcess { get; set; }

		[DataMember(Name="OutsideProcessOptions", EmitDefaultValue=false)]
		public EstimateOperationOutsideProcess OutsideProcessOptions { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<EstimateOverheadDetail> Overheads { get; set; }

		[DataMember(Name="QueueTime", EmitDefaultValue=false)]
		public IntValue QueueTime { get; set; }

		[DataMember(Name="RefMaterialCost", EmitDefaultValue=false)]
		public DecimalValue RefMaterialCost { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

		[DataMember(Name="RunTime", EmitDefaultValue=false)]
		public IntValue RunTime { get; set; }

		[DataMember(Name="RunUnits", EmitDefaultValue=false)]
		public DecimalValue RunUnits { get; set; }

		[DataMember(Name="SetupTime", EmitDefaultValue=false)]
		public IntValue SetupTime { get; set; }

		[DataMember(Name="Steps", EmitDefaultValue=false)]
		public List<EstimateStepDetail> Steps { get; set; }

		[DataMember(Name="SubcontractCost", EmitDefaultValue=false)]
		public DecimalValue SubcontractCost { get; set; }

		[DataMember(Name="SubcontractOverride", EmitDefaultValue=false)]
		public BooleanValue SubcontractOverride { get; set; }

		[DataMember(Name="ToolCost", EmitDefaultValue=false)]
		public DecimalValue ToolCost { get; set; }

		[DataMember(Name="ToolOverride", EmitDefaultValue=false)]
		public BooleanValue ToolOverride { get; set; }

		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public List<EstimateToolDetail> Tools { get; set; }

		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue TotalCost { get; set; }

		[DataMember(Name="VariableLaborOverride", EmitDefaultValue=false)]
		public BooleanValue VariableLaborOverride { get; set; }

		[DataMember(Name="VariableOverheadOverride", EmitDefaultValue=false)]
		public BooleanValue VariableOverheadOverride { get; set; }

		[DataMember(Name="VarLaborCost", EmitDefaultValue=false)]
		public DecimalValue VarLaborCost { get; set; }

		[DataMember(Name="VarOverheadCost", EmitDefaultValue=false)]
		public DecimalValue VarOverheadCost { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue Vendor { get; set; }

		[DataMember(Name="VendorLocation", EmitDefaultValue=false)]
		public StringValue VendorLocation { get; set; }

		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue WorkCenter { get; set; }

		public string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}