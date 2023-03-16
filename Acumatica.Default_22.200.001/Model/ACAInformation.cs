using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ACAInformation : Entity
	{

		[DataMember(Name="ACAInfoDetails", EmitDefaultValue=false)]
		public List<ACAInfoDetail> ACAInfoDetails { get; set; }

		[DataMember(Name="MinIndividualContribution", EmitDefaultValue=false)]
		public DecimalValue MinIndividualContribution { get; set; }

	}
}