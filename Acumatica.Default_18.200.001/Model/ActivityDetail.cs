using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ActivityDetail : Entity
	{

		[DataMember(Name="ClassIcon", EmitDefaultValue=false)]
		public StringValue ClassIcon { get; set; }

		[DataMember(Name="CreatedAt", EmitDefaultValue=false)]
		public DateTimeValue CreatedAt { get; set; }

		[DataMember(Name="CreatorID", EmitDefaultValue=false)]
		public StringValue CreatorID { get; set; }

		[DataMember(Name="CreatorUsername", EmitDefaultValue=false)]
		public StringValue CreatorUsername { get; set; }

		[DataMember(Name="IsCompleteIcon", EmitDefaultValue=false)]
		public StringValue IsCompleteIcon { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue NoteID { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="PriorityIcon", EmitDefaultValue=false)]
		public StringValue PriorityIcon { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="RefNoteID", EmitDefaultValue=false)]
		public GuidValue RefNoteID { get; set; }

		[DataMember(Name="Released", EmitDefaultValue=false)]
		public BooleanValue Released { get; set; }

		[DataMember(Name="ReminderIcon", EmitDefaultValue=false)]
		public StringValue ReminderIcon { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue Summary { get; set; }

		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public StringValue TimeSpent { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="WorkgroupID", EmitDefaultValue=false)]
		public StringValue WorkgroupID { get; set; }

	}
}