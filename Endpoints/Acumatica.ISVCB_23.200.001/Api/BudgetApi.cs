using System;
using Acumatica.RESTClient.Client;
using Acumatica.ISVCB_23_200_001.Model;

namespace Acumatica.ISVCB_23_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class BudgetApi : BaseEndpointApi<Budget>
	{
		public BudgetApi(ApiClient client) : base(client)
		{ }
	}
}