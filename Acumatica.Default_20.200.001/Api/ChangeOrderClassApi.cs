using Acumatica.RESTClient.Client;
using Acumatica.Default_20_200_001.Model;

namespace Acumatica.Default_20_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class ChangeOrderClassApi : BaseEndpointApi<ChangeOrderClass>
	{
		public ChangeOrderClassApi(ApiClient client) : base(client)
		{ }
	}
}