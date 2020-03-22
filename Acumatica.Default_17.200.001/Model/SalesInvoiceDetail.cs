using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class SalesInvoiceDetail : Entity
	{

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue BranchID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue OrderNbr { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue Qty { get; set; }

		[DataMember(Name="ShipmentNbr", EmitDefaultValue=false)]
		public StringValue ShipmentNbr { get; set; }

		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue UnitPrice { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

	}
}