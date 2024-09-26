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
		/// 
		/// Display Name:
		/// DAC Field Name: ABCCodeID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ABCCode", EmitDefaultValue=false)]
		public StringValue? ABCCode { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LotSerNumVal 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AutoIncrementalValue", EmitDefaultValue=false)]
		public StringValue? AutoIncrementalValue { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AvgCost 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AverageCost", EmitDefaultValue=false)]
		public DecimalValue? AverageCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseUnit 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue? BaseUOM { get; set; }

		[DataMember(Name="Boxes", EmitDefaultValue=false)]
		public List<BoxStockItem>? Boxes { get; set; }

		[DataMember(Name="Categories", EmitDefaultValue=false)]
		public List<CategoryStockItem>? Categories { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: COGSAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="COGSAccount", EmitDefaultValue=false)]
		public StringValue? COGSAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: COGSSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="COGSSubaccount", EmitDefaultValue=false)]
		public StringValue? COGSSubaccount { get; set; }

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
		/// DAC Field Name: CountryOfOrigin 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CountryOfOrigin", EmitDefaultValue=false)]
		public StringValue? CountryOfOrigin { get; set; }

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
		[DataMember(Name="CurrentStdCost", EmitDefaultValue=false)]
		public DecimalValue? CurrentStdCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DfltShipLocationID 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultIssueLocationID", EmitDefaultValue=false)]
		public StringValue? DefaultIssueLocationID { get; set; }

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
		/// DAC Field Name: DfltReceiptLocationID 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultReceiptLocationID", EmitDefaultValue=false)]
		public StringValue? DefaultReceiptLocationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultSubItemID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultSubitem", EmitDefaultValue=false)]
		public StringValue? DefaultSubitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DfltSiteID 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultWarehouseID", EmitDefaultValue=false)]
		public StringValue? DefaultWarehouseID { get; set; }

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
		/// DAC Field Name: BaseItemVolume 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DimensionVolume", EmitDefaultValue=false)]
		public DecimalValue? DimensionVolume { get; set; }

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

		[DataMember(Name="DiscountAccount", EmitDefaultValue=false)]
		public StringValue? DiscountAccount { get; set; }

		[DataMember(Name="DiscountSubaccount", EmitDefaultValue=false)]
		public StringValue? DiscountSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ImageUrl 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ImageUrl", EmitDefaultValue=false)]
		public StringValue? ImageUrl { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InvtAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryAccount", EmitDefaultValue=false)]
		public StringValue? InventoryAccount { get; set; }

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
		/// DAC Field Name: InvtSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventorySubaccount", EmitDefaultValue=false)]
		public StringValue? InventorySubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: KitItem 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
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
		/// DAC Field Name: LCVarianceAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LandedCostVarianceAccount", EmitDefaultValue=false)]
		public StringValue? LandedCostVarianceAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LCVarianceSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LandedCostVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? LandedCostVarianceSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastCost 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastCost", EmitDefaultValue=false)]
		public DecimalValue? LastCost { get; set; }

		[DataMember(Name="LastModified", EmitDefaultValue=false)]
		public DateTimeValue? LastModified { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastStdCost 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastStdCost", EmitDefaultValue=false)]
		public DecimalValue? LastStdCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LotSerClassID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LotSerialClass", EmitDefaultValue=false)]
		public StringValue? LotSerialClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MarkupPct 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Markup", EmitDefaultValue=false)]
		public DecimalValue? Markup { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MaxCost 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MaxCost", EmitDefaultValue=false)]
		public DecimalValue? MaxCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MinCost 
		/// DAC: {} 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MinCost", EmitDefaultValue=false)]
		public DecimalValue? MinCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MinGrossProfitPct 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MinMarkup", EmitDefaultValue=false)]
		public DecimalValue? MinMarkup { get; set; }

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

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PackageOption 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PackagingOption", EmitDefaultValue=false)]
		public StringValue? PackagingOption { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PackSeparately 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PackSeparately", EmitDefaultValue=false)]
		public BooleanValue? PackSeparately { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PendingStdCost 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PendingStdCost", EmitDefaultValue=false)]
		public DecimalValue? PendingStdCost { get; set; }

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
		/// DAC Field Name: PriceManagerID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PriceManager", EmitDefaultValue=false)]
		public StringValue? PriceManager { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PriceWorkgroupID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PriceWorkgroup", EmitDefaultValue=false)]
		public StringValue? PriceWorkgroup { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductManagerID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductWorkgroupID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue? ProductWorkgroup { get; set; }

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
		[DataMember(Name="PurchaseUOM", EmitDefaultValue=false)]
		public StringValue? PurchaseUOM { get; set; }

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

		[DataMember(Name="ReplenishmentParameters", EmitDefaultValue=false)]
		public List<ReplenishmentParameterStockItem>? ReplenishmentParameters { get; set; }

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
		[DataMember(Name="SalesUOM", EmitDefaultValue=false)]
		public StringValue? SalesUOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCstRevAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StandardCostRevaluationAccount", EmitDefaultValue=false)]
		public StringValue? StandardCostRevaluationAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCstRevSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StandardCostRevaluationSubaccount", EmitDefaultValue=false)]
		public StringValue? StandardCostRevaluationSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCstVarAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StandardCostVarianceAccount", EmitDefaultValue=false)]
		public StringValue? StandardCostVarianceAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCstVarSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="StandardCostVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue? StandardCostVarianceSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Commisionable 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SubjectToCommission", EmitDefaultValue=false)]
		public BooleanValue? SubjectToCommission { get; set; }

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

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: HSTariffCode 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TariffCode", EmitDefaultValue=false)]
		public StringValue? TariffCode { get; set; }

		[DataMember(Name="UOMConversions", EmitDefaultValue=false)]
		public List<InventoryItemUOMConversion>? UOMConversions { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultSubItemOnEntry 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseOnEntry", EmitDefaultValue=false)]
		public BooleanValue? UseOnEntry { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ValMethod 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ValuationMethod", EmitDefaultValue=false)]
		public StringValue? ValuationMethod { get; set; }

		[DataMember(Name="VendorDetails", EmitDefaultValue=false)]
		public List<StockItemVendorDetail>? VendorDetails { get; set; }

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

		[DataMember(Name="WarehouseDetails", EmitDefaultValue=false)]
		public List<StockItemWarehouseDetail>? WarehouseDetails { get; set; }

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
		/// DAC Field Name: ExportToExternal 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExportToExternal", EmitDefaultValue=false)]
		public BooleanValue? ExportToExternal { get; set; }

		[DataMember(Name="FileURLs", EmitDefaultValue=false)]
		public List<InventoryFileUrls>? FileURLs { get; set; }

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

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NotAvailMode 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NotAvailable", EmitDefaultValue=false)]
		public StringValue? NotAvailable { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}