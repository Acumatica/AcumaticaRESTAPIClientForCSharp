using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.GLConsolidation_22_200_001.Model
{
	[DataContract]
	public class ConsolAccount : Entity, ITopLevelEntity
	{

		[DataMember(Name="AccountCD", EmitDefaultValue=false)]
		public StringValue AccountCD { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		public string GetEndpointPath()
		{
			return "entity/GLConsolidation/22.200.001";
		}
	}
}