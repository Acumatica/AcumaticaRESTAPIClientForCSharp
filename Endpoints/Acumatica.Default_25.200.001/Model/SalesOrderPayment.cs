using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class SalesOrderPayment : Entity
	{

		[DataMember(Name="ApplicationDate", EmitDefaultValue=false)]
		public DateTimeValue? ApplicationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryAdjdAmt</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// </summary>
		[DataMember(Name="AppliedToOrder", EmitDefaultValue=false)]
		public DecimalValue? AppliedToOrder { get; set; }

		[DataMember(Name="Authorize", EmitDefaultValue=false)]
		public BooleanValue? Authorize { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDocBal</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
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
		[DataMember(Name="CardAccountNbr", EmitDefaultValue=false)]
		public StringValue? CardAccountNbr { get; set; }

		[DataMember(Name="Capture", EmitDefaultValue=false)]
		public BooleanValue? Capture { get; set; }

		/// <summary>
		/// The identifier of the cash account associated with the customer payment method.The field is included in the CashAccount foreign key.
		/// <para>DAC Field Name: CashAccountID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARPayment__CuryID</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// </summary>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		[DataMember(Name="CreditCardTransactionInfo", EmitDefaultValue=false)]
		public List<SalesOrderCreditCardTransactionDetail>? CreditCardTransactionInfo { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.SO.SOQuickPayment</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjgDocType</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// <para>Display Name: Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefTranExtNbr</para>
		/// <para>DAC: PX.Objects.SO.SOQuickPayment</para>
		/// <para>Display Name: Orig. Transaction</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="OrigTransactionNbr", EmitDefaultValue=false)]
		public StringValue? OrigTransactionNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryOrigDocAmt</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// <para>Display Name: Payment Amount</para>
		/// </summary>
		[DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
		public DecimalValue? PaymentAmount { get; set; }

		/// <summary>
		/// The identifier of the payment method to be used to pay for the salesorder. The field is included in the PaymentMethod foreign key.
		/// <para>DAC Field Name: PaymentMethodID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Payment Method</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
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
		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Processing Center</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ProcessingCenterID", EmitDefaultValue=false)]
		public StringValue? ProcessingCenterID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjgRefNbr</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="Refund", EmitDefaultValue=false)]
		public BooleanValue? Refund { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.SO.SOQuickPayment</para>
		/// <para>Display Name: Save Card</para>
		/// </summary>
		[DataMember(Name="SaveCard", EmitDefaultValue=false)]
		public BooleanValue? SaveCard { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARPayment__Status</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryAdjdBilledAmt</para>
		/// <para>DAC: PX.Objects.SO.SOAdjust</para>
		/// <para>Display Name: Transferred to Invoice</para>
		/// </summary>
		[DataMember(Name="TransferredtoInvoice", EmitDefaultValue=false)]
		public DecimalValue? TransferredtoInvoice { get; set; }

		[DataMember(Name="ValidateCCRefundOrigTransaction", EmitDefaultValue=false)]
		public BooleanValue? ValidateCCRefundOrigTransaction { get; set; }

		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue? ExternalRef { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

	}
}