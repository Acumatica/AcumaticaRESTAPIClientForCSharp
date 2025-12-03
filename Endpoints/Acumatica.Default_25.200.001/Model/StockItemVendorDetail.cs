using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class StockItemVendorDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Add. Lead Time (Days)</para>
		/// </summary>
		[DataMember(Name="AddLeadTimeDays", EmitDefaultValue=false)]
		public ShortValue? AddLeadTimeDays { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ERQ</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		[DataMember(Name="EOQ", EmitDefaultValue=false)]
		public DecimalValue? EOQ { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastPrice</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Last Vendor Price</para>
		/// </summary>
		[DataMember(Name="LastVendorPrice", EmitDefaultValue=false)]
		public DecimalValue? LastVendorPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Location__VLeadTime</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		[DataMember(Name="LeadTimeDays", EmitDefaultValue=false)]
		public ShortValue? LeadTimeDays { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorLocationID</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Lot Size</para>
		/// </summary>
		[DataMember(Name="LotSize", EmitDefaultValue=false)]
		public DecimalValue? LotSize { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MaxOrdQty</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Max Order Qty.</para>
		/// </summary>
		[DataMember(Name="MaxOrderQty", EmitDefaultValue=false)]
		public DecimalValue? MaxOrderQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MinOrdFreq</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Min. Order Freq.(Days)</para>
		/// </summary>
		[DataMember(Name="MinOrderFrequencyInDays", EmitDefaultValue=false)]
		public IntValue? MinOrderFrequencyInDays { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MinOrdQty</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Min. Order Qty.</para>
		/// </summary>
		[DataMember(Name="MinOrderQty", EmitDefaultValue=false)]
		public DecimalValue? MinOrderQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideSettings</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		/// <summary>
		/// The Unit of Measure used as the purchase unit for the Inventory Item.This field can be changed only if the Multiple Units of Measure feature is enabled.Otherwise, the purchase unit is assumed to be the same as the Base Unit.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Purchase Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		[DataMember(Name="PurchaseUnit", EmitDefaultValue=false)]
		public StringValue? PurchaseUnit { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.IN.INItemXRef</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Vendor ID</para>
		/// </summary>
		[DataMember(Name="VendorID", EmitDefaultValue=false)]
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Vendor__AcctName</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Location__VSiteID</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}