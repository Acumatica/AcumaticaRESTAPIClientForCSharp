using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM209100</c> in the Acumatica ERP
	/// <para>Key Fields: TimeEntryID</para>
	/// </summary>
	[DataContract]
	public class TimeEntry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Approval Status</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="ApprovalStatus", EmitDefaultValue=false)]
		public StringValue? ApprovalStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ApproverID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// </summary>
		[DataMember(Name="Approver", EmitDefaultValue=false)]
		public StringValue? Approver { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsBillable</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// </summary>
		[DataMember(Name="Billable", EmitDefaultValue=false)]
		public BooleanValue? Billable { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvertimeBillable</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Billable Overtime</para>
		/// </summary>
		[DataMember(Name="BillableOvertime", EmitDefaultValue=false)]
		public StringValue? BillableOvertime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TimeBillable</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Billable Time</para>
		/// </summary>
		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public StringValue? BillableTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Certified Job</para>
		/// </summary>
		[DataMember(Name="CertifiedJob", EmitDefaultValue=false)]
		public BooleanValue? CertifiedJob { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// Stores Employee's Hourly rate at the time the activity was released to PM
		/// <para>DAC Field Name: EmployeeRate</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Cost Rate</para>
		/// </summary>
		[DataMember(Name="CostRate", EmitDefaultValue=false)]
		public DecimalValue? CostRate { get; set; }

		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EarningTypeID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Earning Type</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="EarningType", EmitDefaultValue=false)]
		public StringValue? EarningType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Owner</para>
		/// </summary>
		[DataMember(Name="Employee", EmitDefaultValue=false)]
		public StringValue? Employee { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LabourItemID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Labor Item</para>
		/// </summary>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvertimeSpent</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// </summary>
		[DataMember(Name="Overtime", EmitDefaultValue=false)]
		public StringValue? Overtime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Project</para>
		/// </summary>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Summary", EmitDefaultValue=false)]
		public StringValue? Summary { get; set; }

		[DataMember(Name="Time", EmitDefaultValue=false)]
		public DateTimeValue? Time { get; set; }

		/// <summary>
		/// The global identifier of the record. This identifier is used for implementation of multiple system features, such as the search functionality and attachments of notes and files.
		/// <para>DAC Field Name: NoteID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="TimeEntryID", EmitDefaultValue=false)]
		public GuidValue? TimeEntryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Time Spent</para>
		/// </summary>
		[DataMember(Name="TimeSpent", EmitDefaultValue=false)]
		public StringValue? TimeSpent { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: Union Local</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="UnionLocal", EmitDefaultValue=false)]
		public StringValue? UnionLocal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkCodeID</para>
		/// <para>DAC: PX.Objects.CR.PMTimeActivity</para>
		/// <para>Display Name: WCC Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public StringValue? WCCCode { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}