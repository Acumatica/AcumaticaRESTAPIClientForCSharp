using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>EP301020</c> in the Acumatica ERP
	/// <para>Key Fields: ReceiptID</para>
	/// </summary>
	public class ExpenseReceipt : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The company branch that will incur the expenses. If multiple expense receipts associated with different branches are added to one expense claim,the branch specified for the claim on the Financial Details tab of the Expense Claim (EP301000) form (which corresponds to the ExpenseClaimEntry graph)will reimburse the expenses and the branches specified in this box for the receipts will incur the expenses.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The amount to be reimbursed to the employee in the currency of the document.
		/// <para>DAC Field Name: CuryTranAmtWithTaxes</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Claim Amount</para>
		/// </summary>
		public DecimalValue? ClaimAmount { get; set; }

		/// <summary>
		/// The identifier of the employee who is claiming the expenses.
		/// <para>DAC Field Name: EmployeeID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Claimed by</para>
		/// </summary>
		public StringValue? ClaimedBy { get; set; }

		/// <summary>
		/// The date of the receipt. By default, the current business date is used when a new receipt is created.
		/// <para>DAC Field Name: ExpenseDate</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// </summary>
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// The non-stock item  of the expense, which determines the financial accounts,the default tax category, and the unit of measure used for the receipt.
		/// <para>DAC Field Name: InventoryID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Expense Item</para>
		/// </summary>
		public StringValue? ExpenseItemID { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public ExpenseReceiptDetails? ReceiptDetails { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the receipt.
		/// <para>DAC Field Name: ClaimDetailCD</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Receipt Number</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReceiptID { get; set; }

		/// <summary>
		/// The status of the expense receipt.
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public List<ExpenseReceiptTaxDetails>? TaxDetails { get; set; }

		/// <summary>
		/// The total amount of taxes associated with the document in the currency of the document.
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Tax Total</para>
		/// </summary>
		public DecimalValue? TaxTotal { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string ReceiptDetails = "ReceiptDetails";
			public const string TaxDetails = "TaxDetails";
			public const string TaxDetails_Files = "TaxDetails/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,ReceiptDetails,TaxDetails,TaxDetails/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}