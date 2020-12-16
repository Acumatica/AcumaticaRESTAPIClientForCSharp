using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class TimeEntry : Entity_v4
	{

		[DataMember(Name="ApprovalStatus", EmitDefaultValue=false)]
		public StringValue ApprovalStatus { get; set; }

		[DataMember(Name="Approver", EmitDefaultValue=false)]
		public StringValue Approver { get; set; }

		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue Billable { get; set; }

		[DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
		public StringValue BillableOvertime { get; set; }

		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public StringValue BillableTime { get; set; }

		[DataMember(Name="CertifiedJob", EmitDefaultValue=false)]
		public BooleanValue CertifiedJob { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="CostRate", EmitDefaultValue=false)]
		public DecimalValue CostRate { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue Date { get; set; }

		[DataMember(Name="EarningType", EmitDefaultValue=false)]
		public StringValue EarningType { get; set; }

		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue Employee { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue ExternalRefNbr { get; set; }

		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue LaborItem { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="Overtime", EmitDefaultValue=false)]
		public StringValue Overtime { get; set; }

		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue ProjectID { get; set; }

		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue ProjectTaskID { get; set; }

		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue Summary { get; set; }

		[DataMember(Name="Time", EmitDefaultValue=false)]
		public DateTimeValue Time { get; set; }

		[DataMember(Name="TimeEntryID", EmitDefaultValue=false)]
		public GuidValue TimeEntryID { get; set; }

		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public StringValue TimeSpent { get; set; }

		[DataMember(Name="UnionLocal", EmitDefaultValue=false)]
		public StringValue UnionLocal { get; set; }

		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public StringValue WCCCode { get; set; }

	}
}