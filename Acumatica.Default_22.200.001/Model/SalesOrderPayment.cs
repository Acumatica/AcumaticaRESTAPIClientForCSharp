using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class SalesOrderPayment : Entity
	{

		[DataMember(Name="ApplicationDate", EmitDefaultValue=false)]
		public DateTimeValue? ApplicationDate { get; set; }

		/// <summary>
		/// DAC Field Name: CuryAdjdAmt 
		/// DAC: PX.Objects.SO.SOAdjust 
		/// </summary>
		[DataMember(Name="AppliedToOrder", EmitDefaultValue=false)]
		public DecimalValue? AppliedToOrder { get; set; }

		[DataMember(Name="Authorize", EmitDefaultValue=false)]
		public BooleanValue? Authorize { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDocBal 
		/// DAC: PX.Objects.SO.SOAdjust 
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// The identifier of the default card or account number forthe payment method (for payment methods that require card or account numbers).The field is included in the CustomerPaymentMethod foreign key.
		/// DAC Field Name: PMInstanceID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Card/Account Nbr. 
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
		/// DAC Field Name: CashAccountID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Cash Account 
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// DAC Field Name: ARPayment__CuryID 
		/// DAC: PX.Objects.SO.SOAdjust 
		/// </summary>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		[DataMember(Name="CreditCardTransactionInfo", EmitDefaultValue=false)]
		public List<SalesOrderCreditCardTransactionDetail>? CreditCardTransactionInfo { get; set; }

		/// <summary>
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.SO.SOQuickPayment 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: AdjgDocType 
		/// DAC: PX.Objects.SO.SOAdjust 
		/// Display Name: Doc. Type 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: RefTranExtNbr 
		/// DAC: PX.Objects.SO.SOQuickPayment 
		/// Display Name: Orig. Transaction 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="OrigTransactionNbr", EmitDefaultValue=false)]
		public StringValue? OrigTransactionNbr { get; set; }

		/// <summary>
		/// DAC Field Name: CuryOrigDocAmt 
		/// DAC: PX.Objects.SO.SOAdjust 
		/// Display Name: Payment Amount 
		/// </summary>
		[DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
		public DecimalValue? PaymentAmount { get; set; }

		/// <summary>
		/// The identifier of the payment method to be used to pay for the salesorder. The field is included in the PaymentMethod foreign key.
		/// DAC Field Name: PaymentMethodID 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Payment Method 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// The reference number of the payment.
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Payment Ref. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		/// <remarks>
		/// This field is available only for sales orders of the Cash Sales or Cash Return type.
		/// </remarks>
		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOOrder 
		/// Display Name: Processing Center 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ProcessingCenterID", EmitDefaultValue=false)]
		public StringValue? ProcessingCenterID { get; set; }

		/// <summary>
		/// DAC Field Name: AdjgRefNbr 
		/// DAC: PX.Objects.SO.SOAdjust 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="Refund", EmitDefaultValue=false)]
		public BooleanValue? Refund { get; set; }

		/// <summary>
		/// DAC: PX.Objects.SO.SOQuickPayment 
		/// Display Name: Save Card 
		/// </summary>
		[DataMember(Name="SaveCard", EmitDefaultValue=false)]
		public BooleanValue? SaveCard { get; set; }

		/// <summary>
		/// DAC Field Name: ARPayment__Status 
		/// DAC: PX.Objects.SO.SOAdjust 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: CuryAdjdBilledAmt 
		/// DAC: PX.Objects.SO.SOAdjust 
		/// Display Name: Transferred to Invoice 
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