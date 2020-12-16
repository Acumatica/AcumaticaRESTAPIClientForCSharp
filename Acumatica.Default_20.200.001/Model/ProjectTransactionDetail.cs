using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProjectTransactionDetail : Entity_v4
	{

		[DataMember(Name="AccountGroup", EmitDefaultValue=false)]
		public StringValue AccountGroup { get; set; }

		[DataMember(Name="AccountGroupDescription", EmitDefaultValue=false)]
		public StringValue AccountGroupDescription { get; set; }

		[DataMember(Name="Allocated", EmitDefaultValue=false)]
		public BooleanValue Allocated { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue BatchNbr { get; set; }

		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue Billable { get; set; }

		[DataMember(Name="BillableQty", EmitDefaultValue=false)]
		public DecimalValue BillableQty { get; set; }

		[DataMember(Name="Billed", EmitDefaultValue=false)]
		public BooleanValue Billed { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="CreditAccount", EmitDefaultValue=false)]
		public StringValue CreditAccount { get; set; }

		[DataMember(Name="CreditSubaccount", EmitDefaultValue=false)]
		public StringValue CreditSubaccount { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="DebitAccount", EmitDefaultValue=false)]
		public StringValue DebitAccount { get; set; }

		[DataMember(Name="DebitSubaccount", EmitDefaultValue=false)]
		public StringValue DebitSubaccount { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EarningType", EmitDefaultValue=false)]
		public StringValue EarningType { get; set; }

		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue Employee { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue ExternalRefNbr { get; set; }

		[DataMember(Name="FinPeriod", EmitDefaultValue=false)]
		public StringValue FinPeriod { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="Multiplier", EmitDefaultValue=false)]
		public DecimalValue Multiplier { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="Released", EmitDefaultValue=false)]
		public BooleanValue Released { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="TransactionID", EmitDefaultValue=false)]
		public LongValue TransactionID { get; set; }

		[DataMember(Name="UnitRate", EmitDefaultValue=false)]
		public DecimalValue UnitRate { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="UseBillableQtyInAmountFormula", EmitDefaultValue=false)]
		public BooleanValue UseBillableQtyInAmountFormula { get; set; }

		[DataMember(Name="VendorOrCustomer", EmitDefaultValue=false)]
		public StringValue VendorOrCustomer { get; set; }

	}
}