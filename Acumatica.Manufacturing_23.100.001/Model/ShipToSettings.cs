using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class ShipToSettings : Entity
	{

		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue? FreightCost { get; set; }

		[DataMember(Name="FreightPrice", EmitDefaultValue=false)]
		public DecimalValue? FreightPrice { get; set; }

		[DataMember(Name="GroundCollect", EmitDefaultValue=false)]
		public BooleanValue? GroundCollect { get; set; }

		[DataMember(Name="Insurance", EmitDefaultValue=false)]
		public BooleanValue? Insurance { get; set; }

		[DataMember(Name="InvoiceFreightPriceBasedOn", EmitDefaultValue=false)]
		public StringValue? InvoiceFreightPriceBasedOn { get; set; }

		[DataMember(Name="OverrideFreightPrice", EmitDefaultValue=false)]
		public BooleanValue? OverrideFreightPrice { get; set; }

		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue? ResidentialDelivery { get; set; }

		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue? SaturdayDelivery { get; set; }

		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		[DataMember(Name="ShippingZoneID", EmitDefaultValue=false)]
		public StringValue? ShippingZoneID { get; set; }

		[DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
		public Address? ShipToAddress { get; set; }

		[DataMember(Name="ShipToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToAddressOverride { get; set; }

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public DocContact? ShipToContact { get; set; }

		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToContactOverride { get; set; }

		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

	}
}