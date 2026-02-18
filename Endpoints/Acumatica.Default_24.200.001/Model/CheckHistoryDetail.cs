using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class CheckHistoryDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CuryAmt</para>
		/// <para>DAC: PX.Objects.AP.APTranPostBal</para>
		/// <para>Display Name: Amount Paid</para>
		/// </summary>
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryBalanceAmt</para>
		/// <para>DAC: PX.Objects.AP.APTranPostBal</para>
		/// </summary>
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDiscBalanceAmt</para>
		/// <para>DAC: PX.Objects.AP.APTranPostBal</para>
		/// <para>Display Name: Cash Discount Balance</para>
		/// </summary>
		public DecimalValue? CashDiscountBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryPPDAmt</para>
		/// <para>DAC: PX.Objects.AP.APTranPostBal</para>
		/// <para>Display Name: Cash Discount Taken</para>
		/// </summary>
		public DecimalValue? CashDiscountTaken { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceDocType</para>
		/// <para>DAC: PX.Objects.AP.APTranPostBal</para>
		/// <para>Display Name: Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? DocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceRefNbr</para>
		/// <para>DAC: PX.Objects.AP.APTranPostBal</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: APInvoice__InvoiceNbr</para>
		/// <para>DAC: PX.Objects.AP.APAdjust</para>
		/// </summary>
		public StringValue? VendorRef { get; set; }

	}
}