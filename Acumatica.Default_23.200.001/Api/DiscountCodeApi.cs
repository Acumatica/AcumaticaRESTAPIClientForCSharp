using System;
using Acumatica.RESTClient.Client;
using Acumatica.Default_23_200_001.Model;

namespace Acumatica.Default_23_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class DiscountCodeApi : BaseEndpointApi<DiscountCode>
	{
		public DiscountCodeApi(ApiClient client) : base(client)
		{ }
	}
}