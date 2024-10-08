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
	public class ProjectTransactionDetail : Entity
	{

		/// <summary>
		/// The identifier of the Account Group associated with the transaction.
		/// DAC Field Name: AccountGroupID 
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Account Group 
		/// </summary>
		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue? AccountGroup { get; set; }

		[DataMember(Name="AccountGroupDescription", EmitDefaultValue=false)]
		public StringValue? AccountGroupDescription { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the transaction
		/// DAC: PX.Objects.PM.PMTran 
		/// </summary>
		[DataMember(Name="Allocated", EmitDefaultValue=false)]
		public BooleanValue? Allocated { get; set; }

		/// <summary>
		/// The amount of the transaction in the transaction currency.
		/// DAC Field Name: TranCuryAmount 
		/// DAC: PX.Objects.PM.PMTran 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The reference number of the GL Batch associated with the transaction.
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: GL Batch Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the transaction is used in calculating the amount charged to the customer.
		/// DAC: PX.Objects.PM.PMTran 
		/// </summary>
		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// The quantity that is used for billing the customer.
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Billable Quantity 
		/// </summary>
		[DataMember(Name="BillableQty", EmitDefaultValue=false)]
		public DecimalValue? BillableQty { get; set; }

		[DataMember(Name="Billed", EmitDefaultValue=false)]
		public BooleanValue? Billed { get; set; }

		/// <summary>
		/// The identifier of the Branch to which the transaction belongs.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.PM.PMTran 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The identifier of the Cost Code associated with the transaction.
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// DAC Field Name: OffsetAccountID 
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Credit Account 
		/// </summary>
		[DataMember(Name="CreditAccount", EmitDefaultValue=false)]
		public StringValue? CreditAccount { get; set; }

		/// <summary>
		/// The identifier of the credit subaccount associated with the transaction.
		/// DAC Field Name: OffsetSubID 
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Credit Subaccount 
		/// </summary>
		[DataMember(Name="CreditSubaccount", EmitDefaultValue=false)]
		public StringValue? CreditSubaccount { get; set; }

		/// <summary>
		/// The date of the transaction, which is specified by the user.
		/// DAC: PX.Objects.PM.PMTran 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// The identifier of the debit Account associated with the transaction.
		/// DAC Field Name: AccountID 
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Debit Account 
		/// </summary>
		[DataMember(Name="DebitAccount", EmitDefaultValue=false)]
		public StringValue? DebitAccount { get; set; }

		/// <summary>
		/// The identifier of the debit subaccount associated with the transaction.
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Debit Subaccount 
		/// </summary>
		[DataMember(Name="DebitSubaccount", EmitDefaultValue=false)]
		public StringValue? DebitSubaccount { get; set; }

		/// <summary>
		/// The description of the document.
		/// DAC: PX.Objects.PM.PMRegister 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The identifier of the earning type, which is specified for the transaction to calculate the labor cost.
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Earning Type 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="EarningType", EmitDefaultValue=false)]
		public StringValue? EarningType { get; set; }

		/// <summary>
		/// The identifier of the employee associated with the transaction.
		/// DAC Field Name: ResourceID 
		/// DAC: PX.Objects.PM.PMTran 
		/// </summary>
		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue? Employee { get; set; }

		/// <summary>
		/// The transaction end date.
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: End Date 
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		/// <summary>
		/// An identifier of the company-specific financial period to which the transaction belongs.
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Fin. Period 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="FinPeriod", EmitDefaultValue=false)]
		public StringValue? FinPeriod { get; set; }

		/// <summary>
		/// The identifier of the stock or non-stock item associated with the transaction.
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The identifier of the location of the customer or vendor associated with the transaction.
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.PM.PMTran 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// The multiplier by which the unit rate is multiplied when the labor cost is calculated.The multiplier can differ from 1 only for earning types marked as overtime.
		/// DAC Field Name: OvertimeMultiplier 
		/// DAC: PX.Objects.PM.PMTran 
		/// </summary>
		[DataMember(Name="Multiplier", EmitDefaultValue=false)]
		public DecimalValue? Multiplier { get; set; }

		/// <summary>
		/// The identifier of the project associated with the transaction, or the non-project code indicating that the transaction is            not related to any particular project.
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.PM.PMTran 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// The identifier of the task associated with the transaction.
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// The quantity of the transaction.
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Quantity 
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the transaction has been released.
		/// DAC: PX.Objects.PM.PMTran 
		/// </summary>
		[DataMember(Name="Released", EmitDefaultValue=false)]
		public BooleanValue? Released { get; set; }

		/// <summary>
		/// The transaction start date.
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="TransactionID", EmitDefaultValue=false)]
		public LongValue? TransactionID { get; set; }

		/// <summary>
		/// The price of the item or the rate of the service in the transaction currency. For a labor item, the employee's hourly rate is used as the unit rate.
		/// DAC Field Name: TranCuryUnitRate 
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Unit Rate 
		/// </summary>
		[DataMember(Name="UnitRate", EmitDefaultValue=false)]
		public DecimalValue? UnitRate { get; set; }

		/// <summary>
		/// The unit of measure used to estimate the quantity for the transaction.
		/// DAC: PX.Objects.PM.PMTran 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the system uses the billable quantity instead of the overall quantity of the transaction when            calculating the amount of the transaction.
		/// DAC Field Name: UseBillableQty 
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Use Billable Quantity in Amount Formula 
		/// </summary>
		[DataMember(Name="UseBillableQtyInAmountFormula", EmitDefaultValue=false)]
		public BooleanValue? UseBillableQtyInAmountFormula { get; set; }

		/// <summary>
		/// The identifier of the vendor or customer associated with the transaction.
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.PM.PMTran 
		/// Display Name: Customer/Vendor 
		/// </summary>
		[DataMember(Name="VendorOrCustomer", EmitDefaultValue=false)]
		public StringValue? VendorOrCustomer { get; set; }

	}
}