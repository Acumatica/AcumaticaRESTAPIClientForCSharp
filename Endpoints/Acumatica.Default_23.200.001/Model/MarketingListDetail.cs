using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class MarketingListDetail : Entity
	{

		public IntValue? ContactID { get; set; }

		public BooleanValue? DynamicList { get; set; }

		public StringValue? Format { get; set; }

		public StringValue? ListName { get; set; }

		public IntValue? MarketingListID { get; set; }

		public BooleanValue? Subscribed { get; set; }

	}
}