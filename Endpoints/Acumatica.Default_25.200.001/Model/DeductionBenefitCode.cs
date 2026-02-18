using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PR101060</c> in the Acumatica ERP
	/// <para>Key Fields: DeductionBenefitCodeID</para>
	/// </summary>
	public class DeductionBenefitCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: AcaApplicable</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: ACA Applicable</para>
		/// </summary>
		public BooleanValue? ACAApplicable { get; set; }

		public ACAInformation? ACAInformation { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code is available for use.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code affects the tax calculation.
		/// <para>DAC Field Name: AffectsTaxes</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Affects Tax Calculation</para>
		/// </summary>
		public BooleanValue? AffectsTaxCalculation { get; set; }

		public ApplicableWage? ApplicableWage { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AssociatedSource</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Associated With</para>
		/// <para>SQL Type: nchar(3)</para>
		/// </summary>
		public StringValue? AssociatedWith { get; set; }

		/// <summary>
		/// The type of a code that defines how the code affects employee earnings.
		/// <para>DAC Field Name: ContribType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Contribution Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? ContributionType { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the code.
		/// <para>DAC Field Name: CodeCD</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? DeductionBenefitCodeID { get; set; }

		/// <summary>
		/// The description of the code to appear in such places as box selectors and pay stubs.
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public EmployeeDeduction? EmployeeDeduction { get; set; }

		public EmployerContribution? EmployerContribution { get; set; }

		public DeductionOrBenefitCodeGLAccounts? GLAccounts { get; set; }

		/// <summary>
		/// The way the description of the vendor invoice is generated.
		/// <para>DAC Field Name: DedInvDescrType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Invoice Description Source</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? InvoiceDescrSource { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code is to be used for a garnishment.
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Garnishment</para>
		/// </summary>
		public BooleanValue? IsGarnishment { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code may contribute to gross calculation.
		/// <para>DAC Field Name: IsPayableBenefit</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Payable Benefit</para>
		/// </summary>
		public BooleanValue? PayableBenefit { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// </summary>
		public BooleanValue? ShowApplicableWageTab { get; set; }

		public TaxSettingsCA? TaxSettingsCA { get; set; }

		public TaxSettingsUS? TaxSettingsUS { get; set; }

		/// <summary>
		/// The unique identifier of the vendor that will be owed the liability resulting from the deduction or benefit.The field is included in Vendor.
		/// <para>DAC Field Name: BAccountID</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// </summary>
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// The description that you enter for the vendor invoice.
		/// <para>DAC Field Name: VndInvDescr</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Vendor Invoice Description</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? VendorInvoiceDescription { get; set; }

		public DeductionBenefitWCCCode? WCCCode { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string ACAInformation = "ACAInformation";
			public const string ACAInformation_ACAInfoDetails = "ACAInformation/ACAInfoDetails";
			public const string ACAInformation_ACAInfoDetails_Files = "ACAInformation/ACAInfoDetails/Files";
			public const string ApplicableWage = "ApplicableWage";
			public const string ApplicableWage_BenefitIncreasingApplWage = "ApplicableWage/BenefitIncreasingApplWage";
			public const string ApplicableWage_BenefitIncreasingApplWage_BenefitIncreasingApplWageDetails = "ApplicableWage/BenefitIncreasingApplWage/BenefitIncreasingApplWageDetails";
			public const string ApplicableWage_BenefitIncreasingApplWage_BenefitIncreasingApplWageDetails_Files = "ApplicableWage/BenefitIncreasingApplWage/BenefitIncreasingApplWageDetails/Files";
			public const string ApplicableWage_DeductionsDecreasingApplWage = "ApplicableWage/DeductionsDecreasingApplWage";
			public const string ApplicableWage_DeductionsDecreasingApplWage_DeductionIncreasingApplWageDetails = "ApplicableWage/DeductionsDecreasingApplWage/DeductionIncreasingApplWageDetails";
			public const string ApplicableWage_DeductionsDecreasingApplWage_DeductionIncreasingApplWageDetails_Files = "ApplicableWage/DeductionsDecreasingApplWage/DeductionIncreasingApplWageDetails/Files";
			public const string ApplicableWage_EarningIncreasingApplWage = "ApplicableWage/EarningIncreasingApplWage";
			public const string ApplicableWage_EarningIncreasingApplWage_EarningIncreasingApplWageDetails = "ApplicableWage/EarningIncreasingApplWage/EarningIncreasingApplWageDetails";
			public const string ApplicableWage_EarningIncreasingApplWage_EarningIncreasingApplWageDetails_Files = "ApplicableWage/EarningIncreasingApplWage/EarningIncreasingApplWageDetails/Files";
			public const string ApplicableWage_EmployeeTaxesDecreasingApplWage = "ApplicableWage/EmployeeTaxesDecreasingApplWage";
			public const string ApplicableWage_EmployeeTaxesDecreasingApplWage_EmployeeTaxesDecreasingApplWageDetails = "ApplicableWage/EmployeeTaxesDecreasingApplWage/EmployeeTaxesDecreasingApplWageDetails";
			public const string ApplicableWage_EmployeeTaxesDecreasingApplWage_EmployeeTaxesDecreasingApplWageDetails_Files = "ApplicableWage/EmployeeTaxesDecreasingApplWage/EmployeeTaxesDecreasingApplWageDetails/Files";
			public const string ApplicableWage_EmployerTaxesIncreasingApplWage = "ApplicableWage/EmployerTaxesIncreasingApplWage";
			public const string ApplicableWage_EmployerTaxesIncreasingApplWage_EmployerTaxesIncreasingApplWageDetails = "ApplicableWage/EmployerTaxesIncreasingApplWage/EmployerTaxesIncreasingApplWageDetails";
			public const string ApplicableWage_EmployerTaxesIncreasingApplWage_EmployerTaxesIncreasingApplWageDetails_Files = "ApplicableWage/EmployerTaxesIncreasingApplWage/EmployerTaxesIncreasingApplWageDetails/Files";
			public const string EmployeeDeduction = "EmployeeDeduction";
			public const string EmployerContribution = "EmployerContribution";
			public const string GLAccounts = "GLAccounts";
			public const string TaxSettingsCA = "TaxSettingsCA";
			public const string TaxSettingsCA_TaxDetailsCA = "TaxSettingsCA/TaxDetailsCA";
			public const string TaxSettingsCA_TaxDetailsCA_Files = "TaxSettingsCA/TaxDetailsCA/Files";
			public const string TaxSettingsUS = "TaxSettingsUS";
			public const string TaxSettingsUS_TaxDetailsUS = "TaxSettingsUS/TaxDetailsUS";
			public const string TaxSettingsUS_TaxDetailsUS_Files = "TaxSettingsUS/TaxDetailsUS/Files";
			public const string WCCCode = "WCCCode";
			public const string WCCCode_WCCCodeRates = "WCCCode/WCCCodeRates";
			public const string WCCCode_WCCCodeRates_Files = "WCCCode/WCCCodeRates/Files";
			public const string WCCCode_WCCCodeRates_WCCCodeMaxInsurableWages = "WCCCode/WCCCodeRates/WCCCodeMaxInsurableWages";
			public const string WCCCode_WCCCodeRates_WCCCodeMaxInsurableWages_Files = "WCCCode/WCCCodeRates/WCCCodeMaxInsurableWages/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,ACAInformation,ACAInformation/ACAInfoDetails,ACAInformation/ACAInfoDetails/Files,ApplicableWage,ApplicableWage/BenefitIncreasingApplWage,ApplicableWage/BenefitIncreasingApplWage/BenefitIncreasingApplWageDetails,ApplicableWage/BenefitIncreasingApplWage/BenefitIncreasingApplWageDetails/Files,ApplicableWage/DeductionsDecreasingApplWage,ApplicableWage/DeductionsDecreasingApplWage/DeductionIncreasingApplWageDetails,ApplicableWage/DeductionsDecreasingApplWage/DeductionIncreasingApplWageDetails/Files,ApplicableWage/EarningIncreasingApplWage,ApplicableWage/EarningIncreasingApplWage/EarningIncreasingApplWageDetails,ApplicableWage/EarningIncreasingApplWage/EarningIncreasingApplWageDetails/Files,ApplicableWage/EmployeeTaxesDecreasingApplWage,ApplicableWage/EmployeeTaxesDecreasingApplWage/EmployeeTaxesDecreasingApplWageDetails,ApplicableWage/EmployeeTaxesDecreasingApplWage/EmployeeTaxesDecreasingApplWageDetails/Files,ApplicableWage/EmployerTaxesIncreasingApplWage,ApplicableWage/EmployerTaxesIncreasingApplWage/EmployerTaxesIncreasingApplWageDetails,ApplicableWage/EmployerTaxesIncreasingApplWage/EmployerTaxesIncreasingApplWageDetails/Files,EmployeeDeduction,EmployerContribution,GLAccounts,TaxSettingsCA,TaxSettingsCA/TaxDetailsCA,TaxSettingsCA/TaxDetailsCA/Files,TaxSettingsUS,TaxSettingsUS/TaxDetailsUS,TaxSettingsUS/TaxDetailsUS/Files,WCCCode,WCCCode/WCCCodeRates,WCCCode/WCCCodeRates/Files,WCCCode/WCCCodeRates/WCCCodeMaxInsurableWages,WCCCode/WCCCodeRates/WCCCodeMaxInsurableWages/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}