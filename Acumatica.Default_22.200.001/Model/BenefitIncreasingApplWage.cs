using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class BenefitIncreasingApplWage : Entity
	{

		[DataMember(Name="BenefitIncreasingApplWageDetails", EmitDefaultValue=false)]
		public List<BenefitIncreasingApplWageDetail> BenefitIncreasingApplWageDetails { get; set; }

		[DataMember(Name="InclusionType", EmitDefaultValue=false)]
		public StringValue InclusionType { get; set; }

	}
}