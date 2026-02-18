using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class CampaignDetail : Entity
	{

		public StringValue? CampaignID { get; set; }

		public StringValue? CampaignName { get; set; }

		public IntValue? ContactID { get; set; }

		public StringValue? Stage { get; set; }

	}
}