using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class NonStockItem : Entity_v4
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue> Attributes { get; set; }

		[DataMember(Name="BaseUnit", EmitDefaultValue=false)]
		public StringValue BaseUnit { get; set; }

		[DataMember(Name="CrossReferences", EmitDefaultValue=false)]
		public List<InventoryItemCrossReference> CrossReferences { get; set; }

		[DataMember(Name="CurrentCost", EmitDefaultValue=false)]
		public DecimalValue CurrentCost { get; set; }

		[DataMember(Name="DefaultPrice", EmitDefaultValue=false)]
		public DecimalValue DefaultPrice { get; set; }

		[DataMember(Name="DeferralAccount", EmitDefaultValue=false)]
		public StringValue DeferralAccount { get; set; }

		[DataMember(Name="DeferralSubaccount", EmitDefaultValue=false)]
		public StringValue DeferralSubaccount { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue EffectiveDate { get; set; }

		[DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
		public StringValue ExpenseAccount { get; set; }

		[DataMember(Name="ExpenseAccrualAccount", EmitDefaultValue=false)]
		public StringValue ExpenseAccrualAccount { get; set; }

		[DataMember(Name="ExpenseAccrualSubaccount", EmitDefaultValue=false)]
		public StringValue ExpenseAccrualSubaccount { get; set; }

		[DataMember(Name="ExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue ExpenseSubaccount { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="IsKit", EmitDefaultValue=false)]
		public BooleanValue IsKit { get; set; }

		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue ItemClass { get; set; }

		[DataMember(Name="ItemStatus", EmitDefaultValue=false)]
		public StringValue ItemStatus { get; set; }

		[DataMember(Name="ItemType", EmitDefaultValue=false)]
		public StringValue ItemType { get; set; }

		[DataMember(Name="LastCost", EmitDefaultValue=false)]
		public DecimalValue LastCost { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="PendingCost", EmitDefaultValue=false)]
		public DecimalValue PendingCost { get; set; }

		[DataMember(Name="PendingCostDate", EmitDefaultValue=false)]
		public DateTimeValue PendingCostDate { get; set; }

		[DataMember(Name="POAccrualAccount", EmitDefaultValue=false)]
		public StringValue POAccrualAccount { get; set; }

		[DataMember(Name="POAccrualSubaccount", EmitDefaultValue=false)]
		public StringValue POAccrualSubaccount { get; set; }

		[DataMember(Name="PostingClass", EmitDefaultValue=false)]
		public StringValue PostingClass { get; set; }

		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue PriceClass { get; set; }

		[DataMember(Name="PurchasePriceVarianceAccount", EmitDefaultValue=false)]
		public StringValue PurchasePriceVarianceAccount { get; set; }

		[DataMember(Name="PurchasePriceVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue PurchasePriceVarianceSubaccount { get; set; }

		[DataMember(Name="PurchaseUnit", EmitDefaultValue=false)]
		public StringValue PurchaseUnit { get; set; }

		[DataMember(Name="ReasonCodeSubaccount", EmitDefaultValue=false)]
		public StringValue ReasonCodeSubaccount { get; set; }

		[DataMember(Name="RequireReceipt", EmitDefaultValue=false)]
		public BooleanValue RequireReceipt { get; set; }

		[DataMember(Name="RequireShipment", EmitDefaultValue=false)]
		public BooleanValue RequireShipment { get; set; }

		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue SalesAccount { get; set; }

		[DataMember(Name="SalesCategories", EmitDefaultValue=false)]
		public List<NonStockItemSalesCategory> SalesCategories { get; set; }

		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue SalesSubaccount { get; set; }

		[DataMember(Name="SalesUnit", EmitDefaultValue=false)]
		public StringValue SalesUnit { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="VendorDetails", EmitDefaultValue=false)]
		public List<NonStockItemVendorDetail> VendorDetails { get; set; }

		[DataMember(Name="Volume", EmitDefaultValue=false)]
		public DecimalValue Volume { get; set; }

		[DataMember(Name="VolumeUOM", EmitDefaultValue=false)]
		public StringValue VolumeUOM { get; set; }

		[DataMember(Name="Weight", EmitDefaultValue=false)]
		public DecimalValue Weight { get; set; }

		[DataMember(Name="WeightUOM", EmitDefaultValue=false)]
		public StringValue WeightUOM { get; set; }

	}
}