using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class DisassemblyEntryAttribute : Entity
	{

		[DataMember(Name="Attribute", EmitDefaultValue=false)]
		public StringValue? Attribute { get; set; }

		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue? AttributeID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		[DataMember(Name="ProdAttributeLineNbr", EmitDefaultValue=false)]
		public IntValue? ProdAttributeLineNbr { get; set; }

		[DataMember(Name="Required", EmitDefaultValue=false)]
		public BooleanValue? Required { get; set; }

		[DataMember(Name="TranLineNbr", EmitDefaultValue=false)]
		public IntValue? TranLineNbr { get; set; }

		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}