using System;
using Acumatica.RESTClient.Client;
using Acumatica.eCommerce_26_200_001.Model;

namespace Acumatica.eCommerce_26_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class ProjectMaterialsApi : BaseEndpointApi<ProjectMaterials>
	{
		public ProjectMaterialsApi(ApiClient client) : base(client)
		{ }
	}
}