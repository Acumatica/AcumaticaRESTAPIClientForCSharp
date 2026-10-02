using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class VendorPriceDetail : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// </summary>
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPriceFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID_Vendor_AcctName</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// </summary>
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_InventoryItem_Descr</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsPromotionalPrice</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// </summary>
		public BooleanValue? Promotional { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>Display Name: Break Qty.</para>
		/// </summary>
		public DecimalValue? BreakQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesPrice</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// </summary>
		public DecimalValue? Price { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		public DateOnlyValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APVendorPrice</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateOnlyValue? ExpirationDate { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public IntValue? RecordID { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}