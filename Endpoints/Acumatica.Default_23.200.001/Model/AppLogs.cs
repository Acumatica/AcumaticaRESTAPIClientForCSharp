using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class AppLogs : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: TrackOnService</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>Display Name: Add to Actual Duration</para>
		/// </summary>
		[DataMember(Name="AddtoActualDuration", EmitDefaultValue=false)]
		public BooleanValue? AddtoActualDuration { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocRefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>Display Name: Appointment Nbr.</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ApprovedTime</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		[DataMember(Name="Approved", EmitDefaultValue=false)]
		public BooleanValue? Approved { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryBillableTranAmount</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>Display Name: Billable Amount</para>
		/// </summary>
		[DataMember(Name="BillableAmount", EmitDefaultValue=false)]
		public DecimalValue? BillableAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsBillable</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Billable</para>
		/// </summary>
		[DataMember(Name="BillableLabor", EmitDefaultValue=false)]
		public BooleanValue? BillableLabor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BillableTimeDuration</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>Display Name: Billable Time</para>
		/// </summary>
		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public StringValue? BillableTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DetLineRef</para>
		/// <para>DAC: PX.Objects.FS.FSLogActionStartFilter</para>
		/// <para>Display Name: Detail Ref. Nbr.</para>
		/// <para>SQL Type: nchar(4)</para>
		/// </summary>
		[DataMember(Name="DetailLineRef", EmitDefaultValue=false)]
		public StringValue? DetailLineRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TimeDuration</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		[DataMember(Name="Duration", EmitDefaultValue=false)]
		public StringValue? Duration { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Earning Type</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="EarningType", EmitDefaultValue=false)]
		public StringValue? EarningType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DateTimeEnd_Date</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DateTimeEnd_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue? EndTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FSAppointmentDet__InventoryID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Labor Item</para>
		/// </summary>
		[DataMember(Name="LaborItemID", EmitDefaultValue=false)]
		public StringValue? LaborItemID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LineRef</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Ref. Nbr.</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		[DataMember(Name="LogLineRef", EmitDefaultValue=false)]
		public StringValue? LogLineRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Status</para>
		/// <para>DAC: PX.Objects.FS.FSAppointment</para>
		/// <para>Display Name: Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="LogLineStatus", EmitDefaultValue=false)]
		public StringValue? LogLineStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: KeepDateTimes</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>Display Name: Manage Time Manually</para>
		/// </summary>
		[DataMember(Name="ManageTimeManually", EmitDefaultValue=false)]
		public BooleanValue? ManageTimeManually { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectTaskID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentDet</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocType</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BAccountID</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>Display Name: Staff Member</para>
		/// </summary>
		[DataMember(Name="StaffMember", EmitDefaultValue=false)]
		public StringValue? StaffMember { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DateTimeBegin_Date</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DateTimeBegin_Time</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		[DataMember(Name="StartTime", EmitDefaultValue=false)]
		public DateTimeValue? StartTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TimeCardCD</para>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// <para>Display Name: Time Card Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="TimeCardRefNbr", EmitDefaultValue=false)]
		public StringValue? TimeCardRefNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentEmployee</para>
		/// <para>Display Name: Track Time</para>
		/// </summary>
		[DataMember(Name="TrackTime", EmitDefaultValue=false)]
		public BooleanValue? TrackTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSAppointmentLog</para>
		/// </summary>
		[DataMember(Name="Travel", EmitDefaultValue=false)]
		public BooleanValue? Travel { get; set; }

	}
}