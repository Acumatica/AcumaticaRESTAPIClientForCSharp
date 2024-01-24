using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class CreditVerificationRules : Entity
	{

		[DataMember(Name="CreditDaysPastDue", EmitDefaultValue=false)]
		public ShortValue? CreditDaysPastDue { get; set; }

		[DataMember(Name="CreditLimit", EmitDefaultValue=false)]
		public DecimalValue? CreditLimit { get; set; }

		[DataMember(Name="CreditVerification", EmitDefaultValue=false)]
		public StringValue? CreditVerification { get; set; }

		[DataMember(Name="FirstDueDate", EmitDefaultValue=false)]
		public DateTimeValue? FirstDueDate { get; set; }

		[DataMember(Name="OpenOrdersBalance", EmitDefaultValue=false)]
		public DecimalValue? OpenOrdersBalance { get; set; }

		[DataMember(Name="RemainingCreditLimit", EmitDefaultValue=false)]
		public DecimalValue? RemainingCreditLimit { get; set; }

		[DataMember(Name="UnreleasedBalance", EmitDefaultValue=false)]
		public DecimalValue? UnreleasedBalance { get; set; }

	}
}