using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ProjectUnionLocal : Entity_v3
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="UnionLocalID", EmitDefaultValue=false)]
		public StringValue UnionLocalID { get; set; }

	}
}