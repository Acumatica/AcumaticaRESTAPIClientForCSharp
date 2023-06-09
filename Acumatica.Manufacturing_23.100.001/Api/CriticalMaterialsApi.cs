using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_23_100_001.Model;

namespace Acumatica.Manufacturing_23_100_001.Api
{
	public class CriticalMaterialsApi : BaseEndpointApi<CriticalMaterials>
	{
		public CriticalMaterialsApi(ApiClient client) : base(client)
		{ }
	}
}