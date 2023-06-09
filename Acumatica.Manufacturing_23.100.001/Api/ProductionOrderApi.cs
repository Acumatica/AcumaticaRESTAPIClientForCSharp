using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_23_100_001.Model;

namespace Acumatica.Manufacturing_23_100_001.Api
{
	public class ProductionOrderApi : BaseEndpointApi<ProductionOrder>
	{
		public ProductionOrderApi(ApiClient client) : base(client)
		{ }
	}
}