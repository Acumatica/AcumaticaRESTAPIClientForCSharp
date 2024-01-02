using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_21_200_001.Model;

namespace Acumatica.Manufacturing_21_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class MPSTypeApi : BaseEndpointApi<MPSType>
	{
		public MPSTypeApi(ApiClient client) : base(client)
		{ }
	}
}