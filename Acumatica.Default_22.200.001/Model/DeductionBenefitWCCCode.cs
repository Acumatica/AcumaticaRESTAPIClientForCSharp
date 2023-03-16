using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class DeductionBenefitWCCCode : Entity
	{

		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue State { get; set; }

		[DataMember(Name="WCCCodeRates", EmitDefaultValue=false)]
		public List<WCCCodeRateDetail> WCCCodeRates { get; set; }

	}
}