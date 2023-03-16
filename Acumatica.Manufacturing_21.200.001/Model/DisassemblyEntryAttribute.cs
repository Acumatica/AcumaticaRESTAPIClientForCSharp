using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class DisassemblyEntryAttribute : Entity
	{

		[DataMember(Name="Attribute", EmitDefaultValue=false)]
		public StringValue Attribute { get; set; }

		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue AttributeID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="ProdAttributeLineNbr", EmitDefaultValue=false)]
		public IntValue ProdAttributeLineNbr { get; set; }

		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue Required { get; set; }

		[DataMember(Name="TranLineNbr", EmitDefaultValue=false)]
		public IntValue TranLineNbr { get; set; }

		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue Value { get; set; }

	}
}