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
	/// Corresponds to the screen <c>SV307000</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class WorkEvent : Entity, ITopLevelEntity
	{

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public EventAddress? Address { get; set; }

		[DataMember(Name="Confirmed", EmitDefaultValue=false)]
		public BooleanValue? Confirmed { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Duration", EmitDefaultValue=false)]
		public IntValue? Duration { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		[DataMember(Name="Labor", EmitDefaultValue=false)]
		public List<WorkEventLaborDetail>? Labor { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="LocationContactID", EmitDefaultValue=false)]
		public IntValue? LocationContactID { get; set; }

		[DataMember(Name="LocationContactPhone", EmitDefaultValue=false)]
		public StringValue? LocationContactPhone { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		[DataMember(Name="RefNoteID", EmitDefaultValue=false)]
		public GuidValue? RefNoteID { get; set; }

		[DataMember(Name="RefNoteIDType", EmitDefaultValue=false)]
		public StringValue? RefNoteIDType { get; set; }

		[DataMember(Name="SetDurationManually", EmitDefaultValue=false)]
		public BooleanValue? SetDurationManually { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue? Summary { get; set; }

		[DataMember(Name="Tasks", EmitDefaultValue=false)]
		public List<WorkEventTaskDetail>? Tasks { get; set; }

		[DataMember(Name="TicketNbr", EmitDefaultValue=false)]
		public StringValue? TicketNbr { get; set; }

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