using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ConfigurationMaintKey : Entity
	{

		[DataMember(Name="Format", EmitDefaultValue=false)]
		public StringValue Format { get; set; }

		[DataMember(Name="Formula", EmitDefaultValue=false)]
		public StringValue Formula { get; set; }

		[DataMember(Name="KeyDescription", EmitDefaultValue=false)]
		public StringValue KeyDescription { get; set; }

		[DataMember(Name="NumberSequence", EmitDefaultValue=false)]
		public StringValue NumberSequence { get; set; }

		[DataMember(Name="TranDescription", EmitDefaultValue=false)]
		public StringValue TranDescription { get; set; }

	}
}