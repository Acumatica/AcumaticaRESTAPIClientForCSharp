using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_22_200_001.Model;

namespace Acumatica.Default_22_200_001.Api
{
	public class ProjectTransactionApi : BaseEndpointApi<ProjectTransaction>
	{
		public ProjectTransactionApi(Configuration configuration) : base(configuration)
		{ }
	}
}