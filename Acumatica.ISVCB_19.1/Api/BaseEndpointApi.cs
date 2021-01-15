using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.Model;

namespace Acumatica.ISVCB_19_1.Api
{
	public abstract class BaseEndpointApi<EntityType> : EntityAPI<EntityType>
		where EntityType : Entity
	{
		public BaseEndpointApi(Configuration configuration) : base(configuration)
		{ }
		public override string GetEndpointPath()
		{
			return "entity/ISVCB/19.1";
		}
	}
}