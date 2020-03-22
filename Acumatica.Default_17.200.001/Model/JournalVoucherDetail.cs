using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class JournalVoucherDetail : Entity
	{

		[DataMember(Name="APDocumentsToApply", EmitDefaultValue=false)]
		public List<JournalVoucherDetailAPDocumentToApply> APDocumentsToApply { get; set; }

		[DataMember(Name="ARDocumentsToApply", EmitDefaultValue=false)]
		public List<JournalVoucherDetailARDocumentToApply> ARDocumentsToApply { get; set; }

		[DataMember(Name="BatchModule", EmitDefaultValue=false)]
		public StringValue BatchModule { get; set; }

		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue BatchNbr { get; set; }

		[DataMember(Name="CardAccountNbr", EmitDefaultValue=false)]
		public IntValue CardAccountNbr { get; set; }

		[DataMember(Name="CardAccountNbrCardAccountNbr", EmitDefaultValue=false)]
		public StringValue CardAccountNbrCardAccountNbr { get; set; }

		[DataMember(Name="CashDiscount", EmitDefaultValue=false)]
		public DecimalValue CashDiscount { get; set; }

		[DataMember(Name="CashDiscountDate", EmitDefaultValue=false)]
		public DateTimeValue CashDiscountDate { get; set; }

		[DataMember(Name="CreditAccount", EmitDefaultValue=false)]
		public StringValue CreditAccount { get; set; }

		[DataMember(Name="CreditSubaccount", EmitDefaultValue=false)]
		public StringValue CreditSubaccount { get; set; }

		[DataMember(Name="DebitAccount", EmitDefaultValue=false)]
		public StringValue DebitAccount { get; set; }

		[DataMember(Name="DebitSubaccount", EmitDefaultValue=false)]
		public StringValue DebitSubaccount { get; set; }

		[DataMember(Name="DocCreated", EmitDefaultValue=false)]
		public BooleanValue DocCreated { get; set; }

		[DataMember(Name="DocTotal", EmitDefaultValue=false)]
		public DecimalValue DocTotal { get; set; }

		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue DueDate { get; set; }

		[DataMember(Name="EntryTypeID", EmitDefaultValue=false)]
		public StringValue EntryTypeID { get; set; }

		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue ExternalRef { get; set; }

		[DataMember(Name="GroupTransactionID", EmitDefaultValue=false)]
		public IntValue GroupTransactionID { get; set; }

		[DataMember(Name="IncludedTaxAmount", EmitDefaultValue=false)]
		public DecimalValue IncludedTaxAmount { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue PaymentMethod { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue ReferenceNbr { get; set; }

		[DataMember(Name="Released", EmitDefaultValue=false)]
		public BooleanValue Released { get; set; }

		[DataMember(Name="Split", EmitDefaultValue=false)]
		public BooleanValue Split { get; set; }

		[DataMember(Name="SubtotalAmount", EmitDefaultValue=false)]
		public DecimalValue SubtotalAmount { get; set; }

		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue TaxAmount { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue TaxZone { get; set; }

		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue Terms { get; set; }

		[DataMember(Name="TotalAmount", EmitDefaultValue=false)]
		public DecimalValue TotalAmount { get; set; }

		[DataMember(Name="TransactionCode", EmitDefaultValue=false)]
		public StringValue TransactionCode { get; set; }

		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue TransactionDate { get; set; }

		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue TransactionDescription { get; set; }

		[DataMember(Name="VendorOrCustomer", EmitDefaultValue=false)]
		public StringValue VendorOrCustomer { get; set; }

	}
}