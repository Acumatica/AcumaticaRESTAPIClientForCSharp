using System;
using Acumatica.RESTClient.Client;
using Acumatica.ISVCB_23_200_001.Model;

namespace Acumatica.ISVCB_23_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class PurchaseOrderApi : BaseEndpointApi<PurchaseOrder>
	{
		public PurchaseOrderApi(ApiClient client) : base(client)
		{ }
	}
}