using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PR101060 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class DeductionBenefitCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: AcaApplicable 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: ACA Applicable 
		/// </summary>
		[DataMember(Name="ACAApplicable", EmitDefaultValue=false)]
		public BooleanValue? ACAApplicable { get; set; }

		[DataMember(Name="ACAInformation", EmitDefaultValue=false)]
		public ACAInformation? ACAInformation { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code is available for use.
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code affects the tax calculation.
		/// DAC Field Name: AffectsTaxes 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Affects Tax Calculation 
		/// </summary>
		[DataMember(Name="AffectsTaxCalculation", EmitDefaultValue=false)]
		public BooleanValue? AffectsTaxCalculation { get; set; }

		[DataMember(Name="ApplicableWage", EmitDefaultValue=false)]
		public ApplicableWage? ApplicableWage { get; set; }

		/// <summary>
		/// DAC Field Name: AssociatedSource 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Associated With 
		/// SQL Type: nchar(3) 
		/// </summary>
		[DataMember(Name="AssociatedWith", EmitDefaultValue=false)]
		public StringValue? AssociatedWith { get; set; }

		/// <summary>
		/// The type of a code that defines how the code affects employee earnings.
		/// DAC Field Name: ContribType 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Contribution Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="ContributionType", EmitDefaultValue=false)]
		public StringValue? ContributionType { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the code.
		/// DAC Field Name: CodeCD 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Code 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="DeductionBenefitCodeID", EmitDefaultValue=false)]
		public StringValue? DeductionBenefitCodeID { get; set; }

		/// <summary>
		/// The description of the code to appear in such places as box selectors and pay stubs.
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EmployeeDeduction", EmitDefaultValue=false)]
		public EmployeeDeduction? EmployeeDeduction { get; set; }

		[DataMember(Name="EmployerContribution", EmitDefaultValue=false)]
		public EmployerContribution? EmployerContribution { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public DeductionOrBenefitCodeGLAccounts? GLAccounts { get; set; }

		/// <summary>
		/// The way the description of the vendor invoice is generated.
		/// DAC Field Name: DedInvDescrType 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Invoice Description Source 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="InvoiceDescrSource", EmitDefaultValue=false)]
		public StringValue? InvoiceDescrSource { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code is to be used for a garnishment.
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Garnishment 
		/// </summary>
		[DataMember(Name="IsGarnishment", EmitDefaultValue=false)]
		public BooleanValue? IsGarnishment { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code may contribute to gross calculation.
		/// DAC Field Name: IsPayableBenefit 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Payable Benefit 
		/// </summary>
		[DataMember(Name="PayableBenefit", EmitDefaultValue=false)]
		public BooleanValue? PayableBenefit { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		[DataMember(Name="ShowApplicableWageTab", EmitDefaultValue=false)]
		public BooleanValue? ShowApplicableWageTab { get; set; }

		[DataMember(Name="TaxSettingsCA", EmitDefaultValue=false)]
		public TaxSettingsCA? TaxSettingsCA { get; set; }

		[DataMember(Name="TaxSettingsUS", EmitDefaultValue=false)]
		public TaxSettingsUS? TaxSettingsUS { get; set; }

		/// <summary>
		/// The unique identifier of the vendor that will be owed the liability resulting from the deduction or benefit.The field is included in Vendor.
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// The description that you enter for the vendor invoice.
		/// DAC Field Name: VndInvDescr 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Vendor Invoice Description 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="VendorInvoiceDescription", EmitDefaultValue=false)]
		public StringValue? VendorInvoiceDescription { get; set; }

		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public DeductionBenefitWCCCode? WCCCode { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}