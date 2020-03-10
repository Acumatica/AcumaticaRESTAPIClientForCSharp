using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_17_200_001.Model;

namespace Acumatica.Default_17_200_001.Api
{
	public partial class TotalsApi : EntityAPI<Totals>
	{
		public TotalsApi(Configuration configuration) : base(configuration)
		{ }
	}
}