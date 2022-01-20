using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class MachineDetail : Entity_v4
	{

		[DataMember(Name="MachineAccount", EmitDefaultValue=false)]
		public StringValue MachineAccount { get; set; }

		[DataMember(Name="MachineID", EmitDefaultValue=false)]
		public StringValue MachineID { get; set; }

		[DataMember(Name="MachineOverride", EmitDefaultValue=false)]
		public BooleanValue MachineOverride { get; set; }

		[DataMember(Name="MachineSubaccount", EmitDefaultValue=false)]
		public StringValue MachineSubaccount { get; set; }

		[DataMember(Name="StandardCost", EmitDefaultValue=false)]
		public DecimalValue StandardCost { get; set; }

	}
}