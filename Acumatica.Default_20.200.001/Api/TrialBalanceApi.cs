using Acumatica.RESTClient.Client;
using Acumatica.Default_20_200_001.Model;

namespace Acumatica.Default_20_200_001.Api
{
	public class TrialBalanceApi : BaseEndpointApi<TrialBalance>
	{
		public TrialBalanceApi(ApiClient client) : base(client)
		{ }
	}
}