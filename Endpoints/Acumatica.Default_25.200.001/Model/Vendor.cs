using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AP303000</c> in the Acumatica ERP
	/// <para>Key Fields: VendorID</para>
	/// </summary>
	public class Vendor : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The external reference number of the business account.
		/// <para>DAC Field Name: AcctReferenceNbr</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Ext. Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		/// <remarks>
		/// It can be an additional number of the business account used in external integration.            
		/// </remarks>
		public StringValue? AccountRef { get; set; }

		/// <summary>
		/// The identifier of the AP account of the vendor location.
		/// <para>DAC Field Name: VAPAccountID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: AP Account</para>
		/// </summary>
		public StringValue? APAccount { get; set; }

		/// <summary>
		/// The identifier of the AP subaccount of the vendor location.
		/// <para>DAC Field Name: VAPSubID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: AP Sub.</para>
		/// </summary>
		public StringValue? APSubaccount { get; set; }

		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The cash account indentifier of the vendor location.
		/// <para>DAC Field Name: VCashAccountID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Cash Account</para>
		/// </summary>
		public StringValue? CashAccount { get; set; }

		public List<CustomerContact>? Contacts { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Created On</para>
		/// </summary>
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryRateTypeID</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Curr. Rate Type</para>
		/// <para>SQL Type: nvarchar(6)</para>
		/// </summary>
		public StringValue? CurrencyRateType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowOverrideCury</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Enable Currency Override</para>
		/// </summary>
		public BooleanValue? EnableCurrencyOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AllowOverrideRate</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Enable Rate Override</para>
		/// </summary>
		public BooleanValue? EnableRateOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Box1099</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: 1099 Box</para>
		/// </summary>
		public StringValue? F1099Box { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Vendor1099</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: 1099 Vendor</para>
		/// </summary>
		public BooleanValue? F1099Vendor { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// </summary>
		public BooleanValue? FATCA { get; set; }

		/// <summary>
		/// The vendor's FOB (free on board) shipping point.
		/// <para>DAC Field Name: VFOBPointID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: FOB Point</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? FOBPoint { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Foreign Entity</para>
		/// </summary>
		public BooleanValue? ForeignEntity { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Landed Cost Vendor</para>
		/// </summary>
		public BooleanValue? LandedCostVendor { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Last Modified On</para>
		/// </summary>
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The amount of lead days (the time in days from the moment when the production was finished to the moment when the vendor's order was delivered).
		/// <para>DAC Field Name: VLeadTime</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Lead Time (Days)</para>
		/// </summary>
		public ShortValue? LeadTimedays { get; set; }

		/// <summary>
		/// The legal name of the company that is used by the1099 Reporting feature only (see Organization).
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Legal Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? LegalName { get; set; }

		/// <summary>
		/// The name of the location.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Location Name</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? LocationName { get; set; }

		public Contact? MainContact { get; set; }

		/// <summary>
		/// The maximum receipt amount for the vendor location in percentages.
		/// <para>DAC Field Name: VRcptQtyMax</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Max. Receipt (%)</para>
		/// </summary>
		public DecimalValue? MaxReceipt { get; set; }

		/// <summary>
		/// The minimal receipt amount for the vendor location in percentages.
		/// <para>DAC Field Name: VRcptQtyMin</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Min. Receipt (%)</para>
		/// </summary>
		public DecimalValue? MinReceipt { get; set; }

		/// <summary>
		/// The identifier of the parent business account.
		/// <para>DAC Field Name: ParentBAccountID</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Parent Account</para>
		/// </summary>
		public StringValue? ParentAccount { get; set; }

		/// <summary>
		/// An option that defines when a vendor should be paid at this location.
		/// <para>DAC Field Name: VPaymentByType</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Payment By</para>
		/// </summary>
		public StringValue? PaymentBy { get; set; }

		public List<BusinessAccountPaymentInstructionDetail>? PaymentInstructions { get; set; }

		/// <summary>
		/// The amount of the payment lead days for the vendor location.
		/// <para>DAC Field Name: VPaymentLeadTime</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Payment Lead Time (Days)</para>
		/// </summary>
		public ShortValue? PaymentLeadTimedays { get; set; }

		/// <summary>
		/// The payment method indentifier of the vendor location.
		/// <para>DAC Field Name: VPaymentMethodID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Payment Method</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? PaymentMethod { get; set; }

		/// <summary>
		/// This field indicates whether a vendor should pay separately in this location.
		/// <para>DAC Field Name: VSeparateCheck</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Pay Separately</para>
		/// </summary>
		public BooleanValue? PaySeparately { get; set; }

		public Contact? PrimaryContact { get; set; }

		/// <summary>
		/// This field indicates whether the order an order should be printed in the vendor location.
		/// <para>DAC Field Name: VPrintOrder</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Print Order</para>
		/// </summary>
		public BooleanValue? PrintOrders { get; set; }

		/// <summary>
		/// The type of the receipt action for the vendor location.
		/// <para>DAC Field Name: VRcptQtyAction</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Receipt Action</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? ReceiptAction { get; set; }

		/// <summary>
		/// The identifier of the default branch of the vendor location.
		/// <para>DAC Field Name: VBranchID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Receiving Branch</para>
		/// </summary>
		public StringValue? ReceivingBranch { get; set; }

		/// <summary>
		/// This field indicates whether the remit address is not the same as the default address for this location.
		/// <para>DAC Field Name: OverrideRemitAddress</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? RemittanceAddressOverride { get; set; }

		public Contact? RemittanceContact { get; set; }

		/// <summary>
		/// This field indicates whether the remit contact is not the same as the default contact for this location.
		/// <para>DAC Field Name: OverrideRemitContact</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? RemittanceContactOverride { get; set; }

		/// <summary>
		/// This field indicates whether the order should be sent by email in the vendor location.
		/// <para>DAC Field Name: VEmailOrder</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Email Order</para>
		/// </summary>
		public BooleanValue? SendOrdersbyEmail { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Contact record, which isreferenced by DefContactID.
		/// <para>DAC Field Name: OverrideContact</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? ShippingContactOverride { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Address record, which isreferenced by DefAddressID.
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? ShippingAddressOverride { get; set; }

		public Contact? ShippingContact { get; set; }

		/// <summary>
		/// The vendor's shipping terms.
		/// <para>DAC Field Name: VShipTermsID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Shipping Terms</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ShippingTerms { get; set; }

		/// <summary>
		/// The shipping carrier for the customer location.
		/// <para>DAC Field Name: VCarrierID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Ship Via</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ShipVia { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VStatus</para>
		/// <para>DAC: PX.Objects.AP.VendorR</para>
		/// <para>Display Name: Vendor Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// The vendor's tax calculation mode.
		/// <para>DAC Field Name: VTaxCalcMode</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Calculation Mode</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? TaxCalculationMode { get; set; }

		/// <summary>
		/// The registration ID of the company in the state tax authority.
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Registration ID</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? TaxRegistrationID { get; set; }

		/// <summary>
		/// The vendor's tax zone.
		/// <para>DAC Field Name: VTaxZoneID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Tax Zone</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? TaxZone { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TermsID</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? Terms { get; set; }

		/// <summary>
		/// The threshold receipt amount for the vendor location in percentages.
		/// <para>DAC Field Name: VRcptQtyThreshold</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Threshold Receipt (%)</para>
		/// </summary>
		public DecimalValue? ThresholdReceipt { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VendorClassID</para>
		/// <para>DAC: PX.Objects.AP.VendorR</para>
		/// <para>Display Name: Vendor Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? VendorClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AcctCD</para>
		/// <para>DAC: PX.Objects.AP.VendorR</para>
		/// <para>Display Name: Vendor ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? VendorID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxAgency</para>
		/// <para>DAC: PX.Objects.AP.Vendor</para>
		/// <para>Display Name: Vendor Is Tax Agency</para>
		/// </summary>
		public BooleanValue? VendorIsTaxAgency { get; set; }

		/// <summary>
		/// <para>DAC Field Name: AcctName</para>
		/// <para>DAC: PX.Objects.AP.VendorMaint+SuppliedByVendor</para>
		/// </summary>
		public StringValue? VendorName { get; set; }

		/// <summary>
		/// The warehouse identifier of the vendor location.
		/// <para>DAC Field Name: VSiteID</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";
			public const string Contacts = "Contacts";
			public const string Contacts_Files = "Contacts/Files";
			public const string Contacts_Contact = "Contacts/Contact";
			public const string Contacts_Contact_Activities = "Contacts/Contact/Activities";
			public const string Contacts_Contact_Activities_Files = "Contacts/Contact/Activities/Files";
			public const string Contacts_Contact_Address = "Contacts/Contact/Address";
			public const string Contacts_Contact_Attributes = "Contacts/Contact/Attributes";
			public const string Contacts_Contact_Campaigns = "Contacts/Contact/Campaigns";
			public const string Contacts_Contact_Campaigns_Files = "Contacts/Contact/Campaigns/Files";
			public const string Contacts_Contact_Cases = "Contacts/Contact/Cases";
			public const string Contacts_Contact_Cases_Files = "Contacts/Contact/Cases/Files";
			public const string Contacts_Contact_Duplicates = "Contacts/Contact/Duplicates";
			public const string Contacts_Contact_Duplicates_Files = "Contacts/Contact/Duplicates/Files";
			public const string Contacts_Contact_MarketingLists = "Contacts/Contact/MarketingLists";
			public const string Contacts_Contact_MarketingLists_Files = "Contacts/Contact/MarketingLists/Files";
			public const string Contacts_Contact_Notifications = "Contacts/Contact/Notifications";
			public const string Contacts_Contact_Notifications_Files = "Contacts/Contact/Notifications/Files";
			public const string Contacts_Contact_Opportunities = "Contacts/Contact/Opportunities";
			public const string Contacts_Contact_Opportunities_Files = "Contacts/Contact/Opportunities/Files";
			public const string Contacts_Contact_Relations = "Contacts/Contact/Relations";
			public const string Contacts_Contact_Relations_Files = "Contacts/Contact/Relations/Files";
			public const string Contacts_Contact_RoleAssignments = "Contacts/Contact/RoleAssignments";
			public const string Contacts_Contact_RoleAssignments_Files = "Contacts/Contact/RoleAssignments/Files";
			public const string Contacts_Contact_UserInfo = "Contacts/Contact/UserInfo";
			public const string Contacts_Contact_UserInfo_Roles = "Contacts/Contact/UserInfo/Roles";
			public const string Contacts_Contact_UserInfo_Roles_Files = "Contacts/Contact/UserInfo/Roles/Files";
			public const string MainContact = "MainContact";
			public const string MainContact_Activities = "MainContact/Activities";
			public const string MainContact_Activities_Files = "MainContact/Activities/Files";
			public const string MainContact_Address = "MainContact/Address";
			public const string MainContact_Attributes = "MainContact/Attributes";
			public const string MainContact_Campaigns = "MainContact/Campaigns";
			public const string MainContact_Campaigns_Files = "MainContact/Campaigns/Files";
			public const string MainContact_Cases = "MainContact/Cases";
			public const string MainContact_Cases_Files = "MainContact/Cases/Files";
			public const string MainContact_Duplicates = "MainContact/Duplicates";
			public const string MainContact_Duplicates_Files = "MainContact/Duplicates/Files";
			public const string MainContact_MarketingLists = "MainContact/MarketingLists";
			public const string MainContact_MarketingLists_Files = "MainContact/MarketingLists/Files";
			public const string MainContact_Notifications = "MainContact/Notifications";
			public const string MainContact_Notifications_Files = "MainContact/Notifications/Files";
			public const string MainContact_Opportunities = "MainContact/Opportunities";
			public const string MainContact_Opportunities_Files = "MainContact/Opportunities/Files";
			public const string MainContact_Relations = "MainContact/Relations";
			public const string MainContact_Relations_Files = "MainContact/Relations/Files";
			public const string MainContact_RoleAssignments = "MainContact/RoleAssignments";
			public const string MainContact_RoleAssignments_Files = "MainContact/RoleAssignments/Files";
			public const string MainContact_UserInfo = "MainContact/UserInfo";
			public const string MainContact_UserInfo_Roles = "MainContact/UserInfo/Roles";
			public const string MainContact_UserInfo_Roles_Files = "MainContact/UserInfo/Roles/Files";
			public const string PaymentInstructions = "PaymentInstructions";
			public const string PaymentInstructions_Files = "PaymentInstructions/Files";
			public const string PrimaryContact = "PrimaryContact";
			public const string PrimaryContact_Activities = "PrimaryContact/Activities";
			public const string PrimaryContact_Activities_Files = "PrimaryContact/Activities/Files";
			public const string PrimaryContact_Address = "PrimaryContact/Address";
			public const string PrimaryContact_Attributes = "PrimaryContact/Attributes";
			public const string PrimaryContact_Campaigns = "PrimaryContact/Campaigns";
			public const string PrimaryContact_Campaigns_Files = "PrimaryContact/Campaigns/Files";
			public const string PrimaryContact_Cases = "PrimaryContact/Cases";
			public const string PrimaryContact_Cases_Files = "PrimaryContact/Cases/Files";
			public const string PrimaryContact_Duplicates = "PrimaryContact/Duplicates";
			public const string PrimaryContact_Duplicates_Files = "PrimaryContact/Duplicates/Files";
			public const string PrimaryContact_MarketingLists = "PrimaryContact/MarketingLists";
			public const string PrimaryContact_MarketingLists_Files = "PrimaryContact/MarketingLists/Files";
			public const string PrimaryContact_Notifications = "PrimaryContact/Notifications";
			public const string PrimaryContact_Notifications_Files = "PrimaryContact/Notifications/Files";
			public const string PrimaryContact_Opportunities = "PrimaryContact/Opportunities";
			public const string PrimaryContact_Opportunities_Files = "PrimaryContact/Opportunities/Files";
			public const string PrimaryContact_Relations = "PrimaryContact/Relations";
			public const string PrimaryContact_Relations_Files = "PrimaryContact/Relations/Files";
			public const string PrimaryContact_RoleAssignments = "PrimaryContact/RoleAssignments";
			public const string PrimaryContact_RoleAssignments_Files = "PrimaryContact/RoleAssignments/Files";
			public const string PrimaryContact_UserInfo = "PrimaryContact/UserInfo";
			public const string PrimaryContact_UserInfo_Roles = "PrimaryContact/UserInfo/Roles";
			public const string PrimaryContact_UserInfo_Roles_Files = "PrimaryContact/UserInfo/Roles/Files";
			public const string RemittanceContact = "RemittanceContact";
			public const string RemittanceContact_Activities = "RemittanceContact/Activities";
			public const string RemittanceContact_Activities_Files = "RemittanceContact/Activities/Files";
			public const string RemittanceContact_Address = "RemittanceContact/Address";
			public const string RemittanceContact_Attributes = "RemittanceContact/Attributes";
			public const string RemittanceContact_Campaigns = "RemittanceContact/Campaigns";
			public const string RemittanceContact_Campaigns_Files = "RemittanceContact/Campaigns/Files";
			public const string RemittanceContact_Cases = "RemittanceContact/Cases";
			public const string RemittanceContact_Cases_Files = "RemittanceContact/Cases/Files";
			public const string RemittanceContact_Duplicates = "RemittanceContact/Duplicates";
			public const string RemittanceContact_Duplicates_Files = "RemittanceContact/Duplicates/Files";
			public const string RemittanceContact_MarketingLists = "RemittanceContact/MarketingLists";
			public const string RemittanceContact_MarketingLists_Files = "RemittanceContact/MarketingLists/Files";
			public const string RemittanceContact_Notifications = "RemittanceContact/Notifications";
			public const string RemittanceContact_Notifications_Files = "RemittanceContact/Notifications/Files";
			public const string RemittanceContact_Opportunities = "RemittanceContact/Opportunities";
			public const string RemittanceContact_Opportunities_Files = "RemittanceContact/Opportunities/Files";
			public const string RemittanceContact_Relations = "RemittanceContact/Relations";
			public const string RemittanceContact_Relations_Files = "RemittanceContact/Relations/Files";
			public const string RemittanceContact_RoleAssignments = "RemittanceContact/RoleAssignments";
			public const string RemittanceContact_RoleAssignments_Files = "RemittanceContact/RoleAssignments/Files";
			public const string RemittanceContact_UserInfo = "RemittanceContact/UserInfo";
			public const string RemittanceContact_UserInfo_Roles = "RemittanceContact/UserInfo/Roles";
			public const string RemittanceContact_UserInfo_Roles_Files = "RemittanceContact/UserInfo/Roles/Files";
			public const string ShippingContact = "ShippingContact";
			public const string ShippingContact_Activities = "ShippingContact/Activities";
			public const string ShippingContact_Activities_Files = "ShippingContact/Activities/Files";
			public const string ShippingContact_Address = "ShippingContact/Address";
			public const string ShippingContact_Attributes = "ShippingContact/Attributes";
			public const string ShippingContact_Campaigns = "ShippingContact/Campaigns";
			public const string ShippingContact_Campaigns_Files = "ShippingContact/Campaigns/Files";
			public const string ShippingContact_Cases = "ShippingContact/Cases";
			public const string ShippingContact_Cases_Files = "ShippingContact/Cases/Files";
			public const string ShippingContact_Duplicates = "ShippingContact/Duplicates";
			public const string ShippingContact_Duplicates_Files = "ShippingContact/Duplicates/Files";
			public const string ShippingContact_MarketingLists = "ShippingContact/MarketingLists";
			public const string ShippingContact_MarketingLists_Files = "ShippingContact/MarketingLists/Files";
			public const string ShippingContact_Notifications = "ShippingContact/Notifications";
			public const string ShippingContact_Notifications_Files = "ShippingContact/Notifications/Files";
			public const string ShippingContact_Opportunities = "ShippingContact/Opportunities";
			public const string ShippingContact_Opportunities_Files = "ShippingContact/Opportunities/Files";
			public const string ShippingContact_Relations = "ShippingContact/Relations";
			public const string ShippingContact_Relations_Files = "ShippingContact/Relations/Files";
			public const string ShippingContact_RoleAssignments = "ShippingContact/RoleAssignments";
			public const string ShippingContact_RoleAssignments_Files = "ShippingContact/RoleAssignments/Files";
			public const string ShippingContact_UserInfo = "ShippingContact/UserInfo";
			public const string ShippingContact_UserInfo_Roles = "ShippingContact/UserInfo/Roles";
			public const string ShippingContact_UserInfo_Roles_Files = "ShippingContact/UserInfo/Roles/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes,Contacts,Contacts/Files,Contacts/Contact,Contacts/Contact/Activities,Contacts/Contact/Activities/Files,Contacts/Contact/Address,Contacts/Contact/Attributes,Contacts/Contact/Campaigns,Contacts/Contact/Campaigns/Files,Contacts/Contact/Cases,Contacts/Contact/Cases/Files,Contacts/Contact/Duplicates,Contacts/Contact/Duplicates/Files,Contacts/Contact/MarketingLists,Contacts/Contact/MarketingLists/Files,Contacts/Contact/Notifications,Contacts/Contact/Notifications/Files,Contacts/Contact/Opportunities,Contacts/Contact/Opportunities/Files,Contacts/Contact/Relations,Contacts/Contact/Relations/Files,Contacts/Contact/RoleAssignments,Contacts/Contact/RoleAssignments/Files,Contacts/Contact/UserInfo,Contacts/Contact/UserInfo/Roles,Contacts/Contact/UserInfo/Roles/Files,MainContact,MainContact/Activities,MainContact/Activities/Files,MainContact/Address,MainContact/Attributes,MainContact/Campaigns,MainContact/Campaigns/Files,MainContact/Cases,MainContact/Cases/Files,MainContact/Duplicates,MainContact/Duplicates/Files,MainContact/MarketingLists,MainContact/MarketingLists/Files,MainContact/Notifications,MainContact/Notifications/Files,MainContact/Opportunities,MainContact/Opportunities/Files,MainContact/Relations,MainContact/Relations/Files,MainContact/RoleAssignments,MainContact/RoleAssignments/Files,MainContact/UserInfo,MainContact/UserInfo/Roles,MainContact/UserInfo/Roles/Files,PaymentInstructions,PaymentInstructions/Files,PrimaryContact,PrimaryContact/Activities,PrimaryContact/Activities/Files,PrimaryContact/Address,PrimaryContact/Attributes,PrimaryContact/Campaigns,PrimaryContact/Campaigns/Files,PrimaryContact/Cases,PrimaryContact/Cases/Files,PrimaryContact/Duplicates,PrimaryContact/Duplicates/Files,PrimaryContact/MarketingLists,PrimaryContact/MarketingLists/Files,PrimaryContact/Notifications,PrimaryContact/Notifications/Files,PrimaryContact/Opportunities,PrimaryContact/Opportunities/Files,PrimaryContact/Relations,PrimaryContact/Relations/Files,PrimaryContact/RoleAssignments,PrimaryContact/RoleAssignments/Files,PrimaryContact/UserInfo,PrimaryContact/UserInfo/Roles,PrimaryContact/UserInfo/Roles/Files,RemittanceContact,RemittanceContact/Activities,RemittanceContact/Activities/Files,RemittanceContact/Address,RemittanceContact/Attributes,RemittanceContact/Campaigns,RemittanceContact/Campaigns/Files,RemittanceContact/Cases,RemittanceContact/Cases/Files,RemittanceContact/Duplicates,RemittanceContact/Duplicates/Files,RemittanceContact/MarketingLists,RemittanceContact/MarketingLists/Files,RemittanceContact/Notifications,RemittanceContact/Notifications/Files,RemittanceContact/Opportunities,RemittanceContact/Opportunities/Files,RemittanceContact/Relations,RemittanceContact/Relations/Files,RemittanceContact/RoleAssignments,RemittanceContact/RoleAssignments/Files,RemittanceContact/UserInfo,RemittanceContact/UserInfo/Roles,RemittanceContact/UserInfo/Roles/Files,ShippingContact,ShippingContact/Activities,ShippingContact/Activities/Files,ShippingContact/Address,ShippingContact/Attributes,ShippingContact/Campaigns,ShippingContact/Campaigns/Files,ShippingContact/Cases,ShippingContact/Cases/Files,ShippingContact/Duplicates,ShippingContact/Duplicates/Files,ShippingContact/MarketingLists,ShippingContact/MarketingLists/Files,ShippingContact/Notifications,ShippingContact/Notifications/Files,ShippingContact/Opportunities,ShippingContact/Opportunities/Files,ShippingContact/Relations,ShippingContact/Relations/Files,ShippingContact/RoleAssignments,ShippingContact/RoleAssignments/Files,ShippingContact/UserInfo,ShippingContact/UserInfo/Roles,ShippingContact/UserInfo/Roles/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}