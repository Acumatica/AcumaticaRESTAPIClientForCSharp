using System;
using Acumatica.RESTClient.Client;
using Acumatica.Default_22_200_001.Model;

namespace Acumatica.Default_22_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class SalesTerritoryApi : BaseEndpointApi<SalesTerritory>
	{
		public SalesTerritoryApi(ApiClient client) : base(client)
		{ }
	}
}