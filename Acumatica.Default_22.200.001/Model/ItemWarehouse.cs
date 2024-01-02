using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ItemWarehouse : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="DefaultIssueFrom", EmitDefaultValue=false)]
		public StringValue? DefaultIssueFrom { get; set; }

		[DataMember(Name="DefaultReceiptTo", EmitDefaultValue=false)]
		public StringValue? DefaultReceiptTo { get; set; }

		[DataMember(Name="DefaultSubitem", EmitDefaultValue=false)]
		public StringValue? DefaultSubitem { get; set; }

		[DataMember(Name="InventoryAccount", EmitDefaultValue=false)]
		public StringValue? InventoryAccount { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="InventorySubaccount", EmitDefaultValue=false)]
		public StringValue? InventorySubaccount { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="MaxQty", EmitDefaultValue=false)]
		public DecimalValue? MaxQty { get; set; }

		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue? MSRP { get; set; }

		[DataMember(Name="OverrideInventoryAccountSubaccount", EmitDefaultValue=false)]
		public BooleanValue? OverrideInventoryAccountSubaccount { get; set; }

		[DataMember(Name="OverridePreferredVendor", EmitDefaultValue=false)]
		public BooleanValue? OverridePreferredVendor { get; set; }

		[DataMember(Name="OverridePrice", EmitDefaultValue=false)]
		public BooleanValue? OverridePrice { get; set; }

		[DataMember(Name="OverrideReplenishmentSettings", EmitDefaultValue=false)]
		public BooleanValue? OverrideReplenishmentSettings { get; set; }

		[DataMember(Name="OverrideServiceLevel", EmitDefaultValue=false)]
		public BooleanValue? OverrideServiceLevel { get; set; }

		[DataMember(Name="OverrideStandardCost", EmitDefaultValue=false)]
		public BooleanValue? OverrideStandardCost { get; set; }

		[DataMember(Name="OverrideProductManager", EmitDefaultValue=false)]
		public BooleanValue? OverrideProductManager { get; set; }

		[DataMember(Name="OverrideMaxQty", EmitDefaultValue=false)]
		public BooleanValue? OverrideMaxQty { get; set; }

		[DataMember(Name="OverrideReorderPoint", EmitDefaultValue=false)]
		public BooleanValue? OverrideReorderPoint { get; set; }

		[DataMember(Name="OverrideSafetyStock", EmitDefaultValue=false)]
		public BooleanValue? OverrideSafetyStock { get; set; }

		[DataMember(Name="PreferredLocation", EmitDefaultValue=false)]
		public StringValue? PreferredLocation { get; set; }

		[DataMember(Name="PreferredVendor", EmitDefaultValue=false)]
		public StringValue? PreferredVendor { get; set; }

		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue? ProductManager { get; set; }

		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue? ProductWorkgroup { get; set; }

		[DataMember(Name="ReorderPoint", EmitDefaultValue=false)]
		public DecimalValue? ReorderPoint { get; set; }

		[DataMember(Name="ReplenishmentClass", EmitDefaultValue=false)]
		public StringValue? ReplenishmentClass { get; set; }

		[DataMember(Name="ReplenishmentMethod", EmitDefaultValue=false)]
		public StringValue? ReplenishmentMethod { get; set; }

		[DataMember(Name="ReplenishmentSource", EmitDefaultValue=false)]
		public StringValue? ReplenishmentSource { get; set; }

		[DataMember(Name="ReplenishmentWarehouse", EmitDefaultValue=false)]
		public StringValue? ReplenishmentWarehouse { get; set; }

		[DataMember(Name="SafetyStock", EmitDefaultValue=false)]
		public DecimalValue? SafetyStock { get; set; }

		[DataMember(Name="Seasonality", EmitDefaultValue=false)]
		public StringValue? Seasonality { get; set; }

		[DataMember(Name="ServiceLevel", EmitDefaultValue=false)]
		public DecimalValue? ServiceLevel { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}