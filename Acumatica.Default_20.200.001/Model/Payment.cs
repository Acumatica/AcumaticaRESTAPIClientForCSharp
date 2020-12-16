using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Payment : Entity_v4
	{

		[DataMember(Name="ApplicationDate", EmitDefaultValue=false)]
		public DateTimeValue ApplicationDate { get; set; }

		[DataMember(Name="ApplicationHistory", EmitDefaultValue=false)]
		public List<PaymentApplicationHistoryDetail> ApplicationHistory { get; set; }

		[DataMember(Name="AppliedToDocuments", EmitDefaultValue=false)]
		public DecimalValue AppliedToDocuments { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="CardAccountNbr", EmitDefaultValue=false)]
		public IntValue CardAccountNbr { get; set; }

		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue CashAccount { get; set; }

		[DataMember(Name="CreditCardProcessingInfo", EmitDefaultValue=false)]
		public List<CreditCardProcessingDetail> CreditCardProcessingInfo { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue CustomerID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DocumentsToApply", EmitDefaultValue=false)]
		public List<PaymentDetail> DocumentsToApply { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="OrdersToApply", EmitDefaultValue=false)]
		public List<PaymentOrderDetail> OrdersToApply { get; set; }

		[DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
		public DecimalValue PaymentAmount { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue PaymentMethod { get; set; }

		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue PaymentRef { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue ReferenceNbr { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="ProcessingCenterID", EmitDefaultValue=false)]
		public StringValue ProcessingCenterID { get; set; }

		[DataMember(Name="SaveCard", EmitDefaultValue=false)]
		public BooleanValue SaveCard { get; set; }

		[DataMember(Name="CreditCardTransactionInfo", EmitDefaultValue=false)]
		public List<CreditCardTransactionDetail> CreditCardTransactionInfo { get; set; }

	}
}