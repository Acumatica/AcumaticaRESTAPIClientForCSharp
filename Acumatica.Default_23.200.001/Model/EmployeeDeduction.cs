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
		/// DAC Field Name: DedAmount 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// A restriction on the use of earning types in the calculation of employee deductions based on the categories of those earning types.
		/// DAC Field Name: DedApplicableEarnings 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Applicable Earnings 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="ApplicableEarnings", EmitDefaultValue=false)]
		public StringValue? ApplicableEarnings { get; set; }

		/// <summary>
		/// The method to be used for determining the deduction amount.
		/// DAC Field Name: DedCalcType 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Calculation Method 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="CalculationMethod", EmitDefaultValue=false)]
		public StringValue? CalculationMethod { get; set; }

		/// <summary>
		/// The deduction amount cap.
		/// DAC Field Name: DedMaxAmount 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Limit Amount 
		/// </summary>
		[DataMember(Name="MaximumAmount", EmitDefaultValue=false)]
		public DecimalValue? MaximumAmount { get; set; }

		/// <summary>
		/// How often the maximum deduction amount (if any) specified in the following box is to be applied.
		/// DAC Field Name: DedMaxFreqType 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Limit Frequency 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="MaximumFrequency", EmitDefaultValue=false)]
		public StringValue? MaximumFrequency { get; set; }

		/// <summary>
		/// The deduction percentage to be used if the calculation method is set to either PercentOfGross or PercentOfNet.
		/// DAC Field Name: DedPercent 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		[DataMember(Name="Percent", EmitDefaultValue=false)]
		public DecimalValue? Percent { get; set; }

		/// <summary>
		/// The deduction type that is used for reporting and calculation purposes in Canada.
		/// DAC Field Name: DedReportTypeCAN 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Federal Reporting Type 
		/// </summary>
		[DataMember(Name="ReportingTypeCA", EmitDefaultValue=false)]
		public StringValue? ReportingTypeCA { get; set; }

		/// <summary>
		/// A code that determines which reporting type the deduction will use.
		/// DAC Field Name: DedReportType 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Reporting Type 
		/// </summary>
		[DataMember(Name="ReportingTypeUS", EmitDefaultValue=false)]
		public StringValue? ReportingTypeUS { get; set; }

	}
}