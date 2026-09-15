using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SV306000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class WorkTask : Entity, ITopLevelEntity
	{

		[DataMember(Name="CompletedDate", EmitDefaultValue=false)]
		public DateTimeValue? CompletedDate { get; set; }

		[DataMember(Name="DefaultLabor", EmitDefaultValue=false)]
		public List<WorkTaskDefaultLaborDetail>? DefaultLabor { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateOnlyValue? EndDate { get; set; }

		[DataMember(Name="EstimatedDuration", EmitDefaultValue=false)]
		public IntSingleSelectValue? EstimatedDuration { get; set; }

		[DataMember(Name="Events", EmitDefaultValue=false)]
		public List<WorkTaskEventDetail>? Events { get; set; }

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

		[DataMember(Name="SchedulableItem", EmitDefaultValue=false)]
		public BooleanValue? SchedulableItem { get; set; }

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

		[DataMember(Name="TaskTemplateID", EmitDefaultValue=false)]
		public StringValue? TaskTemplateID { get; set; }

		[DataMember(Name="TaskType", EmitDefaultValue=false)]
		public StringSingleSelectValue? TaskType { get; set; }

		[DataMember(Name="WorkTaskActions", EmitDefaultValue=false)]
		public List<WorkTaskActions>? WorkTaskActions { get; set; }

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
			public const string Translations = "Translations";
			public const string DefaultLabor = "DefaultLabor";
			public const string Events = "Events";
			public const string WorkTaskActions = "WorkTaskActions";

			//Intentionally excluded
			//public const string All = "Files,Translations,DefaultLabor,Events,WorkTaskActions";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}