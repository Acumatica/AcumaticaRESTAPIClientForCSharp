using System;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_23_200_001.Model;

namespace Acumatica.Manufacturing_23_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class APSMaintenanceApi : BaseEndpointApi<APSMaintenance>
	{
		public APSMaintenanceApi(ApiClient client) : base(client)
		{ }
	}
}