using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class TaxesDecreasingApplWage : Entity
	{

		[DataMember(Name="EmployeeTaxesDecreasingApplWageDetails", EmitDefaultValue=false)]
		public List<TaxesDecreasingApplWageDetail> EmployeeTaxesDecreasingApplWageDetails { get; set; }

		[DataMember(Name="InclusionType", EmitDefaultValue=false)]
		public StringValue InclusionType { get; set; }

	}
}