using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CompaniesStructure : Entity
	{

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<CompaniesStructureDetail> Results { get; set; }

	}
}