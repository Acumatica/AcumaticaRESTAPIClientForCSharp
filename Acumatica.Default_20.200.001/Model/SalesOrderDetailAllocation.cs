using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SalesOrderDetailAllocation : Entity_v4
	{

		[DataMember(Name="Allocated", EmitDefaultValue=false)]
		public BooleanValue Allocated { get; set; }

		[DataMember(Name="AllocWarehouseID", EmitDefaultValue=false)]
		public StringValue AllocWarehouseID { get; set; }

		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public BooleanValue Completed { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue ExpirationDate { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue LocationID { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue LotSerialNbr { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue OrderNbr { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="QtyOnShipments", EmitDefaultValue=false)]
		public DecimalValue QtyOnShipments { get; set; }

		[DataMember(Name="QtyReceived", EmitDefaultValue=false)]
		public DecimalValue QtyReceived { get; set; }

		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public StringValue RelatedDocument { get; set; }

		[DataMember(Name="ShipOn", EmitDefaultValue=false)]
		public DateTimeValue ShipOn { get; set; }

		[DataMember(Name="SplitLineNbr", EmitDefaultValue=false)]
		public IntValue SplitLineNbr { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

	}
}