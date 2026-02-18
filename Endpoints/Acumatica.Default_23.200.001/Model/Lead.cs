using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CR301000</c> in the Acumatica ERP
	/// <para>Key Fields: LeadID</para>
	/// </summary>
	public class Lead : Entity, ITopLevelEntity
	{

		public List<ActivityDetail>? Activities { get; set; }

		public Address? Address { get; set; }

		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The identifier of the related business account.
		/// <para>DAC Field Name: BAccountID</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Business Account</para>
		/// </summary>
		public StringValue? BusinessAccount { get; set; }

		public List<CampaignDetail>? Campaigns { get; set; }

		/// <summary>
		/// The name of the company the contact works for.
		/// <para>DAC Field Name: FullName</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Account Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// The person's preferred method of contact.
		/// <para>DAC Field Name: Method</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Contact Method</para>
		/// <para>SQL Type: varchar(1)</para>
		/// </summary>
		public StringValue? ContactMethod { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the contact should not be called.
		/// <para>DAC Field Name: NoCall</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Do Not Call</para>
		/// </summary>
		public BooleanValue? DoNotCall { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the email of the contact will not be involved in the mass email process.This contact will not receive any notification emails.
		/// <para>DAC Field Name: NoEMail</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Do Not Email</para>
		/// </summary>
		public BooleanValue? DoNotEmail { get; set; }

		public BooleanValue? DoNotFax { get; set; }

		public BooleanValue? DoNotMail { get; set; }

		/// <summary>
		/// The duplicate status of the contact.
		/// <para>DAC Field Name: DuplicateStatus</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Duplicate { get; set; }

		/// <summary>
		/// Specifies whether DuplicateStatus is equal to PossibleDuplicatedwhen the ContactDuplicate feature is enabled.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Duplicate Found</para>
		/// </summary>
		public BooleanValue? DuplicateFound { get; set; }

		public List<DuplicateDetail>? Duplicates { get; set; }

		/// <summary>
		/// The email address of the contact.
		/// <para>DAC Field Name: EMail</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Email { get; set; }

		/// <summary>
		/// The fax number.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? Fax { get; set; }

		/// <summary>
		/// The phone type for the Fax field.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Fax Type</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		public StringValue? FaxType { get; set; }

		/// <summary>
		/// The first name of the person.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: First Name</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? FirstName { get; set; }

		/// <summary>
		/// The job title of the person.
		/// <para>DAC Field Name: Salutation</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Job Title</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? JobTitle { get; set; }

		/// <summary>
		/// The language in which the contact prefers to communicate.
		/// <para>DAC Field Name: LanguageID</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
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
		/// The last name of the person.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
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
		/// <para>DAC Field Name: ClassID</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Lead Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? LeadClass { get; set; }

		/// <summary>
		/// The display name of the contact.Its value is made up of the LastName, FirstName, MidName, andTitle values. The format depends on the PersonNameFormat site setting.
		/// <para>DAC Field Name: DisplayName</para>
		/// <para>DAC: PX.Objects.CR.ContactAccount</para>
		/// <para>Display Name: Contact</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		/// <remarks>
		/// This field is changed when the fields it depends on are changed.
		/// </remarks>
		public StringValue? LeadDisplayName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ContactID</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Lead ID</para>
		/// Key Field
		/// </summary>
		public IntValue? LeadID { get; set; }

		public List<MarketingListDetail>? MarketingLists { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the email of the contact will not be involved in the mass email process.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: No Marketing</para>
		/// </summary>
		public BooleanValue? NoMarketing { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the email of the contact will not be involved in the mass email process.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: No Mass Mail</para>
		/// </summary>
		public BooleanValue? NoMassMail { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID_description</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// </summary>
		public StringValue? OwnerEmployeeName { get; set; }

		public StringValue? ParentAccount { get; set; }

		/// <summary>
		/// The phone number.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Phone 1</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// The phone type for the Phone1 field.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Phone 1 Type</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		public StringValue? Phone1Type { get; set; }

		/// <summary>
		/// The second phone number.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Phone 2</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? Phone2 { get; set; }

		/// <summary>
		/// The phone type for the Phone2 field.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Phone 2 Type</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		public StringValue? Phone2Type { get; set; }

		/// <summary>
		/// The third phone number.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Phone 3</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? Phone3 { get; set; }

		/// <summary>
		/// The phone type for the Phone3 field.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Phone 3 Type</para>
		/// <para>SQL Type: varchar(3)</para>
		/// </summary>
		public StringValue? Phone3Type { get; set; }

		/// <summary>
		/// The reason why the Status field of this lead has been changed.
		/// <para>DAC Field Name: Resolution</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Reason { get; set; }

		public List<RelationDetail>? Relations { get; set; }

		/// <summary>
		/// The source of the lead.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
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
		/// The status of the lead.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public StringValue? Title { get; set; }

		/// <summary>
		/// The URL of the contact website.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Web</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? WebSite { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// <para>DAC Field Name: WorkgroupID</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// </summary>
		public StringValue? Workgroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkgroupID_description</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// </summary>
		public StringValue? WorkgroupDescription { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// Specifies whether the current contact is active and can be specified in documents.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// </summary>
		/// <remarks>
		/// Only active contacts can be specified in such documents asCROpportunity, CRCase, CRQuote, PMQuote.The duplicate validation feature ContactDuplicate works only with active contacts.
		/// </remarks>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// An alphanumeric string of up to 255 characters that describes the lead.This field is used to add any additional information about the lead.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The identifier of the contact that is associated with this lead.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Contact</para>
		/// </summary>
		public IntValue? RefContactID { get; set; }

		public StringValue? ConvertedBy { get; set; }

		public DateTimeValue? QualificationDate { get; set; }

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
			public const string Duplicates = "Duplicates";
			public const string Duplicates_Files = "Duplicates/Files";
			public const string MarketingLists = "MarketingLists";
			public const string MarketingLists_Files = "MarketingLists/Files";
			public const string Relations = "Relations";
			public const string Relations_Files = "Relations/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Activities,Activities/Files,Address,Attributes,Campaigns,Campaigns/Files,Duplicates,Duplicates/Files,MarketingLists,MarketingLists/Files,Relations,Relations/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}