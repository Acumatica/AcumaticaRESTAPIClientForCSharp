using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AR302000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Payment : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: AdjDate 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Application Date 
		/// </summary>
		[DataMember(Name="ApplicationDate", EmitDefaultValue=false)]
		public DateTimeValue? ApplicationDate { get; set; }

		[DataMember(Name="ApplicationHistory", EmitDefaultValue=false)]
		public List<PaymentApplicationHistoryDetail>? ApplicationHistory { get; set; }

		/// <summary>
		/// DAC Field Name: CuryApplAmt 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Applied to Documents 
		/// </summary>
		[DataMember(Name="AppliedToDocuments", EmitDefaultValue=false)]
		public DecimalValue? AppliedToDocuments { get; set; }

		/// <summary>
		/// The identifier of the branch to which the document belongs.
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC Field Name: PMInstanceID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Card/Account Nbr. 
		/// </summary>
		[DataMember(Name="CardAccountNbr", EmitDefaultValue=false)]
		public IntValue? CardAccountNbr { get; set; }

		/// <summary>
		/// DAC Field Name: CashAccountID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Cash Account 
		/// </summary>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		[DataMember(Name="Charges", EmitDefaultValue=false)]
		public List<PaymentCharge>? Charges { get; set; }

		[DataMember(Name="CreditCardProcessingInfo", EmitDefaultValue=false)]
		public List<CreditCardProcessingDetail>? CreditCardProcessingInfo { get; set; }

		/// <summary>
		/// The code of the Currency of the document.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Customer 
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// The description of the document.
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.AR.ARPayment 
		/// SQL Type: nvarchar(512) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DocumentsToApply", EmitDefaultValue=false)]
		public List<PaymentDetail>? DocumentsToApply { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="IsCCPayment", EmitDefaultValue=false)]
		public BooleanValue? IsCCPayment { get; set; }

		[DataMember(Name="OrdersToApply", EmitDefaultValue=false)]
		public List<PaymentOrderDetail>? OrdersToApply { get; set; }

		/// <summary>
		/// DAC Field Name: CuryOrigDocAmt 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Payment Amount 
		/// </summary>
		[DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
		public DecimalValue? PaymentAmount { get; set; }

		/// <summary>
		/// DAC Field Name: PaymentMethodID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Payment Method 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Payment Ref. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// The status of the document.The value of the field is determined by the values of the status flags,such as Hold, Released, Voided, Scheduled.
		/// DAC: PX.Objects.AR.ARPayment 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: DocType 
		/// DAC: PX.Objects.AR.ARPayment 
		/// SQL Type: char(3) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Proc. Center ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ProcessingCenterID", EmitDefaultValue=false)]
		public StringValue? ProcessingCenterID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Save Card 
		/// </summary>
		[DataMember(Name="SaveCard", EmitDefaultValue=false)]
		public BooleanValue? SaveCard { get; set; }

		[DataMember(Name="CreditCardTransactionInfo", EmitDefaultValue=false)]
		public List<CreditCardTransactionDetail>? CreditCardTransactionInfo { get; set; }

		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue? ExternalRef { get; set; }

		/// <summary>
		/// DAC Field Name: RefTranExtNbr 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Orig. Transaction 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="OrigTransaction", EmitDefaultValue=false)]
		public StringValue? OrigTransaction { get; set; }

		/// <summary>
		/// The identifier of the branch to which the document belongs.
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Branch 
		/// </summary>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// Identifier of the Location of the Customer.
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Location 
		/// </summary>
		[DataMember(Name="CustomerLocationID", EmitDefaultValue=false)]
		public StringValue? CustomerLocationID { get; set; }

		/// <summary>
		/// DAC Field Name: NewCard 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: New Card 
		/// </summary>
		[DataMember(Name="IsNewCard", EmitDefaultValue=false)]
		public BooleanValue? IsNewCard { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// DAC Field Name: CuryUnappliedBal 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Available Balance 
		/// </summary>
		[DataMember(Name="AvailableBalance", EmitDefaultValue=false)]
		public DecimalValue? AvailableBalance { get; set; }

		/// <summary>
		/// DAC Field Name: CurySOApplAmt 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Applied to Orders 
		/// </summary>
		[DataMember(Name="AppliedToOrders", EmitDefaultValue=false)]
		public DecimalValue? AppliedToOrders { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}