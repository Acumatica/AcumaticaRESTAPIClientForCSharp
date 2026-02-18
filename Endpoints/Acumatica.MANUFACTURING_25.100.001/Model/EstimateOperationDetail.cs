using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class EstimateOperationDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: BackFlushLabor</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Backflush Labor</para>
		/// </summary>
		public BooleanValue? BackflushLabor { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Control Point</para>
		/// </summary>
		public BooleanValue? ControlPoint { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Estimate ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? EstimateID { get; set; }

		public IntValue? FinishTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Fixed Labor Cost</para>
		/// </summary>
		public BooleanValue? FixedLaborOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FixedOverheadOverride</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Fixed Overhead Cost</para>
		/// </summary>
		public BooleanValue? FixedOvhdOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FixedLaborCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Fixed Labor Cost</para>
		/// </summary>
		public DecimalValue? FixLaborCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FixedOverheadCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Fixed Overhead Cost</para>
		/// </summary>
		public DecimalValue? FixOverheadCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Machine Cost</para>
		/// </summary>
		public DecimalValue? MachineCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Machine Cost</para>
		/// </summary>
		public BooleanValue? MachineOverride { get; set; }

		public IntValue? MachineTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Machine Units</para>
		/// </summary>
		public DecimalValue? MachineUnits { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Material Cost</para>
		/// </summary>
		public DecimalValue? MaterialCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Material Cost</para>
		/// </summary>
		public BooleanValue? MaterialOverride { get; set; }

		public IntValue? MoveTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Description</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Operation Desc</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? OperationDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OperationCD</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Operation ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? OperationID { get; set; }

		public IntValue? OperationNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Outside Process</para>
		/// </summary>
		public BooleanValue? OutsideProcess { get; set; }

		public IntValue? QueueTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReferenceMaterialCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Ref. Material Cost</para>
		/// </summary>
		public DecimalValue? RefMaterialCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? Revision { get; set; }

		public IntValue? RunTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Run Units</para>
		/// </summary>
		public DecimalValue? RunUnits { get; set; }

		public IntValue? SetupTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Subcontract Cost</para>
		/// </summary>
		public DecimalValue? SubcontractCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Subcontract Cost</para>
		/// </summary>
		public BooleanValue? SubcontractOverride { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Tool Cost</para>
		/// </summary>
		public DecimalValue? ToolCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Tool Cost</para>
		/// </summary>
		public BooleanValue? ToolOverride { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Var. Labor Cost</para>
		/// </summary>
		public BooleanValue? VariableLaborOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VariableOverheadOverride</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Var. Overhead Cost</para>
		/// </summary>
		public BooleanValue? VariableOvhdOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VariableLaborCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Var. Labor Cost</para>
		/// </summary>
		public DecimalValue? VarLaborCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VariableOverheadCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Var. Overhead Cost</para>
		/// </summary>
		public DecimalValue? VarOverheadCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkCenterID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Work Center</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? WorkCenter { get; set; }

	}
}