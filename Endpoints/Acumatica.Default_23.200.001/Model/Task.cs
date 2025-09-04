using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CR306020 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Task : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The HTML body of the activity.
		/// DAC: PX.Objects.CR.CRActivity 
		/// Display Name: Activity Details 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Body", EmitDefaultValue=false)]
		public StringValue? Body { get; set; }

		/// <summary>
		/// The identifier of the task or event category.
		/// DAC Field Name: CategoryID 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		[DataMember(Name="Category", EmitDefaultValue=false)]
		public StringValue? Category { get; set; }

		/// <summary>
		/// The date and time when activity was completed(UIStatus was set to Completed).
		/// DAC Field Name: CompletedDate 
		/// DAC: PX.Objects.CR.CRActivity 
		/// Display Name: Completed On 
		/// </summary>
		[DataMember(Name="CompletedAt", EmitDefaultValue=false)]
		public DateTimeValue? CompletedAt { get; set; }

		/// <summary>
		/// The estimation of the task completion expressed as a percentage.
		/// DAC Field Name: PercentCompletion 
		/// DAC: PX.Objects.CR.CRActivity 
		/// Display Name: Completion (%) 
		/// </summary>
		[DataMember(Name="CompletionPercentage", EmitDefaultValue=false)]
		public IntValue? CompletionPercentage { get; set; }

		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue? DueDate { get; set; }

		/// <summary>
		/// Specifies whether this activity is hidden from external usersand not visible on the portal site.
		/// DAC Field Name: IsPrivate 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		[DataMember(Name="Internal", EmitDefaultValue=false)]
		public BooleanValue? Internal { get; set; }

		/// <summary>
		/// The identifier of the Note object associated with the document.
		/// DAC: PX.Objects.CR.CRActivity 
		/// Display Name: ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// The identifier of the parent task or event of the current activity.
		/// DAC Field Name: ParentNoteID 
		/// DAC: PX.Objects.CR.CRActivity 
		/// Display Name: Parent Activity 
		/// </summary>
		[DataMember(Name="Parent", EmitDefaultValue=false)]
		public GuidValue? Parent { get; set; }

		[DataMember(Name="ParentSummary", EmitDefaultValue=false)]
		public StringValue? ParentSummary { get; set; }

		/// <summary>
		/// The priority of the activity.
		/// DAC: PX.Objects.CR.CRActivity 
		/// </summary>
		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public StringValue? Priority { get; set; }

		[DataMember(Name="RelatedActivities", EmitDefaultValue=false)]
		public List<ActivityDetail>? RelatedActivities { get; set; }

		[DataMember(Name="RelatedTasks", EmitDefaultValue=false)]
		public List<TaskRelatedTask>? RelatedTasks { get; set; }

		[DataMember(Name="Reminder", EmitDefaultValue=false)]
		public ReminderDetail? Reminder { get; set; }

		/// <summary>
		/// The start date and time of the event.
		/// DAC: PX.Objects.CR.CRChildActivity 
		/// Display Name: Start Date 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// The status of the activity.
		/// DAC Field Name: UIStatus 
		/// DAC: PX.Objects.CR.CRActivity 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The summary description of the activity.
		/// DAC Field Name: Subject 
		/// DAC: PX.Objects.CR.CRActivity 
		/// SQL Type: nvarchar(998) 
		/// </summary>
		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue? Summary { get; set; }

		[DataMember(Name="TimeActivity", EmitDefaultValue=false)]
		public TaskTimeActivity? TimeActivity { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// DAC: PX.Objects.CR.CRActivity 
		/// Display Name: Workgroup 
		/// </summary>
		[DataMember(Name="WorkgroupID", EmitDefaultValue=false)]
		public StringValue? WorkgroupID { get; set; }

		[DataMember(Name="CreatedByID", EmitDefaultValue=false)]
		public StringValue? CreatedByID { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// DAC: PX.Objects.CR.CRChildActivity 
		/// Display Name: Created At 
		/// </summary>
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Contains the type of the related entity, that is specified in RefNoteID.
		/// DAC Field Name: RefNoteIDType 
		/// DAC: PX.Objects.CR.CRActivity 
		/// Display Name: Related Entity Type 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="RelatedEntityType", EmitDefaultValue=false)]
		public StringValue? RelatedEntityType { get; set; }

		/// <summary>
		/// Contains the NoteID value of the related entity.This activity is displayed on the Activities tab of the entity's form.
		/// DAC Field Name: RefNoteID 
		/// DAC: PX.Objects.CR.CRActivity 
		/// Display Name: Related Entity 
		/// </summary>
		/// <remarks>
		/// The related document may or may not implement the INotable interface,            but it must have a field marked with the PXNoteAttribute attribute            with the ShowInReferenceSelector property set to true.            
		/// </remarks>
		[DataMember(Name="RelatedEntityNoteID", EmitDefaultValue=false)]
		public GuidValue? RelatedEntityNoteID { get; set; }

		[DataMember(Name="RelatedEntityDescription", EmitDefaultValue=false)]
		public StringValue? RelatedEntityDescription { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}