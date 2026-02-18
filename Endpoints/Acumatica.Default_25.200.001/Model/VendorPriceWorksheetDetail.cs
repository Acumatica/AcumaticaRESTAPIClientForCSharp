using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class VendorPriceWorksheetDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// <para>Display Name: Break Qty.</para>
		/// </summary>
		public DecimalValue? BreakQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryCD</para>
		/// <para>DAC: PX.Objects.AP.APAddItemSelected</para>
		/// <para>Display Name: Inventory ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		public IntValue? LineID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// <para>Display Name: Pending Price</para>
		/// </summary>
		public DecimalValue? PendingPrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheet</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CurrentPrice</para>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// <para>Display Name: Source Price</para>
		/// </summary>
		public DecimalValue? SourcePrice { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxID</para>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Tax { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? UOM { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorID</para>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheetDetail</para>
		/// </summary>
		public StringValue? Vendor { get; set; }

	}
}