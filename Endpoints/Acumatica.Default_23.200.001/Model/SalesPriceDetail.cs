using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class SalesPriceDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARSalesPrice</para>
		/// <para>Display Name: Break Qty.</para>
		/// </summary>
		public DecimalValue? BreakQty { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AR.ARSalesPrice</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARSalesPrice</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARSalesPrice</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARSalesPrice</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARSalesPriceFilter</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesPrice</para>
		/// <para>DAC: PX.Objects.AR.ARSalesPrice</para>
		/// </summary>
		public DecimalValue? Price { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARSalesPriceFilter</para>
		/// <para>Display Name: Price Code</para>
		/// <para>SQL Type: varchar(30)</para>
		/// </summary>
		public StringValue? PriceCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARSalesPriceFilter</para>
		/// <para>Display Name: Price Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? PriceType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsPromotionalPrice</para>
		/// <para>DAC: PX.Objects.AR.ARSalesPrice</para>
		/// </summary>
		public BooleanValue? Promotion { get; set; }

		public IntValue? RecordID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxID</para>
		/// <para>DAC: PX.Objects.AR.ARSalesPrice</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Tax { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARSalesPrice</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		public GuidValue? NoteID { get; set; }

		public StringValue? Warehouse { get; set; }

		public StringValue? TaxCalculationMode { get; set; }

	}
}