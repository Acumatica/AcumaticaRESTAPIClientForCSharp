using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class ProjectRetainage : Entity
	{

		/// <summary>
		/// Retainage Mode
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Retainage Mode</para>
		/// <para>SQL Type: nchar(1)</para>
		/// </summary>
		public StringValue? RetainageMode { get; set; }

		/// <summary>
		/// Include Change Orders in Contract Total
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Include CO</para>
		/// </summary>
		public BooleanValue? IncludeCO { get; set; }

		/// <summary>
		/// Stepped Retainage
		/// <para>DAC Field Name: SteppedRetainage</para>
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Use Steps</para>
		/// </summary>
		public BooleanValue? UseSteps { get; set; }

		/// <summary>
		/// Retainage Cap %
		/// <para>DAC Field Name: RetainageMaxPct</para>
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Cap (%)</para>
		/// </summary>
		public DecimalValue? CapPct { get; set; }

		/// <summary>
		/// The retainage cap amount.
		/// <para>DAC Field Name: CuryCapAmount</para>
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Cap Amount</para>
		/// </summary>
		public DecimalValue? CapAmount { get; set; }

		/// <summary>
		/// The percent of an invoice amount issued for the project that is retained by the customer.
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Retainage (%)</para>
		/// </summary>
		public DecimalValue? RetainagePct { get; set; }

		/// <summary>
		/// The total retained amount in the project currency.
		/// <para>DAC Field Name: CuryTotalRetainedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMRevenueBudget</para>
		/// <para>Display Name: Total Retained Amount</para>
		/// </summary>
		public DecimalValue? RetainTotal { get; set; }

		/// <summary>
		/// The budgeted amount of the budget line in the project currency.
		/// <para>DAC Field Name: CuryAmount</para>
		/// <para>DAC: PX.Objects.PM.PMCostBudget</para>
		/// <para>Display Name: Original Budgeted Amount</para>
		/// </summary>
		public DecimalValue? ContractTotal { get; set; }

		/// <summary>
		/// Contract Completed % (without Change Orders)
		/// <para>DAC Field Name: ContractCompletedPct</para>
		/// <para>DAC: PX.Objects.PM.PMProjectRevenueTotal</para>
		/// <para>Display Name: Completed (%)</para>
		/// </summary>
		public DecimalValue? CompletedPct { get; set; }

	}
}