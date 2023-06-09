using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class ProductionDataCollectionSettings : Entity
	{

		[DataMember(Name="DefaultWarehousefromUserProfile", EmitDefaultValue=false)]
		public BooleanValue DefaultWarehousefromUserProfile { get; set; }

		[DataMember(Name="RequestLocationforEachIteminMaterials", EmitDefaultValue=false)]
		public BooleanValue RequestLocationforEachIteminMaterials { get; set; }

		[DataMember(Name="RequestLocationforEachIteminMoveLabor", EmitDefaultValue=false)]
		public BooleanValue RequestLocationforEachIteminMoveLabor { get; set; }

		[DataMember(Name="UseDefaultOrderType", EmitDefaultValue=false)]
		public BooleanValue UseDefaultOrderType { get; set; }

		[DataMember(Name="UseDefaultQuantityinMaterials", EmitDefaultValue=false)]
		public BooleanValue UseDefaultQuantityinMaterials { get; set; }

		[DataMember(Name="UseDefaultQuantityinMoveLabor", EmitDefaultValue=false)]
		public BooleanValue UseDefaultQuantityinMoveLabor { get; set; }

		[DataMember(Name="UseExplicitLineConfirmation", EmitDefaultValue=false)]
		public BooleanValue UseExplicitLineConfirmation { get; set; }

		[DataMember(Name="UseRemainingQuantityinMaterials", EmitDefaultValue=false)]
		public BooleanValue UseRemainingQuantityinMaterials { get; set; }

		[DataMember(Name="UseRemainingQuantityinMove", EmitDefaultValue=false)]
		public BooleanValue UseRemainingQuantityinMove { get; set; }

	}
}