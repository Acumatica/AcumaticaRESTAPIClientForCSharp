using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ShipmentOrderDetail : Entity_v4
	{

		[DataMember(Name="InventoryDocType", EmitDefaultValue=false)]
		public StringValue InventoryDocType { get; set; }

		[DataMember(Name="InventoryRefNbr", EmitDefaultValue=false)]
		public StringValue InventoryRefNbr { get; set; }

		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue InvoiceNbr { get; set; }

		[DataMember(Name="InvoiceType", EmitDefaultValue=false)]
		public StringValue InvoiceType { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue OrderNbr { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue ShipmentNbr { get; set; }

		[DataMember(Name="ShipmentType", EmitDefaultValue=false)]
		public StringValue ShipmentType { get; set; }

		[DataMember(Name="ShippedQty", EmitDefaultValue=false)]
		public DecimalValue ShippedQty { get; set; }

		[DataMember(Name="ShippedVolume", EmitDefaultValue=false)]
		public DecimalValue ShippedVolume { get; set; }

		[DataMember(Name="ShippedWeight", EmitDefaultValue=false)]
		public DecimalValue ShippedWeight { get; set; }

	}
}