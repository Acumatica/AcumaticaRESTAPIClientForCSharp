using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class EmployerTaxesIncreasingApplWage : Entity
	{

		[DataMember(Name="EmployerTaxesIncreasingApplWageDetails", EmitDefaultValue=false)]
		public List<EmployerTaxesIncreasingApplWageDetail> EmployerTaxesIncreasingApplWageDetails { get; set; }

		[DataMember(Name="InclusionType", EmitDefaultValue=false)]
		public StringValue InclusionType { get; set; }

	}
}