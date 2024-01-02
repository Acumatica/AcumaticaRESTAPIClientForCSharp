using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CriticalMaterials : Entity, ITopLevelEntity
	{

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<CriticalMaterialDetail>? Detail { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		[DataMember(Name="ShowAllItems", EmitDefaultValue=false)]
		public BooleanValue? ShowAllItems { get; set; }

		[DataMember(Name="ShowAllocated", EmitDefaultValue=false)]
		public BooleanValue? ShowAllocated { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/21.200.001";
		}
	}
}