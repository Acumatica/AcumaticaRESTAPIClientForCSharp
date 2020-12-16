using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class BusinessAccountDefaultLocationSetting : Entity_v4
	{

		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue FOBPoint { get; set; }

		[DataMember(Name="Insurance", EmitDefaultValue=false)]
		public BooleanValue Insurance { get; set; }

		[DataMember(Name="LeadTimeInDays", EmitDefaultValue=false)]
		public ShortValue LeadTimeInDays { get; set; }

		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue LocationName { get; set; }

		[DataMember(Name="OrderPriority", EmitDefaultValue=false)]
		public ShortValue OrderPriority { get; set; }

		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue PriceClass { get; set; }

		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue ResidentialDelivery { get; set; }

		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue SaturdayDelivery { get; set; }

		[DataMember(Name="ShippingBranch", EmitDefaultValue=false)]
		public StringValue ShippingBranch { get; set; }

		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue ShippingRule { get; set; }

		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue ShippingTerms { get; set; }

		[DataMember(Name="ShippingZone", EmitDefaultValue=false)]
		public StringValue ShippingZone { get; set; }

		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue ShipVia { get; set; }

		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue TaxRegistrationID { get; set; }

		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue TaxZone { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}