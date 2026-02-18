using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CR302000</c> in the Acumatica ERP
	/// <para>Key Fields: ContactID</para>
	/// </summary>
	public class Contact : Entity, ITopLevelEntity
	{

		public BooleanValue? Active { get; set; }

		public List<ActivityDetail>? Activities { get; set; }

		public Address? Address { get; set; }

		/// <summary>
		/// Specifies whether the address information of this contact differs from the address informationof the business account associated with this contact.IF it is so, the address information is synchronized with the associatedbusiness account.
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Override Address</para>
		/// </summary>
		/// <remarks>
		/// The behavior is controlled by the ContactBAccountSharedAddressOverrideGraphExtgraph extension.
		/// </remarks>
		public BooleanValue? OverrideAccountAddress { get; set; }

		/// <summary>
		/// If set to true, this field indicates that the address has been successfully validated by Acumatica ERP.
		/// <para>DAC Field Name: IsValidated</para>
		/// <para>DAC: PX.Objects.CR.Address</para>
		/// <para>Display Name: Validated</para>
		/// </summary>
		public BooleanValue? AddressValidated { get; set; }

		public StringValue? Attention { get; set; }

		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The identifier of the related business account.
		/// <para>DAC Field Name: BAccountID</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Business Account</para>
		/// </summary>
		public StringValue? BusinessAccount { get; set; }

		public List<CampaignDetail>? Campaigns { get; set; }

		public List<CaseDetail>? Cases { get; set; }

		/// <summary>
		/// The name of the company the contact works for.
		/// <para>DAC Field Name: FullName</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Account Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// The identifier of the class.
		/// <para>DAC Field Name: ClassID</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Contact Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ContactClass { get; set; }

		/// <summary>
		/// The identifier of the contact.This field is the key field.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Contact ID</para>
		/// Key Field
		/// </summary>
		public IntValue? ContactID { get; set; }

		/// <summary>
		/// The person's preferred method of contact.
		/// <para>DAC Field Name: Method</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Contact Method</para>
		/// <para>SQL Type: varchar(1)</para>
		/// </summary>
		public StringValue? ContactMethod { get; set; }

		public StringValue? ConvertedBy { get; set; }

		/// <summary>
		/// The date of birth.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Date Of Birth</para>
		/// </summary>
		public DateTimeValue? DateOfBirth { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.Extensions.CRCreateActions.PopupAttributes</para>
		/// <para>Display Name: Name</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? DisplayName { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the contact should not be called.
		/// <para>DAC Field Name: NoCall</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Do Not Call</para>
		/// </summary>
		public BooleanValue? DoNotCall { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the email of the contact will not be involved in the mass email process.This contact will not receive any notification emails.
		/// <para>DAC Field Name: NoEMail</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Do Not Email</para>
		/// </summary>
		public BooleanValue? DoNotEmail { get; set; }

		public BooleanValue? DoNotFax { get; set; }

		public BooleanValue? DoNotMail { get; set; }

		/// <summary>
		/// The duplicate status of the contact.
		/// <para>DAC Field Name: DuplicateStatus</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Duplicate { get; set; }

		/// <summary>
		/// Specifies whether DuplicateStatus is equal to PossibleDuplicatedwhen the ContactDuplicate feature is enabled.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Duplicate Found</para>
		/// </summary>
		public BooleanValue? DuplicateFound { get; set; }

		public List<ContactDuplicateDetail>? Duplicates { get; set; }

		/// <summary>
		/// The email address of the contact.
		/// <para>DAC Field Name: EMail</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Email { get; set; }

		/// <summary>
		/// The fax number.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? Fax { get; set; }

		/// <summary>
		/// The phone type for the Fax field.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Fax Type</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		public StringValue? FaxType { get; set; }

		/// <summary>
		/// The first name of the person.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: First Name</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? FirstName { get; set; }

		/// <summary>
		/// The gender of the contact.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Gender { get; set; }

		/// <summary>
		/// The image attached to the contact.
		/// <para>DAC Field Name: Img</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? Image { get; set; }

		/// <summary>
		/// The job title of the person.
		/// <para>DAC Field Name: Salutation</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Job Title</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? JobTitle { get; set; }

		/// <summary>
		/// The language in which the contact prefers to communicate.
		/// <para>DAC Field Name: LanguageID</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Language/Locale</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? LanguageOrLocale { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastIncomingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Incoming Activity</para>
		/// </summary>
		public DateTimeValue? LastIncomingActivity { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Last Modified On</para>
		/// </summary>
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The last name of the person.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Last Name</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? LastName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastOutgoingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Outgoing Activity</para>
		/// </summary>
		public DateTimeValue? LastOutgoingActivity { get; set; }

		/// <summary>
		/// The marital status of the contact.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Marital Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? MaritalStatus { get; set; }

		public List<MarketingListDetail>? MarketingLists { get; set; }

		public StringValue? MiddleName { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the email of the contact will not be involved in the mass email process.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: No Marketing</para>
		/// </summary>
		public BooleanValue? NoMarketing { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the email of the contact will not be involved in the mass email process.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: No Mass Mail</para>
		/// </summary>
		public BooleanValue? NoMassMail { get; set; }

		public List<ContactNotification>? Notifications { get; set; }

		public List<OpportunityDetail>? Opportunities { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID_description</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// </summary>
		public StringValue? OwnerEmployeeName { get; set; }

		/// <summary>
		/// The identifier of the account that is considered as parent for the current account (BAccountID).
		/// <para>DAC Field Name: ParentBAccountID</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Parent Account</para>
		/// </summary>
		/// <remarks>
		/// There is no business logic in the application for this field.
		/// </remarks>
		public StringValue? ParentAccount { get; set; }

		/// <summary>
		/// The phone number.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Phone 1</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// The phone type for the Phone1 field.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Phone 1 Type</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		public StringValue? Phone1Type { get; set; }

		/// <summary>
		/// The second phone number.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Phone 2</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? Phone2 { get; set; }

		/// <summary>
		/// The phone type for the Phone2 field.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Phone 2 Type</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		public StringValue? Phone2Type { get; set; }

		/// <summary>
		/// The third phone number.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Phone 3</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? Phone3 { get; set; }

		/// <summary>
		/// The phone type for the Phone3 field.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Phone 3 Type</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		public StringValue? Phone3Type { get; set; }

		public DateTimeValue? QualificationDate { get; set; }

		/// <summary>
		/// The reason why the case has been changed to the current status.
		/// <para>DAC Field Name: Resolution</para>
		/// <para>DAC: PX.Objects.CR.CRCase</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Reason { get; set; }

		public List<RelationDetail>? Relations { get; set; }

		public List<BCRoleAssignment>? RoleAssignments { get; set; }

		/// <summary>
		/// The source of the contact. If a contact was created from a lead,the value is copied from the lead related to the contact.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Source { get; set; }

		/// <summary>
		/// The identifier of the campaign that resulted in creation of the contact.
		/// <para>DAC Field Name: CampaignID</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Source Campaign</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? SourceCampaign { get; set; }

		/// <summary>
		/// The name of the spouse or partner of the contact.
		/// <para>DAC Field Name: Spouse</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Spouse/Partner Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? SpouseOrPartnerName { get; set; }

		/// <summary>
		/// The status of the contact.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// Specifies whether the contact should be included in exchange synchronization.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Synchronize with Exchange</para>
		/// </summary>
		public BooleanValue? Synchronize { get; set; }

		public StringValue? Title { get; set; }

		public StringValue? Type { get; set; }

		public ContactUserInfo? UserInfo { get; set; }

		/// <summary>
		/// The URL of the contact website.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Web</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? WebSite { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// <para>DAC Field Name: WorkgroupID</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// </summary>
		public StringValue? Workgroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkgroupID_description</para>
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// </summary>
		public StringValue? WorkgroupDescription { get; set; }

		public GuidValue? NoteID { get; set; }

		public StringValue? FullName { get; set; }

		/// <summary>
		/// The external reference number of the contact.It can be an additional number of the contact used in external integration.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Ext. Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(40)</para>
		/// </summary>
		public StringValue? ExtRefNbr { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Activities = "Activities";
			public const string Activities_Files = "Activities/Files";
			public const string Address = "Address";
			public const string Attributes = "Attributes";
			public const string Campaigns = "Campaigns";
			public const string Campaigns_Files = "Campaigns/Files";
			public const string Cases = "Cases";
			public const string Cases_Files = "Cases/Files";
			public const string Duplicates = "Duplicates";
			public const string Duplicates_Files = "Duplicates/Files";
			public const string MarketingLists = "MarketingLists";
			public const string MarketingLists_Files = "MarketingLists/Files";
			public const string Notifications = "Notifications";
			public const string Notifications_Files = "Notifications/Files";
			public const string Opportunities = "Opportunities";
			public const string Opportunities_Files = "Opportunities/Files";
			public const string Relations = "Relations";
			public const string Relations_Files = "Relations/Files";
			public const string RoleAssignments = "RoleAssignments";
			public const string RoleAssignments_Files = "RoleAssignments/Files";
			public const string UserInfo = "UserInfo";
			public const string UserInfo_Roles = "UserInfo/Roles";
			public const string UserInfo_Roles_Files = "UserInfo/Roles/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Activities,Activities/Files,Address,Attributes,Campaigns,Campaigns/Files,Cases,Cases/Files,Duplicates,Duplicates/Files,MarketingLists,MarketingLists/Files,Notifications,Notifications/Files,Opportunities,Opportunities/Files,Relations,Relations/Files,RoleAssignments,RoleAssignments/Files,UserInfo,UserInfo/Roles,UserInfo/Roles/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}