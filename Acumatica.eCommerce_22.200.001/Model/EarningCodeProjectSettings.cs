using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class EarningCodeProjectSettings : Entity
	{

		[DataMember(Name="BillableProject", EmitDefaultValue=false)]
		public BooleanValue BillableProject { get; set; }

		[DataMember(Name="DefaultProjectCode", EmitDefaultValue=false)]
		public StringValue DefaultProjectCode { get; set; }

		[DataMember(Name="DefaultProjectTask", EmitDefaultValue=false)]
		public StringValue DefaultProjectTask { get; set; }

	}
}