using System;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_23_200_001.Model;

namespace Acumatica.eCommerce_23_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class CashTransactionApi : BaseEndpointApi<CashTransaction>
	{
		public CashTransactionApi(ApiClient client) : base(client)
		{ }
	}
}