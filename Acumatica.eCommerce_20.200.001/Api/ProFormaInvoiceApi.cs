using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_20_200_001.Model;

namespace Acumatica.eCommerce_20_200_001.Api
{
	public class ProFormaInvoiceApi : BaseEndpointApi<ProFormaInvoice>
	{
		public ProFormaInvoiceApi(Configuration configuration) : base(configuration)
		{ }
	}
}