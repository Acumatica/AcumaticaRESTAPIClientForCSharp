using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_20_200_001.Model;

namespace Acumatica.eCommerce_20_200_001.Api
{
	public class ItemImagesApi : BaseEndpointApi<ItemImages>
	{
		public ItemImagesApi(Configuration configuration) : base(configuration)
		{ }
	}
}