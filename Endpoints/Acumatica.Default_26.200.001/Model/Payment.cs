using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR302000</c> in the Acumatica ERP
	/// <para>Key Fields: Type, ReferenceNbr</para>
	/// </summary>
	public class Payment : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: DocType</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>SQL Type: char(3)</para>
		/// Key Field
		/// </summary>
		public StringSingleSelectValue? Type { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// The status of the document.The value of the field is determined by the values of the status flags,such as Hold, Released, Voided, Scheduled.
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AdjDate</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Application Date</para>
		/// </summary>
		public DateOnlyValue? ApplicationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExtRefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Payment Ref.</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		public StringValue? PaymentRef { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Customer</para>
		/// </summary>
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// Identifier of the Location of the Customer.
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		public StringValue? CustomerLocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PaymentMethodID</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Payment Method</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefTranExtNbr</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Orig. Transaction</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? OrigTransaction { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PMInstanceID</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Card/Account Nbr.</para>
		/// </summary>
		public IntValue? CardAccountNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Proc. Center ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ProcessingCenterID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: NewCard</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: New Card</para>
		/// </summary>
		public BooleanValue? IsNewCard { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Save Card</para>
		/// </summary>
		public BooleanValue? SaveCard { get; set; }

		/// <summary>
		/// CC payment state description
		/// <para>DAC Field Name: CCPaymentStateDescr</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Processing Status</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? CCProcessingStatus { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CashAccountID</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		public StringValue? CashAccount { get; set; }

		/// <summary>
		/// The code of the Currency of the document.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Currency</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The description of the document.
		/// <para>DAC Field Name: DocDesc</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>SQL Type: nvarchar(512)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryOrigDocAmt</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Payment Amount</para>
		/// </summary>
		public DecimalValue? PaymentAmount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryApplAmt</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Applied to Documents</para>
		/// </summary>
		public DecimalValue? AppliedToDocuments { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CurySOApplAmt</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Applied to Orders</para>
		/// </summary>
		public DecimalValue? AppliedToOrders { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryUnappliedBal</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Available Balance</para>
		/// </summary>
		public DecimalValue? AvailableBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SampleRecipRate</para>
		/// <para>DAC: {}</para>
		/// </summary>
		public DecimalValue? ReciprocalRate { get; set; }

		/// <summary>
		/// The identifier of the branch to which the document belongs.
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// The identifier of the branch to which the document belongs.
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Branch</para>
		/// </summary>
		public StringValue? BranchID { get; set; }

		public BooleanValue? Hold { get; set; }

		public BooleanValue? IsCCPayment { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? ExternalRef { get; set; }

		public GuidValue? NoteID { get; set; }

		#endregion

		#region Details
		public List<PaymentApplicationHistoryDetail>? ApplicationHistory { get; set; }

		public List<PaymentCharge>? Charges { get; set; }

		public List<CreditCardProcessingDetail>? CreditCardProcessingInfo { get; set; }

		public List<PaymentDetail>? DocumentsToApply { get; set; }

		public List<PaymentOrderDetail>? OrdersToApply { get; set; }

		public List<CreditCardTransactionDetail>? CreditCardTransactionInfo { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(Payment)} - \"{Type}\" - \"{ReferenceNbr}\"";
		}

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
			public const string Translations = "Translations";
			public const string ApplicationHistory = "ApplicationHistory";
			public const string Charges = "Charges";
			public const string CreditCardProcessingInfo = "CreditCardProcessingInfo";
			public const string DocumentsToApply = "DocumentsToApply";
			public const string OrdersToApply = "OrdersToApply";
			public const string CreditCardTransactionInfo = "CreditCardTransactionInfo";

			//Intentionally excluded
			//public const string All = "Files,Translations,ApplicationHistory,Charges,CreditCardProcessingInfo,DocumentsToApply,OrdersToApply,CreditCardTransactionInfo";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}