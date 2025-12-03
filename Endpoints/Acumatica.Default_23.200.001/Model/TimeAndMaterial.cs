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
	public class TimeAndMaterial : Entity
	{

		/// <summary>
		/// The amount that is billed to the customer.
		/// <para>DAC Field Name: CuryLineTotal</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Amount to Invoice</para>
		/// </summary>
		[DataMember(Name="AmountToInvoice", EmitDefaultValue=false)]
		public DecimalValue? AmountToInvoice { get; set; }

		/// <summary>
		/// The amount to bill the customer provided by the billing rule.
		/// <para>DAC Field Name: CuryBillableAmount</para>
		/// <para>DAC: PX.Objects.PM.PMProformaTransactLine</para>
		/// <para>Display Name: Billed Amount</para>
		/// </summary>
		[DataMember(Name="BilledAmount", EmitDefaultValue=false)]
		public DecimalValue? BilledAmount { get; set; }

		/// <summary>
		/// The quantity to bill the customer provided by the billing rule.
		/// <para>DAC Field Name: BillableQty</para>
		/// <para>DAC: PX.Objects.PM.PMProformaTransactLine</para>
		/// <para>Display Name: Billed Quantity</para>
		/// </summary>
		[DataMember(Name="BilledQty", EmitDefaultValue=false)]
		public DecimalValue? BilledQty { get; set; }

		/// <summary>
		/// The identifier of the Branch to which the pro forma invoice belongs.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The identifier of the cost code associated with the pro forma invoice line.
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The date of the pro forma invoice line.
		/// <para>DAC: PX.Objects.PM.PMProformaTransactLine</para>
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// The deferral code assigned to the stock item or non-stock item specified in this document line.
		/// <para>DAC Field Name: DefCode</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Deferral Code</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="DeferralCode", EmitDefaultValue=false)]
		public StringValue? DeferralCode { get; set; }

		/// <summary>
		/// The description of the pro forma invoice, which is provided by the billing ruleand can be manually modified.
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The identifier of the employee associated with the pro forma invoice line.
		/// <para>DAC Field Name: ResourceID</para>
		/// <para>DAC: PX.Objects.PM.PMProformaTransactLine</para>
		/// <para>Display Name: Employee</para>
		/// </summary>
		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue? EmployeeID { get; set; }

		/// <summary>
		/// The identifier of the inventory item associated with the pro forma invoice line.
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The maximum amount available to bill the customer based on the billing limit amountof the corresponding revenue budget line of the project.
		/// <para>DAC Field Name: CuryAvailableAmount</para>
		/// <para>DAC: PX.Objects.PM.PMProformaTransactLine</para>
		/// <para>Display Name: Max Available Amount</para>
		/// </summary>
		[DataMember(Name="MaxAvailableAmount", EmitDefaultValue=false)]
		public DecimalValue? MaxAvailableAmount { get; set; }

		/// <summary>
		/// The billing limit amount (Maximum Amount)of the corresponding revenue budget line of the project.If no billing limit amount is defined for the revenue budget line of the project,the Max Limit Amount of each corresponding pro forma invoice line is 0.
		/// <para>DAC Field Name: CuryMaxAmount</para>
		/// <para>DAC: PX.Objects.PM.PMProformaTransactLine</para>
		/// <para>Display Name: Max Limit Amount</para>
		/// </summary>
		[DataMember(Name="MaxLimitAmount", EmitDefaultValue=false)]
		public DecimalValue? MaxLimitAmount { get; set; }

		/// <summary>
		/// The amount that exceeds the billing limit.
		/// <para>DAC Field Name: CuryOverflowAmount</para>
		/// <para>DAC: PX.Objects.PM.PMProformaTransactLine</para>
		/// <para>Display Name: Over-Limit Amount</para>
		/// </summary>
		[DataMember(Name="OverLimitAmount", EmitDefaultValue=false)]
		public DecimalValue? OverLimitAmount { get; set; }

		/// <summary>
		/// The identifier of the task associated with the pro forma invoice line.
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// The quantity to bill the customer. The value can be manually modified.
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Quantity to Invoice</para>
		/// </summary>
		[DataMember(Name="QtyToInvoice", EmitDefaultValue=false)]
		public DecimalValue? QtyToInvoice { get; set; }

		/// <summary>
		/// The retainage in percents.
		/// <para>DAC Field Name: RetainagePct</para>
		/// <para>DAC: PX.Objects.PM.PMProforma</para>
		/// <para>Display Name: Retainage (%)</para>
		/// </summary>
		[DataMember(Name="Retainage", EmitDefaultValue=false)]
		public DecimalValue? Retainage { get; set; }

		/// <summary>
		/// The amount to be retained by the customer.
		/// <para>DAC Field Name: CuryRetainage</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Retainage Amount</para>
		/// </summary>
		[DataMember(Name="RetainageAmount", EmitDefaultValue=false)]
		public DecimalValue? RetainageAmount { get; set; }

		/// <summary>
		/// The identifier of the sales account associated with the pro forma invoice line.
		/// <para>DAC Field Name: AccountID</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Sales Account</para>
		/// </summary>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// The identifier of the sales subaccount associated with the pro forma invoice line.
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Sales Subaccount</para>
		/// </summary>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// The status that defines how to bill the line.
		/// <para>DAC Field Name: Option</para>
		/// <para>DAC: PX.Objects.PM.PMProformaTransactLine</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The identifier of the tax category associated with the pro forma invoice line.
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// The price of the item or the rate of the service.
		/// <para>DAC Field Name: CuryUnitPrice</para>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>Display Name: Unit Price</para>
		/// </summary>
		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMProformaProgressLine</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// The identifier of the vendor associated with the pro forma invoice line.
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.PM.PMProformaTransactLine</para>
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

	}
}