using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SalesOrderDetail : Entity_v4
	{

		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue Account { get; set; }

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<SalesOrderDetailAllocation> Allocations { get; set; }

		[DataMember(Name="AlternateID", EmitDefaultValue=false)]
		public StringValue AlternateID { get; set; }

		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue Amount { get; set; }

		[DataMember(Name="AutoCreateIssue", EmitDefaultValue=false)]
		public BooleanValue AutoCreateIssue { get; set; }

		[DataMember(Name="AverageCost", EmitDefaultValue=false)]
		public DecimalValue AverageCost { get; set; }

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="CalculateDiscountsOnImport", EmitDefaultValue=false)]
		public BooleanValue CalculateDiscountsOnImport { get; set; }

		[DataMember(Name="Commissionable", EmitDefaultValue=false)]
		public BooleanValue Commissionable { get; set; }

		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public BooleanValue Completed { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue DiscountAmount { get; set; }

		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue DiscountCode { get; set; }

		[DataMember(Name="DiscountedUnitPrice", EmitDefaultValue=false)]
		public DecimalValue DiscountedUnitPrice { get; set; }

		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue DiscountPercent { get; set; }

		[DataMember(Name="ExtendedPrice", EmitDefaultValue=false)]
		public DecimalValue ExtendedPrice { get; set; }

		[DataMember(Name="FreeItem", EmitDefaultValue=false)]
		public BooleanValue FreeItem { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="LastModifiedDate", EmitDefaultValue=false)]
		public StringValue LastModifiedDate { get; set; }

		[DataMember(Name="LineDescription", EmitDefaultValue=false)]
		public StringValue LineDescription { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="LineType", EmitDefaultValue=false)]
		public StringValue LineType { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue Location { get; set; }

		[DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
		public BooleanValue ManualDiscount { get; set; }

		[DataMember(Name="MarkForPO", EmitDefaultValue=false)]
		public BooleanValue MarkForPO { get; set; }

		[DataMember(Name="OpenQty", EmitDefaultValue=false)]
		public DecimalValue OpenQty { get; set; }

		[DataMember(Name="Operation", EmitDefaultValue=false)]
		public StringValue Operation { get; set; }

		[DataMember(Name="OrderQty", EmitDefaultValue=false)]
		public DecimalValue OrderQty { get; set; }

		[DataMember(Name="OvershipThreshold", EmitDefaultValue=false)]
		public DecimalValue OvershipThreshold { get; set; }

		[DataMember(Name="POSource", EmitDefaultValue=false)]
		public StringValue POSource { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="PurchasingSettings", EmitDefaultValue=false)]
		public PurchaseSettings PurchasingSettings { get; set; }

		[DataMember(Name="QtyOnShipments", EmitDefaultValue=false)]
		public DecimalValue QtyOnShipments { get; set; }

		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue ReasonCode { get; set; }

		[DataMember(Name="RequestedOn", EmitDefaultValue=false)]
		public DateTimeValue RequestedOn { get; set; }

		[DataMember(Name="SalespersonID", EmitDefaultValue=false)]
		public StringValue SalespersonID { get; set; }

		[DataMember(Name="ShipOn", EmitDefaultValue=false)]
		public DateTimeValue ShipOn { get; set; }

		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue ShippingRule { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="UnbilledAmount", EmitDefaultValue=false)]
		public DecimalValue UnbilledAmount { get; set; }

		[DataMember(Name="UndershipThreshold", EmitDefaultValue=false)]
		public DecimalValue UndershipThreshold { get; set; }

		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue UnitCost { get; set; }

		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue UnitPrice { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue UOM { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }

	}
}