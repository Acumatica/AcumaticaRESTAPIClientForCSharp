using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class EmployerContribution : Entity
	{

		/// <summary>
		/// The contribution amount to be used if the calculation method is set to either FixedAmount or AmountPerHour.
		/// <para>DAC Field Name: CNtAmount</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// A restriction on the use of earning types in the calculation of employer contributions based on the categories of those earning types.
		/// <para>DAC Field Name: CntApplicableEarnings</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Applicable Earnings</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="ApplicableEarnings", EmitDefaultValue=false)]
		public StringValue? ApplicableEarnings { get; set; }

		/// <summary>
		/// The method to be used for determining the contribution amount.
		/// <para>DAC Field Name: CntCalcType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Calculation Method</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="CalculationMethod", EmitDefaultValue=false)]
		public StringValue? CalculationMethod { get; set; }

		/// <summary>
		/// The type used for certified reporting.
		/// <para>DAC Field Name: CertifiedReportType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Certified Reporting Type</para>
		/// </summary>
		[DataMember(Name="CertifiedReportingType", EmitDefaultValue=false)]
		public StringValue? CertifiedReportingType { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the deduction or benefit produces no financial transactions.
		/// <para>DAC Field Name: ContributesToGrossCalculation</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Contributes to Gross Calculation</para>
		/// </summary>
		[DataMember(Name="ContributestoGrossCalculation", EmitDefaultValue=false)]
		public BooleanValue? ContributestoGrossCalculation { get; set; }

		/// <summary>
		/// The contribution amount cap.
		/// <para>DAC Field Name: CntMaxAmount</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Limit Amount</para>
		/// </summary>
		[DataMember(Name="MaximumAmount", EmitDefaultValue=false)]
		public DecimalValue? MaximumAmount { get; set; }

		/// <summary>
		/// How often the maximum contribution amount (if any) specified in the following box is to be applied.
		/// <para>DAC Field Name: CntMaxFreqType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Limit Frequency</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="MaximumFrequency", EmitDefaultValue=false)]
		public StringValue? MaximumFrequency { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the deduction or benefit produces no financial transactions.
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: No Financial Transaction</para>
		/// </summary>
		[DataMember(Name="NoFinancialTransaction", EmitDefaultValue=false)]
		public BooleanValue? NoFinancialTransaction { get; set; }

		/// <summary>
		/// The contribution percentage to be used if the calculation method is set to either PercentOfGross or PercentOfNet.
		/// <para>DAC Field Name: CntPercent</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// </summary>
		[DataMember(Name="Percent", EmitDefaultValue=false)]
		public DecimalValue? Percent { get; set; }

		/// <summary>
		/// The contribution type that is used for reporting and calculation purposes in Canada.
		/// <para>DAC Field Name: CntReportTypeCAN</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Federal Reporting Type</para>
		/// </summary>
		[DataMember(Name="ReportingTypeCA", EmitDefaultValue=false)]
		public StringValue? ReportingTypeCA { get; set; }

		/// <summary>
		/// A code that determines which reporting type the contribution will use.
		/// <para>DAC Field Name: CntReportType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Reporting Type</para>
		/// </summary>
		[DataMember(Name="ReportingTypeUS", EmitDefaultValue=false)]
		public StringValue? ReportingTypeUS { get; set; }

	}
}