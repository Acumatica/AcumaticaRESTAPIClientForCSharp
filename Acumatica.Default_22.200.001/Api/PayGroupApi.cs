using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_22_200_001.Model;

namespace Acumatica.Default_22_200_001.Api
{
	public class PayGroupApi : BaseEndpointApi<PayGroup>
	{
		public PayGroupApi(ApiClient client) : base(client)
		{ }
	}
}