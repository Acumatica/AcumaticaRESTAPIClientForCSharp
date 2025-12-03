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
	public class EmployeeDeduction : Entity
	{

		/// <summary>
		/// The deduction amount to be used if the calculation method is set to either FixedAmount or AmountPerHour.
		/// <para>DAC Field Name: DedAmount</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// A restriction on the use of earning types in the calculation of employee deductions based on the categories of those earning types.
		/// <para>DAC Field Name: DedApplicableEarnings</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Applicable Earnings</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="ApplicableEarnings", EmitDefaultValue=false)]
		public StringValue? ApplicableEarnings { get; set; }

		/// <summary>
		/// The method to be used for determining the deduction amount.
		/// <para>DAC Field Name: DedCalcType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Calculation Method</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="CalculationMethod", EmitDefaultValue=false)]
		public StringValue? CalculationMethod { get; set; }

		/// <summary>
		/// The deduction amount cap.
		/// <para>DAC Field Name: DedMaxAmount</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Limit Amount</para>
		/// </summary>
		[DataMember(Name="MaximumAmount", EmitDefaultValue=false)]
		public DecimalValue? MaximumAmount { get; set; }

		/// <summary>
		/// How often the maximum deduction amount (if any) specified in the following box is to be applied.
		/// <para>DAC Field Name: DedMaxFreqType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Limit Frequency</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="MaximumFrequency", EmitDefaultValue=false)]
		public StringValue? MaximumFrequency { get; set; }

		/// <summary>
		/// The deduction percentage to be used if the calculation method is set to either PercentOfGross or PercentOfNet.
		/// <para>DAC Field Name: DedPercent</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// </summary>
		[DataMember(Name="Percent", EmitDefaultValue=false)]
		public DecimalValue? Percent { get; set; }

		/// <summary>
		/// The deduction type that is used for reporting and calculation purposes in Canada.
		/// <para>DAC Field Name: DedReportTypeCAN</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Federal Reporting Type</para>
		/// </summary>
		[DataMember(Name="ReportingTypeCA", EmitDefaultValue=false)]
		public StringValue? ReportingTypeCA { get; set; }

		/// <summary>
		/// A code that determines which reporting type the deduction will use.
		/// <para>DAC Field Name: DedReportType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Reporting Type</para>
		/// </summary>
		[DataMember(Name="ReportingTypeUS", EmitDefaultValue=false)]
		public StringValue? ReportingTypeUS { get; set; }

	}
}