using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class VendorPriceDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>Display Name: Break Qty.</para>
		/// </summary>
		public DecimalValue? BreakQty { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_InventoryItem_Descr</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesPrice</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// </summary>
		public DecimalValue? Price { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsPromotionalPrice</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// </summary>
		public BooleanValue? Promotional { get; set; }

		public IntValue? RecordID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// </summary>
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID_Vendor_AcctName</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// </summary>
		public StringValue? VendorName { get; set; }

	}
}