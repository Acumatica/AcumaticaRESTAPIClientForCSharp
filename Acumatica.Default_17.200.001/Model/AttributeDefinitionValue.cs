using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class AttributeDefinitionValue : Entity
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