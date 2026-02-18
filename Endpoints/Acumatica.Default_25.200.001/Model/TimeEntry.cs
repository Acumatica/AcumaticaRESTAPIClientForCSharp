using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM209100</c> in the Acumatica ERP
	/// <para>Key Fields: TimeEntryID</para>
	/// </summary>
	public class TimeEntry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Approval Status</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? ApprovalStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ApproverID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// </summary>
		public StringValue? Approver { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsBillable</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// </summary>
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvertimeBillable</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Billable Overtime</para>
		/// </summary>
		public StringValue? BillableOvertime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TimeBillable</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Billable Time</para>
		/// </summary>
		public StringValue? BillableTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Certified Job</para>
		/// </summary>
		public BooleanValue? CertifiedJob { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// Stores Employee's Hourly rate at the time the activity was released to PM
		/// <para>DAC Field Name: EmployeeRate</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Cost Rate</para>
		/// </summary>
		public DecimalValue? CostRate { get; set; }

		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EarningTypeID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Earning Type</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? EarningType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Owner</para>
		/// </summary>
		public StringValue? Employee { get; set; }

		public StringValue? ExternalRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LabourItemID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Labor Item</para>
		/// </summary>
		public StringValue? LaborItem { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvertimeSpent</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// </summary>
		public StringValue? Overtime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Project</para>
		/// </summary>
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Summary { get; set; }

		/// <summary>
		/// The global identifier of the record. This identifier is used for implementation of multiple system features, such as the search functionality and attachments of notes and files.
		/// <para>DAC Field Name: NoteID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// Key Field
		/// </summary>
		public GuidValue? TimeEntryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Time Spent</para>
		/// </summary>
		public StringValue? TimeSpent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Union Local</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? UnionLocal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkCodeID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: WCC Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? WCCCode { get; set; }

		public StringValue? TimeZone { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}