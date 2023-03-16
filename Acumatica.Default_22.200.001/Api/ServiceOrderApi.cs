using Acumatica.RESTClient.Client;
using Acumatica.Default_22_200_001.Model;

namespace Acumatica.Default_22_200_001.Api
{
	public class ServiceOrderApi : BaseEndpointApi<ServiceOrder>
	{
		public ServiceOrderApi(ApiClient client) : base(client)
		{ }
	}
}