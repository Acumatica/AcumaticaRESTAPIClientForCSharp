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
	/// Corresponds to the screen CR302000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Contact : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail>? Activities { get; set; }

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public Address? Address { get; set; }

		/// <summary>
		/// Specifies whether the address information of this contact differs from the address informationof the business account associated with this contact.IF it is so, the address information is synchronized with the associatedbusiness account.
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Override 
		/// </summary>
		/// <remarks>
		/// The behavior is controlled by the ContactBAccountSharedAddressOverrideGraphExtgraph extension.
		/// </remarks>
		[DataMember(Name="OverrideAccountAddress", EmitDefaultValue=false)]
		public BooleanValue? OverrideAccountAddress { get; set; }

		/// <summary>
		/// If set to true, this field indicates that the address has been successfully validated by Acumatica ERP.
		/// DAC Field Name: IsValidated 
		/// DAC: PX.Objects.CR.Address 
		/// Display Name: Validated 
		/// </summary>
		[DataMember(Name="AddressValidated", EmitDefaultValue=false)]
		public BooleanValue? AddressValidated { get; set; }

		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue? Attention { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The identifier of the related business account.
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Business Account 
		/// </summary>
		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		[DataMember(Name="Campaigns", EmitDefaultValue=false)]
		public List<CampaignDetail>? Campaigns { get; set; }

		[DataMember(Name="Cases", EmitDefaultValue=false)]
		public List<CaseDetail>? Cases { get; set; }

		/// <summary>
		/// The name of the company the contact works for.
		/// DAC Field Name: FullName 
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Account Name 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// The identifier of the class.
		/// DAC Field Name: ClassID 
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Class ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="ContactClass", EmitDefaultValue=false)]
		public StringValue? ContactClass { get; set; }

		/// <summary>
		/// The identifier of the contact.This field is the key field.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Contact ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		/// <summary>
		/// The person's preferred method of contact.
		/// DAC Field Name: Method 
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Contact Method 
		/// SQL Type: varchar(1) 
		/// </summary>
		[DataMember(Name="ContactMethod", EmitDefaultValue=false)]
		public StringValue? ContactMethod { get; set; }

		[DataMember(Name="ConvertedBy", EmitDefaultValue=false)]
		public StringValue? ConvertedBy { get; set; }

		/// <summary>
		/// The date of birth.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Date Of Birth 
		/// </summary>
		[DataMember(Name="DateOfBirth", EmitDefaultValue=false)]
		public DateTimeValue? DateOfBirth { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CR.Extensions.CRCreateActions.PopupAttributes 
		/// Display Name: Name 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
		public StringValue? DisplayName { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the contact should not be called.
		/// DAC Field Name: NoCall 
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Do Not Call 
		/// </summary>
		[DataMember(Name="DoNotCall", EmitDefaultValue=false)]
		public BooleanValue? DoNotCall { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the email of the contact will not be involved in the mass email process.This contact will not receive any notification emails.
		/// DAC Field Name: NoEMail 
		/// DAC: PX.Objects.CR.Contact 
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
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Duplicate", EmitDefaultValue=false)]
		public StringValue? Duplicate { get; set; }

		/// <summary>
		/// Specifies whether DuplicateStatus is equal to PossibleDuplicatedwhen the ContactDuplicate feature is enabled.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Duplicate Found 
		/// </summary>
		[DataMember(Name="DuplicateFound", EmitDefaultValue=false)]
		public BooleanValue? DuplicateFound { get; set; }

		[DataMember(Name="Duplicates", EmitDefaultValue=false)]
		public List<ContactDuplicateDetail>? Duplicates { get; set; }

		/// <summary>
		/// The email address of the contact.
		/// DAC Field Name: EMail 
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// The fax number.
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Fax", EmitDefaultValue=false)]
		public StringValue? Fax { get; set; }

		/// <summary>
		/// The phone type for the Fax field.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Fax Type 
		/// SQL Type: varchar(3) 
		/// </summary>
		[DataMember(Name="FaxType", EmitDefaultValue=false)]
		public StringValue? FaxType { get; set; }

		/// <summary>
		/// The first name of the person.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: First Name 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="FirstName", EmitDefaultValue=false)]
		public StringValue? FirstName { get; set; }

		/// <summary>
		/// The gender of the contact.
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Gender", EmitDefaultValue=false)]
		public StringValue? Gender { get; set; }

		/// <summary>
		/// The image attached to the contact.
		/// DAC Field Name: Img 
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="Image", EmitDefaultValue=false)]
		public StringValue? Image { get; set; }

		/// <summary>
		/// The job title of the person.
		/// DAC Field Name: Salutation 
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Job Title 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="JobTitle", EmitDefaultValue=false)]
		public StringValue? JobTitle { get; set; }

		/// <summary>
		/// The language in which the contact prefers to communicate.
		/// DAC Field Name: LanguageID 
		/// DAC: PX.Objects.CR.Contact 
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
		/// The date and time when the record was last modified.
		/// DAC: PX.Objects.CR.CRLead 
		/// Display Name: Last Modified On 
		/// </summary>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The last name of the person.
		/// DAC: PX.Objects.CR.Contact 
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
		/// The marital status of the contact.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Marital Status 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="MaritalStatus", EmitDefaultValue=false)]
		public StringValue? MaritalStatus { get; set; }

		[DataMember(Name="MarketingLists", EmitDefaultValue=false)]
		public List<MarketingListDetail>? MarketingLists { get; set; }

		[DataMember(Name="MiddleName", EmitDefaultValue=false)]
		public StringValue? MiddleName { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the email of the contact will not be involved in the mass email process.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: No Marketing 
		/// </summary>
		[DataMember(Name="NoMarketing", EmitDefaultValue=false)]
		public BooleanValue? NoMarketing { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the email of the contact will not be involved in the mass email process.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: No Mass Mail 
		/// </summary>
		[DataMember(Name="NoMassMail", EmitDefaultValue=false)]
		public BooleanValue? NoMassMail { get; set; }

		[DataMember(Name="Notifications", EmitDefaultValue=false)]
		public List<ContactNotification>? Notifications { get; set; }

		[DataMember(Name="Opportunities", EmitDefaultValue=false)]
		public List<OpportunityDetail>? Opportunities { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// DAC Field Name: OwnerID_description 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue? OwnerEmployeeName { get; set; }

		/// <summary>
		/// The identifier of the account that is considered as parent for the current account (BAccountID).
		/// DAC Field Name: ParentBAccountID 
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Parent Account 
		/// </summary>
		/// <remarks>
		/// There is no business logic in the application for this field.
		/// </remarks>
		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue? ParentAccount { get; set; }

		/// <summary>
		/// The phone number.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Phone 1 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// The phone type for the Phone1 field.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Phone 1 Type 
		/// SQL Type: varchar(3) 
		/// </summary>
		[DataMember(Name="Phone1Type", EmitDefaultValue=false)]
		public StringValue? Phone1Type { get; set; }

		/// <summary>
		/// The second phone number.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Phone 2 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue? Phone2 { get; set; }

		/// <summary>
		/// The phone type for the Phone2 field.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Phone 2 Type 
		/// SQL Type: varchar(3) 
		/// </summary>
		[DataMember(Name="Phone2Type", EmitDefaultValue=false)]
		public StringValue? Phone2Type { get; set; }

		/// <summary>
		/// The third phone number.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Phone 3 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Phone3", EmitDefaultValue=false)]
		public StringValue? Phone3 { get; set; }

		/// <summary>
		/// The phone type for the Phone3 field.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Phone 3 Type 
		/// SQL Type: varchar(3) 
		/// </summary>
		[DataMember(Name="Phone3Type", EmitDefaultValue=false)]
		public StringValue? Phone3Type { get; set; }

		[DataMember(Name="QualificationDate", EmitDefaultValue=false)]
		public DateTimeValue? QualificationDate { get; set; }

		/// <summary>
		/// The reason why the case has been changed to the current status.
		/// DAC Field Name: Resolution 
		/// DAC: PX.Objects.CR.CRCase 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue? Reason { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail>? Relations { get; set; }

		[DataMember(Name="RoleAssignments", EmitDefaultValue=false)]
		public List<BCRoleAssignment>? RoleAssignments { get; set; }

		/// <summary>
		/// The source of the contact. If a contact was created from a lead,the value is copied from the lead related to the contact.
		/// DAC: PX.Objects.CR.Contact 
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
		/// The name of the spouse or partner of the contact.
		/// DAC Field Name: Spouse 
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Spouse/Partner Name 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="SpouseOrPartnerName", EmitDefaultValue=false)]
		public StringValue? SpouseOrPartnerName { get; set; }

		/// <summary>
		/// The status of the contact.
		/// DAC: PX.Objects.CR.Contact 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// Specifies whether the contact should be included in exchange synchronization.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Synchronize to Exchange 
		/// </summary>
		[DataMember(Name="Synchronize", EmitDefaultValue=false)]
		public BooleanValue? Synchronize { get; set; }

		[DataMember(Name="Title", EmitDefaultValue=false)]
		public StringValue? Title { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="UserInfo", EmitDefaultValue=false)]
		public ContactUserInfo? UserInfo { get; set; }

		/// <summary>
		/// The URL of the contact website.
		/// DAC: PX.Objects.CR.Contact 
		/// Display Name: Web 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="WebSite", EmitDefaultValue=false)]
		public StringValue? WebSite { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

		/// <summary>
		/// DAC Field Name: WorkgroupID_description 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue? WorkgroupDescription { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		[DataMember(Name="FullName", EmitDefaultValue=false)]
		public StringValue? FullName { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}