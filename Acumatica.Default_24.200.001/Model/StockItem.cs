using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen IN202500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class StockItem : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The ABC code, to which the item is assigned for the purpose of physical inventories.The field is relevant only for Stock Items (see StkItem).
		/// DAC Field Name: ABCCodeID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: ABC Code 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ABCCode", EmitDefaultValue=false)]
		public StringValue? ABCCode { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// DAC Field Name: LotSerNumVal 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		[DataMember(Name="AutoIncrementalValue", EmitDefaultValue=false)]
		public StringValue? AutoIncrementalValue { get; set; }

		/// <summary>
		/// DAC Field Name: AvgCost 
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="AverageCost", EmitDefaultValue=false)]
		public DecimalValue? AverageCost { get; set; }

		/// <summary>
		/// The Unit of Measure used as the base unit for the Inventory Item.
		/// DAC Field Name: BaseUnit 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Base Unit 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue? BaseUOM { get; set; }

		[DataMember(Name="Boxes", EmitDefaultValue=false)]
		public List<BoxStockItem>? Boxes { get; set; }

		[DataMember(Name="Categories", EmitDefaultValue=false)]
		public List<CategoryStockItem>? Categories { get; set; }

		/// <summary>
		/// The expense Account used to record the cost of goods sold for this item when a sales order for it is released.Applicable only for Stock Items (see StkItem).
		/// DAC Field Name: COGSAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: COGS Account 
		/// </summary>
		[DataMember(Name="COGSAccount", EmitDefaultValue=false)]
		public StringValue? COGSAccount { get; set; }

		/// <summary>
		/// The Subaccount used to record the cost of goods sold for this item when a sales order for it is released.Applicable only for Stock Items (see StkItem).
		/// DAC Field Name: COGSSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: COGS Sub. 
		/// </summary>
		[DataMember(Name="COGSSubaccount", EmitDefaultValue=false)]
		public StringValue? COGSSubaccount { get; set; }

		/// <summary>
		/// Rich text description of the item.
		/// DAC Field Name: Body 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Content", EmitDefaultValue=false)]
		public StringValue? Content { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Country Of Origin 
		/// SQL Type: nvarchar(2) 
		/// </summary>
		[DataMember(Name="CountryOfOrigin", EmitDefaultValue=false)]
		public StringValue? CountryOfOrigin { get; set; }

		[DataMember(Name="CrossReferences", EmitDefaultValue=false)]
		public List<InventoryItemCrossReference>? CrossReferences { get; set; }

		/// <summary>
		/// The current standard cost of the item.
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Current Cost 
		/// </summary>
		[DataMember(Name="CurrentStdCost", EmitDefaultValue=false)]
		public DecimalValue? CurrentStdCost { get; set; }

		/// <summary>
		/// The Location of warehouse used by default to issue items of this kind.Applicable only for Stock Items (see StkItem) when the Warehouse Locations feature is enabled.
		/// DAC Field Name: DfltShipLocationID 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Default Issue From 
		/// </summary>
		[DataMember(Name="DefaultIssueLocationID", EmitDefaultValue=false)]
		public StringValue? DefaultIssueLocationID { get; set; }

		/// <summary>
		/// The price used as the default price, if there are no other prices defined for this item in any price list in the Accounts Receivable module.
		/// DAC Field Name: BasePrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Default Price 
		/// </summary>
		[DataMember(Name="DefaultPrice", EmitDefaultValue=false)]
		public DecimalValue? DefaultPrice { get; set; }

		/// <summary>
		/// The Location of warehouse used by default to receive items of this kind.Applicable only for Stock Items (see StkItem) when the Warehouse Locations feature is enabled.
		/// DAC Field Name: DfltReceiptLocationID 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Default Receipt To 
		/// </summary>
		[DataMember(Name="DefaultReceiptLocationID", EmitDefaultValue=false)]
		public StringValue? DefaultReceiptLocationID { get; set; }

		/// <summary>
		/// The default Subitem for this item, which is used when there are no subitemsor when specifying subitems is not important.This field is relevant only if the Inventory Subitems feature is enabled.
		/// DAC Field Name: DefaultSubItemID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Default Subitem 
		/// </summary>
		[DataMember(Name="DefaultSubitem", EmitDefaultValue=false)]
		public StringValue? DefaultSubitem { get; set; }

		/// <summary>
		/// The default Warehouse used to store the items of this kind.Applicable only for Stock Items (see StkItem) and when the Warehouses feature is enabled.
		/// DAC Field Name: DfltSiteID 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Default Warehouse 
		/// </summary>
		[DataMember(Name="DefaultWarehouseID", EmitDefaultValue=false)]
		public StringValue? DefaultWarehouseID { get; set; }

		/// <summary>
		/// DAC Field Name: DeferralAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Deferral Account 
		/// </summary>
		[DataMember(Name="DeferralAccount", EmitDefaultValue=false)]
		public StringValue? DeferralAccount { get; set; }

		/// <summary>
		/// DAC Field Name: DeferralSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Deferral Sub. 
		/// </summary>
		[DataMember(Name="DeferralSubaccount", EmitDefaultValue=false)]
		public StringValue? DeferralSubaccount { get; set; }

		/// <summary>
		/// The description of the Inventory Item.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The volume of the Base Unit of the item.
		/// DAC Field Name: BaseItemVolume 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Volume 
		/// </summary>
		[DataMember(Name="DimensionVolume", EmitDefaultValue=false)]
		public DecimalValue? DimensionVolume { get; set; }

		/// <summary>
		/// The weight of the Base Unit of the item.
		/// DAC Field Name: BaseItemWeight 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Weight 
		/// </summary>
		[DataMember(Name="DimensionWeight", EmitDefaultValue=false)]
		public DecimalValue? DimensionWeight { get; set; }

		[DataMember(Name="DiscountAccount", EmitDefaultValue=false)]
		public StringValue? DiscountAccount { get; set; }

		[DataMember(Name="DiscountSubaccount", EmitDefaultValue=false)]
		public StringValue? DiscountSubaccount { get; set; }

		/// <summary>
		/// The URL of the image associated with the item.
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Image 
		/// SQL Type: varchar(255) 
		/// </summary>
		[DataMember(Name="ImageUrl", EmitDefaultValue=false)]
		public StringValue? ImageUrl { get; set; }

		/// <summary>
		/// The asset Account used to keep the inventory balance, resulting from the transactions with this item.Applicable only for Stock Items (see StkItem).
		/// DAC Field Name: InvtAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Inventory Account 
		/// </summary>
		[DataMember(Name="InventoryAccount", EmitDefaultValue=false)]
		public StringValue? InventoryAccount { get; set; }

		/// <summary>
		/// Key field.The user-friendly unique identifier of the Inventory Item.The structure of the identifier is determined by the INVENTORY Segmented Key.
		/// DAC Field Name: InventoryCD 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Inventory ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The Subaccount used to keep the inventory balance, resulting from the transactions with this item.Applicable only for Stock Items (see StkItem).
		/// DAC Field Name: InvtSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Inventory Sub. 
		/// </summary>
		[DataMember(Name="InventorySubaccount", EmitDefaultValue=false)]
		public StringValue? InventorySubaccount { get; set; }

		/// <summary>
		/// When set to true, indicates that the item is a kit.Kits are stock or non-stock items that consist of other items and are sold as a whole.
		/// DAC Field Name: KitItem 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Is a Kit 
		/// </summary>
		[DataMember(Name="IsAKit", EmitDefaultValue=false)]
		public BooleanValue? IsAKit { get; set; }

		/// <summary>
		/// The identifier of the Item Class, to which the Inventory Item belongs.Item Classes provide default settings for items, which belong to them, and are used to group items.
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Item Class 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// The status of the Inventory Item.
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Item Status 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="ItemStatus", EmitDefaultValue=false)]
		public StringValue? ItemStatus { get; set; }

		/// <summary>
		/// The type of the Inventory Item.
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ItemType", EmitDefaultValue=false)]
		public StringValue? ItemType { get; set; }

		/// <summary>
		/// The expense Account used to record differences between the landed cost amounts specified on purchase receiptsand the amounts on inventory receipts.Applicable only for Stock Items (see StkItem).
		/// DAC Field Name: LCVarianceAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Landed Cost Variance Account 
		/// </summary>
		[DataMember(Name="LandedCostVarianceAccount", EmitDefaultValue=false)]
		public StringValue? LandedCostVarianceAccount { get; set; }

		/// <summary>
		/// The Subaccount used to record differences between the landed cost amounts specified on purchase receiptsand the amounts on inventory receipts.Applicable only for Stock Items (see StkItem).
		/// DAC Field Name: LCVarianceSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Landed Cost Variance Sub. 
		/// </summary>
		[DataMember(Name="LandedCostVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? LandedCostVarianceSubaccount { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="LastCost", EmitDefaultValue=false)]
		public DecimalValue? LastCost { get; set; }

		[DataMember(Name="LastModified", EmitDefaultValue=false)]
		public DateTimeValue? LastModified { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The standard cost assigned to the item before the current standard cost was set.
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Last Cost 
		/// </summary>
		[DataMember(Name="LastStdCost", EmitDefaultValue=false)]
		public DecimalValue? LastStdCost { get; set; }

		/// <summary>
		/// The lot/serial class, to which the item is assigned.This field is relevant only if the Lot/Serial Tracking feature is enabled.
		/// DAC Field Name: LotSerClassID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Lot/Serial Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="LotSerialClass", EmitDefaultValue=false)]
		public StringValue? LotSerialClass { get; set; }

		/// <summary>
		/// The percentage that is added to the item cost to get the selling price for it.
		/// DAC Field Name: MarkupPct 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Markup % 
		/// </summary>
		[DataMember(Name="Markup", EmitDefaultValue=false)]
		public DecimalValue? Markup { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="MaxCost", EmitDefaultValue=false)]
		public DecimalValue? MaxCost { get; set; }

		/// <summary>
		/// DAC: {} 
		/// </summary>
		[DataMember(Name="MinCost", EmitDefaultValue=false)]
		public DecimalValue? MinCost { get; set; }

		/// <summary>
		/// The minimum markup percentage for the item.See the MarkupPct field.
		/// DAC Field Name: MinGrossProfitPct 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Min. Markup % 
		/// </summary>
		[DataMember(Name="MinMarkup", EmitDefaultValue=false)]
		public DecimalValue? MinMarkup { get; set; }

		/// <summary>
		/// The manufacturer's suggested retail price of the item.
		/// DAC Field Name: RecPrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue? MSRP { get; set; }

		/// <summary>
		/// The option that governs the system in the process of determining the optimal set of boxes for the item on each sales order.Applicable only for Stock Items (see StkItem).
		/// DAC Field Name: PackageOption 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Packaging Option 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="PackagingOption", EmitDefaultValue=false)]
		public StringValue? PackagingOption { get; set; }

		/// <summary>
		/// When set to true, indicates that the item must be packaged separately from other items.This field is automatically set to true if By Quantity is selected as the PackageOption.Applicable only for Stock Items (see StkItem).
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Pack Separately 
		/// </summary>
		[DataMember(Name="PackSeparately", EmitDefaultValue=false)]
		public BooleanValue? PackSeparately { get; set; }

		/// <summary>
		/// The standard cost to be assigned to the item when the costs are updated.
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Pending Cost 
		/// </summary>
		[DataMember(Name="PendingStdCost", EmitDefaultValue=false)]
		public DecimalValue? PendingStdCost { get; set; }

		/// <summary>
		/// The liability Account used to accrue amounts on purchase orders related to this item.Applicable for all Stock Items (see StkItem) and for Non-Stock Items, for which a receipt is required.
		/// DAC Field Name: POAccrualAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: PO Accrual Account 
		/// </summary>
		[DataMember(Name="POAccrualAccount", EmitDefaultValue=false)]
		public StringValue? POAccrualAccount { get; set; }

		/// <summary>
		/// The Subaccount used to accrue amounts on purchase orders related to this item.Applicable for all Stock Items (see StkItem) and for Non-Stock Items, for which a receipt is required.
		/// DAC Field Name: POAccrualSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: PO Accrual Sub. 
		/// </summary>
		[DataMember(Name="POAccrualSubaccount", EmitDefaultValue=false)]
		public StringValue? POAccrualSubaccount { get; set; }

		/// <summary>
		/// Identifier of the Posting Class associated with the item.
		/// DAC Field Name: PostClassID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Posting Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PostingClass", EmitDefaultValue=false)]
		public StringValue? PostingClass { get; set; }

		/// <summary>
		/// The Item Price Class associated with the item.
		/// DAC Field Name: PriceClassID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Price Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// The manager responsible for the pricing of this item.
		/// DAC Field Name: PriceManagerID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Price Manager 
		/// </summary>
		[DataMember(Name="PriceManager", EmitDefaultValue=false)]
		public StringValue? PriceManager { get; set; }

		/// <summary>
		/// The workgroup that is responsible for the pricing of this item.
		/// DAC Field Name: PriceWorkgroupID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Price Workgroup 
		/// </summary>
		[DataMember(Name="PriceWorkgroup", EmitDefaultValue=false)]
		public StringValue? PriceWorkgroup { get; set; }

		/// <summary>
		/// The product manager responsible for this item.
		/// DAC Field Name: ProductManagerID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Product Manager 
		/// </summary>
		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// The workgroup that is responsible for the item.
		/// DAC Field Name: ProductWorkgroupID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Product Workgroup 
		/// </summary>
		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// The expense Account used to record the differences between the extended price on the purchase receiptand the extended price on the Accounts Payable bill for this item.Applicable only for Stock Items (see StkItem) under any Valuation Method except Standard.
		/// DAC Field Name: PPVAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Purchase Price Variance Account 
		/// </summary>
		[DataMember(Name="PurchasePriceVarianceAccount", EmitDefaultValue=false)]
		public StringValue? PurchasePriceVarianceAccount { get; set; }

		/// <summary>
		/// The Subaccount used to record the differences between the extended price on the purchase receiptand the extended price on the Accounts Payable bill for this item.Applicable only for Stock Items (see StkItem) under any Valuation Method except Standard.
		/// DAC Field Name: PPVSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Purchase Price Variance Sub. 
		/// </summary>
		[DataMember(Name="PurchasePriceVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? PurchasePriceVarianceSubaccount { get; set; }

		/// <summary>
		/// The Unit of Measure used as the purchase unit for the Inventory Item.This field can be changed only if the Multiple Units of Measure feature is enabled.Otherwise, the purchase unit is assumed to be the same as the Base Unit.
		/// DAC Field Name: PurchaseUnit 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Purchase Unit 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="PurchaseUOM", EmitDefaultValue=false)]
		public StringValue? PurchaseUOM { get; set; }

		/// <summary>
		/// The identifier of the Suabaccount defined by the Reason Code, associated with this item.
		/// DAC Field Name: ReasonCodeSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Reason Code Sub. 
		/// </summary>
		[DataMember(Name="ReasonCodeSubaccount", EmitDefaultValue=false)]
		public StringValue? ReasonCodeSubaccount { get; set; }

		[DataMember(Name="ReplenishmentParameters", EmitDefaultValue=false)]
		public List<ReplenishmentParameterStockItem>? ReplenishmentParameters { get; set; }

		/// <summary>
		/// The income Account used to record sales of the item.
		/// DAC Field Name: SalesAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Sales Account 
		/// </summary>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// The Subaccount used to record sales of the item.
		/// DAC Field Name: SalesSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Sales Sub. 
		/// </summary>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// The Unit of Measure used as the sales unit for the Inventory Item.This field can be changed only if the Multiple Units of Measure feature is enabled.Otherwise, the sales unit is assumed to be the same as the Base Unit.
		/// DAC Field Name: SalesUnit 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Sales Unit 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="SalesUOM", EmitDefaultValue=false)]
		public StringValue? SalesUOM { get; set; }

		/// <summary>
		/// The expense Account used to record the differences in inventory value of this item estimatedby using the pending standard cost and the currently effective standard cost for the quantities on hand.Applicable only for Stock Items (see StkItem) under Standard Valuation Method.
		/// DAC Field Name: StdCstRevAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Standard Cost Revaluation Account 
		/// </summary>
		[DataMember(Name="StandardCostRevaluationAccount", EmitDefaultValue=false)]
		public StringValue? StandardCostRevaluationAccount { get; set; }

		/// <summary>
		/// The Subaccount used to record the differences in inventory value of this item estimatedby using the pending standard cost and the currently effective standard cost for the quantities on hand.Applicable only for Stock Items (see StkItem) under Standard Valuation Method.
		/// DAC Field Name: StdCstRevSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Standard Cost Revaluation Sub. 
		/// </summary>
		[DataMember(Name="StandardCostRevaluationSubaccount", EmitDefaultValue=false)]
		public StringValue? StandardCostRevaluationSubaccount { get; set; }

		/// <summary>
		/// The expense Account used to record the differences between the currently effective standard cost and the cost on the inventory receipt of the item.Applicable only for Stock Items (see StkItem) under Standard Valuation Method.
		/// DAC Field Name: StdCstVarAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Standard Cost Variance Account 
		/// </summary>
		[DataMember(Name="StandardCostVarianceAccount", EmitDefaultValue=false)]
		public StringValue? StandardCostVarianceAccount { get; set; }

		/// <summary>
		/// The Subaccount used to record the differences between the currently effective standard cost and the cost on the inventory receipt of the item.Applicable only for Stock Items (see StkItem) under Standard Valuation Method.
		/// DAC Field Name: StdCstVarSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Standard Cost Variance Sub. 
		/// </summary>
		[DataMember(Name="StandardCostVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? StandardCostVarianceSubaccount { get; set; }

		/// <summary>
		/// When set to true, indicates that the system must calculate commission on the sale of this item.
		/// DAC Field Name: Commisionable 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Subject to Commission 
		/// </summary>
		[DataMember(Name="SubjectToCommission", EmitDefaultValue=false)]
		public BooleanValue? SubjectToCommission { get; set; }

		/// <summary>
		/// Identifier of the TaxCategory associated with the item.
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// DAC Field Name: HSTariffCode 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Commodity Code 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="TariffCode", EmitDefaultValue=false)]
		public StringValue? TariffCode { get; set; }

		[DataMember(Name="UOMConversions", EmitDefaultValue=false)]
		public List<InventoryItemUOMConversion>? UOMConversions { get; set; }

		/// <summary>
		/// When set to true, indicates that the system must set the Default Subitemfor the lines involving this item by default on data entry forms.This field is relevant only if the Inventory Subitems feature is enabled.
		/// DAC Field Name: DefaultSubItemOnEntry 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Use On Entry 
		/// </summary>
		[DataMember(Name="UseOnEntry", EmitDefaultValue=false)]
		public BooleanValue? UseOnEntry { get; set; }

		/// <summary>
		/// The method used for inventory valuation of the item (Stock Items only).
		/// DAC Field Name: ValMethod 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Valuation Method 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ValuationMethod", EmitDefaultValue=false)]
		public StringValue? ValuationMethod { get; set; }

		[DataMember(Name="VendorDetails", EmitDefaultValue=false)]
		public List<StockItemVendorDetail>? VendorDetails { get; set; }

		/// <summary>
		/// The Unit of Measure used for the Volume of the item.
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Volume UOM 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="VolumeUOM", EmitDefaultValue=false)]
		public StringValue? VolumeUOM { get; set; }

		[DataMember(Name="WarehouseDetails", EmitDefaultValue=false)]
		public List<StockItemWarehouseDetail>? WarehouseDetails { get; set; }

		/// <summary>
		/// The Unit of Measure used for the Weight of the item.
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Weight UOM 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="WeightUOM", EmitDefaultValue=false)]
		public StringValue? WeightUOM { get; set; }

		/// <summary>
		/// The manufacturer's suggested retail price of the item.
		/// DAC Field Name: RecPrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: MSRP 
		/// </summary>
		[DataMember(Name="CurySpecificMSRP", EmitDefaultValue=false)]
		public DecimalValue? CurySpecificMSRP { get; set; }

		/// <summary>
		/// The price used as the default price, if there are no other prices defined for this item in any price list in the Accounts Receivable module.
		/// DAC Field Name: BasePrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Default Price 
		/// </summary>
		[DataMember(Name="CurySpecificPrice", EmitDefaultValue=false)]
		public DecimalValue? CurySpecificPrice { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Availability", EmitDefaultValue=false)]
		public StringValue? Availability { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		[DataMember(Name="CustomURL", EmitDefaultValue=false)]
		public StringValue? CustomURL { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Export to External System 
		/// </summary>
		[DataMember(Name="ExportToExternal", EmitDefaultValue=false)]
		public BooleanValue? ExportToExternal { get; set; }

		[DataMember(Name="FileURLs", EmitDefaultValue=false)]
		public List<InventoryFileUrls>? FileURLs { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		[DataMember(Name="MetaDescription", EmitDefaultValue=false)]
		public StringValue? MetaDescription { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		[DataMember(Name="MetaKeywords", EmitDefaultValue=false)]
		public StringValue? MetaKeywords { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		[DataMember(Name="PageTitle", EmitDefaultValue=false)]
		public StringValue? PageTitle { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		[DataMember(Name="SearchKeywords", EmitDefaultValue=false)]
		public StringValue? SearchKeywords { get; set; }

		/// <summary>
		/// References to parent Inventory Item, its database identifier, if this item was created from template.
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Template ID 
		/// </summary>
		[DataMember(Name="TemplateItemID", EmitDefaultValue=false)]
		public StringValue? TemplateItemID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Visibility", EmitDefaultValue=false)]
		public StringValue? Visibility { get; set; }

		/// <summary>
		/// DAC Field Name: NotAvailMode 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: When Qty Unavailable 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="NotAvailable", EmitDefaultValue=false)]
		public StringValue? NotAvailable { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}