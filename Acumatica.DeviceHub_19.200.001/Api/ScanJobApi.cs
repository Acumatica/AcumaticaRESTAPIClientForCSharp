using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.DeviceHub_19_200_001.Model;

namespace Acumatica.DeviceHub_19_200_001.Api
{
	public class ScanJobApi : EntityAPI<ScanJob>
	{
		public ScanJobApi(Configuration configuration) : base(configuration)
		{ }
	}
}