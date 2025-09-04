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
	/// Corresponds to the screen IN204500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ItemWarehouse : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: DfltShipLocationID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Default Issue From 
		/// </summary>
		[DataMember(Name="DefaultIssueFrom", EmitDefaultValue=false)]
		public StringValue? DefaultIssueFrom { get; set; }

		/// <summary>
		/// DAC Field Name: DfltReceiptLocationID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Default Receipt To 
		/// </summary>
		[DataMember(Name="DefaultReceiptTo", EmitDefaultValue=false)]
		public StringValue? DefaultReceiptTo { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryItem__DefaultSubItemID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		[DataMember(Name="DefaultSubitem", EmitDefaultValue=false)]
		public StringValue? DefaultSubitem { get; set; }

		/// <summary>
		/// DAC Field Name: InvtAcctID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Inventory Account 
		/// </summary>
		[DataMember(Name="InventoryAccount", EmitDefaultValue=false)]
		public StringValue? InventoryAccount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Inventory ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: InvtSubID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Inventory Sub. 
		/// </summary>
		[DataMember(Name="InventorySubaccount", EmitDefaultValue=false)]
		public StringValue? InventorySubaccount { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Max Qty. 
		/// </summary>
		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public DecimalValue? MaxQty { get; set; }

		/// <summary>
		/// DAC Field Name: RecPrice 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue? MSRP { get; set; }

		/// <summary>
		/// DAC Field Name: OverrideInvtAcctSub 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Override Inventory Account/Sub. 
		/// </summary>
		[DataMember(Name="OverrideInventoryAccountSubaccount", EmitDefaultValue=false)]
		public BooleanValue? OverrideInventoryAccountSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: PreferredVendorOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Override Preferred Vendor 
		/// </summary>
		[DataMember(Name="OverridePreferredVendor", EmitDefaultValue=false)]
		public BooleanValue? OverridePreferredVendor { get; set; }

		/// <summary>
		/// DAC Field Name: RecPriceOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Override Price 
		/// </summary>
		[DataMember(Name="OverridePrice", EmitDefaultValue=false)]
		public BooleanValue? OverridePrice { get; set; }

		/// <summary>
		/// DAC Field Name: ReplenishmentPolicyOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Override Replenishment Settings 
		/// </summary>
		[DataMember(Name="OverrideReplenishmentSettings", EmitDefaultValue=false)]
		public BooleanValue? OverrideReplenishmentSettings { get; set; }

		/// <summary>
		/// DAC Field Name: ServiceLevelOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="OverrideServiceLevel", EmitDefaultValue=false)]
		public BooleanValue? OverrideServiceLevel { get; set; }

		/// <summary>
		/// DAC Field Name: StdCostOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Override Std. Cost 
		/// </summary>
		[DataMember(Name="OverrideStandardCost", EmitDefaultValue=false)]
		public BooleanValue? OverrideStandardCost { get; set; }

		/// <summary>
		/// DAC Field Name: ProductManagerOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Override Product Manager 
		/// </summary>
		[DataMember(Name="OverrideProductManager", EmitDefaultValue=false)]
		public BooleanValue? OverrideProductManager { get; set; }

		/// <summary>
		/// DAC Field Name: MaxQtyOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="OverrideMaxQty", EmitDefaultValue=false)]
		public BooleanValue? OverrideMaxQty { get; set; }

		/// <summary>
		/// DAC Field Name: MinQtyOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="OverrideReorderPoint", EmitDefaultValue=false)]
		public BooleanValue? OverrideReorderPoint { get; set; }

		/// <summary>
		/// DAC Field Name: SafetyStockOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="OverrideSafetyStock", EmitDefaultValue=false)]
		public BooleanValue? OverrideSafetyStock { get; set; }

		/// <summary>
		/// DAC Field Name: PreferredVendorLocationID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Preferred Location 
		/// </summary>
		[DataMember(Name="PreferredLocation", EmitDefaultValue=false)]
		public StringValue? PreferredLocation { get; set; }

		/// <summary>
		/// DAC Field Name: PreferredVendorID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Preferred Vendor 
		/// </summary>
		[DataMember(Name="PreferredVendor", EmitDefaultValue=false)]
		public StringValue? PreferredVendor { get; set; }

		/// <summary>
		/// DAC Field Name: ProductManagerID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Product Manager 
		/// </summary>
		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue? ProductManager { get; set; }

		/// <summary>
		/// DAC Field Name: ProductWorkgroupID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Product Workgroup 
		/// </summary>
		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// DAC Field Name: MinQty 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Reorder Point 
		/// </summary>
		[DataMember(Name="ReorderPoint", EmitDefaultValue=false)]
		public DecimalValue? ReorderPoint { get; set; }

		/// <summary>
		/// DAC Field Name: ReplenishmentClassID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Replenishment Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ReplenishmentClass", EmitDefaultValue=false)]
		public StringValue? ReplenishmentClass { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Replenishment Method 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ReplenishmentMethod", EmitDefaultValue=false)]
		public StringValue? ReplenishmentMethod { get; set; }

		/// <summary>
		/// Replenishment source
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Replenishment Source 
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
		/// DAC: PX.Objects.IN.INItemSite 
		/// Display Name: Safety Stock 
		/// </summary>
		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue? SafetyStock { get; set; }

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

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}