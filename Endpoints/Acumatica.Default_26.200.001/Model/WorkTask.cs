using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SV306000</c> in the Acumatica ERP
	/// </summary>
	public class WorkTask : Entity, ITopLevelEntity
	{

		#region Fields
		public DateTimeValue? CompletedDate { get; set; }

		public StringValue? Description { get; set; }

		public DateOnlyValue? EndDate { get; set; }

		public IntSingleSelectValue? EstimatedDuration { get; set; }

		public BooleanValue? IsScheduled { get; set; }

		public IntValue? PercentCompletion { get; set; }

		public StringSingleSelectValue? Priority { get; set; }

		public GuidValue? RefNoteID { get; set; }

		public StringValue? RefNoteIDType { get; set; }

		public BooleanValue? SchedulableItem { get; set; }

		public StringSingleSelectValue? Severity { get; set; }

		public DateOnlyValue? StartDate { get; set; }

		public StringSingleSelectValue? Status { get; set; }

		public StringValue? Summary { get; set; }

		public StringValue? TaskID { get; set; }

		public StringValue? TaskTemplateID { get; set; }

		public StringSingleSelectValue? TaskType { get; set; }

		#endregion

		#region Details
		public List<WorkTaskDefaultLaborDetail>? DefaultLabor { get; set; }

		public List<WorkTaskEventDetail>? Events { get; set; }

		public List<WorkTaskActions>? WorkTaskActions { get; set; }

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