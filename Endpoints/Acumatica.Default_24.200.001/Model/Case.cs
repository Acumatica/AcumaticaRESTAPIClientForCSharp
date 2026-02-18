using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CR306000</c> in the Acumatica ERP
	/// <para>Key Fields: CaseID</para>
	/// </summary>
	public class Case : Entity, ITopLevelEntity
	{

		public List<ActivityDetail>? Activities { get; set; }

		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The field indicates whether the case is billable.
		/// <para>DAC Field Name: IsBillable</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// The billable overtime (in hours) spent on the case.
		/// <para>DAC Field Name: OvertimeBillable</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Billable Overtime</para>
		/// </summary>
		public StringValue? BillableOvertime { get; set; }

		/// <summary>
		/// The billable time (in hours) spent on the case.
		/// <para>DAC Field Name: TimeBillable</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Billable Time</para>
		/// </summary>
		public StringValue? BillableTime { get; set; }

		/// <summary>
		/// The business account associated with the case.
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Business Account</para>
		/// </summary>
		public StringValue? BusinessAccount { get; set; }

		/// <summary>
		/// The business account associated with the case.
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Business Account</para>
		/// </summary>
		public StringValue? BusinessAccountName { get; set; }

		/// <summary>
		/// The unique identifier assigned to the case in accordance with the numbering sequence assigned to cases on the Customer Management Preferences (CR101000) form.
		/// <para>DAC Field Name: CaseCD</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Case ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? CaseID { get; set; }

		/// <summary>
		/// The identifier of the case class.
		/// <para>DAC Field Name: CaseClassID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Case Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// The date and time when the case was closed. The field is filled in by the system.
		/// <para>DAC Field Name: ResolutionDate</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Closed On</para>
		/// </summary>
		public DateTimeValue? ClosingDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ContactID_description</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		public StringValue? ContactDisplayName { get; set; }

		/// <summary>
		/// The customer representative to be contacted about the case.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Contact</para>
		/// </summary>
		public IntValue? ContactID { get; set; }

		/// <summary>
		/// The contract associated with the case.
		/// <para>DAC Field Name: ContractID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		public StringValue? Contract { get; set; }

		/// <summary>
		/// Date and time of the case creation.
		/// <para>DAC Field Name: ReportedOnDateTime</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Reported On</para>
		/// </summary>
		public DateTimeValue? DateReported { get; set; }

		/// <summary>
		/// A detailed description of the case or relevant notes.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The time from the creation of the case to the initial response.
		/// <para>DAC Field Name: InitResponse</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Init. Response</para>
		/// </summary>
		public StringValue? InitialResponse { get; set; }

		/// <summary>
		/// The date and time of the last activity of this case.
		/// <para>DAC Field Name: LastActivity</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Last Activity</para>
		/// </summary>
		public DateTimeValue? LastActivityDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastIncomingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Incoming Activity</para>
		/// </summary>
		public DateTimeValue? LastIncomingActivity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastOutgoingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Outgoing Activity</para>
		/// </summary>
		public DateTimeValue? LastOutgoingActivity { get; set; }

		/// <summary>
		/// The identifier of the default Location object linked with the prospective or existing customer that is selected in the Business Account box.
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		/// <remarks>
		/// Also, the BAccountID value must be equal tothe CustomerID value of the current case.
		/// </remarks>
		public StringValue? Location { get; set; }

		/// <summary>
		/// The field indicates whether the billable time and billable overtime can be changed manually.
		/// <para>DAC Field Name: ManualBillableTimes</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Manual Override</para>
		/// </summary>
		public BooleanValue? ManualOverride { get; set; }

		/// <summary>
		/// The overtime (in hours) spent on the case activity.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Overtime Spent</para>
		/// </summary>
		public StringValue? OvertimeSpent { get; set; }

		/// <summary>
		/// The user name of the employee assigned to the case.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID_description</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		public StringValue? OwnerEmployeeName { get; set; }

		/// <summary>
		/// The priority of the case.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Priority { get; set; }

		/// <summary>
		/// The reason why the case has been changed to the current status.
		/// <para>DAC Field Name: Resolution</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Reason { get; set; }

		public List<CaseRelatedCase>? RelatedCases { get; set; }

		public List<RelationDetail>? Relations { get; set; }

		/// <summary>
		/// The time (in minutes) of the case resolution.
		/// <para>DAC Field Name: TimeResolution</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Resolution Time</para>
		/// </summary>
		public StringValue? ResolutionTime { get; set; }

		/// <summary>
		/// The severity level of the case.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Severity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ResolutionDueDateTime</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		public DateTimeValue? SLA { get; set; }

		/// <summary>
		/// The current status of the case.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// A subject of the case.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Subject { get; set; }

		/// <summary>
		/// The time (in hours) spent on the case activity.
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>Display Name: Time Spent</para>
		/// </summary>
		public StringValue? TimeSpent { get; set; }

		/// <summary>
		/// The company tree workgroup to work on the case.
		/// <para>DAC Field Name: WorkgroupID</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		public StringValue? Workgroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkgroupID_description</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// </summary>
		public StringValue? WorkgroupDescription { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public GuidValue? NoteID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Activities = "Activities";
			public const string Activities_Files = "Activities/Files";
			public const string Attributes = "Attributes";
			public const string RelatedCases = "RelatedCases";
			public const string RelatedCases_Files = "RelatedCases/Files";
			public const string Relations = "Relations";
			public const string Relations_Files = "Relations/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Activities,Activities/Files,Attributes,RelatedCases,RelatedCases/Files,Relations,Relations/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}