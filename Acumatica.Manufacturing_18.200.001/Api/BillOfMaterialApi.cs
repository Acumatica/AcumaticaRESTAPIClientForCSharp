using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_18_200_001.Model;

namespace Acumatica.Manufacturing_18_200_001.Api
{
	public class BillOfMaterialApi : BaseEndpointApi<BillOfMaterial>
	{
		public BillOfMaterialApi(Configuration configuration) : base(configuration)
		{ }
	}
}