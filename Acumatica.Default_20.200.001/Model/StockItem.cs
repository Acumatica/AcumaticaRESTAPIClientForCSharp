using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class StockItem : Entity_v4
	{

		[DataMember(Name="ABCCode", EmitDefaultValue=false)]
		public StringValue ABCCode { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue> Attributes { get; set; }

		[DataMember(Name="AutoIncrementalValue", EmitDefaultValue=false)]
		public StringValue AutoIncrementalValue { get; set; }

		[DataMember(Name="AverageCost", EmitDefaultValue=false)]
		public DecimalValue AverageCost { get; set; }

		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue BaseUOM { get; set; }

		[DataMember(Name="Boxes", EmitDefaultValue=false)]
		public List<BoxStockItem> Boxes { get; set; }

		[DataMember(Name="Categories", EmitDefaultValue=false)]
		public List<CategoryStockItem> Categories { get; set; }

		[DataMember(Name="COGSAccount", EmitDefaultValue=false)]
		public StringValue COGSAccount { get; set; }

		[DataMember(Name="COGSSubaccount", EmitDefaultValue=false)]
		public StringValue COGSSubaccount { get; set; }

		[DataMember(Name="Content", EmitDefaultValue=false)]
		public StringValue Content { get; set; }

		[DataMember(Name="CrossReferences", EmitDefaultValue=false)]
		public List<InventoryItemCrossReference> CrossReferences { get; set; }

		[DataMember(Name="CurrentStdCost", EmitDefaultValue=false)]
		public DecimalValue CurrentStdCost { get; set; }

		[DataMember(Name="DefaultIssueLocationID", EmitDefaultValue=false)]
		public StringValue DefaultIssueLocationID { get; set; }

		[DataMember(Name="DefaultPrice", EmitDefaultValue=false)]
		public DecimalValue DefaultPrice { get; set; }

		[DataMember(Name="DefaultReceiptLocationID", EmitDefaultValue=false)]
		public StringValue DefaultReceiptLocationID { get; set; }

		[DataMember(Name="DefaultSubitem", EmitDefaultValue=false)]
		public StringValue DefaultSubitem { get; set; }

		[DataMember(Name="DefaultWarehouseID", EmitDefaultValue=false)]
		public StringValue DefaultWarehouseID { get; set; }

		[DataMember(Name="DeferralAccount", EmitDefaultValue=false)]
		public StringValue DeferralAccount { get; set; }

		[DataMember(Name="DeferralSubaccount", EmitDefaultValue=false)]
		public StringValue DeferralSubaccount { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DimensionVolume", EmitDefaultValue=false)]
		public DecimalValue DimensionVolume { get; set; }

		[DataMember(Name="DimensionWeight", EmitDefaultValue=false)]
		public DecimalValue DimensionWeight { get; set; }

		[DataMember(Name="DiscountAccount", EmitDefaultValue=false)]
		public StringValue DiscountAccount { get; set; }

		[DataMember(Name="DiscountSubaccount", EmitDefaultValue=false)]
		public StringValue DiscountSubaccount { get; set; }

		[DataMember(Name="ImageUrl", EmitDefaultValue=false)]
		public StringValue ImageUrl { get; set; }

		[DataMember(Name="InventoryAccount", EmitDefaultValue=false)]
		public StringValue InventoryAccount { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="InventorySubaccount", EmitDefaultValue=false)]
		public StringValue InventorySubaccount { get; set; }

		[DataMember(Name="IsAKit", EmitDefaultValue=false)]
		public BooleanValue IsAKit { get; set; }

		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue ItemClass { get; set; }

		[DataMember(Name="ItemStatus", EmitDefaultValue=false)]
		public StringValue ItemStatus { get; set; }

		[DataMember(Name="ItemType", EmitDefaultValue=false)]
		public StringValue ItemType { get; set; }

		[DataMember(Name="LandedCostVarianceAccount", EmitDefaultValue=false)]
		public StringValue LandedCostVarianceAccount { get; set; }

		[DataMember(Name="LandedCostVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue LandedCostVarianceSubaccount { get; set; }

		[DataMember(Name="LastCost", EmitDefaultValue=false)]
		public DecimalValue LastCost { get; set; }

		[DataMember(Name="LastModified", EmitDefaultValue=false)]
		public DateTimeValue LastModified { get; set; }

		[DataMember(Name="LastStdCost", EmitDefaultValue=false)]
		public DecimalValue LastStdCost { get; set; }

		[DataMember(Name="LotSerialClass", EmitDefaultValue=false)]
		public StringValue LotSerialClass { get; set; }

		[DataMember(Name="Markup", EmitDefaultValue=false)]
		public DecimalValue Markup { get; set; }

		[DataMember(Name="MaxCost", EmitDefaultValue=false)]
		public DecimalValue MaxCost { get; set; }

		[DataMember(Name="MinCost", EmitDefaultValue=false)]
		public DecimalValue MinCost { get; set; }

		[DataMember(Name="MinMarkup", EmitDefaultValue=false)]
		public DecimalValue MinMarkup { get; set; }

		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue MSRP { get; set; }

		[DataMember(Name="PackagingOption", EmitDefaultValue=false)]
		public StringValue PackagingOption { get; set; }

		[DataMember(Name="PackSeparately", EmitDefaultValue=false)]
		public BooleanValue PackSeparately { get; set; }

		[DataMember(Name="PendingStdCost", EmitDefaultValue=false)]
		public DecimalValue PendingStdCost { get; set; }

		[DataMember(Name="POAccrualAccount", EmitDefaultValue=false)]
		public StringValue POAccrualAccount { get; set; }

		[DataMember(Name="POAccrualSubaccount", EmitDefaultValue=false)]
		public StringValue POAccrualSubaccount { get; set; }

		[DataMember(Name="PostingClass", EmitDefaultValue=false)]
		public StringValue PostingClass { get; set; }

		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue PriceClass { get; set; }

		[DataMember(Name="PriceManager", EmitDefaultValue=false)]
		public StringValue PriceManager { get; set; }

		[DataMember(Name="PriceWorkgroup", EmitDefaultValue=false)]
		public StringValue PriceWorkgroup { get; set; }

		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue ProductManager { get; set; }

		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue ProductWorkgroup { get; set; }

		[DataMember(Name="PurchasePriceVarianceAccount", EmitDefaultValue=false)]
		public StringValue PurchasePriceVarianceAccount { get; set; }

		[DataMember(Name="PurchasePriceVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue PurchasePriceVarianceSubaccount { get; set; }

		[DataMember(Name="PurchaseUOM", EmitDefaultValue=false)]
		public StringValue PurchaseUOM { get; set; }

		[DataMember(Name="ReasonCodeSubaccount", EmitDefaultValue=false)]
		public StringValue ReasonCodeSubaccount { get; set; }

		[DataMember(Name="ReplenishmentParameters", EmitDefaultValue=false)]
		public List<ReplenishmentParameterStockItem> ReplenishmentParameters { get; set; }

		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue SalesAccount { get; set; }

		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue SalesSubaccount { get; set; }

		[DataMember(Name="SalesUOM", EmitDefaultValue=false)]
		public StringValue SalesUOM { get; set; }

		[DataMember(Name="StandardCostRevaluationAccount", EmitDefaultValue=false)]
		public StringValue StandardCostRevaluationAccount { get; set; }

		[DataMember(Name="StandardCostRevaluationSubaccount", EmitDefaultValue=false)]
		public StringValue StandardCostRevaluationSubaccount { get; set; }

		[DataMember(Name="StandardCostVarianceAccount", EmitDefaultValue=false)]
		public StringValue StandardCostVarianceAccount { get; set; }

		[DataMember(Name="StandardCostVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue StandardCostVarianceSubaccount { get; set; }

		[DataMember(Name="SubItems", EmitDefaultValue=false)]
		public List<SubItemStockItem> SubItems { get; set; }

		[DataMember(Name="SubjectToCommission", EmitDefaultValue=false)]
		public BooleanValue SubjectToCommission { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="UOMConversions", EmitDefaultValue=false)]
		public List<InventoryItemUOMConversion> UOMConversions { get; set; }

		[DataMember(Name="UseOnEntry", EmitDefaultValue=false)]
		public BooleanValue UseOnEntry { get; set; }

		[DataMember(Name="ValuationMethod", EmitDefaultValue=false)]
		public StringValue ValuationMethod { get; set; }

		[DataMember(Name="VendorDetails", EmitDefaultValue=false)]
		public List<StockItemVendorDetail> VendorDetails { get; set; }

		[DataMember(Name="VolumeUOM", EmitDefaultValue=false)]
		public StringValue VolumeUOM { get; set; }

		[DataMember(Name="WarehouseDetails", EmitDefaultValue=false)]
		public List<StockItemWarehouseDetail> WarehouseDetails { get; set; }

		[DataMember(Name="WeightUOM", EmitDefaultValue=false)]
		public StringValue WeightUOM { get; set; }

	}
}