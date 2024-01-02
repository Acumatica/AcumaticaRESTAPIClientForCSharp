using Acumatica.RESTClient.Client;
using Acumatica.DeviceHub_23_200_001.Model;
using System;

namespace Acumatica.DeviceHub_23_200_001.Api
{
	[Obsolete]
	public class PrinterApi : BaseEndpointApi<Printer>
	{
		public PrinterApi(ApiClient client) : base(client)
		{ }
	}
}