using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR303020</c> in the Acumatica ERP
	/// <para>Key Fields: Customer, LocationID</para>
	/// </summary>
	public class CustomerLocation : Entity, ITopLevelEntity
	{

		public BooleanValue? Active { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Address record, which isreferenced by DefAddressID.
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? AddressOverride { get; set; }

		/// <summary>
		/// The type of the work calendar in the customer location.
		/// <para>DAC Field Name: CCalendarID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? Calendar { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Contact record, which isreferenced by DefContactID.
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? ContactOverride { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The identifier of the BAccount record that is specified in the document to which the location belongs.
		/// <para>DAC Field Name: BAccountID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Account ID</para>
		/// Key Field
		/// </summary>
		public StringValue? Customer { get; set; }

		/// <summary>
		/// This field indicates whether the location is default for the corresponding business account.
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// </summary>
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// The identifier of the default project of the customer location.
		/// <para>DAC Field Name: CDefProjectID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Default Project</para>
		/// </summary>
		public StringValue? DefaultProject { get; set; }

		/// <summary>
		/// The customer's entity type for reporting purposes. This field is used if the system is integrated with External Tax Calculationand the External Tax Calculation Integration feature is enabled.
		/// <para>DAC Field Name: CAvalaraCustomerUsageType</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Tax Exemption Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? EntityUsageType { get; set; }

		/// <summary>
		/// This field indicates whether the FedEx Ground Collect program is available in this location.
		/// <para>DAC Field Name: CGroundCollect</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Ground Collect</para>
		/// </summary>
		public BooleanValue? FedExGroundCollect { get; set; }

		/// <summary>
		/// The customer's FOB (free on board) shipping point.
		/// <para>DAC Field Name: CFOBPointID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: FOB Point</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// This field indicates whether the delivery insurance is available in this location.
		/// <para>DAC Field Name: CInsurance</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// </summary>
		public BooleanValue? Insurance { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The amount of lead days (the time in days from the moment when the production was finished to the moment when the customer's order was delivered).
		/// <para>DAC Field Name: CLeadTime</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Lead Time (Days)</para>
		/// </summary>
		public ShortValue? LeadTimeDays { get; set; }

		public Contact? LocationContact { get; set; }

		/// <summary>
		/// The human-readable identifier of the location that is specified by the user when they create a location.This field is a natural key as opposed to the LocationID surrogate key.
		/// <para>DAC Field Name: LocationCD</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Location ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// The name of the location.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Location Name</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? LocationName { get; set; }

		/// <summary>
		/// The order priority of the customer's location.
		/// <para>DAC Field Name: COrderPriority</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Order Priority</para>
		/// </summary>
		public ShortValue? OrderPriority { get; set; }

		/// <summary>
		/// The price class of the customer.
		/// <para>DAC Field Name: CPriceClassID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Price Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PriceClass { get; set; }

		/// <summary>
		/// This field indicates whether the residential delivery is available in this location.
		/// <para>DAC Field Name: CResedential</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Residential Delivery</para>
		/// </summary>
		public BooleanValue? ResidentialDelivery { get; set; }

		public List<BCRoleAssignment>? RoleAssignments { get; set; }

		/// <summary>
		/// This field indicates whether the Saturday delivery is available in this location.
		/// <para>DAC Field Name: CSaturdayDelivery</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Saturday Delivery</para>
		/// </summary>
		public BooleanValue? SaturdayDelivery { get; set; }

		/// <summary>
		/// The identifier of the default branch of the customer location.
		/// <para>DAC Field Name: CBranchID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Shipping Branch</para>
		/// </summary>
		public StringValue? ShippingBranch { get; set; }

		/// <summary>
		/// The shipping rule of the customer location.
		/// <para>DAC Field Name: CShipComplete</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Shipping Rule</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ShippingRule { get; set; }

		/// <summary>
		/// The customer's shipping terms.
		/// <para>DAC Field Name: CShipTermsID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Shipping Terms</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// The customer's shipping zone.
		/// <para>DAC Field Name: CShipZoneID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Shipping Zone</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ShippingZone { get; set; }

		/// <summary>
		/// The shipping carrier for the vendor location.
		/// <para>DAC Field Name: CCarrierID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Ship Via</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// The current status of the location.
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// The Avalara Exemption number of the customer location.
		/// <para>DAC Field Name: CAvalaraExemptionNumber</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Tax Exemption Number</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? TaxExemptionNbr { get; set; }

		/// <summary>
		/// The registration ID of the company in the state tax authority.
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Tax Registration ID</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? TaxRegistrationID { get; set; }

		/// <summary>
		/// The customer's tax zone.
		/// <para>DAC Field Name: CTaxZoneID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// <para>Display Name: Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// The warehouse identifier of the customer location.
		/// <para>DAC Field Name: CSiteID</para>
		/// <para>DAC: PX.Objects.CR.Location</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		public GuidValue? NoteID { get; set; }

		public StringValue? ExtRefNbr { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string LocationContact = "LocationContact";
			public const string LocationContact_Activities = "LocationContact/Activities";
			public const string LocationContact_Activities_Files = "LocationContact/Activities/Files";
			public const string LocationContact_Address = "LocationContact/Address";
			public const string LocationContact_Attributes = "LocationContact/Attributes";
			public const string LocationContact_Campaigns = "LocationContact/Campaigns";
			public const string LocationContact_Campaigns_Files = "LocationContact/Campaigns/Files";
			public const string LocationContact_Cases = "LocationContact/Cases";
			public const string LocationContact_Cases_Files = "LocationContact/Cases/Files";
			public const string LocationContact_Duplicates = "LocationContact/Duplicates";
			public const string LocationContact_Duplicates_Files = "LocationContact/Duplicates/Files";
			public const string LocationContact_MarketingLists = "LocationContact/MarketingLists";
			public const string LocationContact_MarketingLists_Files = "LocationContact/MarketingLists/Files";
			public const string LocationContact_Notifications = "LocationContact/Notifications";
			public const string LocationContact_Notifications_Files = "LocationContact/Notifications/Files";
			public const string LocationContact_Opportunities = "LocationContact/Opportunities";
			public const string LocationContact_Opportunities_Files = "LocationContact/Opportunities/Files";
			public const string LocationContact_Relations = "LocationContact/Relations";
			public const string LocationContact_Relations_Files = "LocationContact/Relations/Files";
			public const string LocationContact_RoleAssignments = "LocationContact/RoleAssignments";
			public const string LocationContact_RoleAssignments_Files = "LocationContact/RoleAssignments/Files";
			public const string LocationContact_UserInfo = "LocationContact/UserInfo";
			public const string LocationContact_UserInfo_Roles = "LocationContact/UserInfo/Roles";
			public const string LocationContact_UserInfo_Roles_Files = "LocationContact/UserInfo/Roles/Files";
			public const string RoleAssignments = "RoleAssignments";
			public const string RoleAssignments_Files = "RoleAssignments/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,LocationContact,LocationContact/Activities,LocationContact/Activities/Files,LocationContact/Address,LocationContact/Attributes,LocationContact/Campaigns,LocationContact/Campaigns/Files,LocationContact/Cases,LocationContact/Cases/Files,LocationContact/Duplicates,LocationContact/Duplicates/Files,LocationContact/MarketingLists,LocationContact/MarketingLists/Files,LocationContact/Notifications,LocationContact/Notifications/Files,LocationContact/Opportunities,LocationContact/Opportunities/Files,LocationContact/Relations,LocationContact/Relations/Files,LocationContact/RoleAssignments,LocationContact/RoleAssignments/Files,LocationContact/UserInfo,LocationContact/UserInfo/Roles,LocationContact/UserInfo/Roles/Files,RoleAssignments,RoleAssignments/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}