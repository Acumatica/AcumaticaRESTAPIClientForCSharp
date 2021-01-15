using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Model;

namespace Acumatica.Default_20_200_001.Api
{
	public abstract class BaseEndpointApi<EntityType> : EntityAPI<EntityType>
		where EntityType : Entity
	{
		public BaseEndpointApi(Configuration configuration) : base(configuration)
		{ }
		public override string GetEndpointPath()
		{
			return "entity/Default/20.200.001";
		}
	}
}