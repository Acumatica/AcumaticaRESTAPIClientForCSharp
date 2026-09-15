using System;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_26_200_001.Model;

namespace Acumatica.eCommerce_26_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class WorkTicketApi : BaseEndpointApi<WorkTicket>
	{
		public WorkTicketApi(ApiClient client) : base(client)
		{ }
	}
}