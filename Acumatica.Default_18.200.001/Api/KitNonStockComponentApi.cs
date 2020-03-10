using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_18_200_001.Model;

namespace Acumatica.Default_18_200_001.Api
{
	public partial class KitNonStockComponentApi : EntityAPI<KitNonStockComponent>
	{
		public KitNonStockComponentApi(Configuration configuration) : base(configuration)
		{ }
	}
}