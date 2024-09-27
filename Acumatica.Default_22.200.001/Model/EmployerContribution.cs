using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmployerContribution : Entity
	{

		/// <summary>
		/// The contribution amount to be used if the calculation method is set to either FixedAmount or AmountPerHour.
		/// DAC Field Name: CNtAmount 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// A restriction on the use of earning types in the calculation of employer contributions based on the categories of those earning types.
		/// DAC Field Name: CntApplicableEarnings 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Applicable Earnings 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="ApplicableEarnings", EmitDefaultValue=false)]
		public StringValue? ApplicableEarnings { get; set; }

		/// <summary>
		/// The method to be used for determining the contribution amount.
		/// DAC Field Name: CntCalcType 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Calculation Method 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="CalculationMethod", EmitDefaultValue=false)]
		public StringValue? CalculationMethod { get; set; }

		/// <summary>
		/// The type used for certified reporting.
		/// DAC Field Name: CertifiedReportType 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Certified Reporting Type 
		/// </summary>
		[DataMember(Name="CertifiedReportingType", EmitDefaultValue=false)]
		public StringValue? CertifiedReportingType { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the deduction or benefit produces no financial transactions.
		/// DAC Field Name: ContributesToGrossCalculation 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Contributes to Gross Calculation 
		/// </summary>
		[DataMember(Name="ContributestoGrossCalculation", EmitDefaultValue=false)]
		public BooleanValue? ContributestoGrossCalculation { get; set; }

		/// <summary>
		/// The contribution amount cap.
		/// DAC Field Name: CntMaxAmount 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Limit Amount 
		/// </summary>
		[DataMember(Name="MaximumAmount", EmitDefaultValue=false)]
		public DecimalValue? MaximumAmount { get; set; }

		/// <summary>
		/// How often the maximum contribution amount (if any) specified in the following box is to be applied.
		/// DAC Field Name: CntMaxFreqType 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Limit Frequency 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="MaximumFrequency", EmitDefaultValue=false)]
		public StringValue? MaximumFrequency { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the deduction or benefit produces no financial transactions.
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: No Financial Transaction 
		/// </summary>
		[DataMember(Name="NoFinancialTransaction", EmitDefaultValue=false)]
		public BooleanValue? NoFinancialTransaction { get; set; }

		/// <summary>
		/// The contribution percentage to be used if the calculation method is set to either PercentOfGross or PercentOfNet.
		/// DAC Field Name: CntPercent 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		[DataMember(Name="Percent", EmitDefaultValue=false)]
		public DecimalValue? Percent { get; set; }

		/// <summary>
		/// The contribution type that is used for reporting and calculation purposes in Canada.
		/// DAC Field Name: CntReportTypeCAN 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Federal Reporting Type 
		/// </summary>
		[DataMember(Name="ReportingTypeCA", EmitDefaultValue=false)]
		public StringValue? ReportingTypeCA { get; set; }

		/// <summary>
		/// A code that determines which reporting type the contribution will use.
		/// DAC Field Name: CntReportType 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Reporting Type 
		/// </summary>
		[DataMember(Name="ReportingTypeUS", EmitDefaultValue=false)]
		public StringValue? ReportingTypeUS { get; set; }

	}
}