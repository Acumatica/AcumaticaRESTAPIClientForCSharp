using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class PaymentMethodAllowedCashAccountDetail : Entity_v4
	{

		[DataMember(Name="APDefault", EmitDefaultValue=false)]
		public BooleanValue APDefault { get; set; }

		[DataMember(Name="APLastRefNbr", EmitDefaultValue=false)]
		public StringValue APLastRefNbr { get; set; }

		[DataMember(Name="APSuggestNextNbr", EmitDefaultValue=false)]
		public BooleanValue APSuggestNextNbr { get; set; }

		[DataMember(Name="ARDefault", EmitDefaultValue=false)]
		public BooleanValue ARDefault { get; set; }

		[DataMember(Name="ARDefaultForRefund", EmitDefaultValue=false)]
		public BooleanValue ARDefaultForRefund { get; set; }

		[DataMember(Name="ARLastRefNbr", EmitDefaultValue=false)]
		public StringValue ARLastRefNbr { get; set; }

		[DataMember(Name="ARSuggestNextNbr", EmitDefaultValue=false)]
		public BooleanValue ARSuggestNextNbr { get; set; }

		[DataMember(Name="BatchLastRefNbr", EmitDefaultValue=false)]
		public StringValue BatchLastRefNbr { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue CashAccount { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue PaymentMethod { get; set; }

		[DataMember(Name="UseInAP", EmitDefaultValue=false)]
		public BooleanValue UseInAP { get; set; }

		[DataMember(Name="UseInAR", EmitDefaultValue=false)]
		public BooleanValue UseInAR { get; set; }

	}
}