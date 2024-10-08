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
	public class UnionDeductionOrBenefitDetail : Entity
	{

		/// <summary>
		/// The contribution amount to be used if the calculation method is set to either FixedAmount or AmountPerHour.
		/// DAC Field Name: BenefitAmount 
		/// DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage 
		/// Display Name: Contribution Amount 
		/// </summary>
		[DataMember(Name="ContributionAmount", EmitDefaultValue=false)]
		public DecimalValue? ContributionAmount { get; set; }

		/// <summary>
		/// DAC Field Name: PRDeductCode__CntCalcType 
		/// DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage 
		/// </summary>
		[DataMember(Name="ContributionCalculationMethod", EmitDefaultValue=false)]
		public StringValue? ContributionCalculationMethod { get; set; }

		/// <summary>
		/// The contribution percentage to be used if the calculation method is set to either PercentOfGross or PercentOfNet.
		/// DAC Field Name: BenefitRate 
		/// DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage 
		/// Display Name: Contribution Percent 
		/// </summary>
		[DataMember(Name="ContributionPercent", EmitDefaultValue=false)]
		public DecimalValue? ContributionPercent { get; set; }

		/// <summary>
		/// DAC Field Name: PRDeductCode__ContribType 
		/// DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage 
		/// </summary>
		[DataMember(Name="ContributionType", EmitDefaultValue=false)]
		public StringValue? ContributionType { get; set; }

		/// <summary>
		/// The deduction amount to be used if the calculation method is set to either FixedAmount or AmountPerHour.
		/// DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage 
		/// Display Name: Deduction Amount 
		/// </summary>
		[DataMember(Name="DeductionAmount", EmitDefaultValue=false)]
		public DecimalValue? DeductionAmount { get; set; }

		/// <summary>
		/// The unique identifier of the deduction or benefit code.The field is included in DeductionCode.
		/// DAC Field Name: DeductionAndBenefitCodeID 
		/// DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage 
		/// Display Name: Deduction and Benefit Code 
		/// </summary>
		[DataMember(Name="DeductionAndBenefitCode", EmitDefaultValue=false)]
		public StringValue? DeductionAndBenefitCode { get; set; }

		/// <summary>
		/// DAC Field Name: PRDeductCode__DedCalcType 
		/// DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage 
		/// </summary>
		[DataMember(Name="DeductionCalculationMethod", EmitDefaultValue=false)]
		public StringValue? DeductionCalculationMethod { get; set; }

		/// <summary>
		/// The deduction percentage to be used if the calculation method is set to either PercentOfGross or PercentOfNet.
		/// DAC Field Name: DeductionRate 
		/// DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage 
		/// Display Name: Deduction Percent 
		/// </summary>
		[DataMember(Name="DeductionPercent", EmitDefaultValue=false)]
		public DecimalValue? DeductionPercent { get; set; }

		/// <summary>
		/// DAC Field Name: PRDeductCode__Description 
		/// DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.PMLaborCostRate 
		/// Display Name: Effective Date 
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// A labor item associated with the union pay rate.The field is included in LaborItem.
		/// DAC Field Name: LaborItemID 
		/// DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage 
		/// Display Name: Labor Item 
		/// </summary>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

	}
}