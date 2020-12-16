using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class StockItemWarehouseDetail : Entity_v4
	{

		[DataMember(Name="DailyDemandForecast", EmitDefaultValue=false)]
		public DecimalValue DailyDemandForecast { get; set; }

		[DataMember(Name="DailyDemandForecastErrorSTDEV", EmitDefaultValue=false)]
		public DecimalValue DailyDemandForecastErrorSTDEV { get; set; }

		[DataMember(Name="DefaultIssueLocationID", EmitDefaultValue=false)]
		public StringValue DefaultIssueLocationID { get; set; }

		[DataMember(Name="DefaultReceiptLocationID", EmitDefaultValue=false)]
		public StringValue DefaultReceiptLocationID { get; set; }

		[DataMember(Name="InventoryAccount", EmitDefaultValue=false)]
		public StringValue InventoryAccount { get; set; }

		[DataMember(Name="InventorySubaccount", EmitDefaultValue=false)]
		public StringValue InventorySubaccount { get; set; }

		[DataMember(Name="IsDefault", EmitDefaultValue=false)]
		public BooleanValue IsDefault { get; set; }

		[DataMember(Name="LastForecastDate", EmitDefaultValue=false)]
		public DateTimeValue LastForecastDate { get; set; }

		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue Override { get; set; }

		[DataMember(Name="OverridePreferredVendor", EmitDefaultValue=false)]
		public BooleanValue OverridePreferredVendor { get; set; }

		[DataMember(Name="OverrideReplenishmentSettings", EmitDefaultValue=false)]
		public BooleanValue OverrideReplenishmentSettings { get; set; }

		[DataMember(Name="OverrideStdCost", EmitDefaultValue=false)]
		public BooleanValue OverrideStdCost { get; set; }

		[DataMember(Name="PreferredVendor", EmitDefaultValue=false)]
		public StringValue PreferredVendor { get; set; }

		[DataMember(Name="PriceOverride", EmitDefaultValue=false)]
		public BooleanValue PriceOverride { get; set; }

		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue ProductManager { get; set; }

		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue ProductWorkgroup { get; set; }

		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue QtyOnHand { get; set; }

		[DataMember(Name="ReplenishmentSource", EmitDefaultValue=false)]
		public StringValue ReplenishmentSource { get; set; }

		[DataMember(Name="ReplenishmentWarehouse", EmitDefaultValue=false)]
		public StringValue ReplenishmentWarehouse { get; set; }

		[DataMember(Name="Seasonality", EmitDefaultValue=false)]
		public StringValue Seasonality { get; set; }

		[DataMember(Name="ServiceLevel", EmitDefaultValue=false)]
		public DecimalValue ServiceLevel { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue WarehouseID { get; set; }

	}
}