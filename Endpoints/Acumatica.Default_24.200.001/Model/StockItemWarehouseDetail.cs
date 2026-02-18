using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class StockItemWarehouseDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: DemandPerDayAverage</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Daily Demand Forecast</para>
		/// </summary>
		public DecimalValue? DailyDemandForecast { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DemandPerDaySTDEV</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Daily Demand Forecast Error(STDEV)</para>
		/// </summary>
		public DecimalValue? DailyDemandForecastErrorSTDEV { get; set; }

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
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Default</para>
		/// </summary>
		public BooleanValue? IsDefault { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Last Forecast Date</para>
		/// </summary>
		public DateTimeValue? LastForecastDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ServiceLevelOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// </summary>
		public BooleanValue? Override { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PreferredVendorOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Preferred Vendor</para>
		/// </summary>
		public BooleanValue? OverridePreferredVendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentPolicyOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Replenishment Settings</para>
		/// </summary>
		public BooleanValue? OverrideReplenishmentSettings { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCostOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Std. Cost</para>
		/// </summary>
		public BooleanValue? OverrideStdCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PreferredVendorID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Preferred Vendor</para>
		/// </summary>
		public StringValue? PreferredVendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BasePriceOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Price Override</para>
		/// </summary>
		public BooleanValue? PriceOverride { get; set; }

		/// <summary>
		/// The product manager responsible for this item.
		/// <para>DAC Field Name: ProductManagerID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Product Manager</para>
		/// </summary>
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// The workgroup that is responsible for the item.
		/// <para>DAC Field Name: ProductWorkgroupID</para>
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Product Workgroup</para>
		/// </summary>
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: INSiteStatusSummary__QtyOnHand</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// </summary>
		public DecimalValue? QtyOnHand { get; set; }

		/// <summary>
		/// Replenishment source
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Source</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ReplenishmentSource { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentSourceSiteID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Replenishment Warehouse</para>
		/// </summary>
		public StringValue? ReplenishmentWarehouse { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentPolicyID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? Seasonality { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ServiceLevelPct</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Service Level (%)</para>
		/// </summary>
		public DecimalValue? ServiceLevel { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteStatus</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Warehouse</para>
		/// Key Field
		/// </summary>
		public StringValue? WarehouseID { get; set; }

	}
}