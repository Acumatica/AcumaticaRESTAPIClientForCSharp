using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen EP301020 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ExpenseReceipt : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The company branch that will incur the expenses. If multiple expense receipts associated with different branches are added to one expense claim,the branch specified for the claim on the Financial Details tab of the Expense Claim (EP301000) form (which corresponds to the ExpenseClaimEntry graph)will reimburse the expenses and the branches specified in this box for the receipts will incur the expenses.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
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
		/// The identifier of the employee who is claiming the expenses.
		/// DAC Field Name: EmployeeID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Claimed by 
		/// </summary>
		[DataMember(Name="ClaimedBy", EmitDefaultValue=false)]
		public StringValue? ClaimedBy { get; set; }

		/// <summary>
		/// The date of the receipt. By default, the current business date is used when a new receipt is created.
		/// DAC Field Name: ExpenseDate 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// The non-stock item  of the expense, which determines the financial accounts,the default tax category, and the unit of measure used for the receipt.
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Expense Item 
		/// </summary>
		[DataMember(Name="ExpenseItemID", EmitDefaultValue=false)]
		public StringValue? ExpenseItemID { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="ReceiptDetails", EmitDefaultValue=false)]
		public ExpenseReceiptDetails? ReceiptDetails { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the receipt.
		/// DAC Field Name: ClaimDetailCD 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Receipt Number 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReceiptID", EmitDefaultValue=false)]
		public StringValue? ReceiptID { get; set; }

		/// <summary>
		/// The status of the expense receipt.
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="TaxDetails", EmitDefaultValue=false)]
		public List<ExpenseReceiptTaxDetails>? TaxDetails { get; set; }

		/// <summary>
		/// The total amount of taxes associated with the document in the currency of the document.
		/// DAC Field Name: CuryTaxTotal 
		/// DAC: PX.Objects.EP.EPExpenseClaimDetails 
		/// Display Name: Tax Total 
		/// </summary>
		[DataMember(Name="TaxTotal", EmitDefaultValue=false)]
		public DecimalValue? TaxTotal { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}