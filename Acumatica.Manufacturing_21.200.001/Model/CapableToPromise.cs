using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CapableToPromise : Entity, ITopLevelEntity
	{

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CapableToPromiseDetail> Details { get; set; }

		[DataMember(Name="ProcessAction", EmitDefaultValue=false)]
		public StringValue ProcessAction { get; set; }

		[DataMember(Name="RegularProductionOrderType", EmitDefaultValue=false)]
		public StringValue RegularProductionOrderType { get; set; }

		[DataMember(Name="SONbr", EmitDefaultValue=false)]
		public StringValue SONbr { get; set; }

		[DataMember(Name="SOType", EmitDefaultValue=false)]
		public StringValue SOType { get; set; }

		public string GetEndpointPath()
		{
			return "entity/MANUFACTURING/21.200.001";
		}
	}
}