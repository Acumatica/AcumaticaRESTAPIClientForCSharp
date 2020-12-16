using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CreditCardTransactionDetail : Entity_v4
	{

		[DataMember(Name="TranNbr", EmitDefaultValue=false)]
		public StringValue TranNbr { get; set; }

		[DataMember(Name="TranType", EmitDefaultValue=false)]
		public StringValue TranType { get; set; }

		[DataMember(Name="AuthNbr", EmitDefaultValue=false)]
		public StringValue AuthNbr { get; set; }

		[DataMember(Name="TranDate", EmitDefaultValue=false)]
		public DateTimeValue TranDate { get; set; }

		[DataMember(Name="ExtProfileId", EmitDefaultValue=false)]
		public StringValue ExtProfileId { get; set; }

		[DataMember(Name="NeedValidation", EmitDefaultValue=false)]
		public BooleanValue NeedValidation { get; set; }

	}
}