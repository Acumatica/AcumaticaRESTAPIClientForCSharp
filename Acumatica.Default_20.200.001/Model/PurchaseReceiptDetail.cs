using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class PurchaseReceiptDetail : Entity_v4
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="AccrualAccount", EmitDefaultValue=false)]
		public StringValue AccrualAccount { get; set; }

		[DataMember(Name="AccrualSubaccount", EmitDefaultValue=false)]
		public StringValue AccrualSubaccount { get; set; }

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<PurchaseReceiptDetailAllocation> Allocations { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EditableUnitCost", EmitDefaultValue=false)]
		public BooleanValue EditableUnitCost { get; set; }

		[DataMember(Name="EstimatedINExtendedCost", EmitDefaultValue=false)]
		public DecimalValue EstimatedINExtendedCost { get; set; }

		[DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
		public DecimalValue ExtendedCost { get; set; }

		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue ExpirationDate { get; set; }

		[DataMember(Name="FinalINExtendedCost", EmitDefaultValue=false)]
		public DecimalValue FinalINExtendedCost { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="LineType", EmitDefaultValue=false)]
		public StringValue LineType { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue LotSerialNbr { get; set; }

		[DataMember(Name="OpenQty", EmitDefaultValue=false)]
		public DecimalValue OpenQty { get; set; }

		[DataMember(Name="OrderedQty", EmitDefaultValue=false)]
		public DecimalValue OrderedQty { get; set; }

		[DataMember(Name="POLineNbr", EmitDefaultValue=false)]
		public IntValue POLineNbr { get; set; }

		[DataMember(Name="POOrderNbr", EmitDefaultValue=false)]
		public StringValue POOrderNbr { get; set; }

		[DataMember(Name="POOrderType", EmitDefaultValue=false)]
		public StringValue POOrderType { get; set; }

		[DataMember(Name="POReceiptLineNbr", EmitDefaultValue=false)]
		public IntValue POReceiptLineNbr { get; set; }

		[DataMember(Name="POReceiptNbr", EmitDefaultValue=false)]
		public StringValue POReceiptNbr { get; set; }

		[DataMember(Name="ReceiptQty", EmitDefaultValue=false)]
		public DecimalValue ReceiptQty { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="TransactionDescription", EmitDefaultValue=false)]
		public StringValue TransactionDescription { get; set; }

		[DataMember(Name="TransferOrderNbr", EmitDefaultValue=false)]
		public StringValue TransferOrderNbr { get; set; }

		[DataMember(Name="TransferOrderLineNbr", EmitDefaultValue=false)]
		public IntValue TransferOrderLineNbr { get; set; }

		[DataMember(Name="TransferOrderType", EmitDefaultValue=false)]
		public StringValue TransferOrderType { get; set; }

		[DataMember(Name="TransferShipmentNbr", EmitDefaultValue=false)]
		public StringValue TransferShipmentNbr { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue UnitCost { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}