using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class ExpenseClaimDetails : Entity
	{

		/// <summary>
		/// The total amount of the receipt in the currency of the document.
		/// DAC Field Name: CuryExtCost 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The amount claimed by the employee, which is expressed in the currency of the expense claim.
		/// DAC Field Name: ClaimCuryTranAmtWithTaxes 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Amount in Claim Curr. 
		/// </summary>
		[DataMember(Name="AmountInClaimCurrency", EmitDefaultValue=false)]
		public DecimalValue? AmountInClaimCurrency { get; set; }

		/// <summary>
		/// The reference number of the AR document created as a result of releasing a claim.
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: AP Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="APRefNbr", EmitDefaultValue=false)]
		public StringValue? APRefNbr { get; set; }

		/// <summary>
		/// The reference number of the AR document created as a result of billing a claim.
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: AR Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ARRefNbr", EmitDefaultValue=false)]
		public StringValue? ARRefNbr { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the customer should be billed for the claim amount.You can use the Bill Expense Claims (EP502000) form to bill the customer if no project is specified.
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// </summary>
		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// The branch of the claim.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The amount to be reimbursed to the employee in the currency of the document.
		/// DAC Field Name: CuryTranAmtWithTaxes 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Claim Amount 
		/// </summary>
		[DataMember(Name="ClaimAmount", EmitDefaultValue=false)]
		public DecimalValue? ClaimAmount { get; set; }

		/// <summary>
		/// The identifier of the cost code associated with the record.
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The code of the currency of the document.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The identifier of the Customer associated with the expense claim.
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Customer 
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The date of the receipt. By default, the current business date is used when a new receipt is created.
		/// DAC Field Name: ExpenseDate 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// The description of the expense.
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The part of the total amount that will not be paid back to the employee in the currency of the document.
		/// DAC Field Name: CuryEmployeePart 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Employee Part 
		/// </summary>
		[DataMember(Name="EmployeePart", EmitDefaultValue=false)]
		public DecimalValue? EmployeePart { get; set; }

		/// <summary>
		/// The expense account to which the system records the part of the expense to be paid back to the employee.
		/// DAC Field Name: ExpenseAccountID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Expense Account 
		/// </summary>
		[DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
		public StringValue? ExpenseAccount { get; set; }

		/// <summary>
		/// The non-stock item  of the expense, which determines the financial accounts,the default tax category, and the unit of measure used for the receipt.
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Expense Item 
		/// </summary>
		[DataMember(Name="ExpenseItemID", EmitDefaultValue=false)]
		public StringValue? ExpenseItemID { get; set; }

		/// <summary>
		/// The corresponding subaccount the system uses to record the part of the expense to be paid back to the employee.The segments of the expense subaccount are combined according to the settings specified on the Time and Expenses Preferences (EP101000) form.
		/// DAC Field Name: ExpenseSubID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Expense Sub. 
		/// </summary>
		[DataMember(Name="ExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? ExpenseSubaccount { get; set; }

		/// <summary>
		/// The identifier of the customer location associated with the document.
		/// DAC Field Name: CustomerLocationID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Location 
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// The net amount in the currency of the document.
		/// DAC Field Name: CuryNetAmount 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Net Amount 
		/// </summary>
		[DataMember(Name="NetAmount", EmitDefaultValue=false)]
		public DecimalValue? NetAmount { get; set; }

		/// <summary>
		/// The project or contract, which should be specified if theemployee incurred the expenses while working on a particular project or contract.The value of this field can be specified only if the Project Accounting or Contract Management feature,respectively, is enabled on the Enable/Disable Features (CS100000) form.
		/// DAC Field Name: ContractID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Project/Contract 
		/// </summary>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// The project task to which the expenses are related.This box is available only if the Project Management feature is enabled on the Enable/Disable Features (CS100000) form.
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// The quantity of the expense item that the employee purchased according to the receipt.The quantity is expressed in the unit of measure specifiedfor the selected expense non-stock item.
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Quantity 
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// The reference number, which usually matches the number of the original receipt.
		/// DAC Field Name: ExpenseRefNbr 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Ref. Nbr. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="RefNbr", EmitDefaultValue=false)]
		public StringValue? RefNbr { get; set; }

		/// <summary>
		/// The sales account to which the system records the part of the amount to charge the customer for.If the Billable check box is selected, the sales account specified for the expense non-stock item is filled in by default.
		/// DAC Field Name: SalesAccountID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Sales Account 
		/// </summary>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// The corresponding subaccount the system uses to record the amount to charge the customer for.If the Billable check box is selected, the sales subaccount specified for the expense non-stock item is filled in by default.The segments of the sales subaccount are combined according to the settings specified on the Time and Expenses Preferences (EP101000) form.
		/// DAC Field Name: SalesSubID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Sales Sub. 
		/// </summary>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// The status of the expense claim.
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The total amount of taxes associated with the document in the currency of the document.(Presented in the currency of the document, see CuryID)
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Tax Total 
		/// </summary>
		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// The tax category associated with the expense item.
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// The tax zone associated with the branch.
		/// DAC Field Name: TaxZoneID 
		/// DAC: PX.Objects.EP.EPExpenseClaim 
		/// Display Name: Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// The amount of non-taxable tips in the document currency that will not be included in the tax base of the receipt.
		/// DAC Field Name: CuryTipAmt 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Tip Amount 
		/// </summary>
		[DataMember(Name="TipAmount", EmitDefaultValue=false)]
		public DecimalValue? TipAmount { get; set; }

		/// <summary>
		/// The cost of one unit of the expense item in the currency of the document.If a standard cost is specified for the expense non-stock item, the standard cost is used as the default unit cost.
		/// DAC Field Name: CuryUnitCost 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// The unit of measure of the expense item.
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

	}
}