using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PR101060</c> in the Acumatica ERP
	/// <para>Key Fields: DeductionBenefitCodeID</para>
	/// </summary>
	[DataContract]
	public class DeductionBenefitCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: AcaApplicable</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: ACA Applicable</para>
		/// </summary>
		[DataMember(Name="ACAApplicable", EmitDefaultValue=false)]
		public BooleanValue? ACAApplicable { get; set; }

		[DataMember(Name="ACAInformation", EmitDefaultValue=false)]
		public ACAInformation? ACAInformation { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code is available for use.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code affects the tax calculation.
		/// <para>DAC Field Name: AffectsTaxes</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Affects Tax Calculation</para>
		/// </summary>
		[DataMember(Name="AffectsTaxCalculation", EmitDefaultValue=false)]
		public BooleanValue? AffectsTaxCalculation { get; set; }

		[DataMember(Name="ApplicableWage", EmitDefaultValue=false)]
		public ApplicableWage? ApplicableWage { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AssociatedSource</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Associated With</para>
		/// <para>SQL Type: nchar(3)</para>
		/// </summary>
		[DataMember(Name="AssociatedWith", EmitDefaultValue=false)]
		public StringValue? AssociatedWith { get; set; }

		/// <summary>
		/// The type of a code that defines how the code affects employee earnings.
		/// <para>DAC Field Name: ContribType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Contribution Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="ContributionType", EmitDefaultValue=false)]
		public StringValue? ContributionType { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the code.
		/// <para>DAC Field Name: CodeCD</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="DeductionBenefitCodeID", EmitDefaultValue=false)]
		public StringValue? DeductionBenefitCodeID { get; set; }

		/// <summary>
		/// The description of the code to appear in such places as box selectors and pay stubs.
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>SQL Type: nvarchar(60)</para>
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
		/// <para>DAC Field Name: DedInvDescrType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Invoice Description Source</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="InvoiceDescrSource", EmitDefaultValue=false)]
		public StringValue? InvoiceDescrSource { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code is to be used for a garnishment.
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Garnishment</para>
		/// </summary>
		[DataMember(Name="IsGarnishment", EmitDefaultValue=false)]
		public BooleanValue? IsGarnishment { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code may contribute to gross calculation.
		/// <para>DAC Field Name: IsPayableBenefit</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Payable Benefit</para>
		/// </summary>
		[DataMember(Name="PayableBenefit", EmitDefaultValue=false)]
		public BooleanValue? PayableBenefit { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// </summary>
		[DataMember(Name="ShowApplicableWageTab", EmitDefaultValue=false)]
		public BooleanValue? ShowApplicableWageTab { get; set; }

		[DataMember(Name="TaxSettingsCA", EmitDefaultValue=false)]
		public TaxSettingsCA? TaxSettingsCA { get; set; }

		[DataMember(Name="TaxSettingsUS", EmitDefaultValue=false)]
		public TaxSettingsUS? TaxSettingsUS { get; set; }

		/// <summary>
		/// The unique identifier of the vendor that will be owed the liability resulting from the deduction or benefit.The field is included in Vendor.
		/// <para>DAC Field Name: BAccountID</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// The description that you enter for the vendor invoice.
		/// <para>DAC Field Name: VndInvDescr</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Vendor Invoice Description</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="VendorInvoiceDescription", EmitDefaultValue=false)]
		public StringValue? VendorInvoiceDescription { get; set; }

		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public DeductionBenefitWCCCode? WCCCode { get; set; }

		[DataMember(Name="GarnishmentNetIncome", EmitDefaultValue=false)]
		public GarnishmentNetIncome? GarnishmentNetIncome { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string ACAInformation = "ACAInformation";
			public const string ApplicableWage = "ApplicableWage";
			public const string EmployeeDeduction = "EmployeeDeduction";
			public const string EmployerContribution = "EmployerContribution";
			public const string GLAccounts = "GLAccounts";
			public const string TaxSettingsCA = "TaxSettingsCA";
			public const string TaxSettingsUS = "TaxSettingsUS";
			public const string WCCCode = "WCCCode";
			public const string GarnishmentNetIncome = "GarnishmentNetIncome";

			//Intentionally excluded
			//public const string All = "Files,Translations,ACAInformation,ApplicableWage,EmployeeDeduction,EmployerContribution,GLAccounts,TaxSettingsCA,TaxSettingsUS,WCCCode,GarnishmentNetIncome";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}