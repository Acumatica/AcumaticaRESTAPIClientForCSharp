using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_18_200_001.Model;

namespace Acumatica.Manufacturing_18_200_001.Api
{
	public class MoveEntryApi : BaseEndpointApi<MoveEntry>
	{
		public MoveEntryApi(Configuration configuration) : base(configuration)
		{ }
	}
}