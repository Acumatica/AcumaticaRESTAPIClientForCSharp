using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM209100</c> in the Acumatica ERP
	/// <para>Key Fields: TimeEntryID</para>
	/// </summary>
	public class TimeEntry : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// The PMTimeActivity.noteID field.
		/// <para>DAC Field Name: NoteID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// Key Field
		/// </summary>
		public GuidValue? TimeEntryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Approval Status</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringSingleSelectValue? ApprovalStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Owner</para>
		/// </summary>
		public StringValue? Employee { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ApproverID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// </summary>
		public StringValue? Approver { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Project</para>
		/// </summary>
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Certified Job</para>
		/// </summary>
		public BooleanValue? CertifiedJob { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LabourItemID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Labor Item</para>
		/// </summary>
		public StringValue? LaborItem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Union Local</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? UnionLocal { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Summary { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EarningTypeID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Earning Type</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? EarningType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkCodeID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: WCC Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? WCCCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Time Spent</para>
		/// </summary>
		public IntSingleSelectValue? TimeSpent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvertimeSpent</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// </summary>
		public IntSingleSelectValue? Overtime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsBillable</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// </summary>
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// </summary>
		public BooleanValue? Released { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TimeBillable</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Billable Time</para>
		/// </summary>
		public IntSingleSelectValue? BillableTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvertimeBillable</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Billable Overtime</para>
		/// </summary>
		public IntSingleSelectValue? BillableOvertime { get; set; }

		/// <summary>
		/// Stores Employee's Hourly rate at the time the activity was released to PM
		/// <para>DAC Field Name: EmployeeRate</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Cost Rate</para>
		/// </summary>
		public DecimalValue? CostRate { get; set; }

		public DateTimeValue? Date { get; set; }

		public StringValue? ExternalRefNbr { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? TimeZone { get; set; }

		public StringValue? IDTimeCardRef { get; set; }

		public BooleanValue? IsCorrected { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(TimeEntry)} - \"{TimeEntryID}\"";
		}

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

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}