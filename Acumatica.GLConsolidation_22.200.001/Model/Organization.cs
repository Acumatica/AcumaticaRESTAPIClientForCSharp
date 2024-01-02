using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.GLConsolidation_22_200_001.Model
{
	[DataContract]
	public class Organization : Entity, ITopLevelEntity
	{

		[DataMember(Name="OrganizationName", EmitDefaultValue=false)]
		public StringValue? OrganizationName { get; set; }

		[DataMember(Name="OrganizationCD", EmitDefaultValue=false)]
		public StringValue? OrganizationCD { get; set; }

		[DataMember(Name="LedgerCD", EmitDefaultValue=false)]
		public StringValue? LedgerCD { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/GLConsolidation/22.200.001";
		}
	}
}