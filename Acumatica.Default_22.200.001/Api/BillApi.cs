using Acumatica.RESTClient.Client;
using Acumatica.Default_22_200_001.Model;

namespace Acumatica.Default_22_200_001.Api
{
	public class BillApi : BaseEndpointApi<Bill>
	{
		public BillApi(ApiClient client) : base(client)
		{ }
	}
}