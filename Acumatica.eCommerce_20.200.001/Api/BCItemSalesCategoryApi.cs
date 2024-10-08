using System;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_20_200_001.Model;

namespace Acumatica.eCommerce_20_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class BCItemSalesCategoryApi : BaseEndpointApi<BCItemSalesCategory>
	{
		public BCItemSalesCategoryApi(ApiClient client) : base(client)
		{ }
	}
}