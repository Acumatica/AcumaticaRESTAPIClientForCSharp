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
	public class PTOBankGLAccounts : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: PTOAssetAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Asset Account</para>
		/// </summary>
		[DataMember(Name="AssetAccount", EmitDefaultValue=false)]
		public StringValue? AssetAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOAssetSubID</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Asset Sub.</para>
		/// </summary>
		[DataMember(Name="AssetSub", EmitDefaultValue=false)]
		public StringValue? AssetSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOExpenseAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Expense Account</para>
		/// </summary>
		[DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
		public StringValue? ExpenseAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOExpenseSubID</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Expense Sub.</para>
		/// </summary>
		[DataMember(Name="ExpenseSub", EmitDefaultValue=false)]
		public StringValue? ExpenseSub { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOLiabilityAcctID</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Liability Account</para>
		/// </summary>
		[DataMember(Name="LiabilityAccount", EmitDefaultValue=false)]
		public StringValue? LiabilityAccount { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PTOLiabilitySubID</para>
		/// <para>DAC: PX.Objects.PR.PRPTOBank</para>
		/// <para>Display Name: Liability Sub.</para>
		/// </summary>
		[DataMember(Name="LiabilitySub", EmitDefaultValue=false)]
		public StringValue? LiabilitySub { get; set; }

	}
}