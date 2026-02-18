using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN204500</c> in the Acumatica ERP
	/// <para>Key Fields: InventoryID, WarehouseID</para>
	/// </summary>
	public class ItemWarehouse : Entity, ITopLevelEntity
	{

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltShipLocationID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Default Issue From</para>
		/// </summary>
		public StringValue? DefaultIssueFrom { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltReceiptLocationID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Default Receipt To</para>
		/// </summary>
		public StringValue? DefaultReceiptTo { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryItem__DefaultSubItemID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// </summary>
		public StringValue? DefaultSubitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtAcctID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Inventory Account</para>
		/// </summary>
		public StringValue? InventoryAccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Inventory ID</para>
		/// Key Field
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtSubID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Inventory Sub.</para>
		/// </summary>
		public StringValue? InventorySubaccount { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Max Qty.</para>
		/// </summary>
		public DecimalValue? MaxQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RecPrice</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// </summary>
		public DecimalValue? MSRP { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideInvtAcctSub</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Inventory Account/Sub.</para>
		/// </summary>
		public BooleanValue? OverrideInventoryAccountSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PreferredVendorOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Preferred Vendor</para>
		/// </summary>
		public BooleanValue? OverridePreferredVendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RecPriceOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Price</para>
		/// </summary>
		public BooleanValue? OverridePrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentPolicyOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Replenishment Settings</para>
		/// </summary>
		public BooleanValue? OverrideReplenishmentSettings { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ServiceLevelOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? OverrideServiceLevel { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCostOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Std. Cost</para>
		/// </summary>
		public BooleanValue? OverrideStandardCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductManagerOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Product Manager</para>
		/// </summary>
		public BooleanValue? OverrideProductManager { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MaxQtyOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? OverrideMaxQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MinQtyOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? OverrideReorderPoint { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SafetyStockOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? OverrideSafetyStock { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PreferredVendorLocationID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Preferred Location</para>
		/// </summary>
		public StringValue? PreferredLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PreferredVendorID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Preferred Vendor</para>
		/// </summary>
		public StringValue? PreferredVendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductManagerID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Product Manager</para>
		/// </summary>
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductWorkgroupID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Product Workgroup</para>
		/// </summary>
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MinQty</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Reorder Point</para>
		/// </summary>
		public DecimalValue? ReorderPoint { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentClassID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Replenishment Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ReplenishmentClass { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Replenishment Method</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ReplenishmentMethod { get; set; }

		/// <summary>
		/// Replenishment source
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Replenishment Source</para>
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
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Safety Stock</para>
		/// </summary>
		public DecimalValue? SafetyStock { get; set; }

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

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}