using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_22_200_001.Model;

namespace Acumatica.eCommerce_22_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class InventorySummaryInquiryApi : BaseEndpointApi<InventorySummaryInquiry>
	{
		public InventorySummaryInquiryApi(ApiClient client) : base(client)
		{ }
	}
}