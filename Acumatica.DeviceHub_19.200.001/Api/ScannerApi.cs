using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.DeviceHub_19_200_001.Model;

namespace Acumatica.DeviceHub_19_200_001.Api
{
	public class ScannerApi : BaseEndpointApi<Scanner>
	{
		public ScannerApi(Session session) : base(session)
		{ }
	}
}