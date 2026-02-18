using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class VisibilitySettings : Entity
	{

		public BooleanValue? AP { get; set; }

		public BooleanValue? AR { get; set; }

		public BooleanValue? CA { get; set; }

		public BooleanValue? CRM { get; set; }

		public BooleanValue? Expenses { get; set; }

		public BooleanValue? GL { get; set; }

		public BooleanValue? IN { get; set; }

		public BooleanValue? PO { get; set; }

		public BooleanValue? SO { get; set; }

		public BooleanValue? TimeEntries { get; set; }

	}
}