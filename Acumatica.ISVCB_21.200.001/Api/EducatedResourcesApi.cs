using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.ISVCB_21_200_001.Model;

namespace Acumatica.ISVCB_21_200_001.Api
{
	public class EducatedResourcesApi : BaseEndpointApi<EducatedResources>
	{
		public EducatedResourcesApi(Session session) : base(session)
		{ }
	}
}