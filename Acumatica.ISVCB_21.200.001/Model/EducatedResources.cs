using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_21_200_001.Model
{
	[DataContract]
	public class EducatedResources : Entity
	{

		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue BusinessAccount { get; set; }

		[DataMember(Name="EducatedResourcesDetails", EmitDefaultValue=false)]
		public List<EducatedResourcesDetail> EducatedResourcesDetails { get; set; }

	}
}