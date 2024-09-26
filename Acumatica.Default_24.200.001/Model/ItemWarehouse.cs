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
	/// Corresponds to the screen IN204500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ItemWarehouse : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DfltShipLocationID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultIssueFrom", EmitDefaultValue=false)]
		public StringValue? DefaultIssueFrom { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DfltReceiptLocationID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultReceiptTo", EmitDefaultValue=false)]
		public StringValue? DefaultReceiptTo { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryItem__DefaultSubItemID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultSubitem", EmitDefaultValue=false)]
		public StringValue? DefaultSubitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InvtAcctID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryAccount", EmitDefaultValue=false)]
		public StringValue? InventoryAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryID 
		/// DAC: PX.Objects.IN.INItemSite 
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
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventorySubaccount", EmitDefaultValue=false)]
		public StringValue? InventorySubaccount { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MaxQty 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public DecimalValue? MaxQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RecPrice 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue? MSRP { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideInvtAcctSub 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverrideInventoryAccountSubaccount", EmitDefaultValue=false)]
		public BooleanValue? OverrideInventoryAccountSubaccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PreferredVendorOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverridePreferredVendor", EmitDefaultValue=false)]
		public BooleanValue? OverridePreferredVendor { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RecPriceOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverridePrice", EmitDefaultValue=false)]
		public BooleanValue? OverridePrice { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReplenishmentPolicyOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverrideReplenishmentSettings", EmitDefaultValue=false)]
		public BooleanValue? OverrideReplenishmentSettings { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ServiceLevelOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverrideServiceLevel", EmitDefaultValue=false)]
		public BooleanValue? OverrideServiceLevel { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StdCostOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverrideStandardCost", EmitDefaultValue=false)]
		public BooleanValue? OverrideStandardCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductManagerOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverrideProductManager", EmitDefaultValue=false)]
		public BooleanValue? OverrideProductManager { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MaxQtyOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverrideMaxQty", EmitDefaultValue=false)]
		public BooleanValue? OverrideMaxQty { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MinQtyOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverrideReorderPoint", EmitDefaultValue=false)]
		public BooleanValue? OverrideReorderPoint { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SafetyStockOverride 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverrideSafetyStock", EmitDefaultValue=false)]
		public BooleanValue? OverrideSafetyStock { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PreferredVendorLocationID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PreferredLocation", EmitDefaultValue=false)]
		public StringValue? PreferredLocation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PreferredVendorID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PreferredVendor", EmitDefaultValue=false)]
		public StringValue? PreferredVendor { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductManagerID 
		/// DAC: PX.Objects.IN.INItemSite 
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
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue? ProductWorkgroup { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MinQty 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReorderPoint", EmitDefaultValue=false)]
		public DecimalValue? ReorderPoint { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReplenishmentClassID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReplenishmentClass", EmitDefaultValue=false)]
		public StringValue? ReplenishmentClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReplenishmentMethod 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReplenishmentMethod", EmitDefaultValue=false)]
		public StringValue? ReplenishmentMethod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReplenishmentSource 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReplenishmentSource", EmitDefaultValue=false)]
		public StringValue? ReplenishmentSource { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReplenishmentSourceSiteID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReplenishmentWarehouse", EmitDefaultValue=false)]
		public StringValue? ReplenishmentWarehouse { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SafetyStock 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue? SafetyStock { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReplenishmentPolicyID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Seasonality", EmitDefaultValue=false)]
		public StringValue? Seasonality { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ServiceLevelPct 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ServiceLevel", EmitDefaultValue=false)]
		public DecimalValue? ServiceLevel { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteStatus 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.IN.INItemSite 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}