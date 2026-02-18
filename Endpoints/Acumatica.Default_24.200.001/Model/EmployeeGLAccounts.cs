using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class EmployeeGLAccounts : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: BenefitExpenseAcctID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Benefit Expense Account</para>
		/// </summary>
		public StringValue? BenefitExpenseAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BenefitExpenseSubID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Benefit Expense Sub.</para>
		/// </summary>
		public StringValue? BenefitExpenseSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BenefitLiabilityAcctID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Benefit Liability Account</para>
		/// </summary>
		public StringValue? BenefitLiabilityAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BenefitLiabilitySubID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Benefit Liability Sub.</para>
		/// </summary>
		public StringValue? BenefitLiabilitySub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DedLiabilityAcctID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Deduction Liability Account</para>
		/// </summary>
		public StringValue? DeductionLiabilityAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DedLiabilitySubID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Deduction Liability Sub.</para>
		/// </summary>
		public StringValue? DeductionLiabilitySub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EarningsAcctID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Earnings Account</para>
		/// </summary>
		public StringValue? EarningsAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EarningsSubID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Earnings Sub.</para>
		/// </summary>
		public StringValue? EarningsSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOAssetAcctID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: PTO Asset Account</para>
		/// </summary>
		public StringValue? PTOAssetAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOAssetSubID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: PTO Asset Sub.</para>
		/// </summary>
		public StringValue? PTOAssetSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOExpenseAcctID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: PTO Expense Account</para>
		/// </summary>
		public StringValue? PTOExpenseAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOExpenseSubID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: PTO Expense Sub.</para>
		/// </summary>
		public StringValue? PTOExpenseSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOLiabilityAcctID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: PTO Liability Account</para>
		/// </summary>
		public StringValue? PTOLiabilityAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOLiabilitySubID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: PTO Liability Sub.</para>
		/// </summary>
		public StringValue? PTOLiabilitySub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PayrollTaxExpenseAcctID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Tax Expense Account</para>
		/// </summary>
		public StringValue? TaxExpenseAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PayrollTaxExpenseSubID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Tax Expense Sub.</para>
		/// </summary>
		public StringValue? TaxExpenseSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PayrollTaxLiabilityAcctID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Tax Liability Account</para>
		/// </summary>
		public StringValue? TaxLiabilityAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PayrollTaxLiabilitySubID</para>
		/// <para>DAC: PX.Objects.PR.PREmployee</para>
		/// <para>Display Name: Tax Liability Sub.</para>
		/// </summary>
		public StringValue? TaxLiabilitySub { get; set; }

	}
}