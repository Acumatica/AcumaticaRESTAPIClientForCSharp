using System;
using Acumatica.RESTClient.Client;
using Acumatica.Default_25_200_001.Model;

namespace Acumatica.Default_25_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class VendorApi : BaseEndpointApi<Vendor>
	{
		public VendorApi(ApiClient client) : base(client)
		{ }
	}
}