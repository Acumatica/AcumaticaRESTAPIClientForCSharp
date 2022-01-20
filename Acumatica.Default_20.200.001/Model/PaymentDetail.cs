using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class PaymentDetail : Entity_v4
	{

		[DataMember(Name="AmountPaid", EmitDefaultValue=false)]
		public DecimalValue AmountPaid { get; set; }

		[DataMember(Name="BalanceWriteOff", EmitDefaultValue=false)]
		public DecimalValue BalanceWriteOff { get; set; }

		[DataMember(Name="CashDiscountTaken", EmitDefaultValue=false)]
		public DecimalValue CashDiscountTaken { get; set; }

		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue CustomerOrder { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DocLineNbr", EmitDefaultValue=false)]
		public IntValue DocLineNbr { get; set; }

		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue DocType { get; set; }

		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue ReferenceNbr { get; set; }

		[DataMember(Name="WriteOffReasonCode", EmitDefaultValue=false)]
		public StringValue WriteOffReasonCode { get; set; }

	}
}