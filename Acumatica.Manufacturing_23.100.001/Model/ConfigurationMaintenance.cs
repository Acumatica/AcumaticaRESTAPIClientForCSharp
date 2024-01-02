using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class ConfigurationMaintenance : Entity, ITopLevelEntity
	{

		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		[DataMember(Name="BOMRevision", EmitDefaultValue=false)]
		public StringValue? BOMRevision { get; set; }

		[DataMember(Name="CompletionRequiredBeforeProduction", EmitDefaultValue=false)]
		public BooleanValue? CompletionRequiredBeforeProduction { get; set; }

		[DataMember(Name="ConfigAttributes", EmitDefaultValue=false)]
		public List<ConfigurationMaintAttribute>? ConfigAttributes { get; set; }

		[DataMember(Name="ConfigurationID", EmitDefaultValue=false)]
		public StringValue? ConfigurationID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Features", EmitDefaultValue=false)]
		public List<ConfigurationMaintenanceFeature>? Features { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="Keys", EmitDefaultValue=false)]
		public ConfigurationMaintKey? Keys { get; set; }

		[DataMember(Name="Price", EmitDefaultValue=false)]
		public ConfigurationMaintPrice? Price { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}