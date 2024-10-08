using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AR303020 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CustomerLocation : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Address record, which isreferenced by DefAddressID.
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="AddressOverride", EmitDefaultValue=false)]
		public BooleanValue? AddressOverride { get; set; }

		/// <summary>
		/// The type of the work calendar in the customer location.
		/// DAC Field Name: CCalendarID 
		/// DAC: PX.Objects.CR.Location 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Calendar", EmitDefaultValue=false)]
		public StringValue? Calendar { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Contact record, which isreferenced by DefContactID.
		/// DAC Field Name: OverrideContact 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Override 
		/// </summary>
		[DataMember(Name="ContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ContactOverride { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The identifier of the BAccount record that is specified in the document to which the location belongs.
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Account ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// This field indicates whether the location is default for the corresponding business account.
		/// DAC Field Name: IsDefault 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// The identifier of the default project of the customer location.
		/// DAC Field Name: CDefProjectID 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Default Project 
		/// </summary>
		[DataMember(Name="DefaultProject", EmitDefaultValue=false)]
		public StringValue? DefaultProject { get; set; }

		/// <summary>
		/// The customer's entity type for reporting purposes. This field is used if the system is integrated with External Tax Calculationand the External Tax Calculation Integration feature is enabled.
		/// DAC Field Name: CAvalaraCustomerUsageType 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Tax Exemption Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue? EntityUsageType { get; set; }

		/// <summary>
		/// This field indicates whether the FedEx Ground Collect program is available in this location.
		/// DAC Field Name: CGroundCollect 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Ground Collect 
		/// </summary>
		[DataMember(Name="FedExGroundCollect", EmitDefaultValue=false)]
		public BooleanValue? FedExGroundCollect { get; set; }

		/// <summary>
		/// The customer's FOB (free on board) shipping point.
		/// DAC Field Name: CFOBPointID 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: FOB Point 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// This field indicates whether the delivery insurance is available in this location.
		/// DAC Field Name: CInsurance 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		[DataMember(Name="Insurance", EmitDefaultValue=false)]
		public BooleanValue? Insurance { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The amount of lead days (the time in days from the moment when the production was finished to the moment when the customer's order was delivered).
		/// DAC Field Name: CLeadTime 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Lead Time (Days) 
		/// </summary>
		[DataMember(Name="LeadTimeDays", EmitDefaultValue=false)]
		public ShortValue? LeadTimeDays { get; set; }

		[DataMember(Name="LocationContact", EmitDefaultValue=false)]
		public Contact? LocationContact { get; set; }

		/// <summary>
		/// The human-readable identifier of the location that is specified by the user when they create a location.This field is a natural key as opposed to the LocationID surrogate key.
		/// DAC Field Name: LocationCD 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Location ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// The name of the location.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Location Name 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue? LocationName { get; set; }

		/// <summary>
		/// The order priority of the customer's location.
		/// DAC Field Name: COrderPriority 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Order Priority 
		/// </summary>
		[DataMember(Name="OrderPriority", EmitDefaultValue=false)]
		public ShortValue? OrderPriority { get; set; }

		/// <summary>
		/// The price class of the customer.
		/// DAC Field Name: CPriceClassID 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Price Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// This field indicates whether the residential delivery is available in this location.
		/// DAC Field Name: CResedential 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Residential Delivery 
		/// </summary>
		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue? ResidentialDelivery { get; set; }

		[DataMember(Name="RoleAssignments", EmitDefaultValue=false)]
		public List<BCRoleAssignment>? RoleAssignments { get; set; }

		/// <summary>
		/// This field indicates whether the Saturday delivery is available in this location.
		/// DAC Field Name: CSaturdayDelivery 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Saturday Delivery 
		/// </summary>
		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// The identifier of the default branch of the customer location.
		/// DAC Field Name: CBranchID 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Shipping Branch 
		/// </summary>
		[DataMember(Name="ShippingBranch", EmitDefaultValue=false)]
		public StringValue? ShippingBranch { get; set; }

		/// <summary>
		/// The shipping rule of the customer location.
		/// DAC Field Name: CShipComplete 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Shipping Rule 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue? ShippingRule { get; set; }

		/// <summary>
		/// The customer's shipping terms.
		/// DAC Field Name: CShipTermsID 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Shipping Terms 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// The customer's shipping zone.
		/// DAC Field Name: CShipZoneID 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Shipping Zone 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShippingZone", EmitDefaultValue=false)]
		public StringValue? ShippingZone { get; set; }

		/// <summary>
		/// The shipping carrier for the vendor location.
		/// DAC Field Name: CCarrierID 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Ship Via 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// The current status of the location.
		/// DAC: PX.Objects.CR.Location 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The Avalara Exemption number of the customer location.
		/// DAC Field Name: CAvalaraExemptionNumber 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Tax Exemption Number 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="TaxExemptionNbr", EmitDefaultValue=false)]
		public StringValue? TaxExemptionNbr { get; set; }

		/// <summary>
		/// The registration ID of the company in the state tax authority.
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Tax Registration ID 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue? TaxRegistrationID { get; set; }

		/// <summary>
		/// The customer's tax zone.
		/// DAC Field Name: CTaxZoneID 
		/// DAC: PX.Objects.CR.Location 
		/// Display Name: Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// The warehouse identifier of the customer location.
		/// DAC Field Name: CSiteID 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}