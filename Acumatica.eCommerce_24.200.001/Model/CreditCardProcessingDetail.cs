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
	public class CreditCardProcessingDetail : Entity
	{

		[DataMember(Name="TransactionAmount", EmitDefaultValue=false)]
		public DecimalValue? TransactionAmount { get; set; }

		[DataMember(Name="TransactionStatus", EmitDefaultValue=false)]
		public StringValue? TransactionStatus { get; set; }

	}
}