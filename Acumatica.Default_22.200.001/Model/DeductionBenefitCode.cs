using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class DeductionBenefitCode : Entity
	{

		[DataMember(Name="ACAApplicable", EmitDefaultValue=false)]
		public BooleanValue ACAApplicable { get; set; }

		[DataMember(Name="ACAInformation", EmitDefaultValue=false)]
		public ACAInformation ACAInformation { get; set; }

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="AffectsTaxCalculation", EmitDefaultValue=false)]
		public BooleanValue AffectsTaxCalculation { get; set; }

		[DataMember(Name="ApplicableWage", EmitDefaultValue=false)]
		public ApplicableWage ApplicableWage { get; set; }

		[DataMember(Name="AssociatedWith", EmitDefaultValue=false)]
		public StringValue AssociatedWith { get; set; }

		[DataMember(Name="ContributionType", EmitDefaultValue=false)]
		public StringValue ContributionType { get; set; }

		[DataMember(Name="DeductionBenefitCodeID", EmitDefaultValue=false)]
		public StringValue DeductionBenefitCodeID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EmployeeDeduction", EmitDefaultValue=false)]
		public EmployeeDeduction EmployeeDeduction { get; set; }

		[DataMember(Name="EmployerContribution", EmitDefaultValue=false)]
		public EmployerContribution EmployerContribution { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public DeductionOrBenefitCodeGLAccounts GLAccounts { get; set; }

		[DataMember(Name="InvoiceDescrSource", EmitDefaultValue=false)]
		public StringValue InvoiceDescrSource { get; set; }

		[DataMember(Name="IsGarnishment", EmitDefaultValue=false)]
		public BooleanValue IsGarnishment { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="PayableBenefit", EmitDefaultValue=false)]
		public BooleanValue PayableBenefit { get; set; }

		[DataMember(Name="ShowApplicableWageTab", EmitDefaultValue=false)]
		public BooleanValue ShowApplicableWageTab { get; set; }

		[DataMember(Name="TaxSettingsCA", EmitDefaultValue=false)]
		public TaxSettingsCA TaxSettingsCA { get; set; }

		[DataMember(Name="TaxSettingsUS", EmitDefaultValue=false)]
		public TaxSettingsUS TaxSettingsUS { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue Vendor { get; set; }

		[DataMember(Name="VendorInvoiceDescription", EmitDefaultValue=false)]
		public StringValue VendorInvoiceDescription { get; set; }

		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public DeductionBenefitWCCCode WCCCode { get; set; }

	}
}