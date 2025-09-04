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
	public class ProductionOrderTotals : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Fixed Overhead 
		/// </summary>
		[DataMember(Name="ActualFixedOverhead", EmitDefaultValue=false)]
		public DecimalValue? ActualFixedOverhead { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Labor 
		/// </summary>
		[DataMember(Name="ActualLabor", EmitDefaultValue=false)]
		public DecimalValue? ActualLabor { get; set; }

		/// <summary>
		/// DAC Field Name: ActualLaborTimeRaw 
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: ActualLaborTimeRaw 
		/// </summary>
		[DataMember(Name="ActualLaborTime", EmitDefaultValue=false)]
		public IntValue? ActualLaborTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Machine 
		/// </summary>
		[DataMember(Name="ActualMachine", EmitDefaultValue=false)]
		public DecimalValue? ActualMachine { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Material 
		/// </summary>
		[DataMember(Name="ActualMaterial", EmitDefaultValue=false)]
		public DecimalValue? ActualMaterial { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Subcontract 
		/// </summary>
		[DataMember(Name="ActualSubcontract", EmitDefaultValue=false)]
		public DecimalValue? ActualSubcontract { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Tool 
		/// </summary>
		[DataMember(Name="ActualTool", EmitDefaultValue=false)]
		public DecimalValue? ActualTool { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Variable Overhead 
		/// </summary>
		[DataMember(Name="ActualVariableOverhead", EmitDefaultValue=false)]
		public DecimalValue? ActualVariableOverhead { get; set; }

		/// <summary>
		/// DAC Field Name: WIPAdjustment 
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// </summary>
		[DataMember(Name="Adjustments", EmitDefaultValue=false)]
		public DecimalValue? Adjustments { get; set; }

		/// <summary>
		/// DAC Field Name: VarianceFixedOverhead 
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Fixed Overhead 
		/// </summary>
		[DataMember(Name="FixedOverheadVariance", EmitDefaultValue=false)]
		public DecimalValue? FixedOverheadVariance { get; set; }

		/// <summary>
		/// DAC Field Name: VarianceLaborTimeRaw 
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: VarianceLaborTimeRaw 
		/// </summary>
		[DataMember(Name="LaborTimeVariance", EmitDefaultValue=false)]
		public IntValue? LaborTimeVariance { get; set; }

		/// <summary>
		/// DAC Field Name: VarianceLabor 
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Labor 
		/// </summary>
		[DataMember(Name="LaborVariance", EmitDefaultValue=false)]
		public DecimalValue? LaborVariance { get; set; }

		/// <summary>
		/// DAC Field Name: VarianceMachine 
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Machine 
		/// </summary>
		[DataMember(Name="MachineVariance", EmitDefaultValue=false)]
		public DecimalValue? MachineVariance { get; set; }

		/// <summary>
		/// DAC Field Name: VarianceMaterial 
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Material 
		/// </summary>
		[DataMember(Name="MaterialVariance", EmitDefaultValue=false)]
		public DecimalValue? MaterialVariance { get; set; }

		/// <summary>
		/// DAC Field Name: WIPComp 
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: MFG to Inventory 
		/// </summary>
		[DataMember(Name="MFGtoInventory", EmitDefaultValue=false)]
		public DecimalValue? MFGtoInventory { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Plan Cost Date 
		/// </summary>
		[DataMember(Name="PlanCostDate", EmitDefaultValue=false)]
		public DateTimeValue? PlanCostDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Fixed Overhead 
		/// </summary>
		[DataMember(Name="PlanFixedOverhead", EmitDefaultValue=false)]
		public DecimalValue? PlanFixedOverhead { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Labor 
		/// </summary>
		[DataMember(Name="PlanLabor", EmitDefaultValue=false)]
		public DecimalValue? PlanLabor { get; set; }

		/// <summary>
		/// DAC Field Name: PlanLaborTimeRaw 
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: PlanLaborTimeRaw 
		/// </summary>
		[DataMember(Name="PlanLaborTime", EmitDefaultValue=false)]
		public IntValue? PlanLaborTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Machine 
		/// </summary>
		[DataMember(Name="PlanMachine", EmitDefaultValue=false)]
		public DecimalValue? PlanMachine { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Material 
		/// </summary>
		[DataMember(Name="PlanMaterial", EmitDefaultValue=false)]
		public DecimalValue? PlanMaterial { get; set; }

		/// <summary>
		/// DAC Field Name: PlanReferenceMaterial 
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Ref. Material 
		/// </summary>
		[DataMember(Name="PlanRefMaterial", EmitDefaultValue=false)]
		public DecimalValue? PlanRefMaterial { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Subcontract 
		/// </summary>
		[DataMember(Name="PlanSubcontract", EmitDefaultValue=false)]
		public DecimalValue? PlanSubcontract { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Tool 
		/// </summary>
		[DataMember(Name="PlanTool", EmitDefaultValue=false)]
		public DecimalValue? PlanTool { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Plan Total 
		/// </summary>
		[DataMember(Name="PlanTotal", EmitDefaultValue=false)]
		public DecimalValue? PlanTotal { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="PlanUnitCost", EmitDefaultValue=false)]
		public DecimalValue? PlanUnitCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Variable Overhead 
		/// </summary>
		[DataMember(Name="PlanVariableOverhead", EmitDefaultValue=false)]
		public DecimalValue? PlanVariableOverhead { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Scrap 
		/// </summary>
		[DataMember(Name="ScrapAmount", EmitDefaultValue=false)]
		public DecimalValue? ScrapAmount { get; set; }

		/// <summary>
		/// DAC Field Name: VarianceSubcontract 
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Subcontract 
		/// </summary>
		[DataMember(Name="SubcontractVariance", EmitDefaultValue=false)]
		public DecimalValue? SubcontractVariance { get; set; }

		/// <summary>
		/// DAC Field Name: VarianceTool 
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Tool 
		/// </summary>
		[DataMember(Name="ToolVariance", EmitDefaultValue=false)]
		public DecimalValue? ToolVariance { get; set; }

		/// <summary>
		/// DAC Field Name: VarianceTotal 
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Total Variance 
		/// </summary>
		[DataMember(Name="TotalVariance", EmitDefaultValue=false)]
		public DecimalValue? TotalVariance { get; set; }

		/// <summary>
		/// DAC Field Name: VarianceVariableOverhead 
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: Variable Overhead 
		/// </summary>
		[DataMember(Name="VariableOverheadVariance", EmitDefaultValue=false)]
		public DecimalValue? VariableOverheadVariance { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: WIP Balance 
		/// </summary>
		[DataMember(Name="WIPBalance", EmitDefaultValue=false)]
		public DecimalValue? WIPBalance { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMProdTotal 
		/// Display Name: WIP Total 
		/// </summary>
		[DataMember(Name="WIPTotal", EmitDefaultValue=false)]
		public DecimalValue? WIPTotal { get; set; }

	}
}