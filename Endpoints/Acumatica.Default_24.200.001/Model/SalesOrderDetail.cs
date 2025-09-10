using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class SalesOrderDetail : Entity
	{

		/// <summary>
		/// The account associated with the sale of the line item.
		/// DAC Field Name: SalesAcctID 
		/// DAC: PX.Objects.SO.SOLine 
		/// </summary>
		/// <remarks>
		/// The field is included in the SalesAccount foreign key. The field is the identifier of theSales Account Account.accountID.
		/// </remarks>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<SalesOrderDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// The alternate ID for the item, such as the barcode or the inventory ID used by the customer.
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Alternate ID 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="AlternateID", EmitDefaultValue=false)]
		public StringValue? AlternateID { get; set; }

		/// <summary>
		/// The amount of the line, which the system calculates as the extended price minusthe line-level discount (in the currency of the document).
		/// DAC Field Name: CuryLineAmt 
		/// DAC: PX.Objects.SO.SOLine 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the line of the Issue type willbe created automatically for each order line of the Receipt type if the order is of the RR type.
		/// DAC Field Name: AutoCreateIssueLine 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Auto Create Issue 
		/// </summary>
		[DataMember(Name="AutoCreateIssue", EmitDefaultValue=false)]
		public BooleanValue? AutoCreateIssue { get; set; }

		/// <summary>
		/// Average cost of the Inventory Item of the line.
		/// DAC Field Name: AvgCost 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Average Cost 
		/// </summary>
		[DataMember(Name="AverageCost", EmitDefaultValue=false)]
		public DecimalValue? AverageCost { get; set; }

		/// <summary>
		/// The identifier of the branch.The field is included in the Branch foreign key.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		[DataMember(Name="CalculateDiscountsOnImport", EmitDefaultValue=false)]
		public BooleanValue? CalculateDiscountsOnImport { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the line is subjected to a sales commission.
		/// DAC: PX.Objects.SO.SOLine 
		/// </summary>
		/// <remarks>
		/// This field is available only if the Commissionsfeature is enabled on the Enable/Disable Features (CS100000) form.This field is not available for orders of the TR type.
		/// </remarks>
		[DataMember(Name="Commissionable", EmitDefaultValue=false)]
		public BooleanValue? Commissionable { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the line is completed.
		/// DAC: PX.Objects.SO.SOLine 
		/// </summary>
		[DataMember(Name="Completed", EmitDefaultValue=false)]
		public BooleanValue? Completed { get; set; }

		/// <summary>
		/// The cost code with which this document is associated to track project costs and revenue.
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Cost Code 
		/// </summary>
		/// <remarks>
		/// The field is included in the  foreign key. The field is the identifier ofthe cost code ..This field is available only if the Cost Codesfeature is enabled on the Enable/Disable Features (CS100000) form in addition to the integration of theProjects submodule with Sales Orders.
		/// </remarks>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The reference number of the original customer document that the sales order is based on.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Customer Order Nbr. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		/// <remarks>
		/// A reference number must be specified if theRequire Customer Order Nbr field istrue for the order type.This field is available for orders of the TR type.
		/// </remarks>
		[DataMember(Name="CustomerOrderNbr", EmitDefaultValue=false)]
		public StringValue? CustomerOrderNbr { get; set; }

		/// <summary>
		/// The amount of the line-level discount of the line(in the currency of the document).
		/// DAC Field Name: CuryDiscAmt 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Discount Amount 
		/// </summary>
		[DataMember(Name="DiscountAmount", EmitDefaultValue=false)]
		public DecimalValue? DiscountAmount { get; set; }

		/// <summary>
		/// The code of the discount of the line.
		/// DAC Field Name: DiscountID 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Discount Code 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		/// <remarks>
		/// The field is included in the following foreign keys:                        . The field is the identifier of the Discount            .            . The field is a part of the identifier of the Discount Sequence            .                        This field is available only if the            Customer Discounts            feature is enabled on the Enable/Disable Features (CS100000) form.            
		/// </remarks>
		[DataMember(Name="DiscountCode", EmitDefaultValue=false)]
		public StringValue? DiscountCode { get; set; }

		/// <summary>
		/// The unit price, which has been recalculated after the application of discounts(in the currency of the document).
		/// DAC Field Name: CuryDiscPrice 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Disc. Unit Price 
		/// </summary>
		[DataMember(Name="DiscountedUnitPrice", EmitDefaultValue=false)]
		public DecimalValue? DiscountedUnitPrice { get; set; }

		/// <summary>
		/// The percent of the line-level discount.
		/// DAC Field Name: DiscPct 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Discount Percent 
		/// </summary>
		/// <remarks>
		/// If the Manual Discount field value is true, it indicatesthat the percent of the discount is specified by the line discount that has been applied manually, or hasbeen entered manually or calculated based on the discount amount of the line.
		/// </remarks>
		[DataMember(Name="DiscountPercent", EmitDefaultValue=false)]
		public DecimalValue? DiscountPercent { get; set; }

		/// <summary>
		/// The extended price of the item line (in the currency of the document).
		/// DAC Field Name: CuryExtPrice 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Ext. Price 
		/// </summary>
		[DataMember(Name="ExtendedPrice", EmitDefaultValue=false)]
		public DecimalValue? ExtendedPrice { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the inventory item specified in the row is a free item.
		/// DAC Field Name: IsFree 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Free Item 
		/// </summary>
		/// <remarks>
		/// If the field value is true then the system updates theUnit Price, Discount Percent,Discount Amount, and  Ext. Price amounts with 0 andset Manual Discount field to true.
		/// </remarks>
		[DataMember(Name="FreeItem", EmitDefaultValue=false)]
		public BooleanValue? FreeItem { get; set; }

		/// <summary>
		/// The inventory ID of the Inventory Item to be sold or returned.
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Inventory ID 
		/// </summary>
		/// <remarks>
		/// The field is included in the following foreign keys:. The field is the identifier of the Stock Item or Non-Stock Item.. The field is a part of the identifier of the warehouse container.. The field is a part of the identifier of the Location inventory itemstatus .. The field is a part of the identifier of the Location inventoryitem status by Lot Serial numbers.
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="InvoiceLineNbr", EmitDefaultValue=false)]
		public IntValue? InvoiceLineNbr { get; set; }

		/// <summary>
		/// The reference number of the original invoice (which lists the goods that were ordered andlater returned by the customer).The field is included in the Invoice foreign key.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Invoice Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		/// <remarks>
		/// This field is available for orders of the CR, RC, RR, and RM types.
		/// </remarks>
		[DataMember(Name="InvoiceNbr", EmitDefaultValue=false)]
		public StringValue? InvoiceNbr { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="InvoiceType", EmitDefaultValue=false)]
		public StringValue? InvoiceType { get; set; }

		[DataMember(Name="LastModifiedDate", EmitDefaultValue=false)]
		public StringValue? LastModifiedDate { get; set; }

		/// <summary>
		/// The description provided for the stock item.
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Line Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="LineDescription", EmitDefaultValue=false)]
		public StringValue? LineDescription { get; set; }

		/// <summary>
		/// The line number of the document.
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// The type of the line.
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Line Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="LineType", EmitDefaultValue=false)]
		public StringValue? LineType { get; set; }

		/// <summary>
		/// The identifier of the location of the original sales order.
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.SO.SOLine 
		/// </summary>
		/// <remarks>
		/// The field is included in the following foreign keys:. The field is the identifier of the Location.. The field is a part of the identifier of the Location inventory itemstatus .. The field is a part of the identifier of the Location inventoryitem status by Lot Serial numbers.
		/// </remarks>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the discount has been applied manually.
		/// DAC Field Name: ManualDisc 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Manual Discount 
		/// </summary>
		[DataMember(Name="ManualDiscount", EmitDefaultValue=false)]
		public BooleanValue? ManualDiscount { get; set; }

		/// <summary>
		/// A Boolean value that indicates whether the order line was marked for purchasing (if it has not been shippedcompletely) and the line will be available for adding to a purchase order. 
		/// DAC Field Name: POCreate 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Mark for PO 
		/// </summary>
		[DataMember(Name="MarkForPO", EmitDefaultValue=false)]
		public BooleanValue? MarkForPO { get; set; }

		/// <summary>
		/// The quantity of the item to be shipped.
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Open Qty. 
		/// </summary>
		/// <remarks>
		/// That is, the total quantity minus the quantity shipped according to closed shipment documents.
		/// </remarks>
		[DataMember(Name="OpenQty", EmitDefaultValue=false)]
		public DecimalValue? OpenQty { get; set; }

		/// <summary>
		/// The part of the identifier of the operation to be performed ininventory to fulfill the order.The field is included in the OrderTypeOperation foreign key.
		/// DAC: PX.Objects.SO.SOLine 
		/// SQL Type: char(1) 
		/// </summary>
		/// <remarks>
		/// An order of the RR or RM type includes lines with the Receipt operation and lines with theIssue operation. Orders of other return types include only lines withthe Receipt operation.
		/// </remarks>
		[DataMember(Name="Operation", EmitDefaultValue=false)]
		public StringValue? Operation { get; set; }

		/// <summary>
		/// The summarized quantity of all items that have been added to the child order from the blanket sales order.
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Ordered Qty. 
		/// </summary>
		/// <remarks>
		/// If any items that are not from the current blanket sales order have been added to the child order,their quantity is not summed up to the value in this field.
		/// </remarks>
		[DataMember(Name="OrderQty", EmitDefaultValue=false)]
		public DecimalValue? OrderQty { get; set; }

		/// <summary>
		/// The maximum percentage of goods shipped (with respect to the ordered quantity) allowed by the customer.
		/// DAC Field Name: CompleteQtyMax 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Overship Threshold (%) 
		/// </summary>
		[DataMember(Name="OvershipThreshold", EmitDefaultValue=false)]
		public DecimalValue? OvershipThreshold { get; set; }

		/// <summary>
		/// The purchase order source to be used to fulfill this line.
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: PO Source 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="POSource", EmitDefaultValue=false)]
		public StringValue? POSource { get; set; }

		/// <summary>
		/// The task of the project with which this document is associated.
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Project Task 
		/// </summary>
		/// <remarks>
		/// The field is included in the  foreign key. The field is a part of the identifierof the Project Task ..This field is available only if theProject Accountingfeature is enabled on the Enable/Disable Features (CS100000) form and the integration of the Projectssubmodule with Sales Orders has been enabled.
		/// </remarks>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// The identifier of the destination warehouse for the items to be purchased.The field is included in the POSite foreign key.
		/// DAC Field Name: POSiteID 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Purchase Warehouse 
		/// </summary>
		[DataMember(Name="PurchaseWarehouse", EmitDefaultValue=false)]
		public StringValue? PurchaseWarehouse { get; set; }

		[DataMember(Name="PurchasingDetails", EmitDefaultValue=false)]
		public List<PurchasingDetail>? PurchasingDetails { get; set; }

		/// <summary>
		/// The identifier of the Vendor of the sales order.
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Vendor 
		/// </summary>
		/// <remarks>
		/// The field is included in the Vendor foreign key. The field is a part of the identifier ofthe Vendor Vendor.bAccountID.
		/// </remarks>
		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// The quantity of the stock item being prepared for shipment and already shipped for this order.
		/// DAC Field Name: ShippedQty 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Qty. On Shipments 
		/// </summary>
		[DataMember(Name="QtyOnShipments", EmitDefaultValue=false)]
		public DecimalValue? QtyOnShipments { get; set; }

		/// <summary>
		/// The reason code to be used for creation or cancellation of the order, if applicable.
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Reason Code 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		/// <remarks>
		/// The field is included in the ReasonCode foreign key. The field is the identifier of thereason code ReasonCode.reasonCodeID.
		/// </remarks>
		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// The date when the customer wants to receive the goods.
		/// DAC Field Name: RequestDate 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Requested On 
		/// </summary>
		/// <remarks>
		/// This date provides the default values for the requestDate dates for order lines.
		/// </remarks>
		[DataMember(Name="RequestedOn", EmitDefaultValue=false)]
		public DateTimeValue? RequestedOn { get; set; }

		/// <summary>
		/// The identifier of the salesperson to be used by defaultfor each sales order line.The field is included in the SalesPerson foreign key.
		/// DAC Field Name: SalesPersonID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Default Salesperson 
		/// </summary>
		[DataMember(Name="SalespersonID", EmitDefaultValue=false)]
		public StringValue? SalespersonID { get; set; }

		/// <summary>
		/// The date on which a child order should be generated for the line of the blanket sales order.
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Sched. Order Date 
		/// </summary>
		/// <remarks>
		/// This field is available only for blanket sales orders.
		/// </remarks>
		[DataMember(Name="SchedOrderDate", EmitDefaultValue=false)]
		public DateTimeValue? SchedOrderDate { get; set; }

		/// <summary>
		/// The date when the ordered goods are scheduled to be shipped.
		/// DAC Field Name: ShipDate 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Sched. Shipment 
		/// </summary>
		/// <remarks>
		/// By default, it is the date that is specified in requestDate minus the number of lead days,but it is not earlier than the current business date.
		/// </remarks>
		[DataMember(Name="ShipOn", EmitDefaultValue=false)]
		public DateTimeValue? ShipOn { get; set; }

		/// <summary>
		/// An option that controls whether incomplete and partial shipments for the order are allowed.
		/// DAC Field Name: ShipComplete 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Shipping Rule 
		/// SQL Type: char(1) 
		/// </summary>
		/// <remarks>
		/// This field is available only if the Inventoryfeature is enabled on the Enable/Disable Features (CS100000) form.form.
		/// </remarks>
		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue? ShippingRule { get; set; }

		/// <summary>
		/// The identifier of the customer location.The field is included in the CustomerLocation foreign key.
		/// DAC Field Name: CustomerLocationID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Location 
		/// </summary>
		[DataMember(Name="ShipToLocation", EmitDefaultValue=false)]
		public StringValue? ShipToLocation { get; set; }

		/// <summary>
		/// Represents a Subitem (or subitem code), which is used to indicate the particular size, color, or othervariation of the inventory item.
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.SO.SOLine 
		/// </summary>
		/// <remarks>
		/// The field is included in the following foreign keys:. The field is the identifier of the Subitem.. The field is a part of the identifier of the warehouse container.. The field is a part of the identifier of the Location inventory itemstatus .. The field is a part of the identifier of the Location inventoryitem status by Lot Serial numbers.
		/// </remarks>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// The tax category of the goods mentioned in this line.
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		/// <remarks>
		/// The field is included in the  foreign key.The field is the identifier of the tax category..This field is not available for orders of the TR type.
		/// </remarks>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// The identifier of the tax zone to be used to process customer sales orders.The field is included in the TaxZone foreign key.
		/// DAC Field Name: TaxZoneID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Customer Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// The unbilled amount for a stock item with theGoods for Inventory line type or a non-stock item with theNon-Inventory Goods line type (in the currency of the document).
		/// DAC Field Name: CuryUnbilledAmt 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Unbilled Amount 
		/// </summary>
		[DataMember(Name="UnbilledAmount", EmitDefaultValue=false)]
		public DecimalValue? UnbilledAmount { get; set; }

		/// <summary>
		/// The minimum percentage of goods shipped (with respect to the ordered quantity) for the system to mark theorder as completely shipped.
		/// DAC Field Name: CompleteQtyMin 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Undership Threshold (%) 
		/// </summary>
		[DataMember(Name="UndershipThreshold", EmitDefaultValue=false)]
		public DecimalValue? UndershipThreshold { get; set; }

		/// <summary>
		/// The unit cost at which the item being returned was issued from inventory whenit was sold (in the currency of the document).
		/// DAC Field Name: CuryUnitCost 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// The unit price of the item (in the currency of the document).
		/// DAC Field Name: CuryUnitPrice 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Unit Price 
		/// </summary>
		[DataMember(Name="UnitPrice", EmitDefaultValue=false)]
		public DecimalValue? UnitPrice { get; set; }

		/// <summary>
		/// The unit of measure (UOM) used for the item with this inventory ID.
		/// DAC: PX.Objects.SO.SOLine 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// The identifier of the warehouse from which the specified quantity of theInventory Item should be delivered.
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.SO.SOLine 
		/// Display Name: Warehouse 
		/// </summary>
		/// <remarks>
		/// The field is included in the following foreign keys:. The field is identifier of the Warehouse.. The field is a part of the identifier of the Warehouse inventory itemstatus .. The field is a part of the identifier of the Location inventory itemstatus .. The field is a part of the identifier of the Location inventoryitem status by Lot Serial numbers.This field is available only if the Multiple Warehousesfeature is enabled on the Enable/Disable Features (CS100000) form.
		/// </remarks>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		[DataMember(Name="AssociatedOrderLineNbr", EmitDefaultValue=false)]
		public IntValue? AssociatedOrderLineNbr { get; set; }

		[DataMember(Name="GiftMessage", EmitDefaultValue=false)]
		public StringValue? GiftMessage { get; set; }

		[DataMember(Name="ManualPrice", EmitDefaultValue=false)]
		public BooleanValue? ManualPrice { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue? ExternalRef { get; set; }

	}
}