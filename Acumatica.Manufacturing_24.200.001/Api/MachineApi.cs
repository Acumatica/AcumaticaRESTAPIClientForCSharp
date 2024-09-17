using System;
using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_24_200_001.Model;

namespace Acumatica.Manufacturing_24_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class MachineApi : BaseEndpointApi<Machine>
	{
		public MachineApi(ApiClient client) : base(client)
		{ }
	}
}