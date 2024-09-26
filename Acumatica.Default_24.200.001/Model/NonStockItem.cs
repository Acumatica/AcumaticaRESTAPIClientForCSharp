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
	/// Corresponds to the screen IN202000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class NonStockItem : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseUnit 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BaseUnit", EmitDefaultValue=false)]
		public StringValue? BaseUnit { get; set; }

		[DataMember(Name="CrossReferences", EmitDefaultValue=false)]
		public List<InventoryItemCrossReference>? CrossReferences { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrentCost", EmitDefaultValue=false)]
		public DecimalValue? CurrentCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BasePrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultPrice", EmitDefaultValue=false)]
		public DecimalValue? DefaultPrice { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DeferralAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DeferralAccount", EmitDefaultValue=false)]
		public StringValue? DeferralAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DeferralSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DeferralSubaccount", EmitDefaultValue=false)]
		public StringValue? DeferralSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCostDate 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: COGSAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
		public StringValue? ExpenseAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InvtAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExpenseAccrualAccount", EmitDefaultValue=false)]
		public StringValue? ExpenseAccrualAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InvtSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExpenseAccrualSubaccount", EmitDefaultValue=false)]
		public StringValue? ExpenseAccrualSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: COGSSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue? ExpenseSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryCD 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: KitItem 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IsKit", EmitDefaultValue=false)]
		public BooleanValue? IsKit { get; set; }

		[DataMember(Name="IsAKit", EmitDefaultValue=false)]
		public BooleanValue? IsAKit { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemStatus 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemStatus", EmitDefaultValue=false)]
		public StringValue? ItemStatus { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemType 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemType", EmitDefaultValue=false)]
		public StringValue? ItemType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastStdCost 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastCost", EmitDefaultValue=false)]
		public DecimalValue? LastCost { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PendingStdCost 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PendingCost", EmitDefaultValue=false)]
		public DecimalValue? PendingCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PendingStdCostDate 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PendingCostDate", EmitDefaultValue=false)]
		public DateTimeValue? PendingCostDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: POAccrualAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="POAccrualAccount", EmitDefaultValue=false)]
		public StringValue? POAccrualAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: POAccrualSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="POAccrualSubaccount", EmitDefaultValue=false)]
		public StringValue? POAccrualSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PostClassID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PostingClass", EmitDefaultValue=false)]
		public StringValue? PostingClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PriceClassID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PPVAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PurchasePriceVarianceAccount", EmitDefaultValue=false)]
		public StringValue? PurchasePriceVarianceAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PPVSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PurchasePriceVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? PurchasePriceVarianceSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PurchaseUnit 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PurchaseUnit", EmitDefaultValue=false)]
		public StringValue? PurchaseUnit { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReasonCodeSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReasonCodeSubaccount", EmitDefaultValue=false)]
		public StringValue? ReasonCodeSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NonStockReceipt 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequireReceipt", EmitDefaultValue=false)]
		public BooleanValue? RequireReceipt { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NonStockShip 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequireShipment", EmitDefaultValue=false)]
		public BooleanValue? RequireShipment { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		[DataMember(Name="SalesCategories", EmitDefaultValue=false)]
		public List<NonStockItemSalesCategory>? SalesCategories { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesUnit 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalesUnit", EmitDefaultValue=false)]
		public StringValue? SalesUnit { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		[DataMember(Name="VendorDetails", EmitDefaultValue=false)]
		public List<NonStockItemVendorDetail>? VendorDetails { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseItemVolume 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Volume", EmitDefaultValue=false)]
		public DecimalValue? Volume { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VolumeUOM 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VolumeUOM", EmitDefaultValue=false)]
		public StringValue? VolumeUOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseItemWeight 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Weight", EmitDefaultValue=false)]
		public DecimalValue? Weight { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WeightUOM 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WeightUOM", EmitDefaultValue=false)]
		public StringValue? WeightUOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RecPrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurySpecificMSRP", EmitDefaultValue=false)]
		public DecimalValue? CurySpecificMSRP { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BasePrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurySpecificPrice", EmitDefaultValue=false)]
		public DecimalValue? CurySpecificPrice { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Availability 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Availability", EmitDefaultValue=false)]
		public StringValue? Availability { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExportToExternal 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExportToExternal", EmitDefaultValue=false)]
		public BooleanValue? ExportToExternal { get; set; }

		[DataMember(Name="Categories", EmitDefaultValue=false)]
		public List<CategoryStockItem>? Categories { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Body 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Content", EmitDefaultValue=false)]
		public StringValue? Content { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCost 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrentStdCost", EmitDefaultValue=false)]
		public DecimalValue? CurrentStdCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomURL 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomURL", EmitDefaultValue=false)]
		public StringValue? CustomURL { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseItemWeight 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DimensionWeight", EmitDefaultValue=false)]
		public DecimalValue? DimensionWeight { get; set; }

		[DataMember(Name="FileUrls", EmitDefaultValue=false)]
		public List<InventoryFileUrls>? FileUrls { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MetaDescription 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MetaDescription", EmitDefaultValue=false)]
		public StringValue? MetaDescription { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MetaKeywords 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MetaKeywords", EmitDefaultValue=false)]
		public StringValue? MetaKeywords { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RecPrice 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue? MSRP { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PageTitle 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PageTitle", EmitDefaultValue=false)]
		public StringValue? PageTitle { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SearchKeywords 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SearchKeywords", EmitDefaultValue=false)]
		public StringValue? SearchKeywords { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TemplateItemID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TemplateItemID", EmitDefaultValue=false)]
		public StringValue? TemplateItemID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Visibility 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Visibility", EmitDefaultValue=false)]
		public StringValue? Visibility { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}