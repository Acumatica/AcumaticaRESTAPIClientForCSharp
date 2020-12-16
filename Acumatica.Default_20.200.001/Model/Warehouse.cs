using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Warehouse : Entity_v4
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="COGSExpenseAccount", EmitDefaultValue=false)]
		public StringValue COGSExpenseAccount { get; set; }

		[DataMember(Name="COGSExpenseSubaccount", EmitDefaultValue=false)]
		public StringValue COGSExpenseSubaccount { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DiscountAccount", EmitDefaultValue=false)]
		public StringValue DiscountAccount { get; set; }

		[DataMember(Name="DiscountSubaccount", EmitDefaultValue=false)]
		public StringValue DiscountSubaccount { get; set; }

		[DataMember(Name="DropShipLocationID", EmitDefaultValue=false)]
		public StringValue DropShipLocationID { get; set; }

		[DataMember(Name="FreightChargeAccount", EmitDefaultValue=false)]
		public StringValue FreightChargeAccount { get; set; }

		[DataMember(Name="FreightChargeSubaccount", EmitDefaultValue=false)]
		public StringValue FreightChargeSubaccount { get; set; }

		[DataMember(Name="InventoryAccount", EmitDefaultValue=false)]
		public StringValue InventoryAccount { get; set; }

		[DataMember(Name="InventorySubaccount", EmitDefaultValue=false)]
		public StringValue InventorySubaccount { get; set; }

		[DataMember(Name="LandedCostVarianceAccount", EmitDefaultValue=false)]
		public StringValue LandedCostVarianceAccount { get; set; }

		[DataMember(Name="LandedCostVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue LandedCostVarianceSubaccount { get; set; }

		[DataMember(Name="Locations", EmitDefaultValue=false)]
		public List<WarehouseLocation> Locations { get; set; }

		[DataMember(Name="MiscChargeAccount", EmitDefaultValue=false)]
		public StringValue MiscChargeAccount { get; set; }

		[DataMember(Name="MiscChargeSubaccount", EmitDefaultValue=false)]
		public StringValue MiscChargeSubaccount { get; set; }

		[DataMember(Name="OverrideInventoryAccountSubaccount", EmitDefaultValue=false)]
		public BooleanValue OverrideInventoryAccountSubaccount { get; set; }

		[DataMember(Name="POAccrualAccount", EmitDefaultValue=false)]
		public StringValue POAccrualAccount { get; set; }

		[DataMember(Name="POAccrualSubaccount", EmitDefaultValue=false)]
		public StringValue POAccrualSubaccount { get; set; }

		[DataMember(Name="PurchasePriceVarianceAccount", EmitDefaultValue=false)]
		public StringValue PurchasePriceVarianceAccount { get; set; }

		[DataMember(Name="PurchasePriceVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue PurchasePriceVarianceSubaccount { get; set; }

		[DataMember(Name="ReasonCodeSubaccount", EmitDefaultValue=false)]
		public StringValue ReasonCodeSubaccount { get; set; }

		[DataMember(Name="ReceivingLocationID", EmitDefaultValue=false)]
		public StringValue ReceivingLocationID { get; set; }

		[DataMember(Name="RMALocationID", EmitDefaultValue=false)]
		public StringValue RMALocationID { get; set; }

		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue SalesAccount { get; set; }

		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue SalesSubaccount { get; set; }

		[DataMember(Name="ShippingLocationID", EmitDefaultValue=false)]
		public StringValue ShippingLocationID { get; set; }

		[DataMember(Name="StandardCostRevaluationAccount", EmitDefaultValue=false)]
		public StringValue StandardCostRevaluationAccount { get; set; }

		[DataMember(Name="StandardCostRevaluationSubaccount", EmitDefaultValue=false)]
		public StringValue StandardCostRevaluationSubaccount { get; set; }

		[DataMember(Name="StandardCostVarianceAccount", EmitDefaultValue=false)]
		public StringValue StandardCostVarianceAccount { get; set; }

		[DataMember(Name="StandardCostVarianceSubaccount", EmitDefaultValue=false)]
		public StringValue StandardCostVarianceSubaccount { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }

	}
}