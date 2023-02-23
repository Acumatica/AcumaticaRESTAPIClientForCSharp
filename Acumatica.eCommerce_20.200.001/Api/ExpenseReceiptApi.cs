using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_20_200_001.Model;

namespace Acumatica.eCommerce_20_200_001.Api
{
	public class ExpenseReceiptApi : BaseEndpointApi<ExpenseReceipt>
	{
		public ExpenseReceiptApi(ApiClient client) : base(client)
		{ }
	}
}