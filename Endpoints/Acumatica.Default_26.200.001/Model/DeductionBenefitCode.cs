using System;
using System.Collections.Generic;

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
	public class DeductionBenefitCode : Entity, ITopLevelEntity
	{

		#region Fields
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

		/// <summary>
		/// The type of a code that defines how the code affects employee earnings.
		/// <para>DAC Field Name: ContribType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Contribution Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? ContributionType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AssociatedSource</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Associated With</para>
		/// <para>SQL Type: nchar(3)</para>
		/// </summary>
		public StringValue? AssociatedWith { get; set; }

		/// <summary>
		/// The unique identifier of the vendor that will be owed the liability resulting from the deduction or benefit.The field is included in Vendor.
		/// <para>DAC Field Name: BAccountID</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// </summary>
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// The way the description of the vendor invoice is generated.
		/// <para>DAC Field Name: DedInvDescrType</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Invoice Description Source</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? InvoiceDescrSource { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code is available for use.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code is to be used for a garnishment.
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Garnishment</para>
		/// </summary>
		public BooleanValue? IsGarnishment { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code affects the tax calculation.
		/// <para>DAC Field Name: AffectsTaxes</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Affects Tax Calculation</para>
		/// </summary>
		public BooleanValue? AffectsTaxCalculation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AcaApplicable</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: ACA Applicable</para>
		/// </summary>
		public BooleanValue? ACAApplicable { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the code may contribute to gross calculation.
		/// <para>DAC Field Name: IsPayableBenefit</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Payable Benefit</para>
		/// </summary>
		public BooleanValue? PayableBenefit { get; set; }

		/// <summary>
		/// The description that you enter for the vendor invoice.
		/// <para>DAC Field Name: VndInvDescr</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Vendor Invoice Description</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? VendorInvoiceDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// </summary>
		public BooleanValue? ShowApplicableWageTab { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

		#region LinkedEntities
		public ACAInformation? ACAInformation { get; set; }

		public ApplicableWage? ApplicableWage { get; set; }

		public EmployeeDeduction? EmployeeDeduction { get; set; }

		public EmployerContribution? EmployerContribution { get; set; }

		public DeductionOrBenefitCodeGLAccounts? GLAccounts { get; set; }

		public TaxSettingsCA? TaxSettingsCA { get; set; }

		public TaxSettingsUS? TaxSettingsUS { get; set; }

		public DeductionBenefitWCCCode? WCCCode { get; set; }

		public GarnishmentNetIncome? GarnishmentNetIncome { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(DeductionBenefitCode)} - \"{DeductionBenefitCodeID}\"";
		}

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