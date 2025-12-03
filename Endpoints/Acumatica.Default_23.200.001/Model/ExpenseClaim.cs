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
	/// Corresponds to the screen <c>EP301000</c> in the Acumatica ERP
	/// <para>Key Fields: RefNbr</para>
	/// </summary>
	[DataContract]
	public class ExpenseClaim : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The date when the claim was approved.
		/// <para>DAC Field Name: ApproveDate</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Approval Date</para>
		/// </summary>
		[DataMember(Name="ApprovalDate", EmitDefaultValue=false)]
		public DateTimeValue? ApprovalDate { get; set; }

		[DataMember(Name="ApprovalDetails", EmitDefaultValue=false)]
		public List<Approval>? ApprovalDetails { get; set; }

		/// <summary>
		/// Identifier of the base Currency.
		/// <para>DAC Field Name: BaseCuryID</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Base Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// The identifier of the employee who claims the expenses.When the claim is released, an Accounts Payable bill will be generated for this employee.
		/// <para>DAC Field Name: EmployeeID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Claimed By</para>
		/// </summary>
		[DataMember(Name="ClaimedBy", EmitDefaultValue=false)]
		public StringValue? ClaimedBy { get; set; }

		/// <summary>
		/// The total amount of the claim in the currency of the document.The amount is calculated as the sum of the amounts in the Claim Amount column of the Expense Claim Details table located on the Expense Claim (EP301000) form for all lines specified for the claim with taxes applied.
		/// <para>DAC Field Name: CuryDocBal</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Claim Total</para>
		/// </summary>
		[DataMember(Name="ClaimTotal", EmitDefaultValue=false)]
		public DecimalValue? ClaimTotal { get; set; }

		/// <summary>
		/// The code of the currency of the document.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The exchange rate used for calculations and determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// <para>DAC Field Name: SampleCuryRate</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Curr. Rate</para>
		/// </summary>
		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// The identifier of the Customer associated with the expense claim.
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Customer</para>
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The date when the claim was entered.
		/// <para>DAC Field Name: DocDate</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// The department associated with the expense claim.
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Department ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="DepartmentID", EmitDefaultValue=false)]
		public StringValue? DepartmentID { get; set; }

		/// <summary>
		/// A description of the claim.
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ExpenseClaimDetails>? Details { get; set; }

		[DataMember(Name="FinancialDetails", EmitDefaultValue=false)]
		public ExpenseClaimFinancialDetail? FinancialDetails { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The identifier of the customer location associated with the document.
		/// <para>DAC Field Name: CustomerLocationID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// The inverse of the SampleCuryRate. This value is also determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// <para>DAC Field Name: SampleRecipRate</para>
		/// <para>DAC: PX.Objects.CM.CurrencyInfo</para>
		/// <para>Display Name: Reciprocal Rate</para>
		/// </summary>
		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? ReciprocalRate { get; set; }

		/// <summary>
		/// The unique reference number of the expense claim document, which the system assigns based on the numbering sequence specified for claims on the Time and Expenses Preferences (EP101000) form (which corresponds to the EPSetupMaint graph).This field is the key field.
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		/// <summary>
		/// The status of the expense claim.
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<ExpenseClaimTaxDetail>? TaxDetails { get; set; }

		/// <summary>
		/// The total amount of taxes associated with the document in the currency of the document.(Presented in the currency of the document, see CuryID)
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Tax Total</para>
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		/// <summary>
		/// The document total (in the currency of the document) that is exempt from VAT.This total is calculated as the taxable amount for the tax with the Include in VAT Exempt Total check box selected on the Taxes (TX205000) form. This box is available only if the VAT Reporting feature is enabled on the Enable/Disable Features (CS100000) form (which corresponds to the FeaturesMaint graph).(Presented in the currency of the document, see CuryID)
		/// <para>DAC Field Name: CuryVatExemptTotal</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: VAT Exempt Total</para>
		/// </summary>
		[DataMember(Name="VATExemptTotal", EmitDefaultValue=false)]
		public DecimalValue? VATExemptTotal { get; set; }

		/// <summary>
		/// The document total (in the currency of the document) that is subject to VAT.This box is available only if the VAT Reporting feature is enabled on the Enable/Disable Features (CS100000) form (which corresponds to the FeaturesMaint graph). The VAT taxable amount is displayed in this box only if the Include in VAT Taxable Total check box is selected for the applicable tax on the Taxes (TX205000) form (which corresponds to the SalesTaxMaint graph). If the check box is cleared, this box will be empty.(Presented in the currency of the document, see CuryID)
		/// <para>DAC Field Name: CuryVatTaxableTotal</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: VAT Taxable Total</para>
		/// </summary>
		[DataMember(Name="VATTaxableTotal", EmitDefaultValue=false)]
		public DecimalValue? VATTaxableTotal { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string ApprovalDetails = "ApprovalDetails";
			public const string ApprovalDetails_Files = "ApprovalDetails/Files";
			public const string Details = "Details";
			public const string Details_Files = "Details/Files";
			public const string FinancialDetails = "FinancialDetails";
			public const string FinancialDetails_APDocuments = "FinancialDetails/APDocuments";
			public const string FinancialDetails_APDocuments_Files = "FinancialDetails/APDocuments/Files";
			public const string TaxDetails = "TaxDetails";
			public const string TaxDetails_Files = "TaxDetails/Files";

			//Intentionally excluded
			//public const string All = "Files,ApprovalDetails,ApprovalDetails/Files,Details,Details/Files,FinancialDetails,FinancialDetails/APDocuments,FinancialDetails/APDocuments/Files,TaxDetails,TaxDetails/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}