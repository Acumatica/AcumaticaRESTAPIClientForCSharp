using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class Shift : Entity_v4
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="DiffType", EmitDefaultValue=false)]
		public StringValue DiffType { get; set; }

		[DataMember(Name="shift", EmitDefaultValue=false)]
		public StringValue shift { get; set; }

		[DataMember(Name="ShiftDiff", EmitDefaultValue=false)]
		public DecimalValue ShiftDiff { get; set; }

	}
}