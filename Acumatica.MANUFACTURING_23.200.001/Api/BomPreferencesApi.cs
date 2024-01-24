using System;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_23_200_001.Model;

namespace Acumatica.Manufacturing_23_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class BomPreferencesApi : BaseEndpointApi<BomPreferences>
	{
		public BomPreferencesApi(ApiClient client) : base(client)
		{ }
	}
}