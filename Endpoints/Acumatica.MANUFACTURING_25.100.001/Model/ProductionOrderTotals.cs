using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class ProductionOrderTotals : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Fixed Overhead</para>
		/// </summary>
		public DecimalValue? ActualFixedOverhead { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Labor</para>
		/// </summary>
		public DecimalValue? ActualLabor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ActualLaborTimeRaw</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: ActualLaborTimeRaw</para>
		/// </summary>
		public IntValue? ActualLaborTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Machine</para>
		/// </summary>
		public DecimalValue? ActualMachine { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Material</para>
		/// </summary>
		public DecimalValue? ActualMaterial { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Subcontract</para>
		/// </summary>
		public DecimalValue? ActualSubcontract { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Tool</para>
		/// </summary>
		public DecimalValue? ActualTool { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Variable Overhead</para>
		/// </summary>
		public DecimalValue? ActualVariableOverhead { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPAdjustment</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// </summary>
		public DecimalValue? Adjustments { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceFixedOverhead</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Fixed Overhead</para>
		/// </summary>
		public DecimalValue? FixedOverheadVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceLaborTimeRaw</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: VarianceLaborTimeRaw</para>
		/// </summary>
		public IntValue? LaborTimeVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceLabor</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Labor</para>
		/// </summary>
		public DecimalValue? LaborVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceMachine</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Machine</para>
		/// </summary>
		public DecimalValue? MachineVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceMaterial</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Material</para>
		/// </summary>
		public DecimalValue? MaterialVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WIPComp</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: MFG to Inventory</para>
		/// </summary>
		public DecimalValue? MFGtoInventory { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Plan Cost Date</para>
		/// </summary>
		public DateTimeValue? PlanCostDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Fixed Overhead</para>
		/// </summary>
		public DecimalValue? PlanFixedOverhead { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Labor</para>
		/// </summary>
		public DecimalValue? PlanLabor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PlanLaborTimeRaw</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: PlanLaborTimeRaw</para>
		/// </summary>
		public IntValue? PlanLaborTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Machine</para>
		/// </summary>
		public DecimalValue? PlanMachine { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Material</para>
		/// </summary>
		public DecimalValue? PlanMaterial { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PlanReferenceMaterial</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Ref. Material</para>
		/// </summary>
		public DecimalValue? PlanRefMaterial { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Subcontract</para>
		/// </summary>
		public DecimalValue? PlanSubcontract { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Tool</para>
		/// </summary>
		public DecimalValue? PlanTool { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Plan Total</para>
		/// </summary>
		public DecimalValue? PlanTotal { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? PlanUnitCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Variable Overhead</para>
		/// </summary>
		public DecimalValue? PlanVariableOverhead { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Scrap</para>
		/// </summary>
		public DecimalValue? ScrapAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceSubcontract</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Subcontract</para>
		/// </summary>
		public DecimalValue? SubcontractVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceTool</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Tool</para>
		/// </summary>
		public DecimalValue? ToolVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceTotal</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Total Variance</para>
		/// </summary>
		public DecimalValue? TotalVariance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarianceVariableOverhead</para>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: Variable Overhead</para>
		/// </summary>
		public DecimalValue? VariableOverheadVariance { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: WIP Balance</para>
		/// </summary>
		public DecimalValue? WIPBalance { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMProdTotal</para>
		/// <para>Display Name: WIP Total</para>
		/// </summary>
		public DecimalValue? WIPTotal { get; set; }

	}
}