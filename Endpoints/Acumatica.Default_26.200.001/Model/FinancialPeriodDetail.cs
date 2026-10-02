using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class FinancialPeriodDetail : Entity
	{

		#region Fields
		public BooleanValue? AdjustmentPeriod { get; set; }

		public BooleanValue? ClosedInAP { get; set; }

		public BooleanValue? ClosedInAR { get; set; }

		public BooleanValue? ClosedInCA { get; set; }

		public BooleanValue? ClosedInFA { get; set; }

		public BooleanValue? ClosedInIN { get; set; }

		public StringValue? Description { get; set; }

		public DateOnlyValue? EndDate { get; set; }

		public StringValue? FinancialPeriodID { get; set; }

		public IntValue? LengthInDays { get; set; }

		public StringValue? PeriodNbr { get; set; }

		public DateOnlyValue? StartDate { get; set; }

		public StringSingleSelectValue? Status { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}