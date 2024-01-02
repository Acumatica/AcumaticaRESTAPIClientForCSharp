using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EstimatePreferences : Entity, ITopLevelEntity
	{

		[DataMember(Name="AutoNumberRevisions", EmitDefaultValue=false)]
		public BooleanValue? AutoNumberRevisions { get; set; }

		[DataMember(Name="DefaultEstimateClass", EmitDefaultValue=false)]
		public StringValue? DefaultEstimateClass { get; set; }

		[DataMember(Name="DefaultProdOrderType", EmitDefaultValue=false)]
		public StringValue? DefaultProdOrderType { get; set; }

		[DataMember(Name="DefaultRevision", EmitDefaultValue=false)]
		public StringValue? DefaultRevision { get; set; }

		[DataMember(Name="DefaultWorkCenter", EmitDefaultValue=false)]
		public StringValue? DefaultWorkCenter { get; set; }

		[DataMember(Name="EstimateNumberSequence", EmitDefaultValue=false)]
		public StringValue? EstimateNumberSequence { get; set; }

		[DataMember(Name="NewRevisionIsPrimary", EmitDefaultValue=false)]
		public BooleanValue? NewRevisionIsPrimary { get; set; }

		[DataMember(Name="UpdateAllRevisions", EmitDefaultValue=false)]
		public BooleanValue? UpdateAllRevisions { get; set; }

		[DataMember(Name="UpdatePriceInfo", EmitDefaultValue=false)]
		public BooleanValue? UpdatePriceInfo { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/21.200.001";
		}
	}
}