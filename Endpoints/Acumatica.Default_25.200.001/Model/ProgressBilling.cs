using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class ProgressBilling : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: PMRevenueBudget__CuryActualAmount</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// </summary>
		public DecimalValue? ActualAmount { get; set; }

		/// <summary>
		/// The line amount.
		/// <para>DAC Field Name: CuryAmount</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// </summary>
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The amount that is billed to the customer.
		/// <para>DAC Field Name: CuryLineTotal</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Amount to Invoice</para>
		/// </summary>
		public DecimalValue? AmountToInvoice { get; set; }

		/// <summary>
		/// The identifier of the Branch to which the pro forma invoice belongs.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The identifier of the cost code associated with the pro forma invoice line.
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The percentage of the revised budgeted amount of the revenue budget lineof the project that is invoiced by this pro forma invoice line.
		/// <para>DAC Field Name: CurrentInvoicedPct</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Currently Invoiced (%)</para>
		/// </summary>
		public DecimalValue? CurrentInvoiced { get; set; }

		/// <summary>
		/// The deferral code assigned to the stock item or non-stock item specified in this document line.
		/// <para>DAC Field Name: DefCode</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Deferral Code</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? DeferralCode { get; set; }

		/// <summary>
		/// The description of the pro forma invoice, which is provided by the billing ruleand can be manually modified.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMRevenueBudget__CuryInvoicedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// </summary>
		public DecimalValue? DraftInvoicesAmount { get; set; }

		/// <summary>
		/// The identifier of the inventory item associated with the pro forma invoice line.
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The running total of the amount to invoice column for all the lines of preceding pro forma invoices that refer to the same revenue budget line.            The preceding pro forma invoices are the pro forma invoices that have a reference number that is less than the reference number of the current pro forma            invoice, and have the same project budget key (that is, the same project task, account group, and optionally inventory item or cost code).
		/// <para>DAC Field Name: CuryPreviouslyInvoiced</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Previously Invoiced Amount</para>
		/// </summary>
		public DecimalValue? PreviouslyInvoiced { get; set; }

		/// <summary>
		/// The identifier of the task associated with the pro forma invoice line.
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// The retainage in percents.
		/// <para>DAC Field Name: RetainagePct</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Retainage (%)</para>
		/// </summary>
		public DecimalValue? Retainage { get; set; }

		/// <summary>
		/// The amount to be retained by the customer.
		/// <para>DAC Field Name: CuryRetainage</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Retainage Amount</para>
		/// </summary>
		public DecimalValue? RetainageAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMRevenueBudget__CuryRevisedAmount</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// </summary>
		public DecimalValue? RevisedBudgetedAmount { get; set; }

		/// <summary>
		/// The identifier of the sales account associated with the pro forma invoice line.
		/// <para>DAC Field Name: AccountID</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Sales Account</para>
		/// </summary>
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// The identifier of the sales subaccount associated with the pro forma invoice line.
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Sales Subaccount</para>
		/// </summary>
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// The amount of stored material.
		/// <para>DAC Field Name: CuryMaterialStoredAmount</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Stored Material</para>
		/// </summary>
		public DecimalValue? StoredMaterial { get; set; }

		/// <summary>
		/// The identifier of the tax category associated with the pro forma invoice line.
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// The percentage of the revised budgeted amount of the revenue budget line of the projectthat has been invoiced by all the pro forma invoices of the project, including the current one.
		/// <para>DAC Field Name: CompletedPct</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Total Completed (%)</para>
		/// </summary>
		public DecimalValue? TotalCompleted { get; set; }

	}
}