using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class DeductionDecreasingApplWage : Entity
	{

		[DataMember(Name="DeductionIncreasingApplWageDetails", EmitDefaultValue=false)]
		public List<DeductionDecreasingApplWageDetail> DeductionIncreasingApplWageDetails { get; set; }

		[DataMember(Name="InclusionType", EmitDefaultValue=false)]
		public StringValue InclusionType { get; set; }

	}
}