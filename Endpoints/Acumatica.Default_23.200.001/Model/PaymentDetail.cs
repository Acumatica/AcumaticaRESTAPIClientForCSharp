using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class PaymentDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: CuryAdjgAmt</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// <para>Display Name: Amount Paid in Payment Currency</para>
		/// </summary>
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryAdjgWOAmt</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// <para>Display Name: Write-Off Amount in Payment Currency</para>
		/// </summary>
		public DecimalValue? BalanceWriteOff { get; set; }

		/// <summary>
		/// The cash discount amount displayed for the document.Given in the  currency of the adjusting document.
		/// <para>DAC Field Name: CuryAdjgPPDAmt</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// <para>Display Name: Cash Discount Taken in Payment Currency</para>
		/// </summary>
		public DecimalValue? CashDiscountTaken { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__InvoiceNbr</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		public StringValue? CustomerOrder { get; set; }

		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjdLineNbr</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? DocLineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjdDocType</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// <para>Display Name: Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		public StringValue? DocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjdRefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// <para>Display Name: Write-Off Reason Code</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? WriteOffReasonCode { get; set; }

	}
}