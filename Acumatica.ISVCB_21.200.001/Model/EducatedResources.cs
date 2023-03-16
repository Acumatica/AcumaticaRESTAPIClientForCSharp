using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.ISVCB_21_200_001.Model
{
	[DataContract]
	public class EducatedResources : Entity_v4
	{

		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue BusinessAccount { get; set; }

		[DataMember(Name="EducatedResourcesDetails", EmitDefaultValue=false)]
		public List<EducatedResourcesDetail> EducatedResourcesDetails { get; set; }

	}
}