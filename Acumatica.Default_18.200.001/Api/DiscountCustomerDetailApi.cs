using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_18_200_001.Model;

namespace Acumatica.Default_18_200_001.Api
{
	public class DiscountCustomerDetailApi : EntityAPI<DiscountCustomerDetail>
	{
		public DiscountCustomerDetailApi(Configuration configuration) : base(configuration)
		{ }
	}
}