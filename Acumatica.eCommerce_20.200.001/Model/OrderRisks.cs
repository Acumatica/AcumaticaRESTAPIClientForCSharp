using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class OrderRisks : Entity
	{

		[DataMember(Name="Message", EmitDefaultValue=false)]
		public StringValue Message { get; set; }

		[DataMember(Name="Recommendation", EmitDefaultValue=false)]
		public StringValue Recommendation { get; set; }

		[DataMember(Name="Score", EmitDefaultValue=false)]
		public DecimalValue Score { get; set; }

	}
}