using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_22_200_001.Model;

namespace Acumatica.eCommerce_22_200_001.Api
{
	public class NonStockItemApi : BaseEndpointApi<NonStockItem>
	{
		public NonStockItemApi(ApiClient client) : base(client)
		{ }
	}
}