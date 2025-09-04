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
	public class ExpenseReceiptDetails : Entity
	{

		/// <summary>
		/// The total amount of the receipt in the currency of the document.
		/// DAC Field Name: CuryExtCost 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// Identifier of the base Currency.
		/// DAC Field Name: BaseCuryID 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Base Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue? BaseCurrencyID { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the customer should be billed for the claim amount.You can use the Bill Expense Claims (EP502000) form to bill the customer if no project is specified.
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// </summary>
		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// The identifier of the cost code associated with the record.
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The identifier of the Rate Type associated with this object.
		/// DAC Field Name: CuryRateTypeID 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Curr. Rate Type ID 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="CurrancyRateTypeID", EmitDefaultValue=false)]
		public StringValue? CurrancyRateTypeID { get; set; }

		/// <summary>
		/// The code of the currency of the document.By default, the receipt currency is the currency specified as the default for the employee.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The exchange rate used for calculations and determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// DAC Field Name: SampleCuryRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Curr. Rate 
		/// </summary>
		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue? CurrencyRate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Customer 
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

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
		/// The reference number, which usually matches the number of the original receipt.
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Expense Claim Ref. Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ExpenseClaimID", EmitDefaultValue=false)]
		public StringValue? ExpenseClaimID { get; set; }

		/// <summary>
		/// The status of the Expense Claim (EP301000) form (which corresponds to the ExpenseClaimEntry graph).
		/// DAC Field Name: StatusClaim 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Expense Claim Status 
		/// SQL Type: nchar(1) 
		/// </summary>
		[DataMember(Name="ExpenseClaimStatus", EmitDefaultValue=false)]
		public StringValue? ExpenseClaimStatus { get; set; }

		/// <summary>
		/// The corresponding subaccount the system uses to record the part of the expense to be paid back to the employee.The segments of the expense subaccount are combined according to the settings specified on the Time and Expenses Preferences (EP101000) form.
		/// DAC Field Name: ExpenseSubID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Expense Sub. 
		/// </summary>
		[DataMember(Name="ExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? ExpenseSubaccount { get; set; }

		/// <summary>
		/// The location of the customer related to the expenses.
		/// DAC Field Name: CustomerLocationID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Location 
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

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
		/// The inverse of the SampleCuryRate. This value is also determined by the values ofthe CuryMultDiv, CuryRate and RecipRate fields.
		/// DAC Field Name: SampleRecipRate 
		/// DAC: PX.Objects.CM.CurrencyInfo 
		/// Display Name: Reciprocal Rate 
		/// </summary>
		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue? ReciprocalRate { get; set; }

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
		/// The tax category associated with the expense item.
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// The identifier of the tax zone associated with the receipt.
		/// DAC Field Name: TaxZoneID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

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