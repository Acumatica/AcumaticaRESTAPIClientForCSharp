using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class EstimatePreferences : Entity
	{

		[DataMember(Name="AutoNumberRevisions", EmitDefaultValue=false)]
		public BooleanValue AutoNumberRevisions { get; set; }

		[DataMember(Name="DefaultEstimateClass", EmitDefaultValue=false)]
		public StringValue DefaultEstimateClass { get; set; }

		[DataMember(Name="DefaultProdOrderType", EmitDefaultValue=false)]
		public StringValue DefaultProdOrderType { get; set; }

		[DataMember(Name="DefaultRevision", EmitDefaultValue=false)]
		public StringValue DefaultRevision { get; set; }

		[DataMember(Name="DefaultWorkCenter", EmitDefaultValue=false)]
		public StringValue DefaultWorkCenter { get; set; }

		[DataMember(Name="EstimateNumberSequence", EmitDefaultValue=false)]
		public StringValue EstimateNumberSequence { get; set; }

		[DataMember(Name="NewRevisionIsPrimary", EmitDefaultValue=false)]
		public BooleanValue NewRevisionIsPrimary { get; set; }

		[DataMember(Name="UpdateAllRevisions", EmitDefaultValue=false)]
		public BooleanValue UpdateAllRevisions { get; set; }

		[DataMember(Name="UpdatePriceInfo", EmitDefaultValue=false)]
		public BooleanValue UpdatePriceInfo { get; set; }

	}
}