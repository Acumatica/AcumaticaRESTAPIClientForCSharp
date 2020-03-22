using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class JournalVoucher : Entity
	{

		[DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
		public StringValue BaseCurrencyID { get; set; }

		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue BatchNbr { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="ControlTotal", EmitDefaultValue=false)]
		public DecimalValue ControlTotal { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="CreditTotal", EmitDefaultValue=false)]
		public DecimalValue CreditTotal { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
		public DecimalValue CurrencyRate { get; set; }

		[DataMember(Name="CurrencyRateTypeID", EmitDefaultValue=false)]
		public StringValue CurrencyRateTypeID { get; set; }

		[DataMember(Name="DebitTotal", EmitDefaultValue=false)]
		public DecimalValue DebitTotal { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<JournalVoucherDetail> Details { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue EffectiveDate { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="GLTransactions", EmitDefaultValue=false)]
		public List<JournalVoucherGLTransaction> GLTransactions { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue Ledger { get; set; }

		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue PostPeriod { get; set; }

		[DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
		public DecimalValue ReciprocalRate { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue TransactionDate { get; set; }

	}
}