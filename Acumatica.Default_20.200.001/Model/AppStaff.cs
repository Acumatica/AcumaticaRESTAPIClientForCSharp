using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class AppStaff : Entity_v4
	{

		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue AppointmentNbr { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DetailLineRef", EmitDefaultValue=false)]
		public StringValue DetailLineRef { get; set; }

		[DataMember(Name="EarningType", EmitDefaultValue=false)]
		public StringValue EarningType { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue LaborItem { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="LineRef", EmitDefaultValue=false)]
		public StringValue LineRef { get; set; }

		[DataMember(Name="PrimaryDriver", EmitDefaultValue=false)]
		public BooleanValue PrimaryDriver { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="RouteDriver", EmitDefaultValue=false)]
		public BooleanValue RouteDriver { get; set; }

		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue ServiceOrderType { get; set; }

		[DataMember(Name="StaffMember", EmitDefaultValue=false)]
		public StringValue StaffMember { get; set; }

		[DataMember(Name="StaffType", EmitDefaultValue=false)]
		public StringValue StaffType { get; set; }

		[DataMember(Name="TrackTime", EmitDefaultValue=false)]
		public BooleanValue TrackTime { get; set; }

	}
}