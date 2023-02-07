using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_20_200_001.Model;

namespace Acumatica.Manufacturing_20_200_001.Api
{
	public class EstimateOperationApi : BaseEndpointApi<EstimateOperation>
	{
		public EstimateOperationApi(Session session) : base(session)
		{ }
	}
}