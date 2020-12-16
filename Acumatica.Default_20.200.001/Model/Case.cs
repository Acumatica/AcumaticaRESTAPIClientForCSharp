using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Case : Entity_v4
	{

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail> Activities { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue> Attributes { get; set; }

		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue Billable { get; set; }

		[DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
		public IntValue BillableOvertime { get; set; }

		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public IntValue BillableTime { get; set; }

		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue BusinessAccount { get; set; }

		[DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
		public StringValue BusinessAccountName { get; set; }

		[DataMember(Name="CaseID", EmitDefaultValue=false)]
		public StringValue CaseID { get; set; }

		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue ClassID { get; set; }

		[DataMember(Name="ClosingDate", EmitDefaultValue=false)]
		public DateTimeValue ClosingDate { get; set; }

		[DataMember(Name="ContactDisplayName", EmitDefaultValue=false)]
		public StringValue ContactDisplayName { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue ContactID { get; set; }

		[DataMember(Name="Contract", EmitDefaultValue=false)]
		public StringValue Contract { get; set; }

		[DataMember(Name="DateReported", EmitDefaultValue=false)]
		public DateTimeValue DateReported { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="InitialResponse", EmitDefaultValue=false)]
		public StringValue InitialResponse { get; set; }

		[DataMember(Name="LastActivityDate", EmitDefaultValue=false)]
		public DateTimeValue LastActivityDate { get; set; }

		[DataMember(Name="LastIncomingActivity", EmitDefaultValue=false)]
		public DateTimeValue LastIncomingActivity { get; set; }

		[DataMember(Name="LastOutgoingActivity", EmitDefaultValue=false)]
		public DateTimeValue LastOutgoingActivity { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="ManualOverride", EmitDefaultValue=false)]
		public BooleanValue ManualOverride { get; set; }

		[DataMember(Name="OvertimeSpent", EmitDefaultValue=false)]
		public StringValue OvertimeSpent { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue OwnerEmployeeName { get; set; }

		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public StringValue Priority { get; set; }

		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue Reason { get; set; }

		[DataMember(Name="RelatedCases", EmitDefaultValue=false)]
		public List<CaseRelatedCase> RelatedCases { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail> Relations { get; set; }

		[DataMember(Name="ResolutionTime", EmitDefaultValue=false)]
		public StringValue ResolutionTime { get; set; }

		[DataMember(Name="Severity", EmitDefaultValue=false)]
		public StringValue Severity { get; set; }

		[DataMember(Name="SLA", EmitDefaultValue=false)]
		public DateTimeValue SLA { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue Subject { get; set; }

		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public StringValue TimeSpent { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue Workgroup { get; set; }

		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue WorkgroupDescription { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue NoteID { get; set; }

	}
}