using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ACAInfoDetail : Entity
	{

		[DataMember(Name="CoverageType", EmitDefaultValue=false)]
		public StringValue CoverageType { get; set; }

		[DataMember(Name="HealthPlanType", EmitDefaultValue=false)]
		public StringValue HealthPlanType { get; set; }

	}
}