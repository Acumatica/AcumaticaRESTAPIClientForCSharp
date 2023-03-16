using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_20_200_001.Model;

namespace Acumatica.Manufacturing_20_200_001.Api
{
	public class MRPExceptionApi : BaseEndpointApi<MRPException>
	{
		public MRPExceptionApi(ApiClient client) : base(client)
		{ }
	}
}