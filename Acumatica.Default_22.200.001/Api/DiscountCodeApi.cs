using Acumatica.RESTClient.Client;
using Acumatica.Default_22_200_001.Model;

namespace Acumatica.Default_22_200_001.Api
{
	public class DiscountCodeApi : BaseEndpointApi<DiscountCode>
	{
		public DiscountCodeApi(ApiClient client) : base(client)
		{ }
	}
}