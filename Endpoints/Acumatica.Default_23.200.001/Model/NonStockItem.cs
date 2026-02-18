using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN202000</c> in the Acumatica ERP
	/// <para>Key Fields: InventoryID</para>
	/// </summary>
	public class NonStockItem : Entity, ITopLevelEntity
	{

		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The Unit of Measure used as the base unit for the Inventory Item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Base Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? BaseUnit { get; set; }

		public List<InventoryItemCrossReference>? CrossReferences { get; set; }

		/// <summary>
		/// The current standard cost of the item.
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Current Cost</para>
		/// </summary>
		public DecimalValue? CurrentCost { get; set; }

		/// <summary>
		/// The price used as the default price, if there are no other prices defined for this item in any price list in the Accounts Receivable module.
		/// <para>DAC Field Name: BasePrice</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Default Price</para>
		/// </summary>
		public DecimalValue? DefaultPrice { get; set; }

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
		/// The description of the Inventory Item.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The date when the Current Cost became effective.
		/// <para>DAC Field Name: StdCostDate</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// The expense Account used to record the cost of goods sold for this item when a sales order for it is released.Applicable only for Stock Items (see StkItem).
		/// <para>DAC Field Name: COGSAcctID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: COGS Account</para>
		/// </summary>
		public StringValue? ExpenseAccount { get; set; }

		/// <summary>
		/// The asset Account used to keep the inventory balance, resulting from the transactions with this item.Applicable only for Stock Items (see StkItem).
		/// <para>DAC Field Name: InvtAcctID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Inventory Account</para>
		/// </summary>
		public StringValue? ExpenseAccrualAccount { get; set; }

		/// <summary>
		/// The Subaccount used to keep the inventory balance, resulting from the transactions with this item.Applicable only for Stock Items (see StkItem).
		/// <para>DAC Field Name: InvtSubID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Inventory Sub.</para>
		/// </summary>
		public StringValue? ExpenseAccrualSubaccount { get; set; }

		/// <summary>
		/// The Subaccount used to record the cost of goods sold for this item when a sales order for it is released.Applicable only for Stock Items (see StkItem).
		/// <para>DAC Field Name: COGSSubID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: COGS Sub.</para>
		/// </summary>
		public StringValue? ExpenseSubaccount { get; set; }

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
		/// When set to true, indicates that the item is a kit.Kits are stock or non-stock items that consist of other items and are sold as a whole.
		/// <para>DAC Field Name: KitItem</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Is a Kit</para>
		/// </summary>
		public BooleanValue? IsKit { get; set; }

		/// <summary>
		/// The identifier of the Item Class, to which the Inventory Item belongs.Item Classes provide default settings for items, which belong to them, and are used to group items.
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// The status of the Inventory Item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Item Status</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? ItemStatus { get; set; }

		/// <summary>
		/// The type of the Inventory Item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ItemType { get; set; }

		/// <summary>
		/// The standard cost assigned to the item before the current standard cost was set.
		/// <para>DAC Field Name: LastStdCost</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Last Cost</para>
		/// </summary>
		public DecimalValue? LastCost { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The standard cost to be assigned to the item when the costs are updated.
		/// <para>DAC Field Name: PendingStdCost</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Pending Cost</para>
		/// </summary>
		public DecimalValue? PendingCost { get; set; }

		/// <summary>
		/// The date when the Pending Cost becomes effective.
		/// <para>DAC Field Name: PendingStdCostDate</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Pending Cost Date</para>
		/// </summary>
		public DateTimeValue? PendingCostDate { get; set; }

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
		/// Identifier of the Posting Class associated with the item.
		/// <para>DAC Field Name: PostClassID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Posting Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PostingClass { get; set; }

		/// <summary>
		/// The Item Price Class associated with the item.
		/// <para>DAC Field Name: PriceClassID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Price Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PriceClass { get; set; }

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
		/// The Unit of Measure used as the purchase unit for the Inventory Item.This field can be changed only if the Multiple Units of Measure feature is enabled.Otherwise, the purchase unit is assumed to be the same as the Base Unit.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Purchase Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? PurchaseUnit { get; set; }

		/// <summary>
		/// The identifier of the Suabaccount defined by the Reason Code, associated with this item.
		/// <para>DAC Field Name: ReasonCodeSubID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Reason Code Sub.</para>
		/// </summary>
		public StringValue? ReasonCodeSubaccount { get; set; }

		/// <summary>
		/// Reserved for internal use.Indicates whether the item (assumed Non-Stock) requires receipt.
		/// <para>DAC Field Name: NonStockReceipt</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Require Receipt</para>
		/// </summary>
		public BooleanValue? RequireReceipt { get; set; }

		/// <summary>
		/// Reserved for internal use.Indicates whether the item (assumed Non-Stock) requires shipment.
		/// <para>DAC Field Name: NonStockShip</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Require Shipment</para>
		/// </summary>
		public BooleanValue? RequireShipment { get; set; }

		/// <summary>
		/// The income Account used to record sales of the item.
		/// <para>DAC Field Name: SalesAcctID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Sales Account</para>
		/// </summary>
		public StringValue? SalesAccount { get; set; }

		public List<NonStockItemSalesCategory>? SalesCategories { get; set; }

		/// <summary>
		/// The Subaccount used to record sales of the item.
		/// <para>DAC Field Name: SalesSubID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Sales Sub.</para>
		/// </summary>
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// The Unit of Measure used as the sales unit for the Inventory Item.This field can be changed only if the Multiple Units of Measure feature is enabled.Otherwise, the sales unit is assumed to be the same as the Base Unit.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Sales Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? SalesUnit { get; set; }

		/// <summary>
		/// Identifier of the TaxCategory associated with the item.
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? TaxCategory { get; set; }

		public List<NonStockItemVendorDetail>? VendorDetails { get; set; }

		/// <summary>
		/// The volume of the Base Unit of the item.
		/// <para>DAC Field Name: BaseItemVolume</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// </summary>
		public DecimalValue? Volume { get; set; }

		/// <summary>
		/// The Unit of Measure used for the Volume of the item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Volume UOM</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? VolumeUOM { get; set; }

		/// <summary>
		/// The weight of the Base Unit of the item.
		/// <para>DAC Field Name: BaseItemWeight</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// </summary>
		public DecimalValue? Weight { get; set; }

		/// <summary>
		/// The Unit of Measure used for the Weight of the item.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Weight UOM</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? WeightUOM { get; set; }

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
		public DecimalValue? CurySpecificPrice { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Availability { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Export to External System</para>
		/// </summary>
		public BooleanValue? ExportToExternal { get; set; }

		public List<CategoryStockItem>? Categories { get; set; }

		/// <summary>
		/// Rich text description of the item.
		/// <para>DAC Field Name: Body</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Content { get; set; }

		/// <summary>
		/// The current standard cost of the item.
		/// <para>DAC Field Name: StdCost</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// <para>Display Name: Current Cost</para>
		/// </summary>
		public DecimalValue? CurrentStdCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// </summary>
		public StringValue? CustomURL { get; set; }

		/// <summary>
		/// The weight of the Base Unit of the item.
		/// <para>DAC Field Name: BaseItemWeight</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Weight</para>
		/// </summary>
		public DecimalValue? DimensionWeight { get; set; }

		public List<InventoryFileUrls>? FileUrls { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// </summary>
		public StringValue? MetaDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// </summary>
		public StringValue? MetaKeywords { get; set; }

		/// <summary>
		/// The manufacturer's suggested retail price of the item.
		/// <para>DAC Field Name: RecPrice</para>
		/// <para>DAC: PX.Objects.IN.InventoryItemCurySettings</para>
		/// </summary>
		public DecimalValue? MSRP { get; set; }

		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// </summary>
		public StringValue? PageTitle { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// </summary>
		public StringValue? SearchKeywords { get; set; }

		/// <summary>
		/// References to parent Inventory Item, its database identifier, if this item was created from template.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Template ID</para>
		/// </summary>
		public StringValue? TemplateItemID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Visibility { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";
			public const string CrossReferences = "CrossReferences";
			public const string CrossReferences_Files = "CrossReferences/Files";
			public const string SalesCategories = "SalesCategories";
			public const string SalesCategories_Files = "SalesCategories/Files";
			public const string VendorDetails = "VendorDetails";
			public const string VendorDetails_Files = "VendorDetails/Files";
			public const string Categories = "Categories";
			public const string Categories_Files = "Categories/Files";
			public const string FileUrls = "FileUrls";
			public const string FileUrls_Files = "FileUrls/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes,CrossReferences,CrossReferences/Files,SalesCategories,SalesCategories/Files,VendorDetails,VendorDetails/Files,Categories,Categories/Files,FileUrls,FileUrls/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}