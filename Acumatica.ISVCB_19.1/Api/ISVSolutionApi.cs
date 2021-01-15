using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.ISVCB_19_1.Model;

namespace Acumatica.ISVCB_19_1.Api
{
	public class ISVSolutionApi : BaseEndpointApi<ISVSolution>
	{
		public ISVSolutionApi(Configuration configuration) : base(configuration)
		{ }
	}
}