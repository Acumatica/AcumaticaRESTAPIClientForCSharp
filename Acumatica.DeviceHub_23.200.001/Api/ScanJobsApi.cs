using System;
using Acumatica.RESTClient.Client;
using Acumatica.DeviceHub_23_200_001.Model;

namespace Acumatica.DeviceHub_23_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class ScanJobsApi : BaseEndpointApi<ScanJobs>
	{
		public ScanJobsApi(ApiClient client) : base(client)
		{ }
	}
}