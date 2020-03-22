using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class AttributeValue : Entity
	{

		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue AttributeID { get; set; }

		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue Required { get; set; }

		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue Value { get; set; }

	}
}