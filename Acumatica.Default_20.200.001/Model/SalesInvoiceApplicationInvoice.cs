using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SalesInvoiceApplicationInvoice : Entity_v4
	{

		[DataMember(Name="AdjustedDocReferenceNbr", EmitDefaultValue=false)]
		public StringValue AdjustedDocReferenceNbr { get; set; }

		[DataMember(Name="AdjustingDocReferenceNbr", EmitDefaultValue=false)]
		public StringValue AdjustingDocReferenceNbr { get; set; }

		[DataMember(Name="AdjustmentNbr", EmitDefaultValue=false)]
		public IntValue AdjustmentNbr { get; set; }

		[DataMember(Name="AmountPaid", EmitDefaultValue=false)]
		public DecimalValue AmountPaid { get; set; }

		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue Balance { get; set; }

		[DataMember(Name="CashDiscountTaken", EmitDefaultValue=false)]
		public DecimalValue CashDiscountTaken { get; set; }

		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue Currency { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue DocType { get; set; }

		[DataMember(Name="DocumentType", EmitDefaultValue=false)]
		public StringValue DocumentType { get; set; }

		[DataMember(Name="PaymentDate", EmitDefaultValue=false)]
		public DateTimeValue PaymentDate { get; set; }

		[DataMember(Name="PaymentPeriod", EmitDefaultValue=false)]
		public StringValue PaymentPeriod { get; set; }

		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue PaymentRef { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

	}
}