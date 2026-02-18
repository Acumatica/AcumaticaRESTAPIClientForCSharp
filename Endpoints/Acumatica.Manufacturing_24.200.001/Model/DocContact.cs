using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	public class DocContact : Entity
	{

		public StringValue? Attention { get; set; }

		public StringValue? CompanyName { get; set; }

		public StringValue? Email { get; set; }

		public StringValue? Phone1 { get; set; }

	}
}