using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class InventorySummaryRow : Entity_v4
	{

		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue BaseUOM { get; set; }

		[DataMember(Name="EstimatedTotalCost", EmitDefaultValue=false)]
		public DecimalValue EstimatedTotalCost { get; set; }

		[DataMember(Name="EstimatedUnitCost", EmitDefaultValue=false)]
		public DecimalValue EstimatedUnitCost { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue ExpirationDate { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue LocationID { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue LotSerialNbr { get; set; }

		[DataMember(Name="QtyAvailable", EmitDefaultValue=false)]
		public DecimalValue QtyAvailable { get; set; }

		[DataMember(Name="QtyAvailableForShipment", EmitDefaultValue=false)]
		public DecimalValue QtyAvailableForShipment { get; set; }

		[DataMember(Name="QtyNotAvailable", EmitDefaultValue=false)]
		public DecimalValue QtyNotAvailable { get; set; }

		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue QtyOnHand { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }

	}
}