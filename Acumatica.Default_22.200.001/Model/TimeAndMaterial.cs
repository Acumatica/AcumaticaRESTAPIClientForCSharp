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
	public class TimeAndMaterial : Entity
	{

		/// <summary>
		/// The amount to bill the customer.
		/// DAC Field Name: CuryLineTotal 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Amount to Invoice 
		/// </summary>
		[DataMember(Name="AmountToInvoice", EmitDefaultValue=false)]
		public DecimalValue? AmountToInvoice { get; set; }

		/// <summary>
		/// The amount to bill the customer provided by the billing rule.
		/// DAC Field Name: CuryBillableAmount 
		/// DAC: PX.Objects.PM.PMProformaTransactLine 
		/// Display Name: Billed Amount 
		/// </summary>
		[DataMember(Name="BilledAmount", EmitDefaultValue=false)]
		public DecimalValue? BilledAmount { get; set; }

		/// <summary>
		/// The quantity to bill the customer provided by the billing rule.
		/// DAC Field Name: BillableQty 
		/// DAC: PX.Objects.PM.PMProformaTransactLine 
		/// Display Name: Billed Quantity 
		/// </summary>
		[DataMember(Name="BilledQty", EmitDefaultValue=false)]
		public DecimalValue? BilledQty { get; set; }

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
		/// The date of the pro forma invoice line.
		/// DAC: PX.Objects.PM.PMProformaTransactLine 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

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
		/// The identifier of the employee associated with the pro forma invoice line.
		/// DAC Field Name: ResourceID 
		/// DAC: PX.Objects.PM.PMProformaTransactLine 
		/// Display Name: Employee 
		/// </summary>
		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue? EmployeeID { get; set; }

		/// <summary>
		/// The identifier of the inventory item associated with the pro forma invoice line.
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The maximum amount available to bill the customer based on the billing limit amountof the corresponding revenue budget line of the project.
		/// DAC Field Name: CuryAvailableAmount 
		/// DAC: PX.Objects.PM.PMProformaTransactLine 
		/// Display Name: Max Available Amount 
		/// </summary>
		[DataMember(Name="MaxAvailableAmount", EmitDefaultValue=false)]
		public DecimalValue? MaxAvailableAmount { get; set; }

		/// <summary>
		/// The billing limit amount (Maximum Amount)of the corresponding revenue budget line of the project.If no billing limit amount is defined for the revenue budget line of the project,the Max Limit Amount of each corresponding pro forma invoice line is 0.
		/// DAC Field Name: CuryMaxAmount 
		/// DAC: PX.Objects.PM.PMProformaTransactLine 
		/// Display Name: Max Limit Amount 
		/// </summary>
		[DataMember(Name="MaxLimitAmount", EmitDefaultValue=false)]
		public DecimalValue? MaxLimitAmount { get; set; }

		/// <summary>
		/// The amount that exceeds the billing limit.
		/// DAC Field Name: CuryOverflowAmount 
		/// DAC: PX.Objects.PM.PMProformaTransactLine 
		/// Display Name: Over-Limit Amount 
		/// </summary>
		[DataMember(Name="OverLimitAmount", EmitDefaultValue=false)]
		public DecimalValue? OverLimitAmount { get; set; }

		/// <summary>
		/// The identifier of the task associated with the pro forma invoice line.
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// The quantity to bill the customer. The value can be manually modified.
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Quantity to Invoice 
		/// </summary>
		[DataMember(Name="QtyToInvoice", EmitDefaultValue=false)]
		public DecimalValue? QtyToInvoice { get; set; }

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
		/// The status that defines how to bill the line.
		/// DAC Field Name: Option 
		/// DAC: PX.Objects.PM.PMProformaTransactLine 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

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
		/// The price of the item or the rate of the service.
		/// DAC Field Name: CuryUnitPrice 
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// Display Name: Unit Price 
		/// </summary>
		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.PMProformaProgressLine 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// The identifier of the vendor associated with the pro forma invoice line.
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.PM.PMProformaTransactLine 
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

	}
}