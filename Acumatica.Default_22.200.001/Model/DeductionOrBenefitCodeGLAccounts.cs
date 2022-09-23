using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class DeductionOrBenefitCodeGLAccounts : Entity_v4
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

	}
}