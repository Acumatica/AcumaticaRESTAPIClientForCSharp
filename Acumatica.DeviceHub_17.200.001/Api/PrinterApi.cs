using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.DeviceHub_17_200_001.Model;

namespace Acumatica.DeviceHub_17_200_001.Api
{
	public partial class PrinterApi : EntityAPI<Printer>
	{
		public PrinterApi(Configuration configuration) : base(configuration)
		{ }
	}
}