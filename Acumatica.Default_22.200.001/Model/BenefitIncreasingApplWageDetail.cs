using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class BenefitIncreasingApplWageDetail : Entity
	{

		[DataMember(Name="BenefitCode", EmitDefaultValue=false)]
		public StringValue BenefitCode { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

	}
}