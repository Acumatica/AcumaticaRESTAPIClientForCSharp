using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class NonStockItemAttribute : Entity
	{

		[DataMember(Name="Attribute", EmitDefaultValue=false)]
		public StringValue Attribute { get; set; }

		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue Required { get; set; }

		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue Value { get; set; }

	}
}