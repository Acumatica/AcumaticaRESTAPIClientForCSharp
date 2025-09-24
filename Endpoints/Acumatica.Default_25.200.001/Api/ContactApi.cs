using System;
using Acumatica.RESTClient.Client;
using Acumatica.Default_25_200_001.Model;

namespace Acumatica.Default_25_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class ContactApi : BaseEndpointApi<Contact>
	{
		public ContactApi(ApiClient client) : base(client)
		{ }
	}
}