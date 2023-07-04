using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class ItemWhereUsedInquiry : Entity, ITopLevelEntity
	{

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue ItemClass { get; set; }

		[DataMember(Name="MultiLevel", EmitDefaultValue=false)]
		public BooleanValue MultiLevel { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<ItemWhereUsedRow> Results { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

		public string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}