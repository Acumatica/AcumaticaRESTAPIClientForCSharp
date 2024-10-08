using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ProgressBilling : Entity
	{

		/// <summary>
		/// DAC Field Name: PMRevenueBudget__CuryActualAmount 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// </summary>
		[DataMember(Name="ActualAmount", EmitDefaultValue=false)]
		public DecimalValue? ActualAmount { get; set; }

		/// <summary>
		/// The line amount.
		/// DAC Field Name: CuryAmount 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The amount to bill the customer.
		/// DAC Field Name: CuryLineTotal 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Amount to Invoice 
		/// </summary>
		[DataMember(Name="AmountToInvoice", EmitDefaultValue=false)]
		public DecimalValue? AmountToInvoice { get; set; }

		/// <summary>
		/// The identifier of the Branch to which the pro forma invoice belongs.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.PM.PMProforma 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The identifier of the cost code associated with the pro forma invoice line.
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The percentage of the revised budgeted amount of the revenue budget lineof the project that is invoiced by this pro forma invoice line.
		/// DAC Field Name: CurrentInvoicedPct 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Currently Invoiced (%) 
		/// </summary>
		[DataMember(Name="CurrentInvoiced", EmitDefaultValue=false)]
		public DecimalValue? CurrentInvoiced { get; set; }

		/// <summary>
		/// The deferral code assigned to the stock item or non-stock item specified in this document line.
		/// DAC Field Name: DefCode 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Deferral Code 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="DeferralCode", EmitDefaultValue=false)]
		public StringValue? DeferralCode { get; set; }

		/// <summary>
		/// The description of the pro forma invoice, which is provided by the billing ruleand can be manually modified.
		/// DAC: PX.Objects.PM.PMProforma 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: PMRevenueBudget__CuryInvoicedAmount 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// </summary>
		[DataMember(Name="DraftInvoicesAmount", EmitDefaultValue=false)]
		public DecimalValue? DraftInvoicesAmount { get; set; }

		/// <summary>
		/// The identifier of the inventory item associated with the pro forma invoice line.
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The running total of the amount to invoice column for all the lines of preceding pro forma invoices that refer to the same revenue budget line.            The preceding pro forma invoices are the pro forma invoices that have a reference number that is less than the reference number of the current pro forma            invoice, and have the same project budget key (that is, the same project task, account group, and optionally inventory item or cost code).
		/// DAC Field Name: CuryPreviouslyInvoiced 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Previously Invoiced Amount 
		/// </summary>
		[DataMember(Name="PreviouslyInvoiced", EmitDefaultValue=false)]
		public DecimalValue? PreviouslyInvoiced { get; set; }

		/// <summary>
		/// The identifier of the task associated with the pro forma invoice line.
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// The retainage in percents.
		/// DAC Field Name: RetainagePct 
		/// DAC: PX.Objects.PM.PMProforma 
		/// Display Name: Retainage (%) 
		/// </summary>
		[DataMember(Name="Retainage", EmitDefaultValue=false)]
		public DecimalValue? Retainage { get; set; }

		/// <summary>
		/// The amount to be retained by the customer.
		/// DAC Field Name: CuryRetainage 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Retainage Amount 
		/// </summary>
		[DataMember(Name="RetainageAmount", EmitDefaultValue=false)]
		public DecimalValue? RetainageAmount { get; set; }

		/// <summary>
		/// DAC Field Name: PMRevenueBudget__CuryRevisedAmount 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// </summary>
		[DataMember(Name="RevisedBudgetedAmount", EmitDefaultValue=false)]
		public DecimalValue? RevisedBudgetedAmount { get; set; }

		/// <summary>
		/// The identifier of the sales account associated with the pro forma invoice line.
		/// DAC Field Name: AccountID 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Sales Account 
		/// </summary>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// The identifier of the sales subaccount associated with the pro forma invoice line.
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Sales Subaccount 
		/// </summary>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// The amount of material stored.
		/// DAC Field Name: CuryMaterialStoredAmount 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Stored Material 
		/// </summary>
		[DataMember(Name="StoredMaterial", EmitDefaultValue=false)]
		public DecimalValue? StoredMaterial { get; set; }

		/// <summary>
		/// The identifier of the tax category associated with the pro forma invoice line.
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// The percentage of the revised budgeted amount of the revenue budget line of the projectthat has been invoiced by all the pro forma invoices of the project, including the current one.
		/// DAC Field Name: CompletedPct 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Total Completed (%) 
		/// </summary>
		[DataMember(Name="TotalCompleted", EmitDefaultValue=false)]
		public DecimalValue? TotalCompleted { get; set; }

	}
}