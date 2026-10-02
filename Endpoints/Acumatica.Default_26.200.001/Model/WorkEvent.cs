using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SV307000</c> in the Acumatica ERP
	/// </summary>
	public class WorkEvent : Entity, ITopLevelEntity
	{

		#region Fields
		public BooleanValue? Confirmed { get; set; }

		public StringValue? Description { get; set; }

		public IntValue? Duration { get; set; }

		public DateTimeValue? EndDate { get; set; }

		public StringValue? Location { get; set; }

		public IntValue? LocationContactID { get; set; }

		public StringValue? LocationContactPhone { get; set; }

		public GuidValue? NoteID { get; set; }

		public GuidValue? RefNoteID { get; set; }

		public StringValue? RefNoteIDType { get; set; }

		public BooleanValue? SetDurationManually { get; set; }

		public DateTimeValue? StartDate { get; set; }

		public StringSingleSelectValue? Status { get; set; }

		public StringValue? Summary { get; set; }

		public StringValue? TicketNbr { get; set; }

		#endregion

		#region LinkedEntities
		public EventAddress? Address { get; set; }

		#endregion

		#region Details
		public List<WorkEventLaborDetail>? Labor { get; set; }

		public List<WorkEventTaskDetail>? Tasks { get; set; }

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
			public const string Address = "Address";
			public const string Labor = "Labor";
			public const string Tasks = "Tasks";

			//Intentionally excluded
			//public const string All = "Files,Translations,Address,Labor,Tasks";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}