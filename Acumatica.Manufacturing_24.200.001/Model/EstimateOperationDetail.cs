using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class EstimateOperationDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: BackFlushLabor 
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
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Estimate ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="EstimateID", EmitDefaultValue=false)]
		public StringValue? EstimateID { get; set; }

		[DataMember(Name="FinishTime", EmitDefaultValue=false)]
		public IntValue? FinishTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Fixed Labor Cost 
		/// </summary>
		[DataMember(Name="FixedLaborOverride", EmitDefaultValue=false)]
		public BooleanValue? FixedLaborOverride { get; set; }

		/// <summary>
		/// DAC Field Name: FixedOverheadOverride 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Fixed Overhead Cost 
		/// </summary>
		[DataMember(Name="FixedOvhdOverride", EmitDefaultValue=false)]
		public BooleanValue? FixedOvhdOverride { get; set; }

		/// <summary>
		/// DAC Field Name: FixedLaborCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Fixed Labor Cost 
		/// </summary>
		[DataMember(Name="FixLaborCost", EmitDefaultValue=false)]
		public DecimalValue? FixLaborCost { get; set; }

		/// <summary>
		/// DAC Field Name: FixedOverheadCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Fixed Overhead Cost 
		/// </summary>
		[DataMember(Name="FixOverheadCost", EmitDefaultValue=false)]
		public DecimalValue? FixOverheadCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Machine Cost 
		/// </summary>
		[DataMember(Name="MachineCost", EmitDefaultValue=false)]
		public DecimalValue? MachineCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Machine Cost 
		/// </summary>
		[DataMember(Name="MachineOverride", EmitDefaultValue=false)]
		public BooleanValue? MachineOverride { get; set; }

		[DataMember(Name="MachineTime", EmitDefaultValue=false)]
		public IntValue? MachineTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Machine Units 
		/// </summary>
		[DataMember(Name="MachineUnits", EmitDefaultValue=false)]
		public DecimalValue? MachineUnits { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Material Cost 
		/// </summary>
		[DataMember(Name="MaterialCost", EmitDefaultValue=false)]
		public DecimalValue? MaterialCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Material Cost 
		/// </summary>
		[DataMember(Name="MaterialOverride", EmitDefaultValue=false)]
		public BooleanValue? MaterialOverride { get; set; }

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
		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public IntValue? OperationNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Outside Process 
		/// </summary>
		[DataMember(Name="OutsideProcess", EmitDefaultValue=false)]
		public BooleanValue? OutsideProcess { get; set; }

		[DataMember(Name="QueueTime", EmitDefaultValue=false)]
		public IntValue? QueueTime { get; set; }

		/// <summary>
		/// DAC Field Name: ReferenceMaterialCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Ref. Material Cost 
		/// </summary>
		[DataMember(Name="RefMaterialCost", EmitDefaultValue=false)]
		public DecimalValue? RefMaterialCost { get; set; }

		/// <summary>
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		[DataMember(Name="RunTime", EmitDefaultValue=false)]
		public IntValue? RunTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Run Units 
		/// </summary>
		[DataMember(Name="RunUnits", EmitDefaultValue=false)]
		public DecimalValue? RunUnits { get; set; }

		[DataMember(Name="SetupTime", EmitDefaultValue=false)]
		public IntValue? SetupTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Subcontract Cost 
		/// </summary>
		[DataMember(Name="SubcontractCost", EmitDefaultValue=false)]
		public DecimalValue? SubcontractCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Subcontract Cost 
		/// </summary>
		[DataMember(Name="SubcontractOverride", EmitDefaultValue=false)]
		public BooleanValue? SubcontractOverride { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Tool Cost 
		/// </summary>
		[DataMember(Name="ToolCost", EmitDefaultValue=false)]
		public DecimalValue? ToolCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Tool Cost 
		/// </summary>
		[DataMember(Name="ToolOverride", EmitDefaultValue=false)]
		public BooleanValue? ToolOverride { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Var. Labor Cost 
		/// </summary>
		[DataMember(Name="VariableLaborOverride", EmitDefaultValue=false)]
		public BooleanValue? VariableLaborOverride { get; set; }

		/// <summary>
		/// DAC Field Name: VariableOverheadOverride 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Var. Overhead Cost 
		/// </summary>
		[DataMember(Name="VariableOvhdOverride", EmitDefaultValue=false)]
		public BooleanValue? VariableOvhdOverride { get; set; }

		/// <summary>
		/// DAC Field Name: VariableLaborCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Var. Labor Cost 
		/// </summary>
		[DataMember(Name="VarLaborCost", EmitDefaultValue=false)]
		public DecimalValue? VarLaborCost { get; set; }

		/// <summary>
		/// DAC Field Name: VariableOverheadCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Var. Overhead Cost 
		/// </summary>
		[DataMember(Name="VarOverheadCost", EmitDefaultValue=false)]
		public DecimalValue? VarOverheadCost { get; set; }

		/// <summary>
		/// DAC Field Name: WorkCenterID 
		/// DAC: PX.Objects.AM.AMEstimateOper 
		/// Display Name: Work Center 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="WorkCenter", EmitDefaultValue=false)]
		public StringValue? WorkCenter { get; set; }

	}
}