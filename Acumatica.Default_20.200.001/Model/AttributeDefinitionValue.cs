using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class AttributeDefinitionValue : Entity_v4
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Disabled", EmitDefaultValue=false)]
		public BooleanValue Disabled { get; set; }

		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public ShortValue SortOrder { get; set; }

		[DataMember(Name="ValueID", EmitDefaultValue=false)]
		public StringValue ValueID { get; set; }

	}
}