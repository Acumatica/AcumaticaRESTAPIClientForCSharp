using System;
using Acumatica.RESTClient.Client;
using Acumatica.Default_24_200_001.Model;

namespace Acumatica.Default_24_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class ServiceOrderApi : BaseEndpointApi<ServiceOrder>
	{
		public ServiceOrderApi(ApiClient client) : base(client)
		{ }
	}
}