using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class ProjectRetainage : Entity
	{

		/// <summary>
		/// Retainage Mode
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Retainage Mode</para>
		/// <para>SQL Type: nchar(1)</para>
		/// </summary>
		[DataMember(Name="RetainageMode", EmitDefaultValue=false)]
		public StringValue? RetainageMode { get; set; }

		/// <summary>
		/// Include Change Orders in Contract Total
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Include CO</para>
		/// </summary>
		[DataMember(Name="IncludeCO", EmitDefaultValue=false)]
		public BooleanValue? IncludeCO { get; set; }

		/// <summary>
		/// Stepped Retainage
		/// <para>DAC Field Name: SteppedRetainage</para>
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Use Steps</para>
		/// </summary>
		[DataMember(Name="UseSteps", EmitDefaultValue=false)]
		public BooleanValue? UseSteps { get; set; }

		/// <summary>
		/// Retainage Cap %
		/// <para>DAC Field Name: RetainageMaxPct</para>
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Cap (%)</para>
		/// </summary>
		[DataMember(Name="CapPct", EmitDefaultValue=false)]
		public DecimalValue? CapPct { get; set; }

		/// <summary>
		/// The retainage cap amount.
		/// <para>DAC Field Name: CuryCapAmount</para>
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Cap Amount</para>
		/// </summary>
		[DataMember(Name="CapAmount", EmitDefaultValue=false)]
		public DecimalValue? CapAmount { get; set; }

		/// <summary>
		/// The percent of an invoice amount issued for the project that is retained by the customer.
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Retainage (%)</para>
		/// </summary>
		[DataMember(Name="RetainagePct", EmitDefaultValue=false)]
		public DecimalValue? RetainagePct { get; set; }

		/// <summary>
		/// The total retained amount in the project currency.
		/// <para>DAC Field Name: CuryTotalRetainedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMRevenueBudget</para>
		/// <para>Display Name: Total Retained Amount</para>
		/// </summary>
		[DataMember(Name="RetainTotal", EmitDefaultValue=false)]
		public DecimalValue? RetainTotal { get; set; }

		/// <summary>
		/// The budgeted amount of the budget line in the project currency.
		/// <para>DAC Field Name: CuryAmount</para>
		/// <para>DAC: PX.Objects.PM.PMCostBudget</para>
		/// <para>Display Name: Original Budgeted Amount</para>
		/// </summary>
		[DataMember(Name="ContractTotal", EmitDefaultValue=false)]
		public DecimalValue? ContractTotal { get; set; }

		/// <summary>
		/// Contract Completed % (without Change Orders)
		/// <para>DAC Field Name: ContractCompletedPct</para>
		/// <para>DAC: PX.Objects.PM.PMProjectRevenueTotal</para>
		/// <para>Display Name: Completed (%)</para>
		/// </summary>
		[DataMember(Name="CompletedPct", EmitDefaultValue=false)]
		public DecimalValue? CompletedPct { get; set; }

	}
}