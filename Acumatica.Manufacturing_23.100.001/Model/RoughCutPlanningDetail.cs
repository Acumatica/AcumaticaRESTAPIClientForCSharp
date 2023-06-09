using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class RoughCutPlanningDetail : Entity
	{

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="Constraint", EmitDefaultValue=false)]
		public DateTimeValue Constraint { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DispatchPriority", EmitDefaultValue=false)]
		public ShortValue DispatchPriority { get; set; }

		[DataMember(Name="EndDate", EmitDefaultValue=false)]
		public DateTimeValue EndDate { get; set; }

		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue EndTime { get; set; }

		[DataMember(Name="FirmSchedule", EmitDefaultValue=false)]
		public BooleanValue FirmSchedule { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="OrderDate", EmitDefaultValue=false)]
		public DateTimeValue OrderDate { get; set; }

		[DataMember(Name="OrderDescription", EmitDefaultValue=false)]
		public StringValue OrderDescription { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue ProductionNbr { get; set; }

		[DataMember(Name="QtyRemaining", EmitDefaultValue=false)]
		public DecimalValue QtyRemaining { get; set; }

		[DataMember(Name="QtytoProduce", EmitDefaultValue=false)]
		public DecimalValue QtytoProduce { get; set; }

		[DataMember(Name="ScheduleID", EmitDefaultValue=false)]
		public IntValue ScheduleID { get; set; }

		[DataMember(Name="ScheduleStatus", EmitDefaultValue=false)]
		public StringValue ScheduleStatus { get; set; }

		[DataMember(Name="SchedulingMethod", EmitDefaultValue=false)]
		public StringValue SchedulingMethod { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue Selected { get; set; }

		[DataMember(Name="SOOrderNbr", EmitDefaultValue=false)]
		public StringValue SOOrderNbr { get; set; }

		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue StartDate { get; set; }

		[DataMember(Name="StartTime", EmitDefaultValue=false)]
		public DateTimeValue StartTime { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}