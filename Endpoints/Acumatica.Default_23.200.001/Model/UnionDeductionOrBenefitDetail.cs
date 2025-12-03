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
	public class UnionDeductionOrBenefitDetail : Entity
	{

		/// <summary>
		/// The contribution amount to be used if the calculation method is set to either FixedAmount or AmountPerHour.
		/// <para>DAC Field Name: BenefitAmount</para>
		/// <para>DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage</para>
		/// <para>Display Name: Contribution Amount</para>
		/// </summary>
		[DataMember(Name="ContributionAmount", EmitDefaultValue=false)]
		public DecimalValue? ContributionAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__CntCalcType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage</para>
		/// </summary>
		[DataMember(Name="ContributionCalculationMethod", EmitDefaultValue=false)]
		public StringValue? ContributionCalculationMethod { get; set; }

		/// <summary>
		/// The contribution percentage to be used if the calculation method is set to either PercentOfGross or PercentOfNet.
		/// <para>DAC Field Name: BenefitRate</para>
		/// <para>DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage</para>
		/// <para>Display Name: Contribution Percent</para>
		/// </summary>
		[DataMember(Name="ContributionPercent", EmitDefaultValue=false)]
		public DecimalValue? ContributionPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__ContribType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage</para>
		/// </summary>
		[DataMember(Name="ContributionType", EmitDefaultValue=false)]
		public StringValue? ContributionType { get; set; }

		/// <summary>
		/// The deduction amount to be used if the calculation method is set to either FixedAmount or AmountPerHour.
		/// <para>DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage</para>
		/// <para>Display Name: Deduction Amount</para>
		/// </summary>
		[DataMember(Name="DeductionAmount", EmitDefaultValue=false)]
		public DecimalValue? DeductionAmount { get; set; }

		/// <summary>
		/// The unique identifier of the deduction or benefit code.The field is included in DeductionCode.
		/// <para>DAC Field Name: DeductionAndBenefitCodeID</para>
		/// <para>DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage</para>
		/// <para>Display Name: Deduction and Benefit Code</para>
		/// </summary>
		[DataMember(Name="DeductionAndBenefitCode", EmitDefaultValue=false)]
		public StringValue? DeductionAndBenefitCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__DedCalcType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage</para>
		/// </summary>
		[DataMember(Name="DeductionCalculationMethod", EmitDefaultValue=false)]
		public StringValue? DeductionCalculationMethod { get; set; }

		/// <summary>
		/// The deduction percentage to be used if the calculation method is set to either PercentOfGross or PercentOfNet.
		/// <para>DAC Field Name: DeductionRate</para>
		/// <para>DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage</para>
		/// <para>Display Name: Deduction Percent</para>
		/// </summary>
		[DataMember(Name="DeductionPercent", EmitDefaultValue=false)]
		public DecimalValue? DeductionPercent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PRDeductCode__Description</para>
		/// <para>DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// A labor item associated with the union pay rate.The field is included in LaborItem.
		/// <para>DAC Field Name: LaborItemID</para>
		/// <para>DAC: PX.Objects.PR.PRDeductionAndBenefitUnionPackage</para>
		/// <para>Display Name: Labor Item</para>
		/// </summary>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

	}
}