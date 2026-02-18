using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class PTOBankGLAccounts : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: PTOAssetAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Asset Account</para>
		/// </summary>
		public StringValue? AssetAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOAssetSubID</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Asset Sub.</para>
		/// </summary>
		public StringValue? AssetSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOExpenseAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Expense Account</para>
		/// </summary>
		public StringValue? ExpenseAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOExpenseSubID</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Expense Sub.</para>
		/// </summary>
		public StringValue? ExpenseSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOLiabilityAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Liability Account</para>
		/// </summary>
		public StringValue? LiabilityAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOLiabilitySubID</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Liability Sub.</para>
		/// </summary>
		public StringValue? LiabilitySub { get; set; }

	}
}