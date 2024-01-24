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
	public class DeductionDecreasingApplWage : Entity
	{

		[DataMember(Name="DeductionIncreasingApplWageDetails", EmitDefaultValue=false)]
		public List<DeductionDecreasingApplWageDetail>? DeductionIncreasingApplWageDetails { get; set; }

		[DataMember(Name="InclusionType", EmitDefaultValue=false)]
		public StringValue? InclusionType { get; set; }

	}
}