using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class BatchOvertimeRulesDetail : Entity
	{

		public StringValue? DayofWeek { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? DisbursingEarningType { get; set; }

		public BooleanValue? Enabled { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public DecimalValue? Multiplier { get; set; }

		public StringValue? OvertimeRule { get; set; }

		public StringValue? Project { get; set; }

		public StringValue? State { get; set; }

		public DecimalValue? ThresholdforOvertimehours { get; set; }

		public StringValue? Type { get; set; }

		public StringValue? UnionLocal { get; set; }

	}
}