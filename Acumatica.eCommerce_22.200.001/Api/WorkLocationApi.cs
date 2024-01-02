using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_22_200_001.Model;

namespace Acumatica.eCommerce_22_200_001.Api
{
	public class WorkLocationApi : BaseEndpointApi<WorkLocation>
	{
		public WorkLocationApi(ApiClient client) : base(client)
		{ }
	}
}