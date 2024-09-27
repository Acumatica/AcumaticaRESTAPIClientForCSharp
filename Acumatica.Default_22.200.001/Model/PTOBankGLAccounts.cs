using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class PTOBankGLAccounts : Entity
	{

		/// <summary>
		/// DAC Field Name: PTOAssetAcctID 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Asset Account 
		/// </summary>
		[DataMember(Name="AssetAccount", EmitDefaultValue=false)]
		public StringValue? AssetAccount { get; set; }

		/// <summary>
		/// DAC Field Name: PTOAssetSubID 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Asset Sub. 
		/// </summary>
		[DataMember(Name="AssetSub", EmitDefaultValue=false)]
		public StringValue? AssetSub { get; set; }

		/// <summary>
		/// DAC Field Name: PTOExpenseAcctID 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Expense Account 
		/// </summary>
		[DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
		public StringValue? ExpenseAccount { get; set; }

		/// <summary>
		/// DAC Field Name: PTOExpenseSubID 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Expense Sub. 
		/// </summary>
		[DataMember(Name="ExpenseSub", EmitDefaultValue=false)]
		public StringValue? ExpenseSub { get; set; }

		/// <summary>
		/// DAC Field Name: PTOLiabilityAcctID 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Liability Account 
		/// </summary>
		[DataMember(Name="LiabilityAccount", EmitDefaultValue=false)]
		public StringValue? LiabilityAccount { get; set; }

		/// <summary>
		/// DAC Field Name: PTOLiabilitySubID 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// Display Name: Liability Sub. 
		/// </summary>
		[DataMember(Name="LiabilitySub", EmitDefaultValue=false)]
		public StringValue? LiabilitySub { get; set; }

	}
}