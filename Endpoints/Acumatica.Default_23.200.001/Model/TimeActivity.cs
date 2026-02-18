using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class TimeActivity : Entity
	{

		public StringValue? Approver { get; set; }

		public BooleanValue? Billable { get; set; }

		public StringValue? BillableOvertime { get; set; }

		public StringValue? BillableTime { get; set; }

		public StringValue? CostCode { get; set; }

		public StringValue? EarningType { get; set; }

		public StringValue? Overtime { get; set; }

		public StringValue? Project { get; set; }

		public StringValue? ProjectTask { get; set; }

		public StringValue? ReferenceNbr { get; set; }

		public BooleanValue? Released { get; set; }

		public StringValue? Status { get; set; }

		public StringValue? TimeSpent { get; set; }

		public BooleanValue? TrackTime { get; set; }

	}
}