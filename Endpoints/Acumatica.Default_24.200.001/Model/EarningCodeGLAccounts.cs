using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class EarningCodeGLAccounts : Entity
	{

		/// <summary>
		/// The unique identifier of the expense account to be used by default to record the benefit expense linked with the earning.The field is included in BenefitExpenseAccount.
		/// <para>DAC Field Name: BenefitExpenseAcctID</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Benefit Expense Account</para>
		/// </summary>
		public StringValue? BenefitExpenseAccount { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount to be used with the benefit expense account.The field is included in BenefitExpenseSubaccount.
		/// <para>DAC Field Name: BenefitExpenseSubID</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Benefit Expense Sub.</para>
		/// </summary>
		public StringValue? BenefitExpenseSub { get; set; }

		/// <summary>
		/// The unique identifier of the expense account to be used by default to record the earnings.The field is included in EarningsAccount.
		/// <para>DAC Field Name: EarningsAcctID</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Earnings Account</para>
		/// </summary>
		public StringValue? EarningsAccount { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount to be used with the earnings account.The field is included in EarningsSubaccount.
		/// <para>DAC Field Name: EarningsSubID</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Earnings Sub.</para>
		/// </summary>
		public StringValue? EarningsSub { get; set; }

		/// <summary>
		/// The unique identifier of the expense account to be used by default to record the paid time-off expenses linked with the earning.The field is included in PTOExpenseAccount.
		/// <para>DAC Field Name: PTOExpenseAcctID</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: PTO Expense Account</para>
		/// </summary>
		public StringValue? PTOExpenseAccount { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount to be used with the paid time-off expense account.The field is included in PTOExpenseSubaccount.
		/// <para>DAC Field Name: PTOExpenseSubID</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: PTO Expense Sub.</para>
		/// </summary>
		public StringValue? PTOExpenseSub { get; set; }

		/// <summary>
		/// The unique identifier of the expense account to be used by default to record the tax expenses linked with the earning.The field is included in TaxExpenseAccount.
		/// <para>DAC Field Name: TaxExpenseAcctID</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Tax Expense Account</para>
		/// </summary>
		public StringValue? TaxExpenseAccount { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount to be used with the tax expense account.The field is included in TaxExpenseSubaccount.
		/// <para>DAC Field Name: TaxExpenseSubID</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Tax Expense Sub.</para>
		/// </summary>
		public StringValue? TaxExpenseSub { get; set; }

	}
}