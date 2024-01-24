using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class EmployerTaxesIncreasingApplWage : Entity
	{

		[DataMember(Name="EmployerTaxesIncreasingApplWageDetails", EmitDefaultValue=false)]
		public List<EmployerTaxesIncreasingApplWageDetail>? EmployerTaxesIncreasingApplWageDetails { get; set; }

		[DataMember(Name="InclusionType", EmitDefaultValue=false)]
		public StringValue? InclusionType { get; set; }

	}
}