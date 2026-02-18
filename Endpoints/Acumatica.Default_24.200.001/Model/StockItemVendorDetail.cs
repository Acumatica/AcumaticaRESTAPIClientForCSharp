using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class StockItemVendorDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Add. Lead Time (Days)</para>
		/// </summary>
		public ShortValue? AddLeadTimeDays { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ERQ</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		public DecimalValue? EOQ { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastPrice</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Last Vendor Price</para>
		/// </summary>
		public DecimalValue? LastVendorPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Location__VLeadTime</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		public ShortValue? LeadTimeDays { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorLocationID</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Lot Size</para>
		/// </summary>
		public DecimalValue? LotSize { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MaxOrdQty</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Max Order Qty.</para>
		/// </summary>
		public DecimalValue? MaxOrderQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MinOrdFreq</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Min. Order Freq.(Days)</para>
		/// </summary>
		public IntValue? MinOrderFrequencyInDays { get; set; }

		/// <summary>
		/// <para>DAC Field Name: MinOrdQty</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Min. Order Qty.</para>
		/// </summary>
		public DecimalValue? MinOrderQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideSettings</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		public BooleanValue? Override { get; set; }

		/// <summary>
		/// The Unit of Measure used as the purchase unit for the Inventory Item.This field can be changed only if the Multiple Units of Measure feature is enabled.Otherwise, the purchase unit is assumed to be the same as the Base Unit.
		/// <para>DAC: PX.Objects.IN.InventoryItem</para>
		/// <para>Display Name: Purchase Unit</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? PurchaseUnit { get; set; }

		public IntValue? RecordID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.IN.INItemXRef</para>
		/// Key Field
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// <para>Display Name: Vendor ID</para>
		/// </summary>
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Vendor__AcctName</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Location__VSiteID</para>
		/// <para>DAC: PX.Objects.PO.POVendorInventory</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

	}
}