using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class StorageDetails : Entity, ITopLevelEntity
	{

		[DataMember(Name="BindingID", EmitDefaultValue=false)]
		public IntValue? BindingID { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<StorageDetailsResult>? Results { get; set; }

		[DataMember(Name="SplitByLocation", EmitDefaultValue=false)]
		public BooleanValue? SplitByLocation { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}