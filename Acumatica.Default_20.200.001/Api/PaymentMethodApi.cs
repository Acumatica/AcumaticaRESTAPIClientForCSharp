using Acumatica.RESTClient.Client;
using Acumatica.Default_20_200_001.Model;

namespace Acumatica.Default_20_200_001.Api
{
	public class PaymentMethodApi : BaseEndpointApi<PaymentMethod>
	{
		public PaymentMethodApi(ApiClient client) : base(client)
		{ }
	}
}