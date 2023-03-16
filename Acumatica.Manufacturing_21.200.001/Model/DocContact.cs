using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class DocContact : Entity
	{

		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue Attention { get; set; }

		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue CompanyName { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue Email { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue Phone1 { get; set; }

	}
}