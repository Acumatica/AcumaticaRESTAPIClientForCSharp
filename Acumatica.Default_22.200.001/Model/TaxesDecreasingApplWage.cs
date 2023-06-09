using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

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