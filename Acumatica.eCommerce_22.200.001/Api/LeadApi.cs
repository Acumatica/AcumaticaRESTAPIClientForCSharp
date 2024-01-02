using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_22_200_001.Model;

namespace Acumatica.eCommerce_22_200_001.Api
{
	public class LeadApi : BaseEndpointApi<Lead>
	{
		public LeadApi(ApiClient client) : base(client)
		{ }
	}
}