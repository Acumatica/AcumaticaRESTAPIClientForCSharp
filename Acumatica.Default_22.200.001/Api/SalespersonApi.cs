using Acumatica.RESTClient.Client;
using Acumatica.Default_22_200_001.Model;

namespace Acumatica.Default_22_200_001.Api
{
	public class SalespersonApi : BaseEndpointApi<Salesperson>
	{
		public SalespersonApi(ApiClient client) : base(client)
		{ }
	}
}