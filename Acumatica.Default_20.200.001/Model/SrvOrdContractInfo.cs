using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SrvOrdContractInfo : Entity_v4
	{

		[DataMember(Name="ContractPeriod", EmitDefaultValue=false)]
		public StringValue ContractPeriod { get; set; }

		[DataMember(Name="ServiceContract", EmitDefaultValue=false)]
		public StringValue ServiceContract { get; set; }

	}
}