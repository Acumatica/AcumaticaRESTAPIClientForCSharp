using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ProjectTaskToCRMLink : Entity
	{

		[DataMember(Name="AccountedCampaign", EmitDefaultValue=false)]
		public StringValue AccountedCampaign { get; set; }

	}
}