using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class ProductionOrderOperationTotal : Entity
	{

		public DecimalValue? ActualFixedOverhead { get; set; }

		public DecimalValue? ActualLabor { get; set; }

		public IntValue? ActualLaborTime { get; set; }

		public DecimalValue? ActualMachine { get; set; }

		public DecimalValue? ActualMaterial { get; set; }

		public DecimalValue? ActualSubcontract { get; set; }

		public DecimalValue? ActualTool { get; set; }

		public DecimalValue? ActualVariableOverhead { get; set; }

		public DecimalValue? Adjustments { get; set; }

		public DecimalValue? FixedOverheadVariance { get; set; }

		public IntValue? LaborTimeVariance { get; set; }

		public DecimalValue? LaborVariance { get; set; }

		public DecimalValue? MachineVariance { get; set; }

		public DecimalValue? MaterialVariance { get; set; }

		public DecimalValue? MFGtoInventory { get; set; }

		public DateTimeValue? PlanCostDate { get; set; }

		public DecimalValue? PlanFixedOverhead { get; set; }

		public DecimalValue? PlanLabor { get; set; }

		public IntValue? PlanLaborTime { get; set; }

		public DecimalValue? PlanMachine { get; set; }

		public DecimalValue? PlanMaterial { get; set; }

		public DecimalValue? PlanQty { get; set; }

		public DecimalValue? PlanRefMaterial { get; set; }

		public DecimalValue? PlanSubcontract { get; set; }

		public DecimalValue? PlanTool { get; set; }

		public DecimalValue? PlanTotal { get; set; }

		public DecimalValue? PlanVariableOverhead { get; set; }

		public DecimalValue? ScrapAmount { get; set; }

		public DecimalValue? SubcontractVariance { get; set; }

		public DecimalValue? ToolVariance { get; set; }

		public DecimalValue? TotalVariance { get; set; }

		public DecimalValue? VariableOverheadVariance { get; set; }

		public DecimalValue? WIPBalance { get; set; }

		public DecimalValue? WIPTotal { get; set; }

	}
}