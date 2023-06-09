using Acumatica.RESTClient.Client;
using Acumatica.GLConsolidation_22_200_001.Model;

namespace Acumatica.GLConsolidation_22_200_001.Api
{
	public class BranchApi : BaseEndpointApi<Branch>
	{
		public BranchApi(ApiClient client) : base(client)
		{ }
	}
}