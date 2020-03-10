using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_18_200_001.Model;

namespace Acumatica.Default_18_200_001.Api
{
	public partial class PurchaseOrderDetailApi : EntityAPI<PurchaseOrderDetail>
	{
		public PurchaseOrderDetailApi(Configuration configuration) : base(configuration)
		{ }
	}
}