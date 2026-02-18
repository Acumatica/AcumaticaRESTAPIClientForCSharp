using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM304000</c> in the Acumatica ERP
	/// <para>Key Fields: EstimateID, OperationNbr, Revision</para>
	/// </summary>
	public class EstimateOperation : Entity, ITopLevelEntity
	{

		/// <summary>
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
		/// <para>DAC Field Name: DropShippedToVendor</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Drop Shipped to Vendor</para>
		/// </summary>
		public BooleanValue? DropShippedtoVendor { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Estimate ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? EstimateID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinishTimeRaw</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: FinishTimeRaw</para>
		/// </summary>
		public IntValue? FinishTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Override Fixed Labor Cost</para>
		/// </summary>
		public BooleanValue? FixedLaborOverride { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Override Fixed Overhead Cost</para>
		/// </summary>
		public BooleanValue? FixedOverheadOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FixedLaborCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Fixed Labor Cost</para>
		/// </summary>
		public DecimalValue? FixLaborCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FixedOverheadCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Fixed Overhead Cost</para>
		/// </summary>
		public DecimalValue? FixOverheadCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Machine Cost</para>
		/// </summary>
		public DecimalValue? MachineCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Override Machine Cost</para>
		/// </summary>
		public BooleanValue? MachineOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MachineUnitTimeRaw</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: MachineUnitTimeRaw</para>
		/// </summary>
		public IntValue? MachineTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Machine Units</para>
		/// </summary>
		public DecimalValue? MachineUnits { get; set; }

		public List<EstimateMaterialDetail>? Material { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Material Cost</para>
		/// </summary>
		public DecimalValue? MaterialCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Override Material Cost</para>
		/// </summary>
		public BooleanValue? MaterialOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MoveTimeRaw</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: MoveTimeRaw</para>
		/// </summary>
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
		public StringValue? OperationNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Outside Process</para>
		/// </summary>
		public BooleanValue? OutsideProcess { get; set; }

		public EstimateOperationOutsideProcess? OutsideProcessOptions { get; set; }

		public List<EstimateOverheadDetail>? Overheads { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QueueTimeRaw</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: QueueTimeRaw</para>
		/// </summary>
		public IntValue? QueueTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReferenceMaterialCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Ref. Material Cost</para>
		/// </summary>
		public DecimalValue? RefMaterialCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? Revision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RunUnitTimeRaw</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: RunUnitTimeRaw</para>
		/// </summary>
		public IntValue? RunTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Run Units</para>
		/// </summary>
		public DecimalValue? RunUnits { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SetupTimeRaw</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: SetupTimeRaw</para>
		/// </summary>
		public IntValue? SetupTime { get; set; }

		public List<EstimateStepDetail>? Steps { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Subcontract Cost</para>
		/// </summary>
		public DecimalValue? SubcontractCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Override Subcontract Cost</para>
		/// </summary>
		public BooleanValue? SubcontractOverride { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Tool Cost</para>
		/// </summary>
		public DecimalValue? ToolCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Override Tool Cost</para>
		/// </summary>
		public BooleanValue? ToolOverride { get; set; }

		public List<EstimateToolDetail>? Tools { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExtCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Total Cost</para>
		/// </summary>
		public DecimalValue? TotalCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Override Var. Labor Cost</para>
		/// </summary>
		public BooleanValue? VariableLaborOverride { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Override Var. Overhead Cost</para>
		/// </summary>
		public BooleanValue? VariableOverheadOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VariableLaborCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Var. Labor Cost</para>
		/// </summary>
		public DecimalValue? VarLaborCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VariableOverheadCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Var. Overhead Cost</para>
		/// </summary>
		public DecimalValue? VarOverheadCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// </summary>
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorLocationID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Vendor Location</para>
		/// </summary>
		public StringValue? VendorLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkCenterID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateOper</para>
		/// <para>Display Name: Work Center</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? WorkCenter { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Material = "Material";
			public const string Material_Files = "Material/Files";
			public const string OutsideProcessOptions = "OutsideProcessOptions";
			public const string Overheads = "Overheads";
			public const string Overheads_Files = "Overheads/Files";
			public const string Steps = "Steps";
			public const string Steps_Files = "Steps/Files";
			public const string Tools = "Tools";
			public const string Tools_Files = "Tools/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Material,Material/Files,OutsideProcessOptions,Overheads,Overheads/Files,Steps,Steps/Files,Tools,Tools/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}