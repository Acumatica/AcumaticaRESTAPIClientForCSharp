using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_20_200_001.Model;

namespace Acumatica.eCommerce_20_200_001.Api
{
	public class PaymentMethodApi : BaseEndpointApi<PaymentMethod>
	{
		public PaymentMethodApi(ApiClient client) : base(client)
		{ }
	}
}