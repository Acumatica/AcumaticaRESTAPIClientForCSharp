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
	/// Corresponds to the screen <c>CR306000</c> in the Acumatica ERP
	/// <para>Key Fields: CaseID</para>
	/// </summary>
	[DataContract]
	public class Case : Entity, ITopLevelEntity
	{

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail>? Activities { get; set; }

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public CaseContactAddress? Address { get; set; }

		[DataMember(Name="Age", EmitDefaultValue=false)]
		public IntValue? Age { get; set; }

		[DataMember(Name="AISentiment", EmitDefaultValue=false)]
		public StringValue? AISentiment { get; set; }

		[DataMember(Name="AssignDate", EmitDefaultValue=false)]
		public DateTimeValue? AssignDate { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The field indicates whether the case is billable.
		/// <para>DAC Field Name: IsBillable</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue? Billable { get; set; }

		[DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
		public IntSingleSelectValue? BillableOvertime { get; set; }

		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public IntSingleSelectValue? BillableTime { get; set; }

		/// <summary>
		/// The business account associated with the case.
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Business Account</para>
		/// </summary>
		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		/// <summary>
		/// The business account associated with the case.
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Business Account</para>
		/// </summary>
		[DataMember(Name="BusinessAccountName", EmitDefaultValue=false)]
		public StringValue? BusinessAccountName { get; set; }

		/// <summary>
		/// The unique identifier assigned to the case in accordance with the numbering sequence assigned to cases on the Customer Management Preferences (CR101000) form.
		/// <para>DAC Field Name: CaseCD</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Case ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="CaseID", EmitDefaultValue=false)]
		public StringValue? CaseID { get; set; }

		/// <summary>
		/// The identifier of the case class.
		/// <para>DAC Field Name: CaseClassID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Case Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// The date and time when the case was closed. The field is filled in by the system.
		/// <para>DAC Field Name: ResolutionDate</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Closed On</para>
		/// </summary>
		[DataMember(Name="ClosingDate", EmitDefaultValue=false)]
		public DateTimeValue? ClosingDate { get; set; }

		/// <summary>
		/// On closing case user can record information about closing case or can update data if Closure Notes had any data before on case process steps.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Closure Notes</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="ClosureNotes", EmitDefaultValue=false)]
		public StringValue? ClosureNotes { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ContactID_description</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		[DataMember(Name="ContactDisplayName", EmitDefaultValue=false)]
		public StringValue? ContactDisplayName { get; set; }

		/// <summary>
		/// The customer representative to be contacted about the case.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Contact</para>
		/// </summary>
		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="Contact", EmitDefaultValue=false)]
		public CaseContact? Contact { get; set; }

		/// <summary>
		/// The contract associated with the case.
		/// <para>DAC Field Name: ContractID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		[DataMember(Name="Contract", EmitDefaultValue=false)]
		public StringValue? Contract { get; set; }

		/// <summary>
		/// The ID of the user who created the record.
		/// <para>DAC: PX.Objects.CR.CRRelation</para>
		/// <para>Display Name: Creator</para>
		/// </summary>
		[DataMember(Name="CreatedByID", EmitDefaultValue=false)]
		public GuidValue? CreatedByID { get; set; }

		[DataMember(Name="CustomerID_description", EmitDefaultValue=false)]
		public StringValue? CustomerID_description { get; set; }

		/// <summary>
		/// Date and time of the case creation.
		/// <para>DAC Field Name: ReportedOnDateTime</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Reported On</para>
		/// </summary>
		[DataMember(Name="DateReported", EmitDefaultValue=false)]
		public DateTimeValue? DateReported { get; set; }

		/// <summary>
		/// A detailed description of the case or relevant notes.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The time from the creation of the case to the initial response.
		/// <para>DAC Field Name: InitResponse</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Init. Response</para>
		/// </summary>
		[DataMember(Name="InitialResponse", EmitDefaultValue=false)]
		public StringValue? InitialResponse { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		[DataMember(Name="InitialResponseDueDateTime", EmitDefaultValue=false)]
		public DateTimeValue? InitialResponseDueDateTime { get; set; }

		/// <summary>
		/// This field indicates whether the case is active. A case is considered active if further communication or action is expected for it.If the check box is selected, the case is displayed in the list of cases on the related mass processing forms, such as the Assign Cases (CR503210) form.By default, the check box is cleared when the case is closed.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Active</para>
		/// </summary>
		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue? IsActive { get; set; }

		/// <summary>
		/// The date and time of the last activity of this case.
		/// <para>DAC Field Name: LastActivity</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Last Activity</para>
		/// </summary>
		[DataMember(Name="LastActivityDate", EmitDefaultValue=false)]
		public DateTimeValue? LastActivityDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastIncomingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Incoming Activity</para>
		/// </summary>
		[DataMember(Name="LastIncomingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastIncomingActivity { get; set; }

		/// <summary>
		/// The ID of the user who last modified the record.
		/// <para>DAC: PX.Objects.CR.CRRelation</para>
		/// <para>Display Name: Last Modified By</para>
		/// </summary>
		[DataMember(Name="LastModifiedByID", EmitDefaultValue=false)]
		public StringValue? LastModifiedByID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastOutgoingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Outgoing Activity</para>
		/// </summary>
		[DataMember(Name="LastOutgoingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastOutgoingActivity { get; set; }

		/// <summary>
		/// The identifier of the default Location object linked with the prospective or existing customer that is selected in the Business Account box.
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		/// <remarks>
		/// Also, the BAccountID value must be equal tothe CustomerID value of the current case.
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// The field indicates whether the billable time and billable overtime can be changed manually.
		/// <para>DAC Field Name: ManualBillableTimes</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Manual Override</para>
		/// </summary>
		[DataMember(Name="ManualOverride", EmitDefaultValue=false)]
		public BooleanValue? ManualOverride { get; set; }

		[DataMember(Name="OvertimeSpent", EmitDefaultValue=false)]
		public IntSingleSelectValue? OvertimeSpent { get; set; }

		/// <summary>
		/// The user name of the employee assigned to the case.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID_description</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue? OwnerEmployeeName { get; set; }

		/// <summary>
		/// The priority of the case.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public StringValue? Priority { get; set; }

		/// <summary>
		/// The reason why the case has been changed to the current status.
		/// <para>DAC Field Name: Resolution</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue? Reason { get; set; }

		[DataMember(Name="RelatedCases", EmitDefaultValue=false)]
		public List<CaseRelatedCase>? RelatedCases { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail>? Relations { get; set; }

		/// <summary>
		/// The time (in minutes) of the case resolution.
		/// <para>DAC Field Name: TimeResolution</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Resolution Time</para>
		/// </summary>
		[DataMember(Name="ResolutionTime", EmitDefaultValue=false)]
		public StringValue? ResolutionTime { get; set; }

		/// <summary>
		/// The severity level of the case.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Severity", EmitDefaultValue=false)]
		public StringValue? Severity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ResolutionDueDateTime</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		[DataMember(Name="SLA", EmitDefaultValue=false)]
		public DateTimeValue? SLA { get; set; }

		/// <summary>
		/// The current status of the case.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		[DataMember(Name="StatusDate", EmitDefaultValue=false)]
		public DateTimeValue? StatusDate { get; set; }

		/// <summary>
		/// A subject of the case.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Subject", EmitDefaultValue=false)]
		public StringValue? Subject { get; set; }

		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public IntSingleSelectValue? TimeSpent { get; set; }

		/// <summary>
		/// The company tree workgroup to work on the case.
		/// <para>DAC Field Name: WorkgroupID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkgroupID_description</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue? WorkgroupDescription { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

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
			public const string Activities = "Activities";
			public const string Address = "Address";
			public const string Attributes = "Attributes";
			public const string Contact = "Contact";
			public const string RelatedCases = "RelatedCases";
			public const string Relations = "Relations";

			//Intentionally excluded
			//public const string All = "Files,Translations,Activities,Address,Attributes,Contact,RelatedCases,Relations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}