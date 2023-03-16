using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Api
{
	public abstract class BaseEndpointApi<EntityType> : EntityAPI<EntityType>
		where EntityType : Entity
	{
		public BaseEndpointApi(ApiClient client) : base(client)
		{ }
		public override string GetEndpointPath()
		{
			return "entity/Default/20.200.001";
		}
	}
}