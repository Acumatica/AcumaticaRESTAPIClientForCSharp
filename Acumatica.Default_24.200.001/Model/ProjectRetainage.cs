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
		/// DAC: PX.Objects.PM.PMProject 
		/// Display Name: Retainage Mode 
		/// SQL Type: nchar(1) 
		/// </summary>
		[DataMember(Name="RetainageMode", EmitDefaultValue=false)]
		public StringValue? RetainageMode { get; set; }

		/// <summary>
		/// Include Change Orders in Contract Total
		/// DAC: PX.Objects.PM.PMProject 
		/// Display Name: Include CO 
		/// </summary>
		[DataMember(Name="IncludeCO", EmitDefaultValue=false)]
		public BooleanValue? IncludeCO { get; set; }

		/// <summary>
		/// Stepped Retainage
		/// DAC Field Name: SteppedRetainage 
		/// DAC: PX.Objects.PM.PMProject 
		/// Display Name: Use Steps 
		/// </summary>
		[DataMember(Name="UseSteps", EmitDefaultValue=false)]
		public BooleanValue? UseSteps { get; set; }

		/// <summary>
		/// Retainage Cap %
		/// DAC Field Name: RetainageMaxPct 
		/// DAC: PX.Objects.PM.PMProject 
		/// Display Name: Cap (%) 
		/// </summary>
		[DataMember(Name="CapPct", EmitDefaultValue=false)]
		public DecimalValue? CapPct { get; set; }

		/// <summary>
		/// The retainage cap amount.
		/// DAC Field Name: CuryCapAmount 
		/// DAC: PX.Objects.PM.PMProject 
		/// Display Name: Cap Amount 
		/// </summary>
		[DataMember(Name="CapAmount", EmitDefaultValue=false)]
		public DecimalValue? CapAmount { get; set; }

		/// <summary>
		/// The percent of an invoice amount issued for the project that is retained by the customer.
		/// DAC: PX.Objects.PM.PMProject 
		/// Display Name: Retainage (%) 
		/// </summary>
		[DataMember(Name="RetainagePct", EmitDefaultValue=false)]
		public DecimalValue? RetainagePct { get; set; }

		/// <summary>
		/// The total retained amount in the project currency.
		/// DAC Field Name: CuryTotalRetainedAmount 
		/// DAC: PX.Objects.PM.PMRevenueBudget 
		/// Display Name: Total Retained Amount 
		/// </summary>
		[DataMember(Name="RetainTotal", EmitDefaultValue=false)]
		public DecimalValue? RetainTotal { get; set; }

		/// <summary>
		/// The budgeted amount of the budget line in the project currency.
		/// DAC Field Name: CuryAmount 
		/// DAC: PX.Objects.PM.PMCostBudget 
		/// Display Name: Original Budgeted Amount 
		/// </summary>
		[DataMember(Name="ContractTotal", EmitDefaultValue=false)]
		public DecimalValue? ContractTotal { get; set; }

		/// <summary>
		/// Contract Completed % (without Change Orders)
		/// DAC Field Name: ContractCompletedPct 
		/// DAC: PX.Objects.PM.PMProjectRevenueTotal 
		/// Display Name: Completed (%) 
		/// </summary>
		[DataMember(Name="CompletedPct", EmitDefaultValue=false)]
		public DecimalValue? CompletedPct { get; set; }

	}
}