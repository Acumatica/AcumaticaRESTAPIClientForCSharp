using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_22_200_001.Model;

namespace Acumatica.eCommerce_22_200_001.Api
{
	public class VendorApi : BaseEndpointApi<Vendor>
	{
		public VendorApi(ApiClient client) : base(client)
		{ }
	}
}