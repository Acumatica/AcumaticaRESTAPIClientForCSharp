using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class PaymentMethodAllowedCashAccountDetail : Entity
	{

		[DataMember(Name="APDefault", EmitDefaultValue=false)]
		public BooleanValue? APDefault { get; set; }

		[DataMember(Name="APLastRefNbr", EmitDefaultValue=false)]
		public StringValue? APLastRefNbr { get; set; }

		[DataMember(Name="APSuggestNextNbr", EmitDefaultValue=false)]
		public BooleanValue? APSuggestNextNbr { get; set; }

		[DataMember(Name="ARDefault", EmitDefaultValue=false)]
		public BooleanValue? ARDefault { get; set; }

		[DataMember(Name="ARDefaultForRefund", EmitDefaultValue=false)]
		public BooleanValue? ARDefaultForRefund { get; set; }

		[DataMember(Name="ARLastRefNbr", EmitDefaultValue=false)]
		public StringValue? ARLastRefNbr { get; set; }

		[DataMember(Name="ARSuggestNextNbr", EmitDefaultValue=false)]
		public BooleanValue? ARSuggestNextNbr { get; set; }

		[DataMember(Name="BatchLastRefNbr", EmitDefaultValue=false)]
		public StringValue? BatchLastRefNbr { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		[DataMember(Name="UseInAP", EmitDefaultValue=false)]
		public BooleanValue? UseInAP { get; set; }

		[DataMember(Name="UseInAR", EmitDefaultValue=false)]
		public BooleanValue? UseInAR { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="UseInPR", EmitDefaultValue=false)]
		public BooleanValue? UseInPR { get; set; }

	}
}