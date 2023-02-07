using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_22_200_001.Model;

namespace Acumatica.Default_22_200_001.Api
{
	public class LedgerApi : BaseEndpointApi<Ledger>
	{
		public LedgerApi(Session session) : base(session)
		{ }
	}
}