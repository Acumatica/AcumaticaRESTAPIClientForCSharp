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
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Fixed Overhead</para>
		/// </summary>
		[DataMember(Name="ActualFixedOverhead", EmitDefaultValue=false)]
		public DecimalValue? ActualFixedOverhead { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Labor</para>
		/// </summary>
		[DataMember(Name="ActualLabor", EmitDefaultValue=false)]
		public DecimalValue? ActualLabor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualLaborTimeRaw</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: ActualLaborTimeRaw</para>
		/// </summary>
		[DataMember(Name="ActualLaborTime", EmitDefaultValue=false)]
		public IntValue? ActualLaborTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Machine</para>
		/// </summary>
		[DataMember(Name="ActualMachine", EmitDefaultValue=false)]
		public DecimalValue? ActualMachine { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Material</para>
		/// </summary>
		[DataMember(Name="ActualMaterial", EmitDefaultValue=false)]
		public DecimalValue? ActualMaterial { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Subcontract</para>
		/// </summary>
		[DataMember(Name="ActualSubcontract", EmitDefaultValue=false)]
		public DecimalValue? ActualSubcontract { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Tool</para>
		/// </summary>
		[DataMember(Name="ActualTool", EmitDefaultValue=false)]
		public DecimalValue? ActualTool { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Variable Overhead</para>
		/// </summary>
		[DataMember(Name="ActualVariableOverhead", EmitDefaultValue=false)]
		public DecimalValue? ActualVariableOverhead { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPAdjustment</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// </summary>
		[DataMember(Name="Adjustments", EmitDefaultValue=false)]
		public DecimalValue? Adjustments { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceFixedOverhead</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Fixed Overhead</para>
		/// </summary>
		[DataMember(Name="FixedOverheadVariance", EmitDefaultValue=false)]
		public DecimalValue? FixedOverheadVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceLaborTimeRaw</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: VarianceLaborTimeRaw</para>
		/// </summary>
		[DataMember(Name="LaborTimeVariance", EmitDefaultValue=false)]
		public IntValue? LaborTimeVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceLabor</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Labor</para>
		/// </summary>
		[DataMember(Name="LaborVariance", EmitDefaultValue=false)]
		public DecimalValue? LaborVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceMachine</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Machine</para>
		/// </summary>
		[DataMember(Name="MachineVariance", EmitDefaultValue=false)]
		public DecimalValue? MachineVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceMaterial</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Material</para>
		/// </summary>
		[DataMember(Name="MaterialVariance", EmitDefaultValue=false)]
		public DecimalValue? MaterialVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPComp</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: MFG to Inventory</para>
		/// </summary>
		[DataMember(Name="MFGtoInventory", EmitDefaultValue=false)]
		public DecimalValue? MFGtoInventory { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Plan Cost Date</para>
		/// </summary>
		[DataMember(Name="PlanCostDate", EmitDefaultValue=false)]
		public DateTimeValue? PlanCostDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Fixed Overhead</para>
		/// </summary>
		[DataMember(Name="PlanFixedOverhead", EmitDefaultValue=false)]
		public DecimalValue? PlanFixedOverhead { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Labor</para>
		/// </summary>
		[DataMember(Name="PlanLabor", EmitDefaultValue=false)]
		public DecimalValue? PlanLabor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PlanLaborTimeRaw</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: PlanLaborTimeRaw</para>
		/// </summary>
		[DataMember(Name="PlanLaborTime", EmitDefaultValue=false)]
		public IntValue? PlanLaborTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Machine</para>
		/// </summary>
		[DataMember(Name="PlanMachine", EmitDefaultValue=false)]
		public DecimalValue? PlanMachine { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Material</para>
		/// </summary>
		[DataMember(Name="PlanMaterial", EmitDefaultValue=false)]
		public DecimalValue? PlanMaterial { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PlanReferenceMaterial</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Ref. Material</para>
		/// </summary>
		[DataMember(Name="PlanRefMaterial", EmitDefaultValue=false)]
		public DecimalValue? PlanRefMaterial { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Subcontract</para>
		/// </summary>
		[DataMember(Name="PlanSubcontract", EmitDefaultValue=false)]
		public DecimalValue? PlanSubcontract { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Tool</para>
		/// </summary>
		[DataMember(Name="PlanTool", EmitDefaultValue=false)]
		public DecimalValue? PlanTool { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Plan Total</para>
		/// </summary>
		[DataMember(Name="PlanTotal", EmitDefaultValue=false)]
		public DecimalValue? PlanTotal { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		[DataMember(Name="PlanUnitCost", EmitDefaultValue=false)]
		public DecimalValue? PlanUnitCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Variable Overhead</para>
		/// </summary>
		[DataMember(Name="PlanVariableOverhead", EmitDefaultValue=false)]
		public DecimalValue? PlanVariableOverhead { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Scrap</para>
		/// </summary>
		[DataMember(Name="ScrapAmount", EmitDefaultValue=false)]
		public DecimalValue? ScrapAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceSubcontract</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Subcontract</para>
		/// </summary>
		[DataMember(Name="SubcontractVariance", EmitDefaultValue=false)]
		public DecimalValue? SubcontractVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceTool</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Tool</para>
		/// </summary>
		[DataMember(Name="ToolVariance", EmitDefaultValue=false)]
		public DecimalValue? ToolVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceTotal</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Total Variance</para>
		/// </summary>
		[DataMember(Name="TotalVariance", EmitDefaultValue=false)]
		public DecimalValue? TotalVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceVariableOverhead</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Variable Overhead</para>
		/// </summary>
		[DataMember(Name="VariableOverheadVariance", EmitDefaultValue=false)]
		public DecimalValue? VariableOverheadVariance { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: WIP Balance</para>
		/// </summary>
		[DataMember(Name="WIPBalance", EmitDefaultValue=false)]
		public DecimalValue? WIPBalance { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: WIP Total</para>
		/// </summary>
		[DataMember(Name="WIPTotal", EmitDefaultValue=false)]
		public DecimalValue? WIPTotal { get; set; }

	}
}