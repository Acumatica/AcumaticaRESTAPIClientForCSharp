using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ProjectTaskDefaultValues : Entity
	{

		public StringValue? AccrualAccount { get; set; }

		public StringValue? AccrualSubaccount { get; set; }

		public StringValue? DefaultAccount { get; set; }

		public StringValue? DefaultSubaccount { get; set; }

		public StringValue? DefaultCostAccount { get; set; }

		public StringValue? DefaultCostSubaccount { get; set; }

		public StringValue? TaxCategory { get; set; }

	}
}