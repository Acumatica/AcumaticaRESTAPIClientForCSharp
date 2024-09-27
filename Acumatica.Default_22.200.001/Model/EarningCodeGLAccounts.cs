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
	public class EarningCodeGLAccounts : Entity
	{

		/// <summary>
		/// The unique identifier of the expense account to be used by default to record the benefit expense linked with the earning.The field is included in BenefitExpenseAccount.
		/// DAC Field Name: BenefitExpenseAcctID 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Benefit Expense Account 
		/// </summary>
		[DataMember(Name="BenefitExpenseAccount", EmitDefaultValue=false)]
		public StringValue? BenefitExpenseAccount { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount to be used with the benefit expense account.The field is included in BenefitExpenseSubaccount.
		/// DAC Field Name: BenefitExpenseSubID 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Benefit Expense Sub. 
		/// </summary>
		[DataMember(Name="BenefitExpenseSub", EmitDefaultValue=false)]
		public StringValue? BenefitExpenseSub { get; set; }

		/// <summary>
		/// The unique identifier of the expense account to be used by default to record the earnings.The field is included in EarningsAccount.
		/// DAC Field Name: EarningsAcctID 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Earnings Account 
		/// </summary>
		[DataMember(Name="EarningsAccount", EmitDefaultValue=false)]
		public StringValue? EarningsAccount { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount to be used with the earnings account.The field is included in EarningsSubaccount.
		/// DAC Field Name: EarningsSubID 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Earnings Sub. 
		/// </summary>
		[DataMember(Name="EarningsSub", EmitDefaultValue=false)]
		public StringValue? EarningsSub { get; set; }

		/// <summary>
		/// The unique identifier of the expense account to be used by default to record the paid time-off expenses linked with the earning.The field is included in PTOExpenseAccount.
		/// DAC Field Name: PTOExpenseAcctID 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: PTO Expense Account 
		/// </summary>
		[DataMember(Name="PTOExpenseAccount", EmitDefaultValue=false)]
		public StringValue? PTOExpenseAccount { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount to be used with the paid time-off expense account.The field is included in PTOExpenseSubaccount.
		/// DAC Field Name: PTOExpenseSubID 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: PTO Expense Sub. 
		/// </summary>
		[DataMember(Name="PTOExpenseSub", EmitDefaultValue=false)]
		public StringValue? PTOExpenseSub { get; set; }

		/// <summary>
		/// The unique identifier of the expense account to be used by default to record the tax expenses linked with the earning.The field is included in TaxExpenseAccount.
		/// DAC Field Name: TaxExpenseAcctID 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Tax Expense Account 
		/// </summary>
		[DataMember(Name="TaxExpenseAccount", EmitDefaultValue=false)]
		public StringValue? TaxExpenseAccount { get; set; }

		/// <summary>
		/// The unique identifier of the corresponding subaccount to be used with the tax expense account.The field is included in TaxExpenseSubaccount.
		/// DAC Field Name: TaxExpenseSubID 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Tax Expense Sub. 
		/// </summary>
		[DataMember(Name="TaxExpenseSub", EmitDefaultValue=false)]
		public StringValue? TaxExpenseSub { get; set; }

	}
}