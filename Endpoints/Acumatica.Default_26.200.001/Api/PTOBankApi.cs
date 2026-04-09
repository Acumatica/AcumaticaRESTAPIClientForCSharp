using System;
using Acumatica.RESTClient.Client;
using Acumatica.Default_26_200_001.Model;

namespace Acumatica.Default_26_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class PTOBankApi : BaseEndpointApi<PTOBank>
	{
		public PTOBankApi(ApiClient client) : base(client)
		{ }
	}
}