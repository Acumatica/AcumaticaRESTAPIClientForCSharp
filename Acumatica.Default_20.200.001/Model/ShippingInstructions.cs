using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ShippingInstructions : Entity_v4
	{

		[DataMember(Name="ShippingDestinationType", EmitDefaultValue=false)]
		public StringValue ShippingDestinationType { get; set; }

		[DataMember(Name="ShippingLocation", EmitDefaultValue=false)]
		public StringValue ShippingLocation { get; set; }

		[DataMember(Name="ShipTo", EmitDefaultValue=false)]
		public StringValue ShipTo { get; set; }

		[DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
		public Address ShipToAddress { get; set; }

		[DataMember(Name="ShipToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue ShipToAddressOverride { get; set; }

		[DataMember(Name="ShipToAddressValidated", EmitDefaultValue=false)]
		public BooleanValue ShipToAddressValidated { get; set; }

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public DocContact ShipToContact { get; set; }

		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue ShipToContactOverride { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}