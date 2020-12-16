using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ItemWarehouse : Entity_v4
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue CreatedDateTime { get; set; }

		[DataMember(Name="DefaultIssueFrom", EmitDefaultValue=false)]
		public StringValue DefaultIssueFrom { get; set; }

		[DataMember(Name="DefaultReceiptTo", EmitDefaultValue=false)]
		public StringValue DefaultReceiptTo { get; set; }

		[DataMember(Name="DefaultSubitem", EmitDefaultValue=false)]
		public StringValue DefaultSubitem { get; set; }

		[DataMember(Name="InventoryAccount", EmitDefaultValue=false)]
		public StringValue InventoryAccount { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="InventorySubaccount", EmitDefaultValue=false)]
		public StringValue InventorySubaccount { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="MSRP", EmitDefaultValue=false)]
		public DecimalValue MSRP { get; set; }

		[DataMember(Name="OverrideInventoryAccountSubaccount", EmitDefaultValue=false)]
		public BooleanValue OverrideInventoryAccountSubaccount { get; set; }

		[DataMember(Name="OverridePreferredVendor", EmitDefaultValue=false)]
		public BooleanValue OverridePreferredVendor { get; set; }

		[DataMember(Name="OverridePrice", EmitDefaultValue=false)]
		public BooleanValue OverridePrice { get; set; }

		[DataMember(Name="OverrideReplenishmentSettings", EmitDefaultValue=false)]
		public BooleanValue OverrideReplenishmentSettings { get; set; }

		[DataMember(Name="OverrideServiceLevelOverride", EmitDefaultValue=false)]
		public BooleanValue OverrideServiceLevelOverride { get; set; }

		[DataMember(Name="OverrideStandardCost", EmitDefaultValue=false)]
		public BooleanValue OverrideStandardCost { get; set; }

		[DataMember(Name="OverrideProductManager", EmitDefaultValue=false)]
		public BooleanValue OverrideProductManager { get; set; }

		[DataMember(Name="PreferredLocation", EmitDefaultValue=false)]
		public StringValue PreferredLocation { get; set; }

		[DataMember(Name="PreferredVendor", EmitDefaultValue=false)]
		public StringValue PreferredVendor { get; set; }

		[DataMember(Name="ProductManager", EmitDefaultValue=false)]
		public StringValue ProductManager { get; set; }

		[DataMember(Name="ProductWorkgroup", EmitDefaultValue=false)]
		public StringValue ProductWorkgroup { get; set; }

		[DataMember(Name="ReplenishmentClass", EmitDefaultValue=false)]
		public StringValue ReplenishmentClass { get; set; }

		[DataMember(Name="ReplenishmentMethod", EmitDefaultValue=false)]
		public StringValue ReplenishmentMethod { get; set; }

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