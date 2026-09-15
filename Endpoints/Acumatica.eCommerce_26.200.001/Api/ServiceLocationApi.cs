using System;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_26_200_001.Model;

namespace Acumatica.eCommerce_26_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class ServiceLocationApi : BaseEndpointApi<ServiceLocation>
	{
		public ServiceLocationApi(ApiClient client) : base(client)
		{ }
	}
}