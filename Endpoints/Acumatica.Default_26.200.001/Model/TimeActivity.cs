using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class TimeActivity : Entity
	{

		#region Fields
		public StringValue? Approver { get; set; }

		public BooleanValue? Billable { get; set; }

		public IntSingleSelectValue? BillableOvertime { get; set; }

		public IntSingleSelectValue? BillableTime { get; set; }

		public StringValue? CostCode { get; set; }

		public StringValue? EarningType { get; set; }

		public IntSingleSelectValue? Overtime { get; set; }

		public StringValue? Project { get; set; }

		public StringValue? ProjectTask { get; set; }

		public StringValue? ReferenceNbr { get; set; }

		public BooleanValue? Released { get; set; }

		public StringSingleSelectValue? Status { get; set; }

		public IntSingleSelectValue? TimeSpent { get; set; }

		public BooleanValue? TrackTime { get; set; }

		#endregion

	}
}