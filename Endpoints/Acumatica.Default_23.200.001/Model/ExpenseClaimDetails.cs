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
	public class ExpenseClaimDetails : Entity
	{

		/// <summary>
		/// The total amount of the receipt in the currency of the document.
		/// <para>DAC Field Name: CuryExtCost</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The amount claimed by the employee, which is expressed in the currency of the expense claim.
		/// <para>DAC Field Name: ClaimCuryTranAmtWithTaxes</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Amount in Claim Curr.</para>
		/// </summary>
		[DataMember(Name="AmountInClaimCurrency", EmitDefaultValue=false)]
		public DecimalValue? AmountInClaimCurrency { get; set; }

		/// <summary>
		/// The reference number of the AR document created as a result of releasing a claim.
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: AP Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="APRefNbr", EmitDefaultValue=false)]
		public StringValue? APRefNbr { get; set; }

		/// <summary>
		/// The reference number of the AR document created as a result of billing a claim.
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: AR Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ARRefNbr", EmitDefaultValue=false)]
		public StringValue? ARRefNbr { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the customer should be billed for the claim amount.You can use the Bill Expense Claims (EP502000) form to bill the customer if no project is specified.
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// </summary>
		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// The branch of the claim.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The amount to be reimbursed to the employee in the currency of the document.
		/// <para>DAC Field Name: CuryTranAmtWithTaxes</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Claim Amount</para>
		/// </summary>
		[DataMember(Name="ClaimAmount", EmitDefaultValue=false)]
		public DecimalValue? ClaimAmount { get; set; }

		/// <summary>
		/// The identifier of the cost code associated with the record.
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

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
		/// The identifier of the Customer associated with the expense claim.
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Customer</para>
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The date of the receipt. By default, the current business date is used when a new receipt is created.
		/// <para>DAC Field Name: ExpenseDate</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// The description of the expense.
		/// <para>DAC Field Name: TranDesc</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The part of the total amount that will not be paid back to the employee in the currency of the document.
		/// <para>DAC Field Name: CuryEmployeePart</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Employee Part</para>
		/// </summary>
		[DataMember(Name="EmployeePart", EmitDefaultValue=false)]
		public DecimalValue? EmployeePart { get; set; }

		/// <summary>
		/// The expense account to which the system records the part of the expense to be paid back to the employee.
		/// <para>DAC Field Name: ExpenseAccountID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Expense Account</para>
		/// </summary>
		[DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
		public StringValue? ExpenseAccount { get; set; }

		/// <summary>
		/// The non-stock item  of the expense, which determines the financial accounts,the default tax category, and the unit of measure used for the receipt.
		/// <para>DAC Field Name: InventoryID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Expense Item</para>
		/// </summary>
		[DataMember(Name="ExpenseItemID", EmitDefaultValue=false)]
		public StringValue? ExpenseItemID { get; set; }

		/// <summary>
		/// The corresponding subaccount the system uses to record the part of the expense to be paid back to the employee.The segments of the expense subaccount are combined according to the settings specified on the Time and Expenses Preferences (EP101000) form.
		/// <para>DAC Field Name: ExpenseSubID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Expense Sub.</para>
		/// </summary>
		[DataMember(Name="ExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? ExpenseSubaccount { get; set; }

		/// <summary>
		/// The identifier of the customer location associated with the document.
		/// <para>DAC Field Name: CustomerLocationID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// The net amount in the currency of the document.
		/// <para>DAC Field Name: CuryNetAmount</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Net Amount</para>
		/// </summary>
		[DataMember(Name="NetAmount", EmitDefaultValue=false)]
		public DecimalValue? NetAmount { get; set; }

		/// <summary>
		/// The project or contract, which should be specified if theemployee incurred the expenses while working on a particular project or contract.The value of this field can be specified only if the Project Accounting or Contract Management feature,respectively, is enabled on the Enable/Disable Features (CS100000) form.
		/// <para>DAC Field Name: ContractID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Project/Contract</para>
		/// </summary>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// The project task to which the expenses are related.This box is available only if the Project Management feature is enabled on the Enable/Disable Features (CS100000) form.
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// The quantity of the expense item that the employee purchased according to the receipt.The quantity is expressed in the unit of measure specifiedfor the selected expense non-stock item.
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// The reference number, which usually matches the number of the original receipt.
		/// <para>DAC Field Name: ExpenseRefNbr</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		/// <summary>
		/// The sales account to which the system records the part of the amount to charge the customer for.If the Billable check box is selected, the sales account specified for the expense non-stock item is filled in by default.
		/// <para>DAC Field Name: SalesAccountID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Sales Account</para>
		/// </summary>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// The corresponding subaccount the system uses to record the amount to charge the customer for.If the Billable check box is selected, the sales subaccount specified for the expense non-stock item is filled in by default.The segments of the sales subaccount are combined according to the settings specified on the Time and Expenses Preferences (EP101000) form.
		/// <para>DAC Field Name: SalesSubID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Sales Sub.</para>
		/// </summary>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// The status of the expense claim.
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The total amount of taxes associated with the document in the currency of the document.(Presented in the currency of the document, see CuryID)
		/// <para>DAC Field Name: CuryTaxTotal</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Tax Total</para>
		/// </summary>
		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// The tax category associated with the expense item.
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// The tax zone associated with the branch.
		/// <para>DAC Field Name: TaxZoneID</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaim</para>
		/// <para>Display Name: Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// The amount of non-taxable tips in the document currency that will not be included in the tax base of the receipt.
		/// <para>DAC Field Name: CuryTipAmt</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Tip Amount</para>
		/// </summary>
		[DataMember(Name="TipAmount", EmitDefaultValue=false)]
		public DecimalValue? TipAmount { get; set; }

		/// <summary>
		/// The cost of one unit of the expense item in the currency of the document.If a standard cost is specified for the expense non-stock item, the standard cost is used as the default unit cost.
		/// <para>DAC Field Name: CuryUnitCost</para>
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// The unit of measure of the expense item.
		/// <para>DAC: PX.Objects.EP.EPExpenseClaimDetails</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}