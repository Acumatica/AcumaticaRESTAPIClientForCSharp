using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_21_200_001.Model;

namespace Acumatica.Manufacturing_21_200_001.Api
{
	public class ProductionPreferencesApi : BaseEndpointApi<ProductionPreferences>
	{
		public ProductionPreferencesApi(ApiClient client) : base(client)
		{ }
	}
}