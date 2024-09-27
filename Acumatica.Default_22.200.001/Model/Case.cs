using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CR306000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Case : Entity, ITopLevelEntity
	{

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail>? Activities { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The field indicates whether the case is billable.
		/// DAC Field Name: IsBillable 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// The billable overtime (in hours) spent on the case.
		/// DAC Field Name: OvertimeBillable 
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Billable Overtime 
		/// </summary>
		[DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
		public IntValue? BillableOvertime { get; set; }

		/// <summary>
		/// The billable time (in hours) spent on the case.
		/// DAC Field Name: TimeBillable 
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Billable Time 
		/// </summary>
		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public IntValue? BillableTime { get; set; }

		/// <summary>
		/// The business account associated with the case.
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Business Account 
		/// </summary>
		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		/// <summary>
		/// The business account associated with the case.
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Business Account 
		/// </summary>
		[DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
		public StringValue? BusinessAccountName { get; set; }

		/// <summary>
		/// The unique identifier assigned to the case in accordance with the numbering sequence assigned to cases on the Customer Management Preferences (CR101000) form.
		/// DAC Field Name: CaseCD 
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Case ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="CaseID", EmitDefaultValue=false)]
		public StringValue? CaseID { get; set; }

		/// <summary>
		/// The identifier of the case class.
		/// DAC Field Name: CaseClassID 
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Case Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// The date and time when the case was closed. The field is filled in by the system.
		/// DAC Field Name: ResolutionDate 
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Closed On 
		/// </summary>
		[DataMember(Name="ClosingDate", EmitDefaultValue=false)]
		public DateTimeValue? ClosingDate { get; set; }

		/// <summary>
		/// DAC Field Name: ContactID_description 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		[DataMember(Name="ContactDisplayName", EmitDefaultValue=false)]
		public StringValue? ContactDisplayName { get; set; }

		/// <summary>
		/// The customer representative to be contacted about the case.
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Contact 
		/// </summary>
		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		/// <summary>
		/// The contract associated with the case.
		/// DAC Field Name: ContractID 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		[DataMember(Name="Contract", EmitDefaultValue=false)]
		public StringValue? Contract { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// DAC Field Name: CreatedDateTime 
		/// DAC: PX.Objects.CR.CRPMTimeActivity 
		/// Display Name: Created At 
		/// </summary>
		[DataMember(Name="DateReported", EmitDefaultValue=false)]
		public DateTimeValue? DateReported { get; set; }

		/// <summary>
		/// A detailed description of the case or relevant notes.
		/// DAC: PX.Objects.CR.CRCase 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The time from the creation of the case to the initial response.
		/// DAC Field Name: InitResponse 
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Init. Response 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="InitialResponse", EmitDefaultValue=false)]
		public StringValue? InitialResponse { get; set; }

		/// <summary>
		/// The date and time of the last activity of this case.
		/// DAC Field Name: LastActivity 
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Last Activity 
		/// </summary>
		[DataMember(Name="LastActivityDate", EmitDefaultValue=false)]
		public DateTimeValue? LastActivityDate { get; set; }

		/// <summary>
		/// DAC Field Name: LastIncomingActivityDate 
		/// DAC: PX.Objects.CR.CRActivityStatistics 
		/// Display Name: Last Incoming Activity 
		/// </summary>
		[DataMember(Name="LastIncomingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastIncomingActivity { get; set; }

		/// <summary>
		/// DAC Field Name: LastOutgoingActivityDate 
		/// DAC: PX.Objects.CR.CRActivityStatistics 
		/// Display Name: Last Outgoing Activity 
		/// </summary>
		[DataMember(Name="LastOutgoingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastOutgoingActivity { get; set; }

		/// <summary>
		/// The identifier of the default Location object linked with the prospective or existing customer that is selected in the Business Account box.
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// Also, the Location.BAccountID value must be equal tothe CRCase.CustomerID value of the current case.
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// The field indicates whether the billable time and billable overtime can be changed manually.
		/// DAC Field Name: ManualBillableTimes 
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Manual Override 
		/// </summary>
		[DataMember(Name="ManualOverride", EmitDefaultValue=false)]
		public BooleanValue? ManualOverride { get; set; }

		/// <summary>
		/// The overtime (in hours) spent on the case activity.
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Overtime Spent 
		/// </summary>
		[DataMember(Name="OvertimeSpent", EmitDefaultValue=false)]
		public StringValue? OvertimeSpent { get; set; }

		/// <summary>
		/// The user name of the employee assigned to the case.
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// DAC Field Name: OwnerID_description 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue? OwnerEmployeeName { get; set; }

		/// <summary>
		/// The priority of the case.
		/// DAC: PX.Objects.CR.CRCase 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public StringValue? Priority { get; set; }

		/// <summary>
		/// The reason why the case has been changed to the current status.
		/// DAC Field Name: Resolution 
		/// DAC: PX.Objects.CR.CRCase 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue? Reason { get; set; }

		[DataMember(Name="RelatedCases", EmitDefaultValue=false)]
		public List<CaseRelatedCase>? RelatedCases { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail>? Relations { get; set; }

		/// <summary>
		/// The time (in minutes) of the case resolution.
		/// DAC Field Name: TimeResolution 
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Resolution Time 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="ResolutionTime", EmitDefaultValue=false)]
		public StringValue? ResolutionTime { get; set; }

		/// <summary>
		/// The severity level of the case.
		/// DAC: PX.Objects.CR.CRCase 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Severity", EmitDefaultValue=false)]
		public StringValue? Severity { get; set; }

		[DataMember(Name="SLA", EmitDefaultValue=false)]
		public DateTimeValue? SLA { get; set; }

		/// <summary>
		/// The current status of the case.
		/// DAC: PX.Objects.CR.CRCase 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// A subject of the case.
		/// DAC: PX.Objects.CR.CRCase 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		/// <summary>
		/// The time (in hours) spent on the case activity.
		/// DAC: PX.Objects.CR.CRCase 
		/// Display Name: Time Spent 
		/// </summary>
		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public StringValue? TimeSpent { get; set; }

		/// <summary>
		/// The company tree workgroup to work on the case.
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

		/// <summary>
		/// DAC Field Name: WorkgroupID_description 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue? WorkgroupDescription { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}