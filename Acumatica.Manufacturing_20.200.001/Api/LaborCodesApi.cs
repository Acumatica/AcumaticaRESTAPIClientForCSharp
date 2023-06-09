using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_20_200_001.Model;

namespace Acumatica.Manufacturing_20_200_001.Api
{
	public class LaborCodesApi : BaseEndpointApi<LaborCodes>
	{
		public LaborCodesApi(ApiClient client) : base(client)
		{ }
	}
}