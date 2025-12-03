using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

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
	[DataContract]
	public class ItemWarehouse : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltShipLocationID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Default Issue From</para>
		/// </summary>
		[DataMember(Name="DefaultIssueFrom", EmitDefaultValue=false)]
		public StringValue? DefaultIssueFrom { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DfltReceiptLocationID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Default Receipt To</para>
		/// </summary>
		[DataMember(Name="DefaultReceiptTo", EmitDefaultValue=false)]
		public StringValue? DefaultReceiptTo { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryItem__DefaultSubItemID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// </summary>
		[DataMember(Name="DefaultSubitem", EmitDefaultValue=false)]
		public StringValue? DefaultSubitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtAcctID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Inventory Account</para>
		/// </summary>
		[DataMember(Name="InventoryAccount", EmitDefaultValue=false)]
		public StringValue? InventoryAccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Inventory ID</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InvtSubID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Inventory Sub.</para>
		/// </summary>
		[DataMember(Name="InventorySubaccount", EmitDefaultValue=false)]
		public StringValue? InventorySubaccount { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Max Qty.</para>
		/// </summary>
		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public DecimalValue? MaxQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RecPrice</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// </summary>
		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue? MSRP { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideInvtAcctSub</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Inventory Account/Sub.</para>
		/// </summary>
		[DataMember(Name="OverrideInventoryAccountSubaccount", EmitDefaultValue=false)]
		public BooleanValue? OverrideInventoryAccountSubaccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PreferredVendorOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Preferred Vendor</para>
		/// </summary>
		[DataMember(Name="OverridePreferredVendor", EmitDefaultValue=false)]
		public BooleanValue? OverridePreferredVendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RecPriceOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Price</para>
		/// </summary>
		[DataMember(Name="OverridePrice", EmitDefaultValue=false)]
		public BooleanValue? OverridePrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentPolicyOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Replenishment Settings</para>
		/// </summary>
		[DataMember(Name="OverrideReplenishmentSettings", EmitDefaultValue=false)]
		public BooleanValue? OverrideReplenishmentSettings { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ServiceLevelOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		[DataMember(Name="OverrideServiceLevel", EmitDefaultValue=false)]
		public BooleanValue? OverrideServiceLevel { get; set; }

		/// <summary>
		/// <para>DAC Field Name: StdCostOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Std. Cost</para>
		/// </summary>
		[DataMember(Name="OverrideStandardCost", EmitDefaultValue=false)]
		public BooleanValue? OverrideStandardCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductManagerOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override Product Manager</para>
		/// </summary>
		[DataMember(Name="OverrideProductManager", EmitDefaultValue=false)]
		public BooleanValue? OverrideProductManager { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MaxQtyOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		[DataMember(Name="OverrideMaxQty", EmitDefaultValue=false)]
		public BooleanValue? OverrideMaxQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MinQtyOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		[DataMember(Name="OverrideReorderPoint", EmitDefaultValue=false)]
		public BooleanValue? OverrideReorderPoint { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SafetyStockOverride</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		[DataMember(Name="OverrideSafetyStock", EmitDefaultValue=false)]
		public BooleanValue? OverrideSafetyStock { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PreferredVendorLocationID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Preferred Location</para>
		/// </summary>
		[DataMember(Name="PreferredLocation", EmitDefaultValue=false)]
		public StringValue? PreferredLocation { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PreferredVendorID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Preferred Vendor</para>
		/// </summary>
		[DataMember(Name="PreferredVendor", EmitDefaultValue=false)]
		public StringValue? PreferredVendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductManagerID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Product Manager</para>
		/// </summary>
		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProductWorkgroupID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Product Workgroup</para>
		/// </summary>
		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MinQty</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Reorder Point</para>
		/// </summary>
		[DataMember(Name="ReorderPoint", EmitDefaultValue=false)]
		public DecimalValue? ReorderPoint { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentClassID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Replenishment Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ReplenishmentClass", EmitDefaultValue=false)]
		public StringValue? ReplenishmentClass { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Replenishment Method</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="ReplenishmentMethod", EmitDefaultValue=false)]
		public StringValue? ReplenishmentMethod { get; set; }

		/// <summary>
		/// Replenishment source
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Replenishment Source</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="ReplenishmentSource", EmitDefaultValue=false)]
		public StringValue? ReplenishmentSource { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentSourceSiteID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Replenishment Warehouse</para>
		/// </summary>
		[DataMember(Name="ReplenishmentWarehouse", EmitDefaultValue=false)]
		public StringValue? ReplenishmentWarehouse { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Safety Stock</para>
		/// </summary>
		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue? SafetyStock { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReplenishmentPolicyID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="Seasonality", EmitDefaultValue=false)]
		public StringValue? Seasonality { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ServiceLevelPct</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Service Level (%)</para>
		/// </summary>
		[DataMember(Name="ServiceLevel", EmitDefaultValue=false)]
		public DecimalValue? ServiceLevel { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteStatus</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.INItemSite</para>
		/// <para>Display Name: Warehouse</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}