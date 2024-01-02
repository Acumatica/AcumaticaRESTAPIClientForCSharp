using Acumatica.RESTClient.Client;
using Acumatica.Default_22_200_001.Model;

namespace Acumatica.Default_22_200_001.Api
{
	public class TaxCategoryApi : BaseEndpointApi<TaxCategory>
	{
		public TaxCategoryApi(ApiClient client) : base(client)
		{ }
	}
}