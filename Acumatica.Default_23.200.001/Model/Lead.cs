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
	/// Corresponds to the screen CR301000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Lead : Entity, ITopLevelEntity
	{

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail>? Activities { get; set; }

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public Address? Address { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The identifier of the related business account.
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Business Account 
		/// </summary>
		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		[DataMember(Name="Campaigns", EmitDefaultValue=false)]
		public List<CampaignDetail>? Campaigns { get; set; }

		/// <summary>
		/// The name of the company the contact works for.
		/// DAC Field Name: FullName 
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Account Name 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// The person's preferred method of contact.
		/// DAC Field Name: Method 
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Contact Method 
		/// SQL Type: varchar(1) 
		/// </summary>
		[DataMember(Name="ContactMethod", EmitDefaultValue=false)]
		public StringValue? ContactMethod { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the contact should not be called.
		/// DAC Field Name: NoCall 
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Do Not Call 
		/// </summary>
		[DataMember(Name="DoNotCall", EmitDefaultValue=false)]
		public BooleanValue? DoNotCall { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the email of the contact will not be involved in the mass email process.This contact will not receive any notification emails.
		/// DAC Field Name: NoEMail 
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Do Not Email 
		/// </summary>
		[DataMember(Name="DoNotEmail", EmitDefaultValue=false)]
		public BooleanValue? DoNotEmail { get; set; }

		[DataMember(Name="DoNotFax", EmitDefaultValue=false)]
		public BooleanValue? DoNotFax { get; set; }

		[DataMember(Name="DoNotMail", EmitDefaultValue=false)]
		public BooleanValue? DoNotMail { get; set; }

		/// <summary>
		/// The duplicate status of the contact.
		/// DAC Field Name: DuplicateStatus 
		/// DAC: PX.Objects.CR.CRLead 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Duplicate", EmitDefaultValue=false)]
		public StringValue? Duplicate { get; set; }

		/// <summary>
		/// Specifies whether DuplicateStatus is equal to PossibleDuplicatedwhen the ContactDuplicate feature is enabled.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Duplicate Found 
		/// </summary>
		[DataMember(Name="DuplicateFound", EmitDefaultValue=false)]
		public BooleanValue? DuplicateFound { get; set; }

		[DataMember(Name="Duplicates", EmitDefaultValue=false)]
		public List<DuplicateDetail>? Duplicates { get; set; }

		/// <summary>
		/// The email address of the contact.
		/// DAC Field Name: EMail 
		/// DAC: PX.Objects.CR.CRLead 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// The fax number.
		/// DAC: PX.Objects.CR.CRLead 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Fax", EmitDefaultValue=false)]
		public StringValue? Fax { get; set; }

		/// <summary>
		/// The phone type for the Fax field.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Fax Type 
		/// SQL Type: varchar(3) 
		/// </summary>
		[DataMember(Name="FaxType", EmitDefaultValue=false)]
		public StringValue? FaxType { get; set; }

		/// <summary>
		/// The first name of the person.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: First Name 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="FirstName", EmitDefaultValue=false)]
		public StringValue? FirstName { get; set; }

		/// <summary>
		/// The job title of the person.
		/// DAC Field Name: Salutation 
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Job Title 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="JobTitle", EmitDefaultValue=false)]
		public StringValue? JobTitle { get; set; }

		/// <summary>
		/// The language in which the contact prefers to communicate.
		/// DAC Field Name: LanguageID 
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Language/Locale 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="LanguageOrLocale", EmitDefaultValue=false)]
		public StringValue? LanguageOrLocale { get; set; }

		/// <summary>
		/// DAC Field Name: LastIncomingActivityDate 
		/// DAC: PX.Objects.CR.CRActivityStatistics 
		/// Display Name: Last Incoming Activity 
		/// </summary>
		[DataMember(Name="LastIncomingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastIncomingActivity { get; set; }

		/// <summary>
		/// The last name of the person.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Last Name 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LastName", EmitDefaultValue=false)]
		public StringValue? LastName { get; set; }

		/// <summary>
		/// DAC Field Name: LastOutgoingActivityDate 
		/// DAC: PX.Objects.CR.CRActivityStatistics 
		/// Display Name: Last Outgoing Activity 
		/// </summary>
		[DataMember(Name="LastOutgoingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastOutgoingActivity { get; set; }

		/// <summary>
		/// DAC Field Name: ClassID 
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Lead Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="LeadClass", EmitDefaultValue=false)]
		public StringValue? LeadClass { get; set; }

		/// <summary>
		/// The display name of the contact.Its value is made up of the LastName, FirstName, MidName, andTitle values. The format depends on the PersonNameFormat site setting.
		/// DAC Field Name: DisplayName 
		/// DAC: PX.Objects.CR.ContactAccount 
		/// Display Name: Contact 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		/// <remarks>
		/// This field is changed when the fields it depends on are changed.
		/// </remarks>
		[DataMember(Name="LeadDisplayName", EmitDefaultValue=false)]
		public StringValue? LeadDisplayName { get; set; }

		/// <summary>
		/// DAC Field Name: ContactID 
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Lead ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="LeadID", EmitDefaultValue=false)]
		public IntValue? LeadID { get; set; }

		[DataMember(Name="MarketingLists", EmitDefaultValue=false)]
		public List<MarketingListDetail>? MarketingLists { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the email of the contact will not be involved in the mass email process.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: No Marketing 
		/// </summary>
		[DataMember(Name="NoMarketing", EmitDefaultValue=false)]
		public BooleanValue? NoMarketing { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the email of the contact will not be involved in the mass email process.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: No Mass Mail 
		/// </summary>
		[DataMember(Name="NoMassMail", EmitDefaultValue=false)]
		public BooleanValue? NoMassMail { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.CRLead 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// DAC Field Name: OwnerID_description 
		/// DAC: PX.Objects.CR.CRLead 
		/// </summary>
		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue? OwnerEmployeeName { get; set; }

		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue? ParentAccount { get; set; }

		/// <summary>
		/// The phone number.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Phone 1 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// The phone type for the Phone1 field.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Phone 1 Type 
		/// SQL Type: varchar(3) 
		/// </summary>
		[DataMember(Name="Phone1Type", EmitDefaultValue=false)]
		public StringValue? Phone1Type { get; set; }

		/// <summary>
		/// The second phone number.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Phone 2 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue? Phone2 { get; set; }

		/// <summary>
		/// The phone type for the Phone2 field.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Phone 2 Type 
		/// SQL Type: varchar(3) 
		/// </summary>
		[DataMember(Name="Phone2Type", EmitDefaultValue=false)]
		public StringValue? Phone2Type { get; set; }

		/// <summary>
		/// The third phone number.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Phone 3 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Phone3", EmitDefaultValue=false)]
		public StringValue? Phone3 { get; set; }

		/// <summary>
		/// The phone type for the Phone3 field.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Phone 3 Type 
		/// SQL Type: varchar(3) 
		/// </summary>
		[DataMember(Name="Phone3Type", EmitDefaultValue=false)]
		public StringValue? Phone3Type { get; set; }

		/// <summary>
		/// The reason why the Status field of this lead has been changed.
		/// DAC Field Name: Resolution 
		/// DAC: PX.Objects.CR.CRLead 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue? Reason { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail>? Relations { get; set; }

		/// <summary>
		/// The source of the lead.
		/// DAC: PX.Objects.CR.CRLead 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// The identifier of the campaign that resulted in creation of the contact.
		/// DAC Field Name: CampaignID 
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Source Campaign 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="SourceCampaign", EmitDefaultValue=false)]
		public StringValue? SourceCampaign { get; set; }

		/// <summary>
		/// The status of the lead.
		/// DAC: PX.Objects.CR.CRLead 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="Title", EmitDefaultValue=false)]
		public StringValue? Title { get; set; }

		/// <summary>
		/// The URL of the contact website.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Web 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="WebSite", EmitDefaultValue=false)]
		public StringValue? WebSite { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.CR.CRLead 
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

		/// <summary>
		/// DAC Field Name: WorkgroupID_description 
		/// DAC: PX.Objects.CR.CRLead 
		/// </summary>
		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue? WorkgroupDescription { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// Specifies whether the current contact is active and can be specified in documents.
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.CR.CRLead 
		/// </summary>
		/// <remarks>
		/// Only active contacts can be specified in such documents asCROpportunity, CRCase, CRQuote, PMQuote.The duplicate validation feature ContactDuplicate works only with active contacts.
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// An alphanumeric string of up to 255 characters that describes the lead.This field is used to add any additional information about the lead.
		/// DAC: PX.Objects.CR.CRLead 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The identifier of the contact that is associated with this lead.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Contact 
		/// </summary>
		[DataMember(Name="RefContactID", EmitDefaultValue=false)]
		public IntValue? RefContactID { get; set; }

		[DataMember(Name="ConvertedBy", EmitDefaultValue=false)]
		public StringValue? ConvertedBy { get; set; }

		[DataMember(Name="QualificationDate", EmitDefaultValue=false)]
		public DateTimeValue? QualificationDate { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}