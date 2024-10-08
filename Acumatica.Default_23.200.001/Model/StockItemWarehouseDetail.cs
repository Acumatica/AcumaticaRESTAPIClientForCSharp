using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class StockItemWarehouseDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: DemandPerDayAverage 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Daily Demand Forecast 
		/// </summary>
		[DataMember(Name="DailyDemandForecast", EmitDefaultValue=false)]
		public DecimalValue? DailyDemandForecast { get; set; }

		/// <summary>
		/// DAC Field Name: DemandPerDaySTDEV 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Daily Demand Forecast Error(STDEV) 
		/// </summary>
		[DataMember(Name="DailyDemandForecastErrorSTDEV", EmitDefaultValue=false)]
		public DecimalValue? DailyDemandForecastErrorSTDEV { get; set; }

		/// <summary>
		/// The Location of warehouse used by default to issue items of this kind.Applicable only for Stock Items (see StkItem) when the Warehouse Locations feature is enabled.
		/// DAC Field Name: DfltShipLocationID 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Default Issue From 
		/// </summary>
		[DataMember(Name="DefaultIssueLocationID", EmitDefaultValue=false)]
		public StringValue? DefaultIssueLocationID { get; set; }

		/// <summary>
		/// The Location of warehouse used by default to receive items of this kind.Applicable only for Stock Items (see StkItem) when the Warehouse Locations feature is enabled.
		/// DAC Field Name: DfltReceiptLocationID 
		/// DAC: PX.Objects.IN.InventoryItemCurySettings 
		/// Display Name: Default Receipt To 
		/// </summary>
		[DataMember(Name="DefaultReceiptLocationID", EmitDefaultValue=false)]
		public StringValue? DefaultReceiptLocationID { get; set; }

		/// <summary>
		/// The asset Account used to keep the inventory balance, resulting from the transactions with this item.Applicable only for Stock Items (see StkItem).
		/// DAC Field Name: InvtAcctID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Inventory Account 
		/// </summary>
		[DataMember(Name="InventoryAccount", EmitDefaultValue=false)]
		public StringValue? InventoryAccount { get; set; }

		/// <summary>
		/// The Subaccount used to keep the inventory balance, resulting from the transactions with this item.Applicable only for Stock Items (see StkItem).
		/// DAC Field Name: InvtSubID 
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Inventory Sub. 
		/// </summary>
		[DataMember(Name="InventorySubaccount", EmitDefaultValue=false)]
		public StringValue? InventorySubaccount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// Display Name: Default 
		/// </summary>
		[DataMember(Name="IsDefault", EmitDefaultValue=false)]
		public BooleanValue? IsDefault { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Last Forecast Date 
		/// </summary>
		[DataMember(Name="LastForecastDate", EmitDefaultValue=false)]
		public DateTimeValue? LastForecastDate { get; set; }

		/// <summary>
		/// DAC Field Name: ServiceLevelOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		/// <summary>
		/// DAC Field Name: PreferredVendorOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Override Preferred Vendor 
		/// </summary>
		[DataMember(Name="OverridePreferredVendor", EmitDefaultValue=false)]
		public BooleanValue? OverridePreferredVendor { get; set; }

		/// <summary>
		/// DAC Field Name: ReplenishmentPolicyOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Override Replenishment Settings 
		/// </summary>
		[DataMember(Name="OverrideReplenishmentSettings", EmitDefaultValue=false)]
		public BooleanValue? OverrideReplenishmentSettings { get; set; }

		/// <summary>
		/// DAC Field Name: StdCostOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Override Std. Cost 
		/// </summary>
		[DataMember(Name="OverrideStdCost", EmitDefaultValue=false)]
		public BooleanValue? OverrideStdCost { get; set; }

		/// <summary>
		/// DAC Field Name: PreferredVendorID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Preferred Vendor 
		/// </summary>
		[DataMember(Name="PreferredVendor", EmitDefaultValue=false)]
		public StringValue? PreferredVendor { get; set; }

		/// <summary>
		/// DAC Field Name: BasePriceOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Price Override 
		/// </summary>
		[DataMember(Name="PriceOverride", EmitDefaultValue=false)]
		public BooleanValue? PriceOverride { get; set; }

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
		/// DAC Field Name: INSiteStatusSummary__QtyOnHand 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHand { get; set; }

		/// <summary>
		/// Replenishment source
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Source 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ReplenishmentSource", EmitDefaultValue=false)]
		public StringValue? ReplenishmentSource { get; set; }

		/// <summary>
		/// DAC Field Name: ReplenishmentSourceSiteID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Replenishment Warehouse 
		/// </summary>
		[DataMember(Name="ReplenishmentWarehouse", EmitDefaultValue=false)]
		public StringValue? ReplenishmentWarehouse { get; set; }

		/// <summary>
		/// DAC Field Name: ReplenishmentPolicyID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Seasonality", EmitDefaultValue=false)]
		public StringValue? Seasonality { get; set; }

		/// <summary>
		/// DAC Field Name: ServiceLevelPct 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Service Level (%) 
		/// </summary>
		[DataMember(Name="ServiceLevel", EmitDefaultValue=false)]
		public DecimalValue? ServiceLevel { get; set; }

		/// <summary>
		/// DAC Field Name: SiteStatus 
		/// DAC: PX.Objects.IN.INItemSite 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Warehouse 
		/// Key Field
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

	}
}