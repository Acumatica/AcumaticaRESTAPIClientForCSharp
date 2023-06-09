using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class Payment : Entity
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

		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue ExternalRef { get; set; }

		[DataMember(Name="OrigTransaction", EmitDefaultValue=false)]
		public StringValue OrigTransaction { get; set; }

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue BranchID { get; set; }

		[DataMember(Name="CustomerLocationID", EmitDefaultValue=false)]
		public StringValue CustomerLocationID { get; set; }

		[DataMember(Name="IsNewCard", EmitDefaultValue=false)]
		public BooleanValue IsNewCard { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue NoteID { get; set; }

		[DataMember(Name="AvailableBalance", EmitDefaultValue=false)]
		public DecimalValue AvailableBalance { get; set; }

		[DataMember(Name="AppliedToOrders", EmitDefaultValue=false)]
		public DecimalValue AppliedToOrders { get; set; }

	}
}