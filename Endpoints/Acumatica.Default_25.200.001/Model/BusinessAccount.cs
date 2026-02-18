using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CR303000</c> in the Acumatica ERP
	/// <para>Key Fields: BusinessAccountID</para>
	/// </summary>
	public class BusinessAccount : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The external reference number of the business account.
		/// <para>DAC Field Name: AcctReferenceNbr</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Ext. Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		/// <remarks>
		/// It can be an additional number of the business account used in external integration.            
		/// </remarks>
		public StringValue? AccountRef { get; set; }

		public List<ActivityDetail>? Activities { get; set; }

		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The human-readable identifier of the business account that isspecified by the user or defined by the auto-numbering sequence during thecreation of the account. This field is a natural key, as opposedto the surrogate key BAccountID.
		/// <para>DAC Field Name: AcctCD</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Account ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? BusinessAccountID { get; set; }

		public List<CampaignDetail>? Campaigns { get; set; }

		public List<BusinessAccountCaseDetail>? Cases { get; set; }

		/// <summary>
		/// Identifier of the business acccount class to which the business account belongs.
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Business Account Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ClassID { get; set; }

		public List<BusinessAccountContact>? Contacts { get; set; }

		public List<BusinessAccountContract>? Contracts { get; set; }

		public BusinessAccountDefaultLocationSetting? DefaultLocationSettings { get; set; }

		public StringValue? Duplicate { get; set; }

		public List<DuplicateDetail>? Duplicates { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastIncomingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Incoming Activity</para>
		/// </summary>
		public DateTimeValue? LastIncomingActivity { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Last Modified On</para>
		/// </summary>
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastOutgoingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Outgoing Activity</para>
		/// </summary>
		public DateTimeValue? LastOutgoingActivity { get; set; }

		public List<BusinessAccountLocation>? Locations { get; set; }

		public Address? MainAddress { get; set; }

		/// <summary>
		/// If set to true, this field indicates that the address has been successfully validated by Acumatica ERP.
		/// <para>DAC Field Name: IsValidated</para>
		/// <para>DAC: PX.Objects.CR.Address</para>
		/// <para>Display Name: Validated</para>
		/// </summary>
		public BooleanValue? MainAddressValidated { get; set; }

		public BusinessAccountMainContact? MainContact { get; set; }

		public List<MarketingListDetail>? MarketingLists { get; set; }

		/// <summary>
		/// The full business account name (as opposed to theshort identifier AcctCD).
		/// <para>DAC Field Name: AcctName</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Account Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Name { get; set; }

		public List<BusinessAccountOpportunityDetail>? Opportunities { get; set; }

		public List<BusinessAccountOrder>? Orders { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID_description</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// </summary>
		public StringValue? OwnerEmployeeName { get; set; }

		/// <summary>
		/// The identifier of the parent business account.
		/// <para>DAC Field Name: ParentBAccountID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Parent Account</para>
		/// </summary>
		public StringValue? ParentAccount { get; set; }

		public Contact? PrimaryContact { get; set; }

		public List<RelationDetail>? Relations { get; set; }

		public Address? ShippingAddress { get; set; }

		/// <summary>
		/// If set to true, indicates that the addressoverrides the default Address record, which isreferenced by DefAddressID.
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		public BooleanValue? ShippingAddressOverride { get; set; }

		/// <summary>
		/// If set to true, this field indicates that the address has been successfully validated by Acumatica ERP.
		/// <para>DAC Field Name: IsValidated</para>
		/// <para>DAC: PX.Objects.CR.Address</para>
		/// <para>Display Name: Validated</para>
		/// </summary>
		public BooleanValue? ShippingAddressValidated { get; set; }

		public BusinessAccountShippingContact? ShippingContact { get; set; }

		/// <summary>
		/// The identifier of the marketing or sales campaign that resulted in creation of the business account.
		/// <para>DAC Field Name: CampaignSourceID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Source Campaign</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? SourceCampaign { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Customer Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// Represents the type of the business account.
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// <para>DAC Field Name: WorkgroupID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// </summary>
		public StringValue? Workgroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkgroupID_description</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// </summary>
		public StringValue? WorkgroupDescription { get; set; }

		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// The identifier of the Currency,which is applied to the documents of the business account.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// If set to true, indicates that the currencyof business account documents (which is specified by CuryID)can be overridden by a user during document entry.
		/// <para>DAC Field Name: AllowOverrideCury</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Enable Currency Override</para>
		/// </summary>
		public BooleanValue? EnableCurrencyOverride { get; set; }

		public StringValue? LocaleName { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Activities = "Activities";
			public const string Activities_Files = "Activities/Files";
			public const string Attributes = "Attributes";
			public const string Campaigns = "Campaigns";
			public const string Campaigns_Files = "Campaigns/Files";
			public const string Cases = "Cases";
			public const string Cases_Files = "Cases/Files";
			public const string Contacts = "Contacts";
			public const string Contacts_Files = "Contacts/Files";
			public const string Contracts = "Contracts";
			public const string Contracts_Files = "Contracts/Files";
			public const string DefaultLocationSettings = "DefaultLocationSettings";
			public const string Duplicates = "Duplicates";
			public const string Duplicates_Files = "Duplicates/Files";
			public const string Locations = "Locations";
			public const string Locations_Files = "Locations/Files";
			public const string MainAddress = "MainAddress";
			public const string MainContact = "MainContact";
			public const string MarketingLists = "MarketingLists";
			public const string MarketingLists_Files = "MarketingLists/Files";
			public const string Opportunities = "Opportunities";
			public const string Opportunities_Files = "Opportunities/Files";
			public const string Orders = "Orders";
			public const string Orders_Files = "Orders/Files";
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
			public const string Relations = "Relations";
			public const string Relations_Files = "Relations/Files";
			public const string ShippingAddress = "ShippingAddress";
			public const string ShippingContact = "ShippingContact";

			//Intentionally excluded
			//public const string All = "Files,Translations,Activities,Activities/Files,Attributes,Campaigns,Campaigns/Files,Cases,Cases/Files,Contacts,Contacts/Files,Contracts,Contracts/Files,DefaultLocationSettings,Duplicates,Duplicates/Files,Locations,Locations/Files,MainAddress,MainContact,MarketingLists,MarketingLists/Files,Opportunities,Opportunities/Files,Orders,Orders/Files,PrimaryContact,PrimaryContact/Activities,PrimaryContact/Activities/Files,PrimaryContact/Address,PrimaryContact/Attributes,PrimaryContact/Campaigns,PrimaryContact/Campaigns/Files,PrimaryContact/Cases,PrimaryContact/Cases/Files,PrimaryContact/Duplicates,PrimaryContact/Duplicates/Files,PrimaryContact/MarketingLists,PrimaryContact/MarketingLists/Files,PrimaryContact/Notifications,PrimaryContact/Notifications/Files,PrimaryContact/Opportunities,PrimaryContact/Opportunities/Files,PrimaryContact/Relations,PrimaryContact/Relations/Files,PrimaryContact/RoleAssignments,PrimaryContact/RoleAssignments/Files,PrimaryContact/UserInfo,PrimaryContact/UserInfo/Roles,PrimaryContact/UserInfo/Roles/Files,Relations,Relations/Files,ShippingAddress,ShippingContact";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}