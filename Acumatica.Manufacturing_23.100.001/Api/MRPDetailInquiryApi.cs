using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_23_100_001.Model;

namespace Acumatica.Manufacturing_23_100_001.Api
{
	public class MRPDetailInquiryApi : BaseEndpointApi<MRPDetailInquiry>
	{
		public MRPDetailInquiryApi(ApiClient client) : base(client)
		{ }
	}
}