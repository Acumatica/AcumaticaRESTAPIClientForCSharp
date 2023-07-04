using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class ProductionAttributes : Entity, ITopLevelEntity
	{

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<ProductionAttributesDetail> Detail { get; set; }

		[DataMember(Name="OrderAttributes", EmitDefaultValue=false)]
		public BooleanValue OrderAttributes { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue ProductionNbr { get; set; }

		[DataMember(Name="TransactionAttributes", EmitDefaultValue=false)]
		public BooleanValue TransactionAttributes { get; set; }

		public string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}