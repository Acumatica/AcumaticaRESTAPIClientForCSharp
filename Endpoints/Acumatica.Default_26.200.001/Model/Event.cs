using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CR306030</c> in the Acumatica ERP
	/// <para>Key Fields: NoteID</para>
	/// </summary>
	public class Event : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// The identifier of the Note object associated with the document.
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: ID</para>
		/// Key Field
		/// </summary>
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// The summary description of the activity.
		/// <para>DAC Field Name: Subject</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>SQL Type: nvarchar(998)</para>
		/// </summary>
		public StringValue? Summary { get; set; }

		/// <summary>
		/// The location of the event.
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// Specifies whether this event is an all-day event.
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: All Day</para>
		/// </summary>
		public BooleanValue? AllDay { get; set; }

		/// <summary>
		/// The event status to be displayed on your schedule if it is public.
		/// <para>DAC Field Name: ShowAsID</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Show As</para>
		/// </summary>
		public StringValue? ShowAs { get; set; }

		/// <summary>
		/// Specifies whether this activity is hidden from external usersand not visible on the portal site.
		/// <para>DAC Field Name: IsPrivate</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// </summary>
		public BooleanValue? Internal { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Owner</para>
		/// </summary>
		public IntValue? OwnerID { get; set; }

		/// <summary>
		/// Contains the type of the related entity, that is specified in RefNoteID.
		/// <para>DAC Field Name: RefNoteIDType</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Related Entity Type</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? RelatedEntityType { get; set; }

		/// <summary>
		/// Contains the NoteID value of the related entity.This activity is displayed on the Activities tab of the entity's form.
		/// <para>DAC Field Name: RefNoteID</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Related Entity</para>
		/// </summary>
		/// <remarks>
		/// The related document may or may not implement the INotable interface,            but it must have a field marked with the PXNoteAttribute attribute            with the ShowInReferenceSelector property set to true.            
		/// </remarks>
		public GuidValue? RelatedEntityNoteID { get; set; }

		/// <summary>
		/// The status of the activity.
		/// <para>DAC Field Name: UIStatus</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// The priority of the activity.
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// </summary>
		public StringValue? Priority { get; set; }

		/// <summary>
		/// The identifier of the task or event category.
		/// <para>DAC Field Name: CategoryID</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// </summary>
		public StringValue? Category { get; set; }

		/// <summary>
		/// The HTML body of the activity.
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Activity Details</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Body { get; set; }

		/// <summary>
		/// The start date and time of the event.
		/// <para>DAC: PX.Objects.CR.CRChildActivity</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		public IntValue? DayOfWeek { get; set; }

		public DateTimeValue? EndDateTime { get; set; }

		public StringValue? OwnerID_description { get; set; }

		public StringValue? Style { get; set; }

		public StringValue? CreatedByID { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? RelatedEntityDescription { get; set; }

		#endregion

		#region LinkedEntities
		public ReminderDetail? Reminder { get; set; }

		public EventTimeActivity? TimeActivity { get; set; }

		#endregion

		#region Details
		public List<EventAttendee>? Attendees { get; set; }

		public List<ActivityDetail>? RelatedActivities { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(Event)} - \"{NoteID}\"";
		}

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
			public const string Attendees = "Attendees";
			public const string RelatedActivities = "RelatedActivities";
			public const string Reminder = "Reminder";
			public const string TimeActivity = "TimeActivity";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attendees,RelatedActivities,Reminder,TimeActivity";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}