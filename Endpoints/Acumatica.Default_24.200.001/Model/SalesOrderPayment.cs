using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class SalesOrderPayment : Entity
	{

		public DateTimeValue? ApplicationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryAdjdAmt</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// </summary>
		public DecimalValue? AppliedToOrder { get; set; }

		public BooleanValue? Authorize { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDocBal</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// </summary>
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// The identifier of the default card or account number forthe payment method (for payment methods that require card or account numbers).The field is included in the CustomerPaymentMethod foreign key.
		/// <para>DAC Field Name: PMInstanceID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Card/Account Nbr.</para>
		/// </summary>
		/// <remarks>
		/// If the customer has more than one card or account number, a user can select one from the list of cardsor accounts available for the customer.
		/// </remarks>
		public StringValue? CardAccountNbr { get; set; }

		public BooleanValue? Capture { get; set; }

		/// <summary>
		/// The identifier of the cash account associated with the customer payment method.The field is included in the CashAccount foreign key.
		/// <para>DAC Field Name: CashAccountID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARPayment__CuryID</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// </summary>
		public StringValue? Currency { get; set; }

		public List<SalesOrderCreditCardTransactionDetail>? CreditCardTransactionInfo { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.SO.SOQuickPayment</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjgDocType</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// <para>Display Name: Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		public StringValue? DocType { get; set; }

		public BooleanValue? Hold { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefTranExtNbr</para>
		/// <para>DAC: PX.Objects.SO.SOQuickPayment</para>
		/// <para>Display Name: Orig. Transaction</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? OrigTransactionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryOrigDocAmt</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// <para>Display Name: Payment Amount</para>
		/// </summary>
		public DecimalValue? PaymentAmount { get; set; }

		/// <summary>
		/// The identifier of the payment method to be used to pay for the salesorder. The field is included in the PaymentMethod foreign key.
		/// <para>DAC Field Name: PaymentMethodID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Payment Method</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// The reference number of the payment.
		/// <para>DAC Field Name: ExtRefNbr</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Payment Ref.</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		/// <remarks>
		/// This field is available only for sales orders of the Cash Sales or Cash Return type.
		/// </remarks>
		public StringValue? PaymentRef { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Processing Center</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ProcessingCenterID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjgRefNbr</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		public BooleanValue? Refund { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOQuickPayment</para>
		/// <para>Display Name: Save Card</para>
		/// </summary>
		public BooleanValue? SaveCard { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARPayment__Status</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryAdjdBilledAmt</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// <para>Display Name: Transferred to Invoice</para>
		/// </summary>
		public DecimalValue? TransferredtoInvoice { get; set; }

		public BooleanValue? ValidateCCRefundOrigTransaction { get; set; }

		public StringValue? ExternalRef { get; set; }

		public GuidValue? NoteID { get; set; }

	}
}