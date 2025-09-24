using System;
using Acumatica.RESTClient.Client;
using Acumatica.Default_25_200_001.Model;

namespace Acumatica.Default_25_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class AmazonStoreApi : BaseEndpointApi<AmazonStore>
	{
		public AmazonStoreApi(ApiClient client) : base(client)
		{ }
	}
}