using System;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_20_200_001.Model;

namespace Acumatica.eCommerce_20_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class SubaccountApi : BaseEndpointApi<Subaccount>
	{
		public SubaccountApi(ApiClient client) : base(client)
		{ }
	}
}