using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EarningIncreasingApplWage : Entity_v4
	{

		[DataMember(Name="EarningIncreasingApplWageDetails", EmitDefaultValue=false)]
		public List<EarningIncreasingApplWageDetail> EarningIncreasingApplWageDetails { get; set; }

		[DataMember(Name="InclusionType", EmitDefaultValue=false)]
		public StringValue InclusionType { get; set; }

	}
}