using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmployeeGLAccounts : Entity
	{

		[DataMember(Name="BenefitExpenseAccount", EmitDefaultValue=false)]
		public StringValue BenefitExpenseAccount { get; set; }

		[DataMember(Name="BenefitExpenseSub", EmitDefaultValue=false)]
		public StringValue BenefitExpenseSub { get; set; }

		[DataMember(Name="BenefitLiabilityAccount", EmitDefaultValue=false)]
		public StringValue BenefitLiabilityAccount { get; set; }

		[DataMember(Name="BenefitLiabilitySub", EmitDefaultValue=false)]
		public StringValue BenefitLiabilitySub { get; set; }

		[DataMember(Name="DeductionLiabilityAccount", EmitDefaultValue=false)]
		public StringValue DeductionLiabilityAccount { get; set; }

		[DataMember(Name="DeductionLiabilitySub", EmitDefaultValue=false)]
		public StringValue DeductionLiabilitySub { get; set; }

		[DataMember(Name="EarningsAccount", EmitDefaultValue=false)]
		public StringValue EarningsAccount { get; set; }

		[DataMember(Name="EarningsSub", EmitDefaultValue=false)]
		public StringValue EarningsSub { get; set; }

		[DataMember(Name="PTOAssetAccount", EmitDefaultValue=false)]
		public StringValue PTOAssetAccount { get; set; }

		[DataMember(Name="PTOAssetSub", EmitDefaultValue=false)]
		public StringValue PTOAssetSub { get; set; }

		[DataMember(Name="PTOExpenseAccount", EmitDefaultValue=false)]
		public StringValue PTOExpenseAccount { get; set; }

		[DataMember(Name="PTOExpenseSub", EmitDefaultValue=false)]
		public StringValue PTOExpenseSub { get; set; }

		[DataMember(Name="PTOLiabilityAccount", EmitDefaultValue=false)]
		public StringValue PTOLiabilityAccount { get; set; }

		[DataMember(Name="PTOLiabilitySub", EmitDefaultValue=false)]
		public StringValue PTOLiabilitySub { get; set; }

		[DataMember(Name="TaxExpenseAccount", EmitDefaultValue=false)]
		public StringValue TaxExpenseAccount { get; set; }

		[DataMember(Name="TaxExpenseSub", EmitDefaultValue=false)]
		public StringValue TaxExpenseSub { get; set; }

		[DataMember(Name="TaxLiabilityAccount", EmitDefaultValue=false)]
		public StringValue TaxLiabilityAccount { get; set; }

		[DataMember(Name="TaxLiabilitySub", EmitDefaultValue=false)]
		public StringValue TaxLiabilitySub { get; set; }

	}
}