using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class JournalVoucherGLTransaction : Entity
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue BatchNbr { get; set; }

		[DataMember(Name="CreditAmount", EmitDefaultValue=false)]
		public DecimalValue CreditAmount { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="DebitAmount", EmitDefaultValue=false)]
		public DecimalValue DebitAmount { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue Module { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue ReferenceNbr { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

		[DataMember(Name="TransactionDate", EmitDefaultValue=false)]
		public DateTimeValue TransactionDate { get; set; }

		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue TransactionDescription { get; set; }

	}
}