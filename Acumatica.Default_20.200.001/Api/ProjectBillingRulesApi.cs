using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.Default_20_200_001.Model;

namespace Acumatica.Default_20_200_001.Api
{
	public class ProjectBillingRulesApi : EntityAPI<ProjectBillingRules>
	{
		public ProjectBillingRulesApi(Configuration configuration) : base(configuration)
		{ }
	}
}