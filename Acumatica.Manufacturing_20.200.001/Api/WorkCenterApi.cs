using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_20_200_001.Model;

namespace Acumatica.Manufacturing_20_200_001.Api
{
	public class WorkCenterApi : BaseEndpointApi<WorkCenter>
	{
		public WorkCenterApi(ApiClient client) : base(client)
		{ }
	}
}