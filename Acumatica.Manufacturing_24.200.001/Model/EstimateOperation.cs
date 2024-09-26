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
	/// Corresponds to the screen AM304000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class EstimateOperation : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BackflushLabor 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue? BackflushLabor { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ControlPoint 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ControlPoint", EmitDefaultValue=false)]
		public BooleanValue? ControlPoint { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DropShippedToVendor 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DropShippedtoVendor", EmitDefaultValue=false)]
		public BooleanValue? DropShippedtoVendor { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EstimateID 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EstimateID", EmitDefaultValue=false)]
		public StringValue? EstimateID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinishTimeRaw 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FinishTime", EmitDefaultValue=false)]
		public IntValue? FinishTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FixedLaborOverride 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FixedLaborOverride", EmitDefaultValue=false)]
		public BooleanValue? FixedLaborOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FixedOverheadOverride 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FixedOverheadOverride", EmitDefaultValue=false)]
		public BooleanValue? FixedOverheadOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FixedLaborCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FixLaborCost", EmitDefaultValue=false)]
		public DecimalValue? FixLaborCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FixedOverheadCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FixOverheadCost", EmitDefaultValue=false)]
		public DecimalValue? FixOverheadCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MachineCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MachineCost", EmitDefaultValue=false)]
		public DecimalValue? MachineCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MachineOverride 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MachineOverride", EmitDefaultValue=false)]
		public BooleanValue? MachineOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MachineUnitTimeRaw 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public IntValue? MachineTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MachineUnits 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MachineUnits", EmitDefaultValue=false)]
		public DecimalValue? MachineUnits { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public List<EstimateMaterialDetail>? Material { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MaterialCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MaterialCost", EmitDefaultValue=false)]
		public DecimalValue? MaterialCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MaterialOverride 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MaterialOverride", EmitDefaultValue=false)]
		public BooleanValue? MaterialOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MoveTimeRaw 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MoveTime", EmitDefaultValue=false)]
		public IntValue? MoveTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OperationDescription", EmitDefaultValue=false)]
		public StringValue? OperationDescription { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OperationCD 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue? OperationNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OutsideProcess 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcess { get; set; }

		[DataMember(Name="OutsideProcessOptions", EmitDefaultValue=false)]
		public EstimateOperationOutsideProcess? OutsideProcessOptions { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<EstimateOverheadDetail>? Overheads { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QueueTimeRaw 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="QueueTime", EmitDefaultValue=false)]
		public IntValue? QueueTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReferenceMaterialCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RefMaterialCost", EmitDefaultValue=false)]
		public DecimalValue? RefMaterialCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RunUnitTimeRaw 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RunTime", EmitDefaultValue=false)]
		public IntValue? RunTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RunUnits 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RunUnits", EmitDefaultValue=false)]
		public DecimalValue? RunUnits { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SetupTimeRaw 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SetupTime", EmitDefaultValue=false)]
		public IntValue? SetupTime { get; set; }

		[DataMember(Name="Steps", EmitDefaultValue=false)]
		public List<EstimateStepDetail>? Steps { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubcontractCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SubcontractCost", EmitDefaultValue=false)]
		public DecimalValue? SubcontractCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubcontractOverride 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SubcontractOverride", EmitDefaultValue=false)]
		public BooleanValue? SubcontractOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ToolCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ToolCost", EmitDefaultValue=false)]
		public DecimalValue? ToolCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ToolOverride 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ToolOverride", EmitDefaultValue=false)]
		public BooleanValue? ToolOverride { get; set; }

		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public List<EstimateToolDetail>? Tools { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExtCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VariableLaborOverride 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VariableLaborOverride", EmitDefaultValue=false)]
		public BooleanValue? VariableLaborOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VariableOverheadOverride 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VariableOverheadOverride", EmitDefaultValue=false)]
		public BooleanValue? VariableOverheadOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VariableLaborCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VarLaborCost", EmitDefaultValue=false)]
		public DecimalValue? VarLaborCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VariableOverheadCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VarOverheadCost", EmitDefaultValue=false)]
		public DecimalValue? VarOverheadCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VendorLocationID 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VendorLocation", EmitDefaultValue=false)]
		public StringValue? VendorLocation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkCenterID 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue? WorkCenter { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}