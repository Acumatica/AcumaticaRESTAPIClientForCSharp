using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class CaseActivityDetail : Entity_v3
	{

		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue Billable { get; set; }

		[DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
		public StringValue BillableOvertime { get; set; }

		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public StringValue BillableTime { get; set; }

		[DataMember(Name="Category", EmitDefaultValue=false)]
		public StringValue Category { get; set; }

		[DataMember(Name="ClassIcon", EmitDefaultValue=false)]
		public StringValue ClassIcon { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="CreatedAt", EmitDefaultValue=false)]
		public DateTimeValue CreatedAt { get; set; }

		[DataMember(Name="CreatedBy", EmitDefaultValue=false)]
		public StringValue CreatedBy { get; set; }

		[DataMember(Name="IsCompleteIcon", EmitDefaultValue=false)]
		public StringValue IsCompleteIcon { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue NoteID { get; set; }

		[DataMember(Name="Overtime", EmitDefaultValue=false)]
		public StringValue Overtime { get; set; }

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

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue Workgroup { get; set; }

	}
}