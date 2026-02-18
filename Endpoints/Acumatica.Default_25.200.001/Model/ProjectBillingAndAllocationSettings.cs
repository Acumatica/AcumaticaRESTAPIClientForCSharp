using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class ProjectBillingAndAllocationSettings : Entity
	{

		public StringValue? AllocationRule { get; set; }

		public BooleanValue? AutomaticallyReleaseARDocuments { get; set; }

		public StringValue? BillingPeriod { get; set; }

		public StringValue? BillingRule { get; set; }

		public StringValue? Branch { get; set; }

		public BooleanValue? CreateProFormaOnBilling { get; set; }

		public DateTimeValue? LastBillingDate { get; set; }

		public DateTimeValue? NextBillingDate { get; set; }

		public StringValue? RateTable { get; set; }

		public BooleanValue? RunAllocationOnReleaseOfProjectTransactions { get; set; }

		public StringValue? Terms { get; set; }

		public BooleanValue? UseTMRevenueBudgetLimits { get; set; }

		public StringValue? BillingCurrency { get; set; }

	}
}