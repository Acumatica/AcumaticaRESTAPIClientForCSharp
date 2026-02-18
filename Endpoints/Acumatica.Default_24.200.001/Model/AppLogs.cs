using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class AppLogs : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: TrackOnService</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>Display Name: Add to Actual Duration</para>
		/// </summary>
		public BooleanValue? AddtoActualDuration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocRefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>Display Name: Appointment Nbr.</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ApprovedTime</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		public BooleanValue? Approved { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryBillableTranAmount</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>Display Name: Billable Amount</para>
		/// </summary>
		public DecimalValue? BillableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsBillable</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Billable</para>
		/// </summary>
		public BooleanValue? BillableLabor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BillableTimeDuration</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>Display Name: Billable Time</para>
		/// </summary>
		public StringValue? BillableTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DetLineRef</para>
		/// <para>DAC: PX.Objects.FS.FSLogActionStartFilter</para>
		/// <para>Display Name: Detail Ref. Nbr.</para>
		/// <para>SQL Type: nchar(4)</para>
		/// </summary>
		public StringValue? DetailLineRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TimeDuration</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		public StringValue? Duration { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Earning Type</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? EarningType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DateTimeEnd_Date</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DateTimeEnd_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		public DateTimeValue? EndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FSAppointmentDet__InventoryID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Labor Item</para>
		/// </summary>
		public StringValue? LaborItemID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LineRef</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Ref. Nbr.</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		public StringValue? LogLineRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Status</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? LogLineStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: KeepDateTimes</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>Display Name: Manage Time Manually</para>
		/// </summary>
		public BooleanValue? ManageTimeManually { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectTaskID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocType</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BAccountID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>Display Name: Staff Member</para>
		/// </summary>
		public StringValue? StaffMember { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DateTimeBegin_Date</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DateTimeBegin_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		public DateTimeValue? StartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TimeCardCD</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>Display Name: Time Card Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? TimeCardRefNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Track Time</para>
		/// </summary>
		public BooleanValue? TrackTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		public BooleanValue? Travel { get; set; }

	}
}