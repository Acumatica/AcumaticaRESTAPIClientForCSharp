using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class AccountSummaryRow : Entity
	{

		/// <summary>
		/// DAC Field Name: AccountCD 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// DAC Field Name: AccountClassID 
		/// DAC: PX.Objects.GL.GLHistoryEnqFilter 
		/// Display Name: Account Class 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="AccountClass", EmitDefaultValue=false)]
		public StringValue? AccountClass { get; set; }

		/// <summary>
		/// DAC Field Name: SignBegBalance 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// Display Name: Beg. Balance 
		/// </summary>
		[DataMember(Name="BeginningBalance", EmitDefaultValue=false)]
		public DecimalValue? BeginningBalance { get; set; }

		/// <summary>
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// Key Field
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC Field Name: ConsolAccountCD 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// Display Name: Consolidation Account 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="ConsolidationAccount", EmitDefaultValue=false)]
		public StringValue? ConsolidationAccount { get; set; }

		/// <summary>
		/// DAC Field Name: PtdCreditTotal 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// Display Name: Credit Total 
		/// </summary>
		[DataMember(Name="CreditTotal", EmitDefaultValue=false)]
		public DecimalValue? CreditTotal { get; set; }

		/// <summary>
		/// DAC Field Name: SignCuryBegBalance 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// Display Name: Curr. Beg. Balance 
		/// </summary>
		[DataMember(Name="CurrencyBeginningBalance", EmitDefaultValue=false)]
		public DecimalValue? CurrencyBeginningBalance { get; set; }

		/// <summary>
		/// DAC Field Name: CuryPtdCreditTotal 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// Display Name: Curr. Credit Total 
		/// </summary>
		[DataMember(Name="CurrencyCreditTotal", EmitDefaultValue=false)]
		public DecimalValue? CurrencyCreditTotal { get; set; }

		/// <summary>
		/// DAC Field Name: CuryPtdDebitTotal 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// Display Name: Curr. Debit Total 
		/// </summary>
		[DataMember(Name="CurrencyDebitTotal", EmitDefaultValue=false)]
		public DecimalValue? CurrencyDebitTotal { get; set; }

		/// <summary>
		/// DAC Field Name: SignCuryEndBalance 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// Display Name: Curr. Ending Balance 
		/// </summary>
		[DataMember(Name="CurrencyEndingBalance", EmitDefaultValue=false)]
		public DecimalValue? CurrencyEndingBalance { get; set; }

		/// <summary>
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// Display Name: Currency ID 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: CuryPtdSaldo 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// Display Name: Cury. Ptd. Total 
		/// </summary>
		[DataMember(Name="CurrencyPtdTotal", EmitDefaultValue=false)]
		public DecimalValue? CurrencyPtdTotal { get; set; }

		/// <summary>
		/// DAC Field Name: PtdDebitTotal 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// Display Name: Debit Total 
		/// </summary>
		[DataMember(Name="DebitTotal", EmitDefaultValue=false)]
		public DecimalValue? DebitTotal { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: SignEndBalance 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// Display Name: Ending Balance 
		/// </summary>
		[DataMember(Name="EndingBalance", EmitDefaultValue=false)]
		public DecimalValue? EndingBalance { get; set; }

		/// <summary>
		/// DAC Field Name: LastActivityPeriod 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// Display Name: Last Activity 
		/// SQL Type: char(6) 
		/// Key Field
		/// </summary>
		[DataMember(Name="LastActivity", EmitDefaultValue=false)]
		public StringValue? LastActivity { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLHistoryEnqFilter 
		/// Display Name: Ledger 
		/// </summary>
		[DataMember(Name="LedgerID", EmitDefaultValue=false)]
		public IntValue? LedgerID { get; set; }

		/// <summary>
		/// DAC Field Name: PtdSaldo 
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// Display Name: Ptd. Total 
		/// </summary>
		[DataMember(Name="PtdTotal", EmitDefaultValue=false)]
		public DecimalValue? PtdTotal { get; set; }

		/// <summary>
		/// DAC Field Name: SubCD 
		/// DAC: PX.Objects.GL.GLHistoryEnqFilter 
		/// SQL Type: varchar(30) 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLHistoryEnquiryResult 
		/// SQL Type: varchar(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}