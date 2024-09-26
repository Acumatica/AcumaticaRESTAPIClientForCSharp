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
		/// 
		/// Display Name:
		/// DAC Field Name: AdjDate 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ApplicationDate", EmitDefaultValue=false)]
		public DateTimeValue? ApplicationDate { get; set; }

		[DataMember(Name="ApplicationHistory", EmitDefaultValue=false)]
		public List<PaymentApplicationHistoryDetail>? ApplicationHistory { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryApplAmt 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AppliedToDocuments", EmitDefaultValue=false)]
		public DecimalValue? AppliedToDocuments { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PMInstanceID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CardAccountNbr", EmitDefaultValue=false)]
		public IntValue? CardAccountNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CashAccountID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CashAccount", EmitDefaultValue=false)]
		public StringValue? CashAccount { get; set; }

		[DataMember(Name="Charges", EmitDefaultValue=false)]
		public List<PaymentCharge>? Charges { get; set; }

		[DataMember(Name="CreditCardProcessingInfo", EmitDefaultValue=false)]
		public List<CreditCardProcessingDetail>? CreditCardProcessingInfo { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DocDesc 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
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
		/// 
		/// Display Name:
		/// DAC Field Name: CuryOrigDocAmt 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentAmount", EmitDefaultValue=false)]
		public DecimalValue? PaymentAmount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PaymentMethodID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PaymentRef", EmitDefaultValue=false)]
		public StringValue? PaymentRef { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DocType 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProcessingCenterID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProcessingCenterID", EmitDefaultValue=false)]
		public StringValue? ProcessingCenterID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SaveCard 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SaveCard", EmitDefaultValue=false)]
		public BooleanValue? SaveCard { get; set; }

		[DataMember(Name="CreditCardTransactionInfo", EmitDefaultValue=false)]
		public List<CreditCardTransactionDetail>? CreditCardTransactionInfo { get; set; }

		[DataMember(Name="ExternalRef", EmitDefaultValue=false)]
		public StringValue? ExternalRef { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefTranExtNbr 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrigTransaction", EmitDefaultValue=false)]
		public StringValue? OrigTransaction { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BranchID", EmitDefaultValue=false)]
		public StringValue? BranchID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerLocationID 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CustomerLocationID", EmitDefaultValue=false)]
		public StringValue? CustomerLocationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NewCard 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IsNewCard", EmitDefaultValue=false)]
		public BooleanValue? IsNewCard { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryUnappliedBal 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AvailableBalance", EmitDefaultValue=false)]
		public DecimalValue? AvailableBalance { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CurySOApplAmt 
		/// DAC: PX.Objects.AR.ARPayment 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AppliedToOrders", EmitDefaultValue=false)]
		public DecimalValue? AppliedToOrders { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}