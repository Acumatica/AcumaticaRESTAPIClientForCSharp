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
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Backflush Labor 
		/// </summary>
		[DataMember(Name="BackflushLabor", EmitDefaultValue=false)]
		public BooleanValue? BackflushLabor { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Control Point 
		/// </summary>
		[DataMember(Name="ControlPoint", EmitDefaultValue=false)]
		public BooleanValue? ControlPoint { get; set; }

		/// <summary>
		/// DAC Field Name: DropShippedToVendor 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Drop Shipped to Vendor 
		/// </summary>
		[DataMember(Name="DropShippedtoVendor", EmitDefaultValue=false)]
		public BooleanValue? DropShippedtoVendor { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Estimate ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="EstimateID", EmitDefaultValue=false)]
		public StringValue? EstimateID { get; set; }

		/// <summary>
		/// DAC Field Name: FinishTimeRaw 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: FinishTimeRaw 
		/// </summary>
		[DataMember(Name="FinishTime", EmitDefaultValue=false)]
		public IntValue? FinishTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Override Fixed Labor Cost 
		/// </summary>
		[DataMember(Name="FixedLaborOverride", EmitDefaultValue=false)]
		public BooleanValue? FixedLaborOverride { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Override Fixed Overhead Cost 
		/// </summary>
		[DataMember(Name="FixedOverheadOverride", EmitDefaultValue=false)]
		public BooleanValue? FixedOverheadOverride { get; set; }

		/// <summary>
		/// DAC Field Name: FixedLaborCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Fixed Labor Cost 
		/// </summary>
		[DataMember(Name="FixLaborCost", EmitDefaultValue=false)]
		public DecimalValue? FixLaborCost { get; set; }

		/// <summary>
		/// DAC Field Name: FixedOverheadCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Fixed Overhead Cost 
		/// </summary>
		[DataMember(Name="FixOverheadCost", EmitDefaultValue=false)]
		public DecimalValue? FixOverheadCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Machine Cost 
		/// </summary>
		[DataMember(Name="MachineCost", EmitDefaultValue=false)]
		public DecimalValue? MachineCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Override Machine Cost 
		/// </summary>
		[DataMember(Name="MachineOverride", EmitDefaultValue=false)]
		public BooleanValue? MachineOverride { get; set; }

		/// <summary>
		/// DAC Field Name: MachineUnitTimeRaw 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: MachineUnitTimeRaw 
		/// </summary>
		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public IntValue? MachineTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Machine Units 
		/// </summary>
		[DataMember(Name="MachineUnits", EmitDefaultValue=false)]
		public DecimalValue? MachineUnits { get; set; }

		[DataMember(Name="Material", EmitDefaultValue=false)]
		public List<EstimateMaterialDetail>? Material { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Material Cost 
		/// </summary>
		[DataMember(Name="MaterialCost", EmitDefaultValue=false)]
		public DecimalValue? MaterialCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Override Material Cost 
		/// </summary>
		[DataMember(Name="MaterialOverride", EmitDefaultValue=false)]
		public BooleanValue? MaterialOverride { get; set; }

		/// <summary>
		/// DAC Field Name: MoveTimeRaw 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: MoveTimeRaw 
		/// </summary>
		[DataMember(Name="MoveTime", EmitDefaultValue=false)]
		public IntValue? MoveTime { get; set; }

		/// <summary>
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Operation Desc 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="OperationDescription", EmitDefaultValue=false)]
		public StringValue? OperationDescription { get; set; }

		/// <summary>
		/// DAC Field Name: OperationCD 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Operation ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue? OperationNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Outside Process 
		/// </summary>
		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcess { get; set; }

		[DataMember(Name="OutsideProcessOptions", EmitDefaultValue=false)]
		public EstimateOperationOutsideProcess? OutsideProcessOptions { get; set; }

		[DataMember(Name="Overheads", EmitDefaultValue=false)]
		public List<EstimateOverheadDetail>? Overheads { get; set; }

		/// <summary>
		/// DAC Field Name: QueueTimeRaw 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: QueueTimeRaw 
		/// </summary>
		[DataMember(Name="QueueTime", EmitDefaultValue=false)]
		public IntValue? QueueTime { get; set; }

		/// <summary>
		/// DAC Field Name: ReferenceMaterialCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Ref. Material Cost 
		/// </summary>
		[DataMember(Name="RefMaterialCost", EmitDefaultValue=false)]
		public DecimalValue? RefMaterialCost { get; set; }

		/// <summary>
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// DAC Field Name: RunUnitTimeRaw 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: RunUnitTimeRaw 
		/// </summary>
		[DataMember(Name="RunTime", EmitDefaultValue=false)]
		public IntValue? RunTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Run Units 
		/// </summary>
		[DataMember(Name="RunUnits", EmitDefaultValue=false)]
		public DecimalValue? RunUnits { get; set; }

		/// <summary>
		/// DAC Field Name: SetupTimeRaw 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: SetupTimeRaw 
		/// </summary>
		[DataMember(Name="SetupTime", EmitDefaultValue=false)]
		public IntValue? SetupTime { get; set; }

		[DataMember(Name="Steps", EmitDefaultValue=false)]
		public List<EstimateStepDetail>? Steps { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Subcontract Cost 
		/// </summary>
		[DataMember(Name="SubcontractCost", EmitDefaultValue=false)]
		public DecimalValue? SubcontractCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Override Subcontract Cost 
		/// </summary>
		[DataMember(Name="SubcontractOverride", EmitDefaultValue=false)]
		public BooleanValue? SubcontractOverride { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Tool Cost 
		/// </summary>
		[DataMember(Name="ToolCost", EmitDefaultValue=false)]
		public DecimalValue? ToolCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Override Tool Cost 
		/// </summary>
		[DataMember(Name="ToolOverride", EmitDefaultValue=false)]
		public BooleanValue? ToolOverride { get; set; }

		[DataMember(Name="Tools", EmitDefaultValue=false)]
		public List<EstimateToolDetail>? Tools { get; set; }

		/// <summary>
		/// DAC Field Name: ExtCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Total Cost 
		/// </summary>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Override Var. Labor Cost 
		/// </summary>
		[DataMember(Name="VariableLaborOverride", EmitDefaultValue=false)]
		public BooleanValue? VariableLaborOverride { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Override Var. Overhead Cost 
		/// </summary>
		[DataMember(Name="VariableOverheadOverride", EmitDefaultValue=false)]
		public BooleanValue? VariableOverheadOverride { get; set; }

		/// <summary>
		/// DAC Field Name: VariableLaborCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Var. Labor Cost 
		/// </summary>
		[DataMember(Name="VarLaborCost", EmitDefaultValue=false)]
		public DecimalValue? VarLaborCost { get; set; }

		/// <summary>
		/// DAC Field Name: VariableOverheadCost 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Var. Overhead Cost 
		/// </summary>
		[DataMember(Name="VarOverheadCost", EmitDefaultValue=false)]
		public DecimalValue? VarOverheadCost { get; set; }

		/// <summary>
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// DAC Field Name: VendorLocationID 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Vendor Location 
		/// </summary>
		[DataMember(Name="VendorLocation", EmitDefaultValue=false)]
		public StringValue? VendorLocation { get; set; }

		/// <summary>
		/// DAC Field Name: WorkCenterID 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Work Center 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue? WorkCenter { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}