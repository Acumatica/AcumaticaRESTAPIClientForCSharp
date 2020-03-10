using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.POS_17_200_001.Model;

namespace Acumatica.POS_17_200_001.Api
{
	public partial class AccountDetailsInquiryApi : EntityAPI<AccountDetailsInquiry>
	{
		public AccountDetailsInquiryApi(Configuration configuration) : base(configuration)
		{ }
	}
}