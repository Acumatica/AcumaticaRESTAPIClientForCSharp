using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_22_200_001.Model;

namespace Acumatica.eCommerce_22_200_001.Api
{
	public class CustomerLocationApi : BaseEndpointApi<CustomerLocation>
	{
		public CustomerLocationApi(ApiClient client) : base(client)
		{ }
	}
}