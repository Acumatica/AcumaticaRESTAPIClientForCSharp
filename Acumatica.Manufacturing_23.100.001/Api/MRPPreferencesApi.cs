using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_23_100_001.Model;

namespace Acumatica.Manufacturing_23_100_001.Api
{
	public class MRPPreferencesApi : BaseEndpointApi<MRPPreferences>
	{
		public MRPPreferencesApi(ApiClient client) : base(client)
		{ }
	}
}