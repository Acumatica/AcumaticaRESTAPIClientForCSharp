using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CR306020</c> in the Acumatica ERP
	/// <para>Key Fields: NoteID</para>
	/// </summary>
	public class Task : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The HTML body of the activity.
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Activity Details</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Body { get; set; }

		/// <summary>
		/// The identifier of the task or event category.
		/// <para>DAC Field Name: CategoryID</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// </summary>
		public StringValue? Category { get; set; }

		/// <summary>
		/// The date and time when activity was completed(UIStatus was set to Completed).
		/// <para>DAC Field Name: CompletedDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Completed On</para>
		/// </summary>
		public DateTimeValue? CompletedAt { get; set; }

		/// <summary>
		/// The estimation of the task completion expressed as a percentage.
		/// <para>DAC Field Name: PercentCompletion</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Completion (%)</para>
		/// </summary>
		public IntValue? CompletionPercentage { get; set; }

		public DateTimeValue? DueDate { get; set; }

		/// <summary>
		/// Specifies whether this activity is hidden from external usersand not visible on the portal site.
		/// <para>DAC Field Name: IsPrivate</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// </summary>
		public BooleanValue? Internal { get; set; }

		/// <summary>
		/// The identifier of the Note object associated with the document.
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: ID</para>
		/// Key Field
		/// </summary>
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		/// <summary>
		/// The identifier of the parent task or event of the current activity.
		/// <para>DAC Field Name: ParentNoteID</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Parent Activity</para>
		/// </summary>
		public GuidValue? Parent { get; set; }

		public StringValue? ParentSummary { get; set; }

		/// <summary>
		/// The priority of the activity.
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// </summary>
		public StringValue? Priority { get; set; }

		public List<ActivityDetail>? RelatedActivities { get; set; }

		public List<TaskRelatedTask>? RelatedTasks { get; set; }

		public ReminderDetail? Reminder { get; set; }

		/// <summary>
		/// The start date and time of the event.
		/// <para>DAC: PX.Objects.CR.CRChildActivity</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// The status of the activity.
		/// <para>DAC Field Name: UIStatus</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// The summary description of the activity.
		/// <para>DAC Field Name: Subject</para>
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>SQL Type: nvarchar(998)</para>
		/// </summary>
		public StringValue? Summary { get; set; }

		public TaskTimeActivity? TimeActivity { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// <para>DAC: PX.Objects.CR.CRActivity</para>
		/// <para>Display Name: Workgroup</para>
		/// </summary>
		public StringValue? WorkgroupID { get; set; }

		public StringValue? CreatedByID { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC: PX.Objects.CR.CRChildActivity</para>
		/// <para>Display Name: Created At</para>
		/// </summary>
		public DateTimeValue? CreatedDateTime { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

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

		public StringValue? RelatedEntityDescription { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string RelatedActivities = "RelatedActivities";
			public const string RelatedActivities_Files = "RelatedActivities/Files";
			public const string RelatedTasks = "RelatedTasks";
			public const string RelatedTasks_Files = "RelatedTasks/Files";
			public const string Reminder = "Reminder";
			public const string TimeActivity = "TimeActivity";

			//Intentionally excluded
			//public const string All = "Files,Translations,RelatedActivities,RelatedActivities/Files,RelatedTasks,RelatedTasks/Files,Reminder,TimeActivity";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}