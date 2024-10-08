using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen IN202000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class NonStockItem : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The Unit of Measure used as the base unit for the Inventory Item.
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Base Unit 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="BaseUnit", EmitDefaultValue=false)]
		public StringValue? BaseUnit { get; set; }

		[DataMember(Name="CrossReferences", EmitDefaultValue=false)]
		public List<InventoryItemCrossReference>? CrossReferences { get; set; }

		/// <summary>
		/// The current standard cost of the item.
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Current Cost 
		/// </summary>
		[DataMember(Name="CurrentCost", EmitDefaultValue=false)]
		public DecimalValue? CurrentCost { get; set; }

		/// <summary>
		/// The price used as the default price, if there are no other prices defined for this item in any price list in the Accounts Receivable module.
		/// DAC Field Name: BasePrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Default Price 
		/// </summary>
		[DataMember(Name="DefaultPrice", EmitDefaultValue=false)]
		public DecimalValue? DefaultPrice { get; set; }

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
		/// The date when the Current Cost became effective.
		/// DAC Field Name: StdCostDate 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Effective Date 
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// The expense Account used to record the cost of goods sold for this item when a sales order for it is released.Applicable only for Stock Items (see StkItem).
		/// DAC Field Name: COGSAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: COGS Account 
		/// </summary>
		[DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
		public StringValue? ExpenseAccount { get; set; }

		/// <summary>
		/// The asset Account used to keep the inventory balance, resulting from the transactions with this item.Applicable only for Stock Items (see StkItem).
		/// DAC Field Name: InvtAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Inventory Account 
		/// </summary>
		[DataMember(Name="ExpenseAccrualAccount", EmitDefaultValue=false)]
		public StringValue? ExpenseAccrualAccount { get; set; }

		/// <summary>
		/// The Subaccount used to keep the inventory balance, resulting from the transactions with this item.Applicable only for Stock Items (see StkItem).
		/// DAC Field Name: InvtSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Inventory Sub. 
		/// </summary>
		[DataMember(Name="ExpenseAccrualSubaccount", EmitDefaultValue=false)]
		public StringValue? ExpenseAccrualSubaccount { get; set; }

		/// <summary>
		/// The Subaccount used to record the cost of goods sold for this item when a sales order for it is released.Applicable only for Stock Items (see StkItem).
		/// DAC Field Name: COGSSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: COGS Sub. 
		/// </summary>
		[DataMember(Name="ExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? ExpenseSubaccount { get; set; }

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
		/// When set to true, indicates that the item is a kit.Kits are stock or non-stock items that consist of other items and are sold as a whole.
		/// DAC Field Name: KitItem 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Is a Kit 
		/// </summary>
		[DataMember(Name="IsKit", EmitDefaultValue=false)]
		public BooleanValue? IsKit { get; set; }

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
		/// The standard cost assigned to the item before the current standard cost was set.
		/// DAC Field Name: LastStdCost 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Last Cost 
		/// </summary>
		[DataMember(Name="LastCost", EmitDefaultValue=false)]
		public DecimalValue? LastCost { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The standard cost to be assigned to the item when the costs are updated.
		/// DAC Field Name: PendingStdCost 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Pending Cost 
		/// </summary>
		[DataMember(Name="PendingCost", EmitDefaultValue=false)]
		public DecimalValue? PendingCost { get; set; }

		/// <summary>
		/// The date when the Pending Cost becomes effective.
		/// DAC Field Name: PendingStdCostDate 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Pending Cost Date 
		/// </summary>
		[DataMember(Name="PendingCostDate", EmitDefaultValue=false)]
		public DateTimeValue? PendingCostDate { get; set; }

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
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Purchase Unit 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="PurchaseUnit", EmitDefaultValue=false)]
		public StringValue? PurchaseUnit { get; set; }

		/// <summary>
		/// The identifier of the Suabaccount defined by the Reason Code, associated with this item.
		/// DAC Field Name: ReasonCodeSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Reason Code Sub. 
		/// </summary>
		[DataMember(Name="ReasonCodeSubaccount", EmitDefaultValue=false)]
		public StringValue? ReasonCodeSubaccount { get; set; }

		/// <summary>
		/// Reserved for internal use.Indicates whether the item (assumed Non-Stock) requires receipt.
		/// DAC Field Name: NonStockReceipt 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Require Receipt 
		/// </summary>
		[DataMember(Name="RequireReceipt", EmitDefaultValue=false)]
		public BooleanValue? RequireReceipt { get; set; }

		/// <summary>
		/// Reserved for internal use.Indicates whether the item (assumed Non-Stock) requires shipment.
		/// DAC Field Name: NonStockShip 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Require Shipment 
		/// </summary>
		[DataMember(Name="RequireShipment", EmitDefaultValue=false)]
		public BooleanValue? RequireShipment { get; set; }

		/// <summary>
		/// The income Account used to record sales of the item.
		/// DAC Field Name: SalesAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Sales Account 
		/// </summary>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		[DataMember(Name="SalesCategories", EmitDefaultValue=false)]
		public List<NonStockItemSalesCategory>? SalesCategories { get; set; }

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
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Sales Unit 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="SalesUnit", EmitDefaultValue=false)]
		public StringValue? SalesUnit { get; set; }

		/// <summary>
		/// Identifier of the TaxCategory associated with the item.
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		[DataMember(Name="VendorDetails", EmitDefaultValue=false)]
		public List<NonStockItemVendorDetail>? VendorDetails { get; set; }

		/// <summary>
		/// The volume of the Base Unit of the item.
		/// DAC Field Name: BaseItemVolume 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		[DataMember(Name="Volume", EmitDefaultValue=false)]
		public DecimalValue? Volume { get; set; }

		/// <summary>
		/// The Unit of Measure used for the Volume of the item.
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Volume UOM 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="VolumeUOM", EmitDefaultValue=false)]
		public StringValue? VolumeUOM { get; set; }

		/// <summary>
		/// The weight of the Base Unit of the item.
		/// DAC Field Name: BaseItemWeight 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		[DataMember(Name="Weight", EmitDefaultValue=false)]
		public DecimalValue? Weight { get; set; }

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
		/// Display Name: Export to External System 
		/// </summary>
		[DataMember(Name="ExportToExternal", EmitDefaultValue=false)]
		public BooleanValue? ExportToExternal { get; set; }

		[DataMember(Name="Categories", EmitDefaultValue=false)]
		public List<CategoryStockItem>? Categories { get; set; }

		/// <summary>
		/// Rich text description of the item.
		/// DAC Field Name: Body 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Content", EmitDefaultValue=false)]
		public StringValue? Content { get; set; }

		/// <summary>
		/// The current standard cost of the item.
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Current Cost 
		/// </summary>
		[DataMember(Name="CurrentStdCost", EmitDefaultValue=false)]
		public DecimalValue? CurrentStdCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		[DataMember(Name="CustomURL", EmitDefaultValue=false)]
		public StringValue? CustomURL { get; set; }

		/// <summary>
		/// The weight of the Base Unit of the item.
		/// DAC Field Name: BaseItemWeight 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Weight 
		/// </summary>
		[DataMember(Name="DimensionWeight", EmitDefaultValue=false)]
		public DecimalValue? DimensionWeight { get; set; }

		[DataMember(Name="FileUrls", EmitDefaultValue=false)]
		public List<InventoryFileUrls>? FileUrls { get; set; }

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

		/// <summary>
		/// The manufacturer's suggested retail price of the item.
		/// DAC Field Name: RecPrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue? MSRP { get; set; }

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

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}