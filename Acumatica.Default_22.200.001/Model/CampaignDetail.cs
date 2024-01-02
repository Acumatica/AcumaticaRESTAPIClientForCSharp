using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class CampaignDetail : Entity
	{

		[DataMember(Name="CampaignID", EmitDefaultValue=false)]
		public StringValue? CampaignID { get; set; }

		[DataMember(Name="CampaignName", EmitDefaultValue=false)]
		public StringValue? CampaignName { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		[DataMember(Name="Stage", EmitDefaultValue=false)]
		public StringValue? Stage { get; set; }

	}
}