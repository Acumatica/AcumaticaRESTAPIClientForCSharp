using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN202500</c> in the Acumatica ERP
	/// <para>Key Fields: InventoryID</para>
	/// </summary>
	public class StockItem : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// Key field.The user-friendly unique identifier of the Inventory Item.The structure of the identifier is determined by the INVENTORY Segmented Key.
		/// <para>DAC Field Name: InventoryCD</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Inventory ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// The status of the Inventory Item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Item Status</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringSingleSelectValue? ItemStatus { get; set; }

		/// <summary>
		/// The description of the Inventory Item.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The workgroup that is responsible for the item.
		/// <para>DAC Field Name: ProductWorkgroupID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Product Workgroup</para>
		/// </summary>
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// The product manager responsible for this item.
		/// <para>DAC Field Name: ProductManagerID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Product Manager</para>
		/// </summary>
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// References to parent Inventory Item, its database identifier, if this item was created from template.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Template ID</para>
		/// </summary>
		public StringValue? TemplateItemID { get; set; }

		/// <summary>
		/// The identifier of the Item Class, to which the Inventory Item belongs.Item Classes provide default settings for items, which belong to them, and are used to group items.
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// The type of the Inventory Item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringSingleSelectValue? ItemType { get; set; }

		/// <summary>
		/// When set to <c>true</c>, indicates that the item is a kit.Kits are stock or non-stock items that consist of other items and are sold as a whole.
		/// <para>DAC Field Name: KitItem</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Kit</para>
		/// </summary>
		public BooleanValue? IsAKit { get; set; }

		/// <summary>
		/// The method used for inventory valuation of the item (Stock Items only).
		/// <para>DAC Field Name: ValMethod</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Valuation Method</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ValuationMethod { get; set; }

		/// <summary>
		/// Identifier of the TaxCategory associated with the item.
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// Identifier of the Posting Class associated with the item.
		/// <para>DAC Field Name: PostClassID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Posting Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PostingClass { get; set; }

		/// <summary>
		/// The lot/serial class, to which the item is assigned.This field is relevant only if the Lot/Serial Tracking feature is enabled.
		/// <para>DAC Field Name: LotSerClassID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Lot/Serial Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? LotSerialClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LotSerNumVal</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// </summary>
		public StringValue? AutoIncrementalValue { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Country Of Origin</para>
		/// <para>SQL Type: nvarchar(2)</para>
		/// </summary>
		public StringValue? CountryOfOrigin { get; set; }

		/// <summary>
		/// The Unit of Measure used as the base unit for the Inventory Item.
		/// <para>DAC Field Name: BaseUnit</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Base Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? BaseUOM { get; set; }

		/// <summary>
		/// The Unit of Measure used as the sales unit for the Inventory Item.This field can be changed only if the Multiple Units of Measure feature is enabled.Otherwise, the sales unit is assumed to be the same as the Base Unit.
		/// <para>DAC Field Name: SalesUnit</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Sales Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? SalesUOM { get; set; }

		/// <summary>
		/// The Unit of Measure used as the purchase unit for the Inventory Item.This field can be changed only if the Multiple Units of Measure feature is enabled.Otherwise, the purchase unit is assumed to be the same as the Base Unit.
		/// <para>DAC Field Name: PurchaseUnit</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Purchase Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? PurchaseUOM { get; set; }

		/// <summary>
		/// The ABC code, to which the item is assigned for the purpose of physical inventories.The field is relevant only for Stock Items (see StkItem).
		/// <para>DAC Field Name: ABCCodeID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: ABC Code</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ABCCode { get; set; }

		/// <summary>
		/// The Item Price Class associated with the item.
		/// <para>DAC Field Name: PriceClassID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Price Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// The workgroup that is responsible for the pricing of this item.
		/// <para>DAC Field Name: PriceWorkgroupID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Price Workgroup</para>
		/// </summary>
		public StringValue? PriceWorkgroup { get; set; }

		/// <summary>
		/// The manager responsible for the pricing of this item.
		/// <para>DAC Field Name: PriceManagerID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Price Manager</para>
		/// </summary>
		public StringValue? PriceManager { get; set; }

		/// <summary>
		/// When set to <c>true</c>, indicates that the system must calculate commission on the sale of this item.
		/// <para>DAC Field Name: Commisionable</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Subject to Commission</para>
		/// </summary>
		public BooleanValue? SubjectToCommission { get; set; }

		/// <summary>
		/// The minimum markup percentage for the item.See the MarkupPct field.
		/// <para>DAC Field Name: MinGrossProfitPct</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Min. Markup %</para>
		/// </summary>
		public DecimalValue? MinMarkup { get; set; }

		/// <summary>
		/// The percentage that is added to the item cost to get the selling price for it.
		/// <para>DAC Field Name: MarkupPct</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Markup %</para>
		/// </summary>
		public DecimalValue? Markup { get; set; }

		/// <summary>
		/// The URL of the image associated with the item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Image</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? ImageUrl { get; set; }

		/// <summary>
		/// The weight of the Base Unit of the item.
		/// <para>DAC Field Name: BaseItemWeight</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Weight</para>
		/// </summary>
		public DecimalValue? DimensionWeight { get; set; }

		/// <summary>
		/// The Unit of Measure used for the Weight of the item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Weight UOM</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? WeightUOM { get; set; }

		/// <summary>
		/// The volume of the Base Unit of the item.
		/// <para>DAC Field Name: BaseItemVolume</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Volume</para>
		/// </summary>
		public DecimalValue? DimensionVolume { get; set; }

		/// <summary>
		/// The Unit of Measure used for the Volume of the item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Volume UOM</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? VolumeUOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: HSTariffCode</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Commodity Code</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? TariffCode { get; set; }

		/// <summary>
		/// The option that governs the system in the process of determining the optimal set of boxes for the item on each sales order.Applicable only for Stock Items (see StkItem).
		/// <para>DAC Field Name: PackageOption</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Packaging Option</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? PackagingOption { get; set; }

		/// <summary>
		/// When set to <c>true</c>, indicates that the item must be packaged separately from other items.This field is automatically set to <c>true</c> if By Quantity is selected as the PackageOption.Applicable only for Stock Items (see StkItem).
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Pack Separately</para>
		/// </summary>
		public BooleanValue? PackSeparately { get; set; }

		/// <summary>
		/// The asset Account used to keep the inventory balance, resulting from the transactions with this item.Applicable only for Stock Items (see StkItem).
		/// <para>DAC Field Name: InvtAcctID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Inventory Account</para>
		/// </summary>
		public StringValue? InventoryAccount { get; set; }

		/// <summary>
		/// The Subaccount used to keep the inventory balance, resulting from the transactions with this item.Applicable only for Stock Items (see StkItem).
		/// <para>DAC Field Name: InvtSubID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Inventory Sub.</para>
		/// </summary>
		public StringValue? InventorySubaccount { get; set; }

		/// <summary>
		/// The identifier of the Suabaccount defined by the Reason Code, associated with this item.
		/// <para>DAC Field Name: ReasonCodeSubID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Reason Code Sub.</para>
		/// </summary>
		public StringValue? ReasonCodeSubaccount { get; set; }

		/// <summary>
		/// The income Account used to record sales of the item.
		/// <para>DAC Field Name: SalesAcctID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Sales Account</para>
		/// </summary>
		public StringValue? SalesAccount { get; set; }

		/// <summary>
		/// The Subaccount used to record sales of the item.
		/// <para>DAC Field Name: SalesSubID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Sales Sub.</para>
		/// </summary>
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// The expense Account used to record the cost of goods sold for this item when a sales order for it is released.Applicable only for Stock Items (see StkItem).
		/// <para>DAC Field Name: COGSAcctID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: COGS Account</para>
		/// </summary>
		public StringValue? COGSAccount { get; set; }

		/// <summary>
		/// The Subaccount used to record the cost of goods sold for this item when a sales order for it is released.Applicable only for Stock Items (see StkItem).
		/// <para>DAC Field Name: COGSSubID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: COGS Sub.</para>
		/// </summary>
		public StringValue? COGSSubaccount { get; set; }

		/// <summary>
		/// The expense Account used to record the differences between the currently effective standard cost and the cost on the inventory receipt of the item.Applicable only for Stock Items (see StkItem) under Standard Valuation Method.
		/// <para>DAC Field Name: StdCstVarAcctID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Standard Cost Variance Account</para>
		/// </summary>
		public StringValue? StandardCostVarianceAccount { get; set; }

		/// <summary>
		/// The Subaccount used to record the differences between the currently effective standard cost and the cost on the inventory receipt of the item.Applicable only for Stock Items (see StkItem) under Standard Valuation Method.
		/// <para>DAC Field Name: StdCstVarSubID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Standard Cost Variance Sub.</para>
		/// </summary>
		public StringValue? StandardCostVarianceSubaccount { get; set; }

		/// <summary>
		/// The expense Account used to record the differences in inventory value of this item estimatedby using the pending standard cost and the currently effective standard cost for the quantities on hand.Applicable only for Stock Items (see StkItem) under Standard Valuation Method.
		/// <para>DAC Field Name: StdCstRevAcctID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Standard Cost Revaluation Account</para>
		/// </summary>
		public StringValue? StandardCostRevaluationAccount { get; set; }

		/// <summary>
		/// The Subaccount used to record the differences in inventory value of this item estimatedby using the pending standard cost and the currently effective standard cost for the quantities on hand.Applicable only for Stock Items (see StkItem) under Standard Valuation Method.
		/// <para>DAC Field Name: StdCstRevSubID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Standard Cost Revaluation Sub.</para>
		/// </summary>
		public StringValue? StandardCostRevaluationSubaccount { get; set; }

		/// <summary>
		/// The liability Account used to accrue amounts on purchase orders related to this item.Applicable for all Stock Items (see StkItem) and for Non-Stock Items, for which a receipt is required.
		/// <para>DAC Field Name: POAccrualAcctID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: PO Accrual Account</para>
		/// </summary>
		public StringValue? POAccrualAccount { get; set; }

		/// <summary>
		/// The Subaccount used to accrue amounts on purchase orders related to this item.Applicable for all Stock Items (see StkItem) and for Non-Stock Items, for which a receipt is required.
		/// <para>DAC Field Name: POAccrualSubID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: PO Accrual Sub.</para>
		/// </summary>
		public StringValue? POAccrualSubaccount { get; set; }

		/// <summary>
		/// The expense Account used to record the differences between the extended price on the purchase receiptand the extended price on the Accounts Payable bill for this item.Applicable only for Stock Items (see StkItem) under any Valuation Method except Standard.
		/// <para>DAC Field Name: PPVAcctID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Purchase Price Variance Account</para>
		/// </summary>
		public StringValue? PurchasePriceVarianceAccount { get; set; }

		/// <summary>
		/// The Subaccount used to record the differences between the extended price on the purchase receiptand the extended price on the Accounts Payable bill for this item.Applicable only for Stock Items (see StkItem) under any Valuation Method except Standard.
		/// <para>DAC Field Name: PPVSubID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Purchase Price Variance Sub.</para>
		/// </summary>
		public StringValue? PurchasePriceVarianceSubaccount { get; set; }

		/// <summary>
		/// The expense Account used to record differences between the landed cost amounts specified on purchase receiptsand the amounts on inventory receipts.Applicable only for Stock Items (see StkItem).
		/// <para>DAC Field Name: LCVarianceAcctID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Landed Cost Variance Account</para>
		/// </summary>
		public StringValue? LandedCostVarianceAccount { get; set; }

		/// <summary>
		/// The Subaccount used to record differences between the landed cost amounts specified on purchase receiptsand the amounts on inventory receipts.Applicable only for Stock Items (see StkItem).
		/// <para>DAC Field Name: LCVarianceSubID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Landed Cost Variance Sub.</para>
		/// </summary>
		public StringValue? LandedCostVarianceSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DeferralAcctID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Deferral Account</para>
		/// </summary>
		public StringValue? DeferralAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DeferralSubID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Deferral Sub.</para>
		/// </summary>
		public StringValue? DeferralSubaccount { get; set; }

		/// <summary>
		/// Rich text description of the item.
		/// <para>DAC Field Name: Body</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Content { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Export to External System</para>
		/// </summary>
		public BooleanValue? ExportToExternal { get; set; }

		/// <summary>
		/// Indicates the visibility for this inventory item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Visibility { get; set; }

		/// <summary>
		/// Indicates the availability setting for the inventory item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Availability { get; set; }

		/// <summary>
		/// Indicates the Not Available Setting to use when an item has no more quantity available.
		/// <para>DAC Field Name: NotAvailMode</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: When Qty Unavailable</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? NotAvailable { get; set; }

		/// <summary>
		/// The URL to use for this inventory item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Custom URL</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? CustomURL { get; set; }

		/// <summary>
		/// The title to use on this item's page.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Page Title</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? PageTitle { get; set; }

		/// <summary>
		/// A comma-separated list of search keywords for this item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Search Keywords</para>
		/// <para>SQL Type: nvarchar(1024)</para>
		/// </summary>
		public StringValue? SearchKeywords { get; set; }

		/// <summary>
		/// A comma-separated list of meta keywords for this item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Meta Keywords</para>
		/// <para>SQL Type: nvarchar(1024)</para>
		/// </summary>
		public StringValue? MetaKeywords { get; set; }

		/// <summary>
		/// The meta description for this item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Meta Description</para>
		/// <para>SQL Type: nvarchar(1024)</para>
		/// </summary>
		public StringValue? MetaDescription { get; set; }

		/// <summary>
		/// APS Schedule option - Check for Material Availability.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Check for Material Availability</para>
		/// </summary>
		public StringValue? AMCheckSchdMatlAvailability { get; set; }

		/// <summary>
		/// The default Warehouse used to store the items of this kind.Applicable only for Stock Items (see StkItem) and when the Warehouses feature is enabled.
		/// <para>DAC Field Name: DfltSiteID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Default Warehouse</para>
		/// </summary>
		public StringValue? DefaultWarehouseID { get; set; }

		/// <summary>
		/// The Location of warehouse used by default to issue items of this kind.Applicable only for Stock Items (see StkItem) when the Warehouse Locations feature is enabled.
		/// <para>DAC Field Name: DfltShipLocationID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Default Issue From</para>
		/// </summary>
		public StringValue? DefaultIssueLocationID { get; set; }

		/// <summary>
		/// The Location of warehouse used by default to receive items of this kind.Applicable only for Stock Items (see StkItem) when the Warehouse Locations feature is enabled.
		/// <para>DAC Field Name: DfltReceiptLocationID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Default Receipt To</para>
		/// </summary>
		public StringValue? DefaultReceiptLocationID { get; set; }

		/// <summary>
		/// The manufacturer's suggested retail price of the item.
		/// <para>DAC Field Name: RecPrice</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// </summary>
		public DecimalValue? MSRP { get; set; }

		/// <summary>
		/// The manufacturer's suggested retail price of the item.
		/// <para>DAC Field Name: RecPrice</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: MSRP</para>
		/// </summary>
		public DecimalValue? CurySpecificMSRP { get; set; }

		/// <summary>
		/// The price used as the default price, if there are no other prices defined for this item in any price list in the Accounts Receivable module.
		/// <para>DAC Field Name: BasePrice</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Default Price</para>
		/// </summary>
		public DecimalValue? DefaultPrice { get; set; }

		/// <summary>
		/// The price used as the default price, if there are no other prices defined for this item in any price list in the Accounts Receivable module.
		/// <para>DAC Field Name: BasePrice</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Default Price</para>
		/// </summary>
		public DecimalValue? CurySpecificPrice { get; set; }

		/// <summary>
		/// The standard cost to be assigned to the item when the costs are updated.
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Pending Cost</para>
		/// </summary>
		public DecimalValue? PendingStdCost { get; set; }

		/// <summary>
		/// The current standard cost of the item.
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Current Cost</para>
		/// </summary>
		public DecimalValue? CurrentStdCost { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public DecimalValue? LastCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AvgCost</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public DecimalValue? AverageCost { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public DecimalValue? MinCost { get; set; }

		/// <summary>
		/// <para>DAC: {}</para>
		/// </summary>
		public DecimalValue? MaxCost { get; set; }

		/// <summary>
		/// The standard cost assigned to the item before the current standard cost was set.
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Last Cost</para>
		/// </summary>
		public DecimalValue? LastStdCost { get; set; }

		public StringValue? DiscountAccount { get; set; }

		public StringValue? DiscountSubaccount { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public GuidValue? NoteID { get; set; }

		#endregion

		#region Details
		public List<AttributeValue>? Attributes { get; set; }

		public List<BoxStockItem>? Boxes { get; set; }

		public List<CategoryStockItem>? Categories { get; set; }

		public List<InventoryItemCrossReference>? CrossReferences { get; set; }

		public List<ReplenishmentParameterStockItem>? ReplenishmentParameters { get; set; }

		public List<InventoryItemUOMConversion>? UOMConversions { get; set; }

		public List<StockItemVendorDetail>? VendorDetails { get; set; }

		public List<StockItemWarehouseDetail>? WarehouseDetails { get; set; }

		public List<InventoryFileUrls>? FileURLs { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(StockItem)} - \"{InventoryID}\"";
		}

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";
			public const string Boxes = "Boxes";
			public const string Categories = "Categories";
			public const string CrossReferences = "CrossReferences";
			public const string ReplenishmentParameters = "ReplenishmentParameters";
			public const string UOMConversions = "UOMConversions";
			public const string VendorDetails = "VendorDetails";
			public const string WarehouseDetails = "WarehouseDetails";
			public const string FileURLs = "FileURLs";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes,Boxes,Categories,CrossReferences,ReplenishmentParameters,UOMConversions,VendorDetails,WarehouseDetails,FileURLs";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}