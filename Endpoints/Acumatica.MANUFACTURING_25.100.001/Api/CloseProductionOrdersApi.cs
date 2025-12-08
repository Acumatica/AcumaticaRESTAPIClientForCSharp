using System;
using Acumatica.RESTClient.Client;
using Acumatica.MANUFACTURING_25_100_001.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Api
{
	[Obsolete("For backward compatibility")]
	public class CloseProductionOrdersApi : BaseEndpointApi<CloseProductionOrders>
	{
		public CloseProductionOrdersApi(ApiClient client) : base(client)
		{ }
	}
}