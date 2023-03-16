using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class VendorShipment : Entity
	{

		[DataMember(Name="ControlQuantity", EmitDefaultValue=false)]
		public DecimalValue ControlQuantity { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<VendorShipmentDetails> Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="ShipmentDate", EmitDefaultValue=false)]
		public DateTimeValue ShipmentDate { get; set; }

		[DataMember(Name="ShipmentID", EmitDefaultValue=false)]
		public StringValue ShipmentID { get; set; }

		[DataMember(Name="ShippedQuantity", EmitDefaultValue=false)]
		public DecimalValue ShippedQuantity { get; set; }

		[DataMember(Name="ShippingSettings", EmitDefaultValue=false)]
		public ShipToSettings ShippingSettings { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue Vendor { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue Workgroup { get; set; }

	}
}