using System;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_22_200_001.Model;

namespace Acumatica.eCommerce_22_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class ItemClassApi : BaseEndpointApi<ItemClass>
	{
		public ItemClassApi(ApiClient client) : base(client)
		{ }
	}
}