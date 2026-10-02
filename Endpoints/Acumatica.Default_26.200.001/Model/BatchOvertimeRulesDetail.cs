using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class BatchOvertimeRulesDetail : Entity
	{

		#region Fields
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