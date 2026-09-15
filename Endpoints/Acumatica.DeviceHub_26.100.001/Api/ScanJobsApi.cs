using System;
using Acumatica.RESTClient.Client;
using Acumatica.DeviceHub_26_100_001.Model;

namespace Acumatica.DeviceHub_26_100_001.Api
{
	[Obsolete("For backward compatibility")]
	public class ScanJobsApi : BaseEndpointApi<ScanJobs>
	{
		public ScanJobsApi(ApiClient client) : base(client)
		{ }
	}
}