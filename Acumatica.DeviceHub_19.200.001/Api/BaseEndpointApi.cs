using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Model;

namespace Acumatica.DeviceHub_19_200_001.Api
{
	public abstract class BaseEndpointApi<EntityType> : EntityAPI<EntityType>
		where EntityType : Entity
	{
		public BaseEndpointApi(Session session) : base(session)
		{ }
		public override string GetEndpointPath()
		{
			return "entity/DeviceHub/19.200.001";
		}
	}
}