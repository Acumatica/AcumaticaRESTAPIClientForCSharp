using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class FinancialPeriodDetail : Entity
	{

		public BooleanValue? AdjustmentPeriod { get; set; }

		public BooleanValue? ClosedInAP { get; set; }

		public BooleanValue? ClosedInAR { get; set; }

		public BooleanValue? ClosedInCA { get; set; }

		public BooleanValue? ClosedInFA { get; set; }

		public BooleanValue? ClosedInIN { get; set; }

		public StringValue? Description { get; set; }

		public DateTimeValue? EndDate { get; set; }

		public StringValue? FinancialPeriodID { get; set; }

		public IntValue? LengthInDays { get; set; }

		public StringValue? PeriodNbr { get; set; }

		public DateTimeValue? StartDate { get; set; }

		public StringValue? Status { get; set; }

	}
}