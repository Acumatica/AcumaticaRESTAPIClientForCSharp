using System;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_24_200_001.Model;

namespace Acumatica.eCommerce_24_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class PayrollUnionLocalApi : BaseEndpointApi<PayrollUnionLocal>
	{
		public PayrollUnionLocalApi(ApiClient client) : base(client)
		{ }
	}
}