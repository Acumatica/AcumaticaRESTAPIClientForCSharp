using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_18_200_001.Model;

namespace Acumatica.Default_18_200_001.Api
{
	public class ShipViaFreightRateApi : EntityAPI<ShipViaFreightRate>
	{
		public ShipViaFreightRateApi(Configuration configuration) : base(configuration)
		{ }
	}
}