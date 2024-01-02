using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_22_200_001.Model;

namespace Acumatica.eCommerce_22_200_001.Api
{
	public class SalesInvoiceApi : BaseEndpointApi<SalesInvoice>
	{
		public SalesInvoiceApi(ApiClient client) : base(client)
		{ }
	}
}