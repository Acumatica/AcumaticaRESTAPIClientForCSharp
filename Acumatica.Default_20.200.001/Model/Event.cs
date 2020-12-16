using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Event : Entity_v4
	{

		[DataMember(Name="AllDay", EmitDefaultValue=false)]
		public BooleanValue AllDay { get; set; }

		[DataMember(Name="Attendees", EmitDefaultValue=false)]
		public List<EventAttendee> Attendees { get; set; }

		[DataMember(Name="Body", EmitDefaultValue=false)]
		public StringValue Body { get; set; }

		[DataMember(Name="Category", EmitDefaultValue=false)]
		public StringValue Category { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue EndTime { get; set; }

		[DataMember(Name="Internal", EmitDefaultValue=false)]
		public BooleanValue Internal { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue NoteID { get; set; }

		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public StringValue Priority { get; set; }

		[DataMember(Name="RelatedActivities", EmitDefaultValue=false)]
		public List<ActivityDetail> RelatedActivities { get; set; }

		[DataMember(Name="Reminder", EmitDefaultValue=false)]
		public ReminderDetail Reminder { get; set; }

		[DataMember(Name="ShowAs", EmitDefaultValue=false)]
		public StringValue ShowAs { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue Summary { get; set; }

		[DataMember(Name="TimeActivity", EmitDefaultValue=false)]
		public EventTimeActivity TimeActivity { get; set; }

		[DataMember(Name="CreatedByID", EmitDefaultValue=false)]
		public StringValue CreatedByID { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="RelatedEntityType", EmitDefaultValue=false)]
		public StringValue RelatedEntityType { get; set; }

		[DataMember(Name="RelatedEntityNoteID", EmitDefaultValue=false)]
		public GuidValue RelatedEntityNoteID { get; set; }

		[DataMember(Name="RelatedEntityDescription", EmitDefaultValue=false)]
		public StringValue RelatedEntityDescription { get; set; }

	}
}