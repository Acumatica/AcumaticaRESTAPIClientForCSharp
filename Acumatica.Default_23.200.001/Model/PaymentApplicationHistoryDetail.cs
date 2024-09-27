using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class PaymentApplicationHistoryDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: SourceDocType 
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// Display Name: Source Doc. Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="AdjustedDocType", EmitDefaultValue=false)]
		public StringValue? AdjustedDocType { get; set; }

		/// <summary>
		/// DAC Field Name: SourceRefNbr 
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// Display Name: Source Ref. Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="AdjustedRefNbr", EmitDefaultValue=false)]
		public StringValue? AdjustedRefNbr { get; set; }

		/// <summary>
		/// DAC Field Name: SourceDocType 
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// Display Name: Source Doc. Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="AdjustingDocType", EmitDefaultValue=false)]
		public StringValue? AdjustingDocType { get; set; }

		[DataMember(Name="AdjustingRefNbr", EmitDefaultValue=false)]
		public StringValue? AdjustingRefNbr { get; set; }

		[DataMember(Name="AdjustmentNbr", EmitDefaultValue=false)]
		public IntValue? AdjustmentNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ARAdjust2__PendingPPD 
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// </summary>
		[DataMember(Name="AdjustsVAT", EmitDefaultValue=false)]
		public BooleanValue? AdjustsVAT { get; set; }

		/// <summary>
		/// DAC Field Name: CuryAmt 
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// Display Name: Amount 
		/// </summary>
		[DataMember(Name="AmountPaid", EmitDefaultValue=false)]
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// DAC Field Name: ARRegisterAlias__FinPeriodID 
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// </summary>
		[DataMember(Name="ApplicationPeriod", EmitDefaultValue=false)]
		public StringValue? ApplicationPeriod { get; set; }

		/// <summary>
		/// DAC Field Name: CuryBalanceAmt 
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// DAC Field Name: CuryWOAmt 
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Write-Off Amount 
		/// </summary>
		[DataMember(Name="BalanceWriteOff", EmitDefaultValue=false)]
		public DecimalValue? BalanceWriteOff { get; set; }

		/// <summary>
		/// The number of the Batch created from the document on release.
		/// DAC: PX.Objects.AR.ARPayment 
		/// Display Name: Batch Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// DAC Field Name: CuryDiscBalanceAmt 
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// Display Name: Cash Discount Balance 
		/// </summary>
		[DataMember(Name="CashDiscountBalance", EmitDefaultValue=false)]
		public DecimalValue? CashDiscountBalance { get; set; }

		/// <summary>
		/// DAC Field Name: ARInvoice__DiscDate 
		/// DAC: PX.Objects.AR.ARAdjust 
		/// </summary>
		[DataMember(Name="CashDiscountDate", EmitDefaultValue=false)]
		public DateTimeValue? CashDiscountDate { get; set; }

		[DataMember(Name="CashDiscountTaken", EmitDefaultValue=false)]
		public DecimalValue? CashDiscountTaken { get; set; }

		/// <summary>
		/// DAC Field Name: ARRegisterAlias__CuryID 
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: ARRegisterAlias__CustomerID 
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// DAC Field Name: ARInvoice__InvoiceNbr 
		/// DAC: PX.Objects.AR.ARAdjust 
		/// </summary>
		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// DAC Field Name: ARRegisterAlias__DocDate 
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// DAC Field Name: ARRegisterAlias__DocDesc 
		/// DAC: PX.Objects.AR.ARAdjust 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: SourceDocType 
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// Display Name: Source Doc. Type 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="DisplayDocType", EmitDefaultValue=false)]
		public StringValue? DisplayDocType { get; set; }

		/// <summary>
		/// DAC Field Name: SourceRefNbr 
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// Display Name: Source Ref. Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="DisplayRefNbr", EmitDefaultValue=false)]
		public StringValue? DisplayRefNbr { get; set; }

		/// <summary>
		/// DAC Field Name: ARRegisterAlias__DueDate 
		/// DAC: PX.Objects.AR.ARAdjust 
		/// </summary>
		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue? DueDate { get; set; }

		/// <summary>
		/// DAC Field Name: ARRegisterAlias__FinPeriodID 
		/// DAC: PX.Objects.AR.ARTranPostBal 
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		[DataMember(Name="VATCreditMemo", EmitDefaultValue=false)]
		public StringValue? VATCreditMemo { get; set; }

	}
}