using Acumatica.RESTClient.Client;
using Acumatica.Default_22_200_001.Model;

namespace Acumatica.Default_22_200_001.Api
{
	public class WorkLocationApi : BaseEndpointApi<WorkLocation>
	{
		public WorkLocationApi(ApiClient client) : base(client)
		{ }
	}
}