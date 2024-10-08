using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class AppLogs : Entity
	{

		/// <summary>
		/// DAC Field Name: TrackOnService 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// Display Name: Add to Actual Duration 
		/// </summary>
		[DataMember(Name="AddtoActualDuration", EmitDefaultValue=false)]
		public BooleanValue? AddtoActualDuration { get; set; }

		/// <summary>
		/// DAC Field Name: DocRefNbr 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// Display Name: Appointment Nbr. 
		/// SQL Type: nvarchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ApprovedTime 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// </summary>
		[DataMember(Name="Approved", EmitDefaultValue=false)]
		public BooleanValue? Approved { get; set; }

		/// <summary>
		/// DAC Field Name: CuryBillableTranAmount 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// Display Name: Billable Amount 
		/// </summary>
		[DataMember(Name="BillableAmount", EmitDefaultValue=false)]
		public DecimalValue? BillableAmount { get; set; }

		/// <summary>
		/// DAC Field Name: IsBillable 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Billable 
		/// </summary>
		[DataMember(Name="BillableLabor", EmitDefaultValue=false)]
		public BooleanValue? BillableLabor { get; set; }

		/// <summary>
		/// DAC Field Name: BillableTimeDuration 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// Display Name: Billable Time 
		/// </summary>
		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public StringValue? BillableTime { get; set; }

		/// <summary>
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: DetLineRef 
		/// DAC: PX.Objects.FS.FSLogActionStartFilter 
		/// Display Name: Detail Ref. Nbr. 
		/// SQL Type: nchar(4) 
		/// </summary>
		[DataMember(Name="DetailLineRef", EmitDefaultValue=false)]
		public StringValue? DetailLineRef { get; set; }

		/// <summary>
		/// DAC Field Name: TimeDuration 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// </summary>
		[DataMember(Name="Duration", EmitDefaultValue=false)]
		public StringValue? Duration { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentEmployee 
		/// Display Name: Earning Type 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="EarningType", EmitDefaultValue=false)]
		public StringValue? EarningType { get; set; }

		/// <summary>
		/// DAC Field Name: DateTimeEnd_Date 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// </summary>
		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue? EndDate { get; set; }

		/// <summary>
		/// DAC Field Name: DateTimeEnd_Time 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// </summary>
		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue? EndTime { get; set; }

		/// <summary>
		/// DAC Field Name: FSAppointmentDet__InventoryID 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentEmployee 
		/// Display Name: Labor Item 
		/// </summary>
		[DataMember(Name="LaborItemID", EmitDefaultValue=false)]
		public StringValue? LaborItemID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: LineRef 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Ref. Nbr. 
		/// SQL Type: char(4) 
		/// </summary>
		[DataMember(Name="LogLineRef", EmitDefaultValue=false)]
		public StringValue? LogLineRef { get; set; }

		/// <summary>
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Status 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="LogLineStatus", EmitDefaultValue=false)]
		public StringValue? LogLineStatus { get; set; }

		/// <summary>
		/// DAC Field Name: KeepDateTimes 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// Display Name: Manage Time Manually 
		/// </summary>
		[DataMember(Name="ManageTimeManually", EmitDefaultValue=false)]
		public BooleanValue? ManageTimeManually { get; set; }

		/// <summary>
		/// DAC Field Name: ProjectTaskID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// DAC Field Name: DocType 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Type 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// Display Name: Staff Member 
		/// </summary>
		[DataMember(Name="StaffMember", EmitDefaultValue=false)]
		public StringValue? StaffMember { get; set; }

		/// <summary>
		/// DAC Field Name: DateTimeBegin_Date 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// DAC Field Name: DateTimeBegin_Time 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// </summary>
		[DataMember(Name="StartTime", EmitDefaultValue=false)]
		public DateTimeValue? StartTime { get; set; }

		/// <summary>
		/// DAC Field Name: TimeCardCD 
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// Display Name: Time Card Ref. Nbr. 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="TimeCardRefNbr", EmitDefaultValue=false)]
		public StringValue? TimeCardRefNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentEmployee 
		/// Display Name: Track Time 
		/// </summary>
		[DataMember(Name="TrackTime", EmitDefaultValue=false)]
		public BooleanValue? TrackTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentLog 
		/// </summary>
		[DataMember(Name="Travel", EmitDefaultValue=false)]
		public BooleanValue? Travel { get; set; }

	}
}