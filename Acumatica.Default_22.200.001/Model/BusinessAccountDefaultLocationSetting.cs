using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class BusinessAccountDefaultLocationSetting : Entity
	{

		/// <summary>
		/// The customer's FOB (free on board) shipping point.
		/// DAC Field Name: CFOBPointID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: FOB Point 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// This field indicates whether the delivery insurance is available in this location.
		/// DAC Field Name: CInsurance 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="Insurance", EmitDefaultValue=false)]
		public BooleanValue? Insurance { get; set; }

		/// <summary>
		/// The amount of lead days (the time in days from the moment when the production was finished to the moment when the customer's order was delivered).
		/// DAC Field Name: CLeadTime 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Lead Time (Days) 
		/// </summary>
		[DataMember(Name="LeadTimeInDays", EmitDefaultValue=false)]
		public ShortValue? LeadTimeInDays { get; set; }

		/// <summary>
		/// The name of the location.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Location Name 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue? LocationName { get; set; }

		/// <summary>
		/// The order priority of the customer's location.
		/// DAC Field Name: COrderPriority 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Order Priority 
		/// </summary>
		[DataMember(Name="OrderPriority", EmitDefaultValue=false)]
		public ShortValue? OrderPriority { get; set; }

		/// <summary>
		/// The price class of the customer.
		/// DAC Field Name: CPriceClassID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Price Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// This field indicates whether the residential delivery is available in this location.
		/// DAC Field Name: CResedential 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Residential Delivery 
		/// </summary>
		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue? ResidentialDelivery { get; set; }

		/// <summary>
		/// This field indicates whether the Saturday delivery is available in this location.
		/// DAC Field Name: CSaturdayDelivery 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Saturday Delivery 
		/// </summary>
		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// The identifier of the default branch of the customer location.
		/// DAC Field Name: CBranchID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Shipping Branch 
		/// </summary>
		[DataMember(Name="ShippingBranch", EmitDefaultValue=false)]
		public StringValue? ShippingBranch { get; set; }

		/// <summary>
		/// The shipping rule of the customer location.
		/// DAC Field Name: CShipComplete 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Shipping Rule 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue? ShippingRule { get; set; }

		/// <summary>
		/// The customer's shipping terms.
		/// DAC Field Name: CShipTermsID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Shipping Terms 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// The customer's shipping zone.
		/// DAC Field Name: CShipZoneID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Shipping Zone 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShippingZone", EmitDefaultValue=false)]
		public StringValue? ShippingZone { get; set; }

		/// <summary>
		/// The shipping carrier for the vendor location.
		/// DAC Field Name: CCarrierID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Ship Via 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// The registration ID of the company in the state tax authority.
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Tax Registration ID 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue? TaxRegistrationID { get; set; }

		/// <summary>
		/// The customer's tax zone.
		/// DAC Field Name: CTaxZoneID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// The warehouse identifier of the customer location.
		/// DAC Field Name: CSiteID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}