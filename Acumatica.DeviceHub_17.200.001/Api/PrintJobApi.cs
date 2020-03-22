using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.DeviceHub_17_200_001.Model;

namespace Acumatica.DeviceHub_17_200_001.Api
{
	public class PrintJobApi : EntityAPI<PrintJob>
	{
		public PrintJobApi(Configuration configuration) : base(configuration)
		{ }
	}
}