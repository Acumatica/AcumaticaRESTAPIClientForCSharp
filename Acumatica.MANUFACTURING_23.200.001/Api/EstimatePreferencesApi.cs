using System;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_23_200_001.Model;

namespace Acumatica.Manufacturing_23_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class EstimatePreferencesApi : BaseEndpointApi<EstimatePreferences>
	{
		public EstimatePreferencesApi(ApiClient client) : base(client)
		{ }
	}
}