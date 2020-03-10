using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.POS_17_200_001.Model;

namespace Acumatica.POS_17_200_001.Api
{
	public partial class OpportunityDetailApi : EntityAPI<OpportunityDetail>
	{
		public OpportunityDetailApi(Configuration configuration) : base(configuration)
		{ }
	}
}