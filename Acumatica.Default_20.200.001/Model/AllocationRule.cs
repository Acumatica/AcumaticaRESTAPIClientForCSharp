using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class AllocationRule : Entity, ITopLevelEntity
	{

		[DataMember(Name="AllocationRuleID", EmitDefaultValue=false)]
		public StringValue AllocationRuleID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		public string GetEndpointPath()
		{
			return "entity/Default/20.200.001";
		}
	}
}