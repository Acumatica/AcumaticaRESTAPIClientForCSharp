using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class ProjectActivity : Entity
	{

		public BooleanValue? Billable { get; set; }

		public StringValue? BillableOvertime { get; set; }

		public StringValue? BillableTime { get; set; }

		public StringValue? Category { get; set; }

		public StringValue? Overtime { get; set; }

		public StringValue? Owner { get; set; }

		public DateTimeValue? StartDate { get; set; }

		public StringValue? Status { get; set; }

		public StringValue? Summary { get; set; }

		public StringValue? TimeSpent { get; set; }

		public StringValue? Type { get; set; }

		public StringValue? Workgroup { get; set; }

	}
}