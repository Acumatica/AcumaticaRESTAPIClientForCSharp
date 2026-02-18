using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class DeductionOrBenefitCodeGLAccounts : Entity
	{

		/// <summary>
		/// The unique identifier of the expense account to be used by default to record the benefit to employee paycheck.The field is included in BenefitExpenseAccount.
		/// <para>DAC Field Name: BenefitExpenseAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Benefit Expense Account</para>
		/// </summary>
		public StringValue? BenefitExpenseAccount { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount used with the benefit expense account.The field is included in BenefitExpenseSubaccount.
		/// <para>DAC Field Name: BenefitExpenseSubID</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Benefit Expense Sub.</para>
		/// </summary>
		public StringValue? BenefitExpenseSub { get; set; }

		/// <summary>
		/// The unique identifier of the liability account to be used by default to off-set the benefit expense account.The field is included in BenefitLiabilityAccount.
		/// <para>DAC Field Name: BenefitLiabilityAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Benefit Liability Account</para>
		/// </summary>
		public StringValue? BenefitLiabilityAccount { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount used with the benefit liability account.The field is included in BenefitLiabilitySubaccount.
		/// <para>DAC Field Name: BenefitLiabilitySubID</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Benefit Liability Sub.</para>
		/// </summary>
		public StringValue? BenefitLiabilitySub { get; set; }

		/// <summary>
		/// The unique identifier of the liability account used by default to record the deduction from employee paycheck.The field is included in DeductionLiabilityAccount.
		/// <para>DAC Field Name: DedLiabilityAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Deduction Liability Account</para>
		/// </summary>
		public StringValue? DeductionLiabilityAccount { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount used with the deduction liability account.The field is included in DeductionLiabilitySubaccount.
		/// <para>DAC Field Name: DedLiabilitySubID</para>
		/// <para>DAC: PX.Objects.PR.PRDeductCode</para>
		/// <para>Display Name: Deduction Liability Sub.</para>
		/// </summary>
		public StringValue? DeductionLiabilitySub { get; set; }

	}
}