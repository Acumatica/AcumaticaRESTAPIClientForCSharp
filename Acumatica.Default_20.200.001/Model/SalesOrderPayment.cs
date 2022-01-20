using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SalesOrderPayment : Entity_v4
	{

		[DataMember(Name="ApplicationDate", EmitDefaultValue=false)]
		public DateTimeValue ApplicationDate { get; set; }

		[DataMember(Name="AppliedToOrder", EmitDefaultValue=false)]
		public DecimalValue AppliedToOrder { get; set; }

		[DataMember(Name="Authorize", EmitDefaultValue=false)]
		public BooleanValue Authorize { get; set; }

		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue Balance { get; set; }

		[DataMember(Name="CardAccountNbr", EmitDefaultValue=false)]
		public StringValue CardAccountNbr { get; set; }

		[DataMember(Name="Capture", EmitDefaultValue=false)]
		public BooleanValue Capture { get; set; }

		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue CashAccount { get; set; }

		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue Currency { get; set; }

		[DataMember(Name="CreditCardTransactionInfo", EmitDefaultValue=false)]
		public List<SalesOrderCreditCardTransactionDetail> CreditCardTransactionInfo { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue DocType { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="OrigTransactionNbr", EmitDefaultValue=false)]
		public StringValue OrigTransactionNbr { get; set; }

		[DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
		public DecimalValue PaymentAmount { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue PaymentMethod { get; set; }

		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue PaymentRef { get; set; }

		[DataMember(Name="ProcessingCenterID", EmitDefaultValue=false)]
		public StringValue ProcessingCenterID { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue ReferenceNbr { get; set; }

		[DataMember(Name="Refund", EmitDefaultValue=false)]
		public BooleanValue Refund { get; set; }

		[DataMember(Name="SaveCard", EmitDefaultValue=false)]
		public BooleanValue SaveCard { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TransferredtoInvoice", EmitDefaultValue=false)]
		public DecimalValue TransferredtoInvoice { get; set; }

		[DataMember(Name="ValidateCCRefundOrigTransaction", EmitDefaultValue=false)]
		public BooleanValue ValidateCCRefundOrigTransaction { get; set; }

	}
}