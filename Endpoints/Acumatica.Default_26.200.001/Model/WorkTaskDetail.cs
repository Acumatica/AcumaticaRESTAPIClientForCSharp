using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class WorkTaskDetail : Entity
	{

		#region Fields
		public IntValue? ActionLineCntr { get; set; }

		public DateTimeValue? CompletedDate { get; set; }

		public StringValue? Description { get; set; }

		public DateOnlyValue? EndDate { get; set; }

		public IntSingleSelectValue? EstimatedDuration { get; set; }

		public IntValue? EventCount { get; set; }

		public IntValue? EventDuration { get; set; }

		public DateTimeValue? EventEndDate { get; set; }

		public DateTimeValue? EventStartDate { get; set; }

		public StringValue? EventStatus { get; set; }

		public StringValue? EventSummary { get; set; }

		public StringValue? HasMoreEvents { get; set; }

		public BooleanValue? IsScheduled { get; set; }

		public IntValue? PercentCompletion { get; set; }

		public StringSingleSelectValue? Priority { get; set; }

		public GuidValue? RefNoteID { get; set; }

		public StringValue? RefNoteIDType { get; set; }

		public StringSingleSelectValue? Severity { get; set; }

		public DateOnlyValue? StartDate { get; set; }

		public StringSingleSelectValue? Status { get; set; }

		public StringValue? Summary { get; set; }

		public StringValue? TaskID { get; set; }

		public GuidValue? TaskNoteID { get; set; }

		public StringSingleSelectValue? TaskType { get; set; }

		public StringValue? Workforce { get; set; }

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