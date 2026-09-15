using System;
using Acumatica.RESTClient.Client;
using Acumatica.Default_26_200_001.Model;

namespace Acumatica.Default_26_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class WorkTaskApi : BaseEndpointApi<WorkTask>
	{
		public WorkTaskApi(ApiClient client) : base(client)
		{ }
	}
}