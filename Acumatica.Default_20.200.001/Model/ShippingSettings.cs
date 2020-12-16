using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ShippingSettings : Entity_v4
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

		[DataMember(Name="Freight", EmitDefaultValue=false)]
		public DecimalValue Freight { get; set; }

		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue FreightCost { get; set; }

		[DataMember(Name="FreightCostIsuptodate", EmitDefaultValue=false)]
		public BooleanValue FreightCostIsuptodate { get; set; }

		[DataMember(Name="FreightTaxCategory", EmitDefaultValue=false)]
		public StringValue FreightTaxCategory { get; set; }

		[DataMember(Name="OrderVolume", EmitDefaultValue=false)]
		public DecimalValue OrderVolume { get; set; }

		[DataMember(Name="OrderWeight", EmitDefaultValue=false)]
		public DecimalValue OrderWeight { get; set; }

		[DataMember(Name="PackageWeight", EmitDefaultValue=false)]
		public DecimalValue PackageWeight { get; set; }

		[DataMember(Name="PremiumFreight", EmitDefaultValue=false)]
		public DecimalValue PremiumFreight { get; set; }

	}
}