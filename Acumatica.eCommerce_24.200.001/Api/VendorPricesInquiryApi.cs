using System;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_24_200_001.Model;

namespace Acumatica.eCommerce_24_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class VendorPricesInquiryApi : BaseEndpointApi<VendorPricesInquiry>
	{
		public VendorPricesInquiryApi(ApiClient client) : base(client)
		{ }
	}
}