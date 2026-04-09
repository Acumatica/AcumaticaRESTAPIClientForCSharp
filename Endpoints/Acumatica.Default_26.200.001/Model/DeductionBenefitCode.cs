using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class DeductionBenefitCode : Entity, ITopLevelEntity
	{

		[DataMember(Name="ACAApplicable", EmitDefaultValue=false)]
		public BooleanValue? ACAApplicable { get; set; }

		[DataMember(Name="ACAInformation", EmitDefaultValue=false)]
		public ACAInformation? ACAInformation { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AffectsTaxCalculation", EmitDefaultValue=false)]
		public BooleanValue? AffectsTaxCalculation { get; set; }

		[DataMember(Name="ApplicableWage", EmitDefaultValue=false)]
		public ApplicableWage? ApplicableWage { get; set; }

		[DataMember(Name="AssociatedWith", EmitDefaultValue=false)]
		public StringValue? AssociatedWith { get; set; }

		[DataMember(Name="ContributionType", EmitDefaultValue=false)]
		public StringValue? ContributionType { get; set; }

		[DataMember(Name="DeductionBenefitCodeID", EmitDefaultValue=false)]
		public StringValue? DeductionBenefitCodeID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EmployeeDeduction", EmitDefaultValue=false)]
		public EmployeeDeduction? EmployeeDeduction { get; set; }

		[DataMember(Name="EmployerContribution", EmitDefaultValue=false)]
		public EmployerContribution? EmployerContribution { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public DeductionOrBenefitCodeGLAccounts? GLAccounts { get; set; }

		[DataMember(Name="InvoiceDescrSource", EmitDefaultValue=false)]
		public StringValue? InvoiceDescrSource { get; set; }

		[DataMember(Name="IsGarnishment", EmitDefaultValue=false)]
		public BooleanValue? IsGarnishment { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="PayableBenefit", EmitDefaultValue=false)]
		public BooleanValue? PayableBenefit { get; set; }

		[DataMember(Name="ShowApplicableWageTab", EmitDefaultValue=false)]
		public BooleanValue? ShowApplicableWageTab { get; set; }

		[DataMember(Name="TaxSettingsCA", EmitDefaultValue=false)]
		public TaxSettingsCA? TaxSettingsCA { get; set; }

		[DataMember(Name="TaxSettingsUS", EmitDefaultValue=false)]
		public TaxSettingsUS? TaxSettingsUS { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		[DataMember(Name="VendorInvoiceDescription", EmitDefaultValue=false)]
		public StringValue? VendorInvoiceDescription { get; set; }

		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
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
			return "entity/Default/26.200.001";
		}
	}
}