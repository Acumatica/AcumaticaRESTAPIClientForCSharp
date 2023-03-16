using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_21_200_001.Model;

namespace Acumatica.Manufacturing_21_200_001.Api
{
	public class EngineeringChangeOrderApi : BaseEndpointApi<EngineeringChangeOrder>
	{
		public EngineeringChangeOrderApi(ApiClient client) : base(client)
		{ }
	}
}