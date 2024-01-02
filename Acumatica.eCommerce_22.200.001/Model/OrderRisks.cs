using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class OrderRisks : Entity
	{

		[DataMember(Name="Message", EmitDefaultValue=false)]
		public StringValue? Message { get; set; }

		[DataMember(Name="Recommendation", EmitDefaultValue=false)]
		public StringValue? Recommendation { get; set; }

		[DataMember(Name="Score", EmitDefaultValue=false)]
		public DecimalValue? Score { get; set; }

	}
}