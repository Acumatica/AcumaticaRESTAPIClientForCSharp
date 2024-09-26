using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
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
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideAddress 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverrideAccountAddress", EmitDefaultValue=false)]
		public BooleanValue? OverrideAccountAddress { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsValidated 
		/// DAC: PX.Objects.CR.Address 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AddressValidated", EmitDefaultValue=false)]
		public BooleanValue? AddressValidated { get; set; }

		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue? Attention { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
		public StringValue? BusinessAccount { get; set; }

		[DataMember(Name="Campaigns", EmitDefaultValue=false)]
		public List<CampaignDetail>? Campaigns { get; set; }

		[DataMember(Name="Cases", EmitDefaultValue=false)]
		public List<CaseDetail>? Cases { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FullName 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ClassID 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ContactClass", EmitDefaultValue=false)]
		public StringValue? ContactClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ContactID 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ContactID", EmitDefaultValue=false)]
		public IntValue? ContactID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Method 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ContactMethod", EmitDefaultValue=false)]
		public StringValue? ContactMethod { get; set; }

		[DataMember(Name="ConvertedBy", EmitDefaultValue=false)]
		public StringValue? ConvertedBy { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DateOfBirth 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DateOfBirth", EmitDefaultValue=false)]
		public DateTimeValue? DateOfBirth { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DisplayName 
		/// DAC: PX.Objects.CR.Extensions.CRCreateActions.PopupAttributes 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DisplayName", EmitDefaultValue=false)]
		public StringValue? DisplayName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NoCall 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DoNotCall", EmitDefaultValue=false)]
		public BooleanValue? DoNotCall { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NoEMail 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DoNotEmail", EmitDefaultValue=false)]
		public BooleanValue? DoNotEmail { get; set; }

		[DataMember(Name="DoNotFax", EmitDefaultValue=false)]
		public BooleanValue? DoNotFax { get; set; }

		[DataMember(Name="DoNotMail", EmitDefaultValue=false)]
		public BooleanValue? DoNotMail { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DuplicateStatus 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Duplicate", EmitDefaultValue=false)]
		public StringValue? Duplicate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DuplicateFound 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DuplicateFound", EmitDefaultValue=false)]
		public BooleanValue? DuplicateFound { get; set; }

		[DataMember(Name="Duplicates", EmitDefaultValue=false)]
		public List<ContactDuplicateDetail>? Duplicates { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EMail 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Fax 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Fax", EmitDefaultValue=false)]
		public StringValue? Fax { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FaxType 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FaxType", EmitDefaultValue=false)]
		public StringValue? FaxType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FirstName 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FirstName", EmitDefaultValue=false)]
		public StringValue? FirstName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Gender 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Gender", EmitDefaultValue=false)]
		public StringValue? Gender { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Img 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Image", EmitDefaultValue=false)]
		public StringValue? Image { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Salutation 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="JobTitle", EmitDefaultValue=false)]
		public StringValue? JobTitle { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LanguageID 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LanguageOrLocale", EmitDefaultValue=false)]
		public StringValue? LanguageOrLocale { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastIncomingActivityDate 
		/// DAC: PX.Objects.CR.CRActivityStatistics 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastIncomingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastIncomingActivity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastModifiedDateTime 
		/// DAC: PX.Objects.CR.CRLead 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastName 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastName", EmitDefaultValue=false)]
		public StringValue? LastName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LastOutgoingActivityDate 
		/// DAC: PX.Objects.CR.CRActivityStatistics 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LastOutgoingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastOutgoingActivity { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MaritalStatus 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MaritalStatus", EmitDefaultValue=false)]
		public StringValue? MaritalStatus { get; set; }

		[DataMember(Name="MarketingLists", EmitDefaultValue=false)]
		public List<MarketingListDetail>? MarketingLists { get; set; }

		[DataMember(Name="MiddleName", EmitDefaultValue=false)]
		public StringValue? MiddleName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NoMarketing 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NoMarketing", EmitDefaultValue=false)]
		public BooleanValue? NoMarketing { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: NoMassMail 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NoMassMail", EmitDefaultValue=false)]
		public BooleanValue? NoMassMail { get; set; }

		[DataMember(Name="Notifications", EmitDefaultValue=false)]
		public List<ContactNotification>? Notifications { get; set; }

		[DataMember(Name="Opportunities", EmitDefaultValue=false)]
		public List<OpportunityDetail>? Opportunities { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID_description 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue? OwnerEmployeeName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ParentBAccountID 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue? ParentAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Phone1 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Phone1Type 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Phone1Type", EmitDefaultValue=false)]
		public StringValue? Phone1Type { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Phone2 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Phone2", EmitDefaultValue=false)]
		public StringValue? Phone2 { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Phone2Type 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Phone2Type", EmitDefaultValue=false)]
		public StringValue? Phone2Type { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Phone3 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Phone3", EmitDefaultValue=false)]
		public StringValue? Phone3 { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Phone3Type 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Phone3Type", EmitDefaultValue=false)]
		public StringValue? Phone3Type { get; set; }

		[DataMember(Name="QualificationDate", EmitDefaultValue=false)]
		public DateTimeValue? QualificationDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Resolution 
		/// DAC: PX.Objects.CR.CRCase 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Reason", EmitDefaultValue=false)]
		public StringValue? Reason { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail>? Relations { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Source 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CampaignID 
		/// DAC: PX.Objects.CR.CRLead 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SourceCampaign", EmitDefaultValue=false)]
		public StringValue? SourceCampaign { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Spouse 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SpouseOrPartnerName", EmitDefaultValue=false)]
		public StringValue? SpouseOrPartnerName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Synchronize 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Synchronize", EmitDefaultValue=false)]
		public BooleanValue? Synchronize { get; set; }

		[DataMember(Name="Title", EmitDefaultValue=false)]
		public StringValue? Title { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		[DataMember(Name="UserInfo", EmitDefaultValue=false)]
		public ContactUserInfo? UserInfo { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WebSite 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WebSite", EmitDefaultValue=false)]
		public StringValue? WebSite { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkgroupID 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WorkgroupID_description 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue? WorkgroupDescription { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		[DataMember(Name="FullName", EmitDefaultValue=false)]
		public StringValue? FullName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverrideSalesTerritory 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverrideSalesTerritory", EmitDefaultValue=false)]
		public BooleanValue? OverrideSalesTerritory { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesTerritoryID 
		/// DAC: PX.Objects.CR.Contact 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalesTerritoryID", EmitDefaultValue=false)]
		public StringValue? SalesTerritoryID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}