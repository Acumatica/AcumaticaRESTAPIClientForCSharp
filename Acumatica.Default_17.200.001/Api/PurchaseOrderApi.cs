using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_17_200_001.Model;

namespace Acumatica.Default_17_200_001.Api
{
	public partial class PurchaseOrderApi : EntityAPI<PurchaseOrder>
	{
		public PurchaseOrderApi(Configuration configuration) : base(configuration)
		{ }
	}
}