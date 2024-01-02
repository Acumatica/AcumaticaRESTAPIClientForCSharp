using Acumatica.RESTClient.Client;
using Acumatica.GLConsolidation_22_200_001.Model;

namespace Acumatica.GLConsolidation_22_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class ConsolAccountApi : BaseEndpointApi<ConsolAccount>
	{
		public ConsolAccountApi(ApiClient client) : base(client)
		{ }
	}
}