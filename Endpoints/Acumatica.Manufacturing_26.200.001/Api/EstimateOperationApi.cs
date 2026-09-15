using System;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_26_200_001.Model;

namespace Acumatica.Manufacturing_26_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class EstimateOperationApi : BaseEndpointApi<EstimateOperation>
	{
		public EstimateOperationApi(ApiClient client) : base(client)
		{ }
	}
}