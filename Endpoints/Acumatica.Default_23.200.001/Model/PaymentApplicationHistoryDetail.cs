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
		/// <para>DAC Field Name: SourceDocType</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Source Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="AdjustedDocType", EmitDefaultValue=false)]
		public StringValue? AdjustedDocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceRefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Source Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="AdjustedRefNbr", EmitDefaultValue=false)]
		public StringValue? AdjustedRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceDocType</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Source Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="AdjustingDocType", EmitDefaultValue=false)]
		public StringValue? AdjustingDocType { get; set; }

		[DataMember(Name="AdjustingRefNbr", EmitDefaultValue=false)]
		public StringValue? AdjustingRefNbr { get; set; }

		[DataMember(Name="AdjustmentNbr", EmitDefaultValue=false)]
		public IntValue? AdjustmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARAdjust2__PendingPPD</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		[DataMember(Name="AdjustsVAT", EmitDefaultValue=false)]
		public BooleanValue? AdjustsVAT { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryAmt</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Amount</para>
		/// </summary>
		[DataMember(Name="AmountPaid", EmitDefaultValue=false)]
		public DecimalValue? AmountPaid { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__FinPeriodID</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		[DataMember(Name="ApplicationPeriod", EmitDefaultValue=false)]
		public StringValue? ApplicationPeriod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryBalanceAmt</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		[DataMember(Name="Balance", EmitDefaultValue=false)]
		public DecimalValue? Balance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryWOAmt</para>
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Write-Off Amount</para>
		/// </summary>
		[DataMember(Name="BalanceWriteOff", EmitDefaultValue=false)]
		public DecimalValue? BalanceWriteOff { get; set; }

		/// <summary>
		/// The number of the Batch created from the document on release.
		/// <para>DAC: PX.Objects.AR.ARPayment</para>
		/// <para>Display Name: Batch Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryDiscBalanceAmt</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Cash Discount Balance</para>
		/// </summary>
		[DataMember(Name="CashDiscountBalance", EmitDefaultValue=false)]
		public DecimalValue? CashDiscountBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__DiscDate</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		[DataMember(Name="CashDiscountDate", EmitDefaultValue=false)]
		public DateTimeValue? CashDiscountDate { get; set; }

		[DataMember(Name="CashDiscountTaken", EmitDefaultValue=false)]
		public DecimalValue? CashDiscountTaken { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__CuryID</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__CustomerID</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARInvoice__InvoiceNbr</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		[DataMember(Name="CustomerOrder", EmitDefaultValue=false)]
		public StringValue? CustomerOrder { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__DocDate</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		[DataMember(Name="Date", EmitDefaultValue=false)]
		public DateTimeValue? Date { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__DocDesc</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceDocType</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Source Doc. Type</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		[DataMember(Name="DisplayDocType", EmitDefaultValue=false)]
		public StringValue? DisplayDocType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SourceRefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// <para>Display Name: Source Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="DisplayRefNbr", EmitDefaultValue=false)]
		public StringValue? DisplayRefNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__DueDate</para>
		/// <para>DAC: PX.Objects.AR.ARAdjust</para>
		/// </summary>
		[DataMember(Name="DueDate", EmitDefaultValue=false)]
		public DateTimeValue? DueDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ARRegisterAlias__FinPeriodID</para>
		/// <para>DAC: PX.Objects.AR.ARTranPostBal</para>
		/// </summary>
		[DataMember(Name="PostPeriod", EmitDefaultValue=false)]
		public StringValue? PostPeriod { get; set; }

		[DataMember(Name="VATCreditMemo", EmitDefaultValue=false)]
		public StringValue? VATCreditMemo { get; set; }

	}
}