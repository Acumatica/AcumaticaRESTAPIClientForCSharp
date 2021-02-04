using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Contact : Entity_v4
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail> Activities { get; set; }

		[DataMember(Name="Address", EmitDefaultValue=false)]
		public Address Address { get; set; }

		[DataMember(Name="OverrideAccountAddress", EmitDefaultValue=false)]
		public BooleanValue OverrideAccountAddress { get; set; }

		[DataMember(Name="AddressValidated", EmitDefaultValue=false)]
		public BooleanValue AddressValidated { get; set; }

		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue Attention { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue> Attributes { get; set; }

		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue BusinessAccount { get; set; }

		[DataMember(Name="Campaigns", EmitDefaultValue=false)]
		public List<CampaignDetail> Campaigns { get; set; }

		[DataMember(Name="Cases", EmitDefaultValue=false)]
		public List<CaseDetail> Cases { get; set; }

		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue CompanyName { get; set; }

		[DataMember(Name="ContactClass", EmitDefaultValue=false)]
		public StringValue ContactClass { get; set; }

		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue ContactID { get; set; }

		[DataMember(Name="ContactMethod", EmitDefaultValue=false)]
		public StringValue ContactMethod { get; set; }

		[DataMember(Name="ConvertedBy", EmitDefaultValue=false)]
		public StringValue ConvertedBy { get; set; }

		[DataMember(Name="DateOfBirth", EmitDefaultValue=false)]
		public DateTimeValue DateOfBirth { get; set; }

		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
		public StringValue DisplayName { get; set; }

		[DataMember(Name="DoNotCall", EmitDefaultValue=false)]
		public BooleanValue DoNotCall { get; set; }

		[DataMember(Name="DoNotEmail", EmitDefaultValue=false)]
		public BooleanValue DoNotEmail { get; set; }

		[DataMember(Name="DoNotFax", EmitDefaultValue=false)]
		public BooleanValue DoNotFax { get; set; }

		[DataMember(Name="DoNotMail", EmitDefaultValue=false)]
		public BooleanValue DoNotMail { get; set; }

		[DataMember(Name="Duplicate", EmitDefaultValue=false)]
		public StringValue Duplicate { get; set; }

		[DataMember(Name="DuplicateFound", EmitDefaultValue=false)]
		public BooleanValue DuplicateFound { get; set; }

		[DataMember(Name="Duplicates", EmitDefaultValue=false)]
		public List<ContactDuplicateDetail> Duplicates { get; set; }

		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue Email { get; set; }

		[DataMember(Name="Fax", EmitDefaultValue=false)]
		public StringValue Fax { get; set; }

		[DataMember(Name="FaxType", EmitDefaultValue=false)]
		public StringValue FaxType { get; set; }

		[DataMember(Name="FirstName", EmitDefaultValue=false)]
		public StringValue FirstName { get; set; }

		[DataMember(Name="Gender", EmitDefaultValue=false)]
		public StringValue Gender { get; set; }

		[DataMember(Name="Image", EmitDefaultValue=false)]
		public StringValue Image { get; set; }

		[DataMember(Name="JobTitle", EmitDefaultValue=false)]
		public StringValue JobTitle { get; set; }

		[DataMember(Name="LanguageOrLocale", EmitDefaultValue=false)]
		public StringValue LanguageOrLocale { get; set; }

		[DataMember(Name="LastIncomingActivity", EmitDefaultValue=false)]
		public DateTimeValue LastIncomingActivity { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="LastName", EmitDefaultValue=false)]
		public StringValue LastName { get; set; }

		[DataMember(Name="LastOutgoingActivity", EmitDefaultValue=false)]
		public DateTimeValue LastOutgoingActivity { get; set; }

		[DataMember(Name="MaritalStatus", EmitDefaultValue=false)]
		public StringValue MaritalStatus { get; set; }

		[DataMember(Name="MarketingLists", EmitDefaultValue=false)]
		public List<MarketingListDetail> MarketingLists { get; set; }

		[DataMember(Name="MiddleName", EmitDefaultValue=false)]
		public StringValue MiddleName { get; set; }

		[DataMember(Name="NoMarketing", EmitDefaultValue=false)]
		public BooleanValue NoMarketing { get; set; }

		[DataMember(Name="NoMassMail", EmitDefaultValue=false)]
		public BooleanValue NoMassMail { get; set; }

		[DataMember(Name="Notifications", EmitDefaultValue=false)]
		public List<ContactNotification> Notifications { get; set; }

		[DataMember(Name="Opportunities", EmitDefaultValue=false)]
		public List<OpportunityDetail> Opportunities { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue OwnerEmployeeName { get; set; }

		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue ParentAccount { get; set; }

		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue Phone1 { get; set; }

		[DataMember(Name="Phone1Type", EmitDefaultValue=false)]
		public StringValue Phone1Type { get; set; }

		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue Phone2 { get; set; }

		[DataMember(Name="Phone2Type", EmitDefaultValue=false)]
		public StringValue Phone2Type { get; set; }

		[DataMember(Name="Phone3", EmitDefaultValue=false)]
		public StringValue Phone3 { get; set; }

		[DataMember(Name="Phone3Type", EmitDefaultValue=false)]
		public StringValue Phone3Type { get; set; }

		[DataMember(Name="QualificationDate", EmitDefaultValue=false)]
		public DateTimeValue QualificationDate { get; set; }

		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue Reason { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail> Relations { get; set; }

		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue Source { get; set; }

		[DataMember(Name="SourceCampaign", EmitDefaultValue=false)]
		public StringValue SourceCampaign { get; set; }

		[DataMember(Name="SpouseOrPartnerName", EmitDefaultValue=false)]
		public StringValue SpouseOrPartnerName { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="Synchronize", EmitDefaultValue=false)]
		public BooleanValue Synchronize { get; set; }

		[DataMember(Name="Title", EmitDefaultValue=false)]
		public StringValue Title { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="UserInfo", EmitDefaultValue=false)]
		public ContactUserInfo UserInfo { get; set; }

		[DataMember(Name="WebSite", EmitDefaultValue=false)]
		public StringValue WebSite { get; set; }

		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue Workgroup { get; set; }

		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue WorkgroupDescription { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue NoteID { get; set; }

	}
}