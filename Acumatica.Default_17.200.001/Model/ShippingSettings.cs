using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class ShippingSettings : Entity
	{

		[DataMember(Name="CancelByDate", EmitDefaultValue=false)]
		public DateTimeValue CancelByDate { get; set; }

		[DataMember(Name="Canceled", EmitDefaultValue=false)]
		public BooleanValue Canceled { get; set; }

		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue FOBPoint { get; set; }

		[DataMember(Name="GroundCollect", EmitDefaultValue=false)]
		public BooleanValue GroundCollect { get; set; }

		[DataMember(Name="Insurance", EmitDefaultValue=false)]
		public BooleanValue Insurance { get; set; }

		[DataMember(Name="PreferredWarehouseID", EmitDefaultValue=false)]
		public StringValue PreferredWarehouseID { get; set; }

		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public ShortValue Priority { get; set; }

		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue ResidentialDelivery { get; set; }

		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue SaturdayDelivery { get; set; }

		[DataMember(Name="ScheduledShipmentDate", EmitDefaultValue=false)]
		public DateTimeValue ScheduledShipmentDate { get; set; }

		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue ShippingRule { get; set; }

		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue ShippingTerms { get; set; }

		[DataMember(Name="ShippingZone", EmitDefaultValue=false)]
		public StringValue ShippingZone { get; set; }

		[DataMember(Name="ShipSeparately", EmitDefaultValue=false)]
		public BooleanValue ShipSeparately { get; set; }

		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue ShipVia { get; set; }

		[DataMember(Name="ShopForRates", EmitDefaultValue=false)]
		public ShopForRates ShopForRates { get; set; }

		[DataMember(Name="UseCustomersAccount", EmitDefaultValue=false)]
		public BooleanValue UseCustomersAccount { get; set; }

	}
}