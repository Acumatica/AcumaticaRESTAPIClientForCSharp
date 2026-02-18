using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class ProjectTaskBillingAndAllocationSettings : Entity
	{

		public StringValue? AllocationRule { get; set; }

		public StringValue? BillingOption { get; set; }

		public StringValue? BillingRule { get; set; }

		public BooleanValue? BillSeparately { get; set; }

		public StringValue? Branch { get; set; }

		public StringValue? Customer { get; set; }

		public StringValue? Location { get; set; }

		public StringValue? RateTable { get; set; }

		public StringValue? WIPAccountGroup { get; set; }

	}
}