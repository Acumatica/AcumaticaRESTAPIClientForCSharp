using System;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_23_200_001.Model;

namespace Acumatica.eCommerce_23_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class InventoryAdjustmentApi : BaseEndpointApi<InventoryAdjustment>
	{
		public InventoryAdjustmentApi(ApiClient client) : base(client)
		{ }
	}
}