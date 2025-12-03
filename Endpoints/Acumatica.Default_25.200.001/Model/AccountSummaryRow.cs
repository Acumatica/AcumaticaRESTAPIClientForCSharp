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
	public class AccountSummaryRow : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: AccountCD</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AccountClassID</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnqFilter</para>
		/// <para>Display Name: Account Class</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		[DataMember(Name="AccountClass", EmitDefaultValue=false)]
		public StringValue? AccountClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SignBegBalance</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>Display Name: Beg. Balance</para>
		/// </summary>
		[DataMember(Name="BeginningBalance", EmitDefaultValue=false)]
		public DecimalValue? BeginningBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ConsolAccountCD</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>Display Name: Consolidation Account</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="ConsolidationAccount", EmitDefaultValue=false)]
		public StringValue? ConsolidationAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PtdCreditTotal</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>Display Name: Credit Total</para>
		/// </summary>
		[DataMember(Name="CreditTotal", EmitDefaultValue=false)]
		public DecimalValue? CreditTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SignCuryBegBalance</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>Display Name: Curr. Beg. Balance</para>
		/// </summary>
		[DataMember(Name="CurrencyBeginningBalance", EmitDefaultValue=false)]
		public DecimalValue? CurrencyBeginningBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryPtdCreditTotal</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>Display Name: Curr. Credit Total</para>
		/// </summary>
		[DataMember(Name="CurrencyCreditTotal", EmitDefaultValue=false)]
		public DecimalValue? CurrencyCreditTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryPtdDebitTotal</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>Display Name: Curr. Debit Total</para>
		/// </summary>
		[DataMember(Name="CurrencyDebitTotal", EmitDefaultValue=false)]
		public DecimalValue? CurrencyDebitTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SignCuryEndBalance</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>Display Name: Curr. Ending Balance</para>
		/// </summary>
		[DataMember(Name="CurrencyEndingBalance", EmitDefaultValue=false)]
		public DecimalValue? CurrencyEndingBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>Display Name: Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryPtdSaldo</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>Display Name: Cury. Ptd. Total</para>
		/// </summary>
		[DataMember(Name="CurrencyPtdTotal", EmitDefaultValue=false)]
		public DecimalValue? CurrencyPtdTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PtdDebitTotal</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>Display Name: Debit Total</para>
		/// </summary>
		[DataMember(Name="DebitTotal", EmitDefaultValue=false)]
		public DecimalValue? DebitTotal { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SignEndBalance</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>Display Name: Ending Balance</para>
		/// </summary>
		[DataMember(Name="EndingBalance", EmitDefaultValue=false)]
		public DecimalValue? EndingBalance { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastActivityPeriod</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>Display Name: Last Activity</para>
		/// <para>SQL Type: char(6)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LastActivity", EmitDefaultValue=false)]
		public StringValue? LastActivity { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnqFilter</para>
		/// <para>Display Name: Ledger</para>
		/// </summary>
		[DataMember(Name="LedgerID", EmitDefaultValue=false)]
		public IntValue? LedgerID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PtdSaldo</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>Display Name: Ptd. Total</para>
		/// </summary>
		[DataMember(Name="PtdTotal", EmitDefaultValue=false)]
		public DecimalValue? PtdTotal { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubCD</para>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnqFilter</para>
		/// <para>SQL Type: varchar(30)</para>
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.GL.GLHistoryEnquiryResult</para>
		/// <para>SQL Type: varchar(1)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}