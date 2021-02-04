using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_20_200_001.Model;

namespace Acumatica.Manufacturing_20_200_001.Api
{
	public class CostRollHistoryApi : BaseEndpointApi<CostRollHistory>
	{
		public CostRollHistoryApi(Configuration configuration) : base(configuration)
		{ }
	}
}