using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class CampaignDetail : Entity
	{

		[DataMember(Name="CampaignID", EmitDefaultValue=false)]
		public StringValue CampaignID { get; set; }

		[DataMember(Name="CampaignName", EmitDefaultValue=false)]
		public StringValue CampaignName { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue ContactID { get; set; }

		[DataMember(Name="Stage", EmitDefaultValue=false)]
		public StringValue Stage { get; set; }

	}
}