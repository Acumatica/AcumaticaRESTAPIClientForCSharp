using System;
using Acumatica.RESTClient.Client;
using Acumatica.Default_23_200_001.Model;

namespace Acumatica.Default_23_200_001.Api
{
	[Obsolete("For backward compatibility")]
	public class StorageDetailsInquiryApi : BaseEndpointApi<StorageDetailsInquiry>
	{
		public StorageDetailsInquiryApi(ApiClient client) : base(client)
		{ }
	}
}