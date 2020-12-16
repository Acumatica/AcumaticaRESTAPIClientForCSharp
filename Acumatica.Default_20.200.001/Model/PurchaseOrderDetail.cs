using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class PurchaseOrderDetail : Entity_v4
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="AlternateID", EmitDefaultValue=false)]
		public StringValue AlternateID { get; set; }

		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue BranchID { get; set; }

		[DataMember(Name="CalculateDiscountsOnImport", EmitDefaultValue=false)]
		public BooleanValue CalculateDiscountsOnImport { get; set; }

		[DataMember(Name="Cancelled", EmitDefaultValue=false)]
		public BooleanValue Cancelled { get; set; }

		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public BooleanValue Completed { get; set; }

		[DataMember(Name="CompleteOn", EmitDefaultValue=false)]
		public DecimalValue CompleteOn { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
		public DecimalValue ExtendedCost { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LineDescription", EmitDefaultValue=false)]
		public StringValue LineDescription { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="LineType", EmitDefaultValue=false)]
		public StringValue LineType { get; set; }

		[DataMember(Name="MaxReceiptPercent", EmitDefaultValue=false)]
		public DecimalValue MaxReceiptPercent { get; set; }

		[DataMember(Name="MinReceiptPercent", EmitDefaultValue=false)]
		public DecimalValue MinReceiptPercent { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue OrderNbr { get; set; }

		[DataMember(Name="OrderQty", EmitDefaultValue=false)]
		public DecimalValue OrderQty { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="OrigPONbr", EmitDefaultValue=false)]
		public StringValue OrigPONbr { get; set; }

		[DataMember(Name="OrigPOType", EmitDefaultValue=false)]
		public StringValue OrigPOType { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="Promised", EmitDefaultValue=false)]
		public DateTimeValue Promised { get; set; }

		[DataMember(Name="QtyOnReceipts", EmitDefaultValue=false)]
		public DecimalValue QtyOnReceipts { get; set; }

		[DataMember(Name="ReceiptAction", EmitDefaultValue=false)]
		public StringValue ReceiptAction { get; set; }

		[DataMember(Name="ReceivedAmount", EmitDefaultValue=false)]
		public DecimalValue ReceivedAmount { get; set; }

		[DataMember(Name="Requested", EmitDefaultValue=false)]
		public DateTimeValue Requested { get; set; }

		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue Subaccount { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue UnitCost { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }

	}
}