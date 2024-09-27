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
	public class DeductionOrBenefitCodeGLAccounts : Entity
	{

		/// <summary>
		/// The unique identifier of the expense account to be used by default to record the benefit to employee paycheck.The field is included in BenefitExpenseAccount.
		/// DAC Field Name: BenefitExpenseAcctID 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Benefit Expense Account 
		/// </summary>
		[DataMember(Name="BenefitExpenseAccount", EmitDefaultValue=false)]
		public StringValue? BenefitExpenseAccount { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount used with the benefit expense account.The field is included in BenefitExpenseSubaccount.
		/// DAC Field Name: BenefitExpenseSubID 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Benefit Expense Sub. 
		/// </summary>
		[DataMember(Name="BenefitExpenseSub", EmitDefaultValue=false)]
		public StringValue? BenefitExpenseSub { get; set; }

		/// <summary>
		/// The unique identifier of the liability account to be used by default to off-set the benefit expense account.The field is included in BenefitLiabilityAccount.
		/// DAC Field Name: BenefitLiabilityAcctID 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Benefit Liability Account 
		/// </summary>
		[DataMember(Name="BenefitLiabilityAccount", EmitDefaultValue=false)]
		public StringValue? BenefitLiabilityAccount { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount used with the benefit liability account.The field is included in BenefitLiabilitySubaccount.
		/// DAC Field Name: BenefitLiabilitySubID 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Benefit Liability Sub. 
		/// </summary>
		[DataMember(Name="BenefitLiabilitySub", EmitDefaultValue=false)]
		public StringValue? BenefitLiabilitySub { get; set; }

		/// <summary>
		/// The unique identifier of the liability account used by default to record the deduction from employee paycheck.The field is included in DeductionLiabilityAccount.
		/// DAC Field Name: DedLiabilityAcctID 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Deduction Liability Account 
		/// </summary>
		[DataMember(Name="DeductionLiabilityAccount", EmitDefaultValue=false)]
		public StringValue? DeductionLiabilityAccount { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount used with the deduction liability account.The field is included in DeductionLiabilitySubaccount.
		/// DAC Field Name: DedLiabilitySubID 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// Display Name: Deduction Liability Sub. 
		/// </summary>
		[DataMember(Name="DeductionLiabilitySub", EmitDefaultValue=false)]
		public StringValue? DeductionLiabilitySub { get; set; }

	}
}