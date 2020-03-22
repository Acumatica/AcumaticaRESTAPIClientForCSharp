using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class Payments : Entity
	{

		[DataMember(Name="AppliedToOrder", EmitDefaultValue=false)]
		public DecimalValue AppliedToOrder { get; set; }

		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue Balance { get; set; }

		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue CashAccount { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue CurrencyID { get; set; }

		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue DocType { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue OrderNbr { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

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

		[DataMember(Name="TransferredtoInvoice", EmitDefaultValue=false)]
		public DecimalValue TransferredtoInvoice { get; set; }

	}
}