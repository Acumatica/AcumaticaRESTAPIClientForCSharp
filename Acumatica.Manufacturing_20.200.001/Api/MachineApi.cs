using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_20_200_001.Model;

namespace Acumatica.Manufacturing_20_200_001.Api
{
	public class MachineApi : BaseEndpointApi<Machine>
	{
		public MachineApi(ApiClient client) : base(client)
		{ }
	}
}