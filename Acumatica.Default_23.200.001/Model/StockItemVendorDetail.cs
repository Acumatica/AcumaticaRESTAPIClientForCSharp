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
	public class StockItemVendorDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// Display Name: Add. Lead Time (Days) 
		/// </summary>
		[DataMember(Name="AddLeadTimeDays", EmitDefaultValue=false)]
		public ShortValue? AddLeadTimeDays { get; set; }

		/// <summary>
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// Display Name: Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: IsDefault 
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// DAC Field Name: ERQ 
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// </summary>
		[DataMember(Name="EOQ", EmitDefaultValue=false)]
		public DecimalValue? EOQ { get; set; }

		/// <summary>
		/// DAC Field Name: LastPrice 
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// Display Name: Last Vendor Price 
		/// </summary>
		[DataMember(Name="LastVendorPrice", EmitDefaultValue=false)]
		public DecimalValue? LastVendorPrice { get; set; }

		/// <summary>
		/// DAC Field Name: Location__VLeadTime 
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// </summary>
		[DataMember(Name="LeadTimeDays", EmitDefaultValue=false)]
		public ShortValue? LeadTimeDays { get; set; }

		/// <summary>
		/// DAC Field Name: VendorLocationID 
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// Display Name: Lot Size 
		/// </summary>
		[DataMember(Name="LotSize", EmitDefaultValue=false)]
		public DecimalValue? LotSize { get; set; }

		/// <summary>
		/// DAC Field Name: MaxOrdQty 
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// Display Name: Max Order Qty. 
		/// </summary>
		[DataMember(Name="MaxOrderQty", EmitDefaultValue=false)]
		public DecimalValue? MaxOrderQty { get; set; }

		/// <summary>
		/// DAC Field Name: MinOrdFreq 
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// Display Name: Min. Order Freq.(Days) 
		/// </summary>
		[DataMember(Name="MinOrderFrequencyInDays", EmitDefaultValue=false)]
		public IntValue? MinOrderFrequencyInDays { get; set; }

		/// <summary>
		/// DAC Field Name: MinOrdQty 
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// Display Name: Min. Order Qty. 
		/// </summary>
		[DataMember(Name="MinOrderQty", EmitDefaultValue=false)]
		public DecimalValue? MinOrderQty { get; set; }

		/// <summary>
		/// DAC Field Name: OverrideSettings 
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// </summary>
		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		/// <summary>
		/// The Unit of Measure used as the purchase unit for the Inventory Item.This field can be changed only if the Multiple Units of Measure feature is enabled.Otherwise, the purchase unit is assumed to be the same as the Base Unit.
		/// DAC: PX.Objects.IN.InventoryItem 
		/// Display Name: Purchase Unit 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="PurchaseUnit", EmitDefaultValue=false)]
		public StringValue? PurchaseUnit { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.IN.INItemXRef 
		/// Key Field
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// Display Name: Vendor ID 
		/// </summary>
		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// DAC Field Name: Vendor__AcctName 
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// </summary>
		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// DAC Field Name: Location__VSiteID 
		/// DAC: PX.Objects.PO.POVendorInventory 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}