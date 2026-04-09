using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class Customer : Entity, ITopLevelEntity
	{

		[DataMember(Name="AccountRef", EmitDefaultValue=false)]
		public StringValue? AccountRef { get; set; }

		[DataMember(Name="ApplyOverdueCharges", EmitDefaultValue=false)]
		public BooleanValue? ApplyOverdueCharges { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		[DataMember(Name="AutoApplyPayments", EmitDefaultValue=false)]
		public BooleanValue? AutoApplyPayments { get; set; }

		[DataMember(Name="BAccountID", EmitDefaultValue=false)]
		public IntValue? BAccountID { get; set; }

		[DataMember(Name="BillingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? BillingAddressOverride { get; set; }

		[DataMember(Name="BillingContact", EmitDefaultValue=false)]
		public Contact? BillingContact { get; set; }

		[DataMember(Name="BillingContactOverride", EmitDefaultValue=false)]
		public BooleanValue? BillingContactOverride { get; set; }

		[DataMember(Name="Contacts", EmitDefaultValue=false)]
		public List<CustomerContact>? Contacts { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="CreditVerificationRules", EmitDefaultValue=false)]
		public CreditVerificationRules? CreditVerificationRules { get; set; }

		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		[DataMember(Name="CurrencyRateType", EmitDefaultValue=false)]
		public StringValue? CurrencyRateType { get; set; }

		[DataMember(Name="CustomerClass", EmitDefaultValue=false)]
		public StringValue? CustomerClass { get; set; }

		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		[DataMember(Name="CustomerCategory", EmitDefaultValue=false)]
		public StringValue? CustomerCategory { get; set; }

		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue? CustomerName { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableCurrencyOverride { get; set; }

		[DataMember(Name="EnableRateOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableRateOverride { get; set; }

		[DataMember(Name="EnableWriteOffs", EmitDefaultValue=false)]
		public BooleanValue? EnableWriteOffs { get; set; }

		[DataMember(Name="FOBPoint", EmitDefaultValue=false)]
		public StringValue? FOBPoint { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="LeadTimedays", EmitDefaultValue=false)]
		public ShortValue? LeadTimedays { get; set; }

		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue? LocationName { get; set; }

		[DataMember(Name="MainContact", EmitDefaultValue=false)]
		public Contact? MainContact { get; set; }

		[DataMember(Name="MultiCurrencyStatements", EmitDefaultValue=false)]
		public BooleanValue? MultiCurrencyStatements { get; set; }

		[DataMember(Name="OrderPriority", EmitDefaultValue=false)]
		public ShortValue? OrderPriority { get; set; }

		[DataMember(Name="ParentRecord", EmitDefaultValue=false)]
		public StringValue? ParentRecord { get; set; }

		[DataMember(Name="PaymentInstructions", EmitDefaultValue=false)]
		public List<BusinessAccountPaymentInstructionDetail>? PaymentInstructions { get; set; }

		[DataMember(Name="PriceClassID", EmitDefaultValue=false)]
		public StringValue? PriceClassID { get; set; }

		[DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
		public Contact? PrimaryContact { get; set; }

		[DataMember(Name="PrimaryContactID", EmitDefaultValue=false)]
		public IntValue? PrimaryContactID { get; set; }

		[DataMember(Name="PrintDunningLetters", EmitDefaultValue=false)]
		public BooleanValue? PrintDunningLetters { get; set; }

		[DataMember(Name="PrintInvoices", EmitDefaultValue=false)]
		public BooleanValue? PrintInvoices { get; set; }

		[DataMember(Name="PrintStatements", EmitDefaultValue=false)]
		public BooleanValue? PrintStatements { get; set; }

		[DataMember(Name="ResidentialDelivery", EmitDefaultValue=false)]
		public BooleanValue? ResidentialDelivery { get; set; }

		[DataMember(Name="Salespersons", EmitDefaultValue=false)]
		public List<CustomerSalesPerson>? Salespersons { get; set; }

		[DataMember(Name="SaturdayDelivery", EmitDefaultValue=false)]
		public BooleanValue? SaturdayDelivery { get; set; }

		[DataMember(Name="SendDunningLettersbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendDunningLettersbyEmail { get; set; }

		[DataMember(Name="SendInvoicesbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendInvoicesbyEmail { get; set; }

		[DataMember(Name="SendStatementsbyEmail", EmitDefaultValue=false)]
		public BooleanValue? SendStatementsbyEmail { get; set; }

		[DataMember(Name="ShippingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingAddressOverride { get; set; }

		[DataMember(Name="ShippingBranch", EmitDefaultValue=false)]
		public StringValue? ShippingBranch { get; set; }

		[DataMember(Name="ShippingContact", EmitDefaultValue=false)]
		public Contact? ShippingContact { get; set; }

		[DataMember(Name="ShippingContactOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingContactOverride { get; set; }

		[DataMember(Name="ShippingRule", EmitDefaultValue=false)]
		public StringValue? ShippingRule { get; set; }

		[DataMember(Name="ShippingTerms", EmitDefaultValue=false)]
		public StringValue? ShippingTerms { get; set; }

		[DataMember(Name="ShippingZoneID", EmitDefaultValue=false)]
		public StringValue? ShippingZoneID { get; set; }

		[DataMember(Name="ShipVia", EmitDefaultValue=false)]
		public StringValue? ShipVia { get; set; }

		[DataMember(Name="StatementCycleID", EmitDefaultValue=false)]
		public StringValue? StatementCycleID { get; set; }

		[DataMember(Name="StatementType", EmitDefaultValue=false)]
		public StringValue? StatementType { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		[DataMember(Name="TaxRegistrationID", EmitDefaultValue=false)]
		public StringValue? TaxRegistrationID { get; set; }

		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

		[DataMember(Name="Terms", EmitDefaultValue=false)]
		public StringValue? Terms { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		[DataMember(Name="WriteOffLimit", EmitDefaultValue=false)]
		public DecimalValue? WriteOffLimit { get; set; }

		[DataMember(Name="RestrictVisibilityTo", EmitDefaultValue=false)]
		public StringValue? RestrictVisibilityTo { get; set; }

		[DataMember(Name="CreditLimit", EmitDefaultValue=false)]
		public DecimalValue? CreditLimit { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		[DataMember(Name="EntityUsageType", EmitDefaultValue=false)]
		public StringValue? EntityUsageType { get; set; }

		[DataMember(Name="TaxExemptionNumber", EmitDefaultValue=false)]
		public StringValue? TaxExemptionNumber { get; set; }

		[DataMember(Name="IsGuestCustomer", EmitDefaultValue=false)]
		public BooleanValue? IsGuestCustomer { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";
			public const string BillingContact = "BillingContact";
			public const string BillingContact_Activities = "BillingContact/Activities";
			public const string BillingContact_Activities_Files = "BillingContact/Activities/Files";
			public const string BillingContact_Address = "BillingContact/Address";
			public const string BillingContact_Attributes = "BillingContact/Attributes";
			public const string BillingContact_Campaigns = "BillingContact/Campaigns";
			public const string BillingContact_Campaigns_Files = "BillingContact/Campaigns/Files";
			public const string BillingContact_Cases = "BillingContact/Cases";
			public const string BillingContact_Cases_Files = "BillingContact/Cases/Files";
			public const string BillingContact_Duplicates = "BillingContact/Duplicates";
			public const string BillingContact_Duplicates_Files = "BillingContact/Duplicates/Files";
			public const string BillingContact_MarketingLists = "BillingContact/MarketingLists";
			public const string BillingContact_MarketingLists_Files = "BillingContact/MarketingLists/Files";
			public const string BillingContact_Notifications = "BillingContact/Notifications";
			public const string BillingContact_Notifications_Files = "BillingContact/Notifications/Files";
			public const string BillingContact_Opportunities = "BillingContact/Opportunities";
			public const string BillingContact_Opportunities_Files = "BillingContact/Opportunities/Files";
			public const string BillingContact_Relations = "BillingContact/Relations";
			public const string BillingContact_Relations_Files = "BillingContact/Relations/Files";
			public const string BillingContact_RoleAssignments = "BillingContact/RoleAssignments";
			public const string BillingContact_RoleAssignments_Files = "BillingContact/RoleAssignments/Files";
			public const string BillingContact_UserInfo = "BillingContact/UserInfo";
			public const string BillingContact_UserInfo_Roles = "BillingContact/UserInfo/Roles";
			public const string BillingContact_UserInfo_Roles_Files = "BillingContact/UserInfo/Roles/Files";
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
			public const string CreditVerificationRules = "CreditVerificationRules";
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
			public const string Salespersons = "Salespersons";
			public const string Salespersons_Files = "Salespersons/Files";
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
			//public const string All = "Files,Translations,Attributes,BillingContact,BillingContact/Activities,BillingContact/Activities/Files,BillingContact/Address,BillingContact/Attributes,BillingContact/Campaigns,BillingContact/Campaigns/Files,BillingContact/Cases,BillingContact/Cases/Files,BillingContact/Duplicates,BillingContact/Duplicates/Files,BillingContact/MarketingLists,BillingContact/MarketingLists/Files,BillingContact/Notifications,BillingContact/Notifications/Files,BillingContact/Opportunities,BillingContact/Opportunities/Files,BillingContact/Relations,BillingContact/Relations/Files,BillingContact/RoleAssignments,BillingContact/RoleAssignments/Files,BillingContact/UserInfo,BillingContact/UserInfo/Roles,BillingContact/UserInfo/Roles/Files,Contacts,Contacts/Files,Contacts/Contact,Contacts/Contact/Activities,Contacts/Contact/Activities/Files,Contacts/Contact/Address,Contacts/Contact/Attributes,Contacts/Contact/Campaigns,Contacts/Contact/Campaigns/Files,Contacts/Contact/Cases,Contacts/Contact/Cases/Files,Contacts/Contact/Duplicates,Contacts/Contact/Duplicates/Files,Contacts/Contact/MarketingLists,Contacts/Contact/MarketingLists/Files,Contacts/Contact/Notifications,Contacts/Contact/Notifications/Files,Contacts/Contact/Opportunities,Contacts/Contact/Opportunities/Files,Contacts/Contact/Relations,Contacts/Contact/Relations/Files,Contacts/Contact/RoleAssignments,Contacts/Contact/RoleAssignments/Files,Contacts/Contact/UserInfo,Contacts/Contact/UserInfo/Roles,Contacts/Contact/UserInfo/Roles/Files,CreditVerificationRules,MainContact,MainContact/Activities,MainContact/Activities/Files,MainContact/Address,MainContact/Attributes,MainContact/Campaigns,MainContact/Campaigns/Files,MainContact/Cases,MainContact/Cases/Files,MainContact/Duplicates,MainContact/Duplicates/Files,MainContact/MarketingLists,MainContact/MarketingLists/Files,MainContact/Notifications,MainContact/Notifications/Files,MainContact/Opportunities,MainContact/Opportunities/Files,MainContact/Relations,MainContact/Relations/Files,MainContact/RoleAssignments,MainContact/RoleAssignments/Files,MainContact/UserInfo,MainContact/UserInfo/Roles,MainContact/UserInfo/Roles/Files,PaymentInstructions,PaymentInstructions/Files,PrimaryContact,PrimaryContact/Activities,PrimaryContact/Activities/Files,PrimaryContact/Address,PrimaryContact/Attributes,PrimaryContact/Campaigns,PrimaryContact/Campaigns/Files,PrimaryContact/Cases,PrimaryContact/Cases/Files,PrimaryContact/Duplicates,PrimaryContact/Duplicates/Files,PrimaryContact/MarketingLists,PrimaryContact/MarketingLists/Files,PrimaryContact/Notifications,PrimaryContact/Notifications/Files,PrimaryContact/Opportunities,PrimaryContact/Opportunities/Files,PrimaryContact/Relations,PrimaryContact/Relations/Files,PrimaryContact/RoleAssignments,PrimaryContact/RoleAssignments/Files,PrimaryContact/UserInfo,PrimaryContact/UserInfo/Roles,PrimaryContact/UserInfo/Roles/Files,Salespersons,Salespersons/Files,ShippingContact,ShippingContact/Activities,ShippingContact/Activities/Files,ShippingContact/Address,ShippingContact/Attributes,ShippingContact/Campaigns,ShippingContact/Campaigns/Files,ShippingContact/Cases,ShippingContact/Cases/Files,ShippingContact/Duplicates,ShippingContact/Duplicates/Files,ShippingContact/MarketingLists,ShippingContact/MarketingLists/Files,ShippingContact/Notifications,ShippingContact/Notifications/Files,ShippingContact/Opportunities,ShippingContact/Opportunities/Files,ShippingContact/Relations,ShippingContact/Relations/Files,ShippingContact/RoleAssignments,ShippingContact/RoleAssignments/Files,ShippingContact/UserInfo,ShippingContact/UserInfo/Roles,ShippingContact/UserInfo/Roles/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}