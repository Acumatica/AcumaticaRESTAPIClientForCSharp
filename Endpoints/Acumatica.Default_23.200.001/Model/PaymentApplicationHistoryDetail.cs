using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class PaymentApplicationHistoryDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: SourceDocType</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? AdjustedDocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceRefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? AdjustedRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceDocType</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? AdjustingDocType { get; set; }

		public StringValue? AdjustingRefNbr { get; set; }

		public IntValue? AdjustmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARAdjust2__PendingPPD</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		public BooleanValue? AdjustsVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryAmt</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Amount Paid</para>
		/// </summary>
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__FinPeriodID</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		public StringValue? ApplicationPeriod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryBalanceAmt</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryWOAmt</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Write-Off Amount</para>
		/// </summary>
		public DecimalValue? BalanceWriteOff { get; set; }

		/// <summary>
		/// The number of the Batch created from the document on release.
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Batch Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDiscBalanceAmt</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Cash Discount Balance</para>
		/// </summary>
		public DecimalValue? CashDiscountBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__DiscDate</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		public DateTimeValue? CashDiscountDate { get; set; }

		public DecimalValue? CashDiscountTaken { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__CuryID</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__CustomerID</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__InvoiceNbr</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__DocDate</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__DocDesc</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceDocType</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? DisplayDocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceRefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? DisplayRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__DueDate</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		public DateTimeValue? DueDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__FinPeriodID</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		public StringValue? PostPeriod { get; set; }

		public StringValue? VATCreditMemo { get; set; }

	}
}