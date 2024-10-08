using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class ShipToSettings : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: FOB Point 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// DAC Field Name: CuryFreightCost 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: Freight Cost 
		/// </summary>
		[DataMember(Name="FreightCost", EmitDefaultValue=false)]
		public DecimalValue? FreightCost { get; set; }

		/// <summary>
		/// DAC Field Name: CuryFreightAmt 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: Freight Price 
		/// </summary>
		[DataMember(Name="FreightPrice", EmitDefaultValue=false)]
		public DecimalValue? FreightPrice { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: Ground Collect 
		/// </summary>
		[DataMember(Name="GroundCollect", EmitDefaultValue=false)]
		public BooleanValue? GroundCollect { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// </summary>
		[DataMember(Name="Insurance", EmitDefaultValue=false)]
		public BooleanValue? Insurance { get; set; }

		/// <summary>
		/// DAC Field Name: FreightAmountSource 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: Invoice Freight Price Based On 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="InvoiceFreightPriceBasedOn", EmitDefaultValue=false)]
		public StringValue? InvoiceFreightPriceBasedOn { get; set; }

		/// <summary>
		/// DAC Field Name: OverrideFreightAmount 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: Override Freight Price 
		/// </summary>
		[DataMember(Name="OverrideFreightPrice", EmitDefaultValue=false)]
		public BooleanValue? OverrideFreightPrice { get; set; }

		/// <summary>
		/// DAC Field Name: Residential 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: Residential Delivery 
		/// </summary>
		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue? ResidentialDelivery { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: Saturday Delivery 
		/// </summary>
		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// DAC Field Name: ShipTermsID 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: Shipping Terms 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// DAC Field Name: ShipZoneID 
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: Shipping Zone ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShippingZoneID", EmitDefaultValue=false)]
		public StringValue? ShippingZoneID { get; set; }

		[DataMember(Name="ShipToAddress", EmitDefaultValue=false)]
		public Address? ShipToAddress { get; set; }

		/// <summary>
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.AM.AMVendorShipmentAddress 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="ShipToAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToAddressOverride { get; set; }

		[DataMember(Name="ShipToContact", EmitDefaultValue=false)]
		public DocContact? ShipToContact { get; set; }

		/// <summary>
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.AM.AMVendorShipmentContact 
		/// Display Name: Override Contact 
		/// </summary>
		[DataMember(Name="ShipToContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShipToContactOverride { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMVendorShipment 
		/// Display Name: Ship Via 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

	}
}