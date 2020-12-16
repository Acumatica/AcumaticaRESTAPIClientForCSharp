using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class PaymentApplicationHistoryDetail : Entity_v4
	{

		[DataMember(Name="AdjustedDocType", EmitDefaultValue=false)]
		public StringValue AdjustedDocType { get; set; }

		[DataMember(Name="AdjustedRefNbr", EmitDefaultValue=false)]
		public StringValue AdjustedRefNbr { get; set; }

		[DataMember(Name="AdjustingDocType", EmitDefaultValue=false)]
		public StringValue AdjustingDocType { get; set; }

		[DataMember(Name="AdjustingRefNbr", EmitDefaultValue=false)]
		public StringValue AdjustingRefNbr { get; set; }

		[DataMember(Name="AdjustmentNbr", EmitDefaultValue=false)]
		public IntValue AdjustmentNbr { get; set; }

		[DataMember(Name="AdjustsVAT", EmitDefaultValue=false)]
		public BooleanValue AdjustsVAT { get; set; }

		[DataMember(Name="AmountPaid", EmitDefaultValue=false)]
		public DecimalValue AmountPaid { get; set; }

		[DataMember(Name="ApplicationPeriod", EmitDefaultValue=false)]
		public StringValue ApplicationPeriod { get; set; }

		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue Balance { get; set; }

		[DataMember(Name="BalanceWriteOff", EmitDefaultValue=false)]
		public DecimalValue BalanceWriteOff { get; set; }

		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue BatchNbr { get; set; }

		[DataMember(Name="CashDiscountBalance", EmitDefaultValue=false)]
		public DecimalValue CashDiscountBalance { get; set; }

		[DataMember(Name="CashDiscountDate", EmitDefaultValue=false)]
		public DateTimeValue CashDiscountDate { get; set; }

		[DataMember(Name="CashDiscountTaken", EmitDefaultValue=false)]
		public DecimalValue CashDiscountTaken { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue CustomerOrder { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DisplayDocType", EmitDefaultValue=false)]
		public StringValue DisplayDocType { get; set; }

		[DataMember(Name="DisplayRefNbr", EmitDefaultValue=false)]
		public StringValue DisplayRefNbr { get; set; }

		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue DueDate { get; set; }

		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue PostPeriod { get; set; }

		[DataMember(Name="VATCreditMemo", EmitDefaultValue=false)]
		public StringValue VATCreditMemo { get; set; }

	}
}