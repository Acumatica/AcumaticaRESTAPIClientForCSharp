using Acumatica.RESTClient.Client;
using Acumatica.Default_20_200_001.Model;

namespace Acumatica.Default_20_200_001.Api
{
	public class ContactApi : BaseEndpointApi<Contact>
	{
		public ContactApi(ApiClient client) : base(client)
		{ }
	}
}