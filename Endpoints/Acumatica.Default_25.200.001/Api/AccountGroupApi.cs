using System;
using Acumatica.RESTClient.Client;
using Acumatica.Default_25_200_001.Model;

namespace Acumatica.Default_25_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class AccountGroupApi : BaseEndpointApi<AccountGroup>
	{
		public AccountGroupApi(ApiClient client) : base(client)
		{ }
	}
}