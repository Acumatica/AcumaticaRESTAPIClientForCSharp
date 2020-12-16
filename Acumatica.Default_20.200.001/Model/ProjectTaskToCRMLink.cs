using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProjectTaskToCRMLink : Entity_v4
	{

		[DataMember(Name="AccountedCampaign", EmitDefaultValue=false)]
		public StringValue AccountedCampaign { get; set; }

	}
}