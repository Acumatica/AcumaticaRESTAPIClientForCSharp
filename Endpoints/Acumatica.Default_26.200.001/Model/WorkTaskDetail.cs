using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class WorkTaskDetail : Entity
	{

		[DataMember(Name="ActionLineCntr", EmitDefaultValue=false)]
		public IntValue? ActionLineCntr { get; set; }

		[DataMember(Name="CompletedDate", EmitDefaultValue=false)]
		public DateTimeValue? CompletedDate { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateOnlyValue? EndDate { get; set; }

		[DataMember(Name="EstimatedDuration", EmitDefaultValue=false)]
		public IntSingleSelectValue? EstimatedDuration { get; set; }

		[DataMember(Name="EventCount", EmitDefaultValue=false)]
		public IntValue? EventCount { get; set; }

		[DataMember(Name="EventDuration", EmitDefaultValue=false)]
		public IntValue? EventDuration { get; set; }

		[DataMember(Name="EventEndDate", EmitDefaultValue=false)]
		public DateTimeValue? EventEndDate { get; set; }

		[DataMember(Name="EventStartDate", EmitDefaultValue=false)]
		public DateTimeValue? EventStartDate { get; set; }

		[DataMember(Name="EventStatus", EmitDefaultValue=false)]
		public StringValue? EventStatus { get; set; }

		[DataMember(Name="EventSummary", EmitDefaultValue=false)]
		public StringValue? EventSummary { get; set; }

		[DataMember(Name="HasMoreEvents", EmitDefaultValue=false)]
		public StringValue? HasMoreEvents { get; set; }

		[DataMember(Name="IsScheduled", EmitDefaultValue=false)]
		public BooleanValue? IsScheduled { get; set; }

		[DataMember(Name="PercentCompletion", EmitDefaultValue=false)]
		public IntValue? PercentCompletion { get; set; }

		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public StringSingleSelectValue? Priority { get; set; }

		[DataMember(Name="RefNoteID", EmitDefaultValue=false)]
		public GuidValue? RefNoteID { get; set; }

		[DataMember(Name="RefNoteIDType", EmitDefaultValue=false)]
		public StringValue? RefNoteIDType { get; set; }

		[DataMember(Name="Severity", EmitDefaultValue=false)]
		public StringSingleSelectValue? Severity { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateOnlyValue? StartDate { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue? Summary { get; set; }

		[DataMember(Name="TaskID", EmitDefaultValue=false)]
		public StringValue? TaskID { get; set; }

		[DataMember(Name="TaskNoteID", EmitDefaultValue=false)]
		public GuidValue? TaskNoteID { get; set; }

		[DataMember(Name="TaskType", EmitDefaultValue=false)]
		public StringSingleSelectValue? TaskType { get; set; }

		[DataMember(Name="Workforce", EmitDefaultValue=false)]
		public StringValue? Workforce { get; set; }

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