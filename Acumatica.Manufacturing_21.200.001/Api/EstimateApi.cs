using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_21_200_001.Model;

namespace Acumatica.Manufacturing_21_200_001.Api
{
	public class EstimateApi : BaseEndpointApi<Estimate>
	{
		public EstimateApi(ApiClient client) : base(client)
		{ }
	}
}