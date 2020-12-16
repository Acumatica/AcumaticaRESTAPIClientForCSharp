using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class AppLogs : Entity_v4
	{

		[DataMember(Name="AddtoActualDuration", EmitDefaultValue=false)]
		public BooleanValue AddtoActualDuration { get; set; }

		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue AppointmentNbr { get; set; }

		[DataMember(Name="Approved", EmitDefaultValue=false)]
		public BooleanValue Approved { get; set; }

		[DataMember(Name="BillableAmount", EmitDefaultValue=false)]
		public DecimalValue BillableAmount { get; set; }

		[DataMember(Name="BillableLabor", EmitDefaultValue=false)]
		public BooleanValue BillableLabor { get; set; }

		[DataMember(Name="BillableTime", EmitDefaultValue=false)]
		public StringValue BillableTime { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DetailLineRef", EmitDefaultValue=false)]
		public StringValue DetailLineRef { get; set; }

		[DataMember(Name="Duration", EmitDefaultValue=false)]
		public StringValue Duration { get; set; }

		[DataMember(Name="EarningType", EmitDefaultValue=false)]
		public StringValue EarningType { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue EndTime { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LaborItemID", EmitDefaultValue=false)]
		public StringValue LaborItemID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="LogLineRef", EmitDefaultValue=false)]
		public StringValue LogLineRef { get; set; }

		[DataMember(Name="LogLineStatus", EmitDefaultValue=false)]
		public StringValue LogLineStatus { get; set; }

		[DataMember(Name="ManageTimeManually", EmitDefaultValue=false)]
		public BooleanValue ManageTimeManually { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue ServiceOrderType { get; set; }

		[DataMember(Name="StaffMember", EmitDefaultValue=false)]
		public StringValue StaffMember { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="StartTime", EmitDefaultValue=false)]
		public DateTimeValue StartTime { get; set; }

		[DataMember(Name="TimeCardRefNbr", EmitDefaultValue=false)]
		public StringValue TimeCardRefNbr { get; set; }

		[DataMember(Name="TrackTime", EmitDefaultValue=false)]
		public BooleanValue TrackTime { get; set; }

		[DataMember(Name="Travel", EmitDefaultValue=false)]
		public BooleanValue Travel { get; set; }

	}
}