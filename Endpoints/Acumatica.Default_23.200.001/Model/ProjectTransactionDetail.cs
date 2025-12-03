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
	public class ProjectTransactionDetail : Entity
	{

		/// <summary>
		/// The identifier of the Account Group associated with the transaction.
		/// <para>DAC Field Name: AccountGroupID</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Account Group</para>
		/// </summary>
		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue? AccountGroup { get; set; }

		[DataMember(Name="AccountGroupDescription", EmitDefaultValue=false)]
		public StringValue? AccountGroupDescription { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the transaction
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// </summary>
		[DataMember(Name="Allocated", EmitDefaultValue=false)]
		public BooleanValue? Allocated { get; set; }

		/// <summary>
		/// The amount of the transaction in the transaction currency.
		/// <para>DAC Field Name: TranCuryAmount</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The reference number of the GL Batch associated with the transaction.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: GL Batch Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the transaction is used in calculating the amount charged to the customer.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// </summary>
		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// The quantity that is used for billing the customer.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Billable Quantity</para>
		/// </summary>
		[DataMember(Name="BillableQty", EmitDefaultValue=false)]
		public DecimalValue? BillableQty { get; set; }

		[DataMember(Name="Billed", EmitDefaultValue=false)]
		public BooleanValue? Billed { get; set; }

		/// <summary>
		/// The identifier of the Branch to which the transaction belongs.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The identifier of the Cost Code associated with the transaction.
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OffsetAccountID</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Credit Account</para>
		/// </summary>
		[DataMember(Name="CreditAccount", EmitDefaultValue=false)]
		public StringValue? CreditAccount { get; set; }

		/// <summary>
		/// The identifier of the credit subaccount associated with the transaction.
		/// <para>DAC Field Name: OffsetSubID</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Credit Subaccount</para>
		/// </summary>
		[DataMember(Name="CreditSubaccount", EmitDefaultValue=false)]
		public StringValue? CreditSubaccount { get; set; }

		/// <summary>
		/// The date of the transaction, which is specified by the user.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// The identifier of the debit Account associated with the transaction.
		/// <para>DAC Field Name: AccountID</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Debit Account</para>
		/// </summary>
		[DataMember(Name="DebitAccount", EmitDefaultValue=false)]
		public StringValue? DebitAccount { get; set; }

		/// <summary>
		/// The identifier of the debit subaccount associated with the transaction.
		/// <para>DAC Field Name: SubID</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Debit Subaccount</para>
		/// </summary>
		[DataMember(Name="DebitSubaccount", EmitDefaultValue=false)]
		public StringValue? DebitSubaccount { get; set; }

		/// <summary>
		/// The description of the document.
		/// <para>DAC: PX.Objects.PM.PMRegister</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The identifier of the earning type, which is specified for the transaction to calculate the labor cost.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Earning Type</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="EarningType", EmitDefaultValue=false)]
		public StringValue? EarningType { get; set; }

		/// <summary>
		/// The identifier of the employee associated with the transaction.
		/// <para>DAC Field Name: ResourceID</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// </summary>
		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue? Employee { get; set; }

		/// <summary>
		/// The transaction end date.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: End Date</para>
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		/// <summary>
		/// An identifier of the company-specific financial period to which the transaction belongs.
		/// <para>DAC Field Name: FinPeriodID</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Fin. Period</para>
		/// <para>SQL Type: char(6)</para>
		/// </summary>
		[DataMember(Name="FinPeriod", EmitDefaultValue=false)]
		public StringValue? FinPeriod { get; set; }

		/// <summary>
		/// The identifier of the stock or non-stock item associated with the transaction.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The identifier of the location of the customer or vendor associated with the transaction.
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// The multiplier by which the unit rate is multiplied when the labor cost is calculated.The multiplier can differ from 1 only for earning types marked as overtime.
		/// <para>DAC Field Name: OvertimeMultiplier</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// </summary>
		[DataMember(Name="Multiplier", EmitDefaultValue=false)]
		public DecimalValue? Multiplier { get; set; }

		/// <summary>
		/// The identifier of the project associated with the transaction, or the non-project code indicating that the transaction is            not related to any particular project.
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// The identifier of the task associated with the transaction.
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// The quantity of the transaction.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Quantity</para>
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the transaction has been released.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// </summary>
		[DataMember(Name="Released", EmitDefaultValue=false)]
		public BooleanValue? Released { get; set; }

		/// <summary>
		/// The transaction start date.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="TransactionID", EmitDefaultValue=false)]
		public LongValue? TransactionID { get; set; }

		/// <summary>
		/// The price of the item or the rate of the service in the transaction currency. For a labor item, the employee's hourly rate is used as the unit rate.
		/// <para>DAC Field Name: TranCuryUnitRate</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Unit Rate</para>
		/// </summary>
		[DataMember(Name="UnitRate", EmitDefaultValue=false)]
		public DecimalValue? UnitRate { get; set; }

		/// <summary>
		/// The unit of measure used to estimate the quantity for the transaction.
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the system uses the billable quantity instead of the overall quantity of the transaction when            calculating the amount of the transaction.
		/// <para>DAC Field Name: UseBillableQty</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Use Billable Quantity in Amount Formula</para>
		/// </summary>
		[DataMember(Name="UseBillableQtyInAmountFormula", EmitDefaultValue=false)]
		public BooleanValue? UseBillableQtyInAmountFormula { get; set; }

		/// <summary>
		/// The identifier of the vendor or customer associated with the transaction.
		/// <para>DAC Field Name: BAccountID</para>
		/// <para>DAC: PX.Objects.PM.PMTran</para>
		/// <para>Display Name: Customer/Vendor</para>
		/// </summary>
		[DataMember(Name="VendorOrCustomer", EmitDefaultValue=false)]
		public StringValue? VendorOrCustomer { get; set; }

	}
}