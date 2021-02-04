using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class MPSType : Entity_v4
	{

		[DataMember(Name="Dependent", EmitDefaultValue=false)]
		public BooleanValue Dependent { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="NumberingSequence", EmitDefaultValue=false)]
		public StringValue NumberingSequence { get; set; }

		[DataMember(Name="TypeID", EmitDefaultValue=false)]
		public StringValue TypeID { get; set; }

	}
}