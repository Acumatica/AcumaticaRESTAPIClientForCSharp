using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_23_100_001.Model;

namespace Acumatica.Manufacturing_23_100_001.Api
{
	public class ConfigurationMaintenanceApi : BaseEndpointApi<ConfigurationMaintenance>
	{
		public ConfigurationMaintenanceApi(ApiClient client) : base(client)
		{ }
	}
}