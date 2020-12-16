using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ShipToSettings : Entity_v4
	{

		[DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
		public Address ShipToAddress { get; set; }

		[DataMember(Name="ShipToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue ShipToAddressOverride { get; set; }

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public DocContact ShipToContact { get; set; }

		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue ShipToContactOverride { get; set; }

		[DataMember(Name="Validated", EmitDefaultValue=false)]
		public BooleanValue Validated { get; set; }

	}
}