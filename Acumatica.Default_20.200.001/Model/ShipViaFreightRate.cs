using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ShipViaFreightRate : Entity_v4
	{

		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue LineNbr { get; set; }

		[DataMember(Name="Rate", EmitDefaultValue=false)]
		public DecimalValue Rate { get; set; }

		[DataMember(Name="Volume", EmitDefaultValue=false)]
		public DecimalValue Volume { get; set; }

		[DataMember(Name="Weight", EmitDefaultValue=false)]
		public DecimalValue Weight { get; set; }

		[DataMember(Name="ZoneID", EmitDefaultValue=false)]
		public StringValue ZoneID { get; set; }

	}
}