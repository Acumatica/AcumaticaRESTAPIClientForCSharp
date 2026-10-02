using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class PaymentApplicationHistoryDetail : Entity
	{

		#region Fields
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
		/// <para>DAC Field Name: ARRegisterAlias__DueDate</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		public DateOnlyValue? DueDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__DiscDate</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		public DateOnlyValue? CashDiscountDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__DocDesc</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__InvoiceNbr</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceDocType</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringSingleSelectValue? AdjustedDocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceDocType</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringSingleSelectValue? AdjustingDocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceDocType</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringSingleSelectValue? DisplayDocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceRefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? AdjustedRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceRefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? DisplayRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__CustomerID</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryAmt</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Amount Paid</para>
		/// </summary>
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__DocDate</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		public DateOnlyValue? Date { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryBalanceAmt</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDiscBalanceAmt</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Cash Discount Balance</para>
		/// </summary>
		public DecimalValue? CashDiscountBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__CuryID</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__FinPeriodID</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		public StringValue? ApplicationPeriod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__FinPeriodID</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		public StringValue? PostPeriod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARAdjust2__PendingPPD</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		public BooleanValue? AdjustsVAT { get; set; }

		public StringValue? AdjustingRefNbr { get; set; }

		public IntValue? AdjustmentNbr { get; set; }

		public DecimalValue? CashDiscountTaken { get; set; }

		public StringValue? VATCreditMemo { get; set; }

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