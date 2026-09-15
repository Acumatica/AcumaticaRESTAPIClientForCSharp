using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>CR303000</c> in the Acumatica ERP
	/// <para>Key Fields: BusinessAccountID</para>
	/// </summary>
	[DataContract]
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
		[DataMember(Name="AccountRef", EmitDefaultValue=false)]
		public StringValue? AccountRef { get; set; }

		[DataMember(Name="Activities", EmitDefaultValue=false)]
		public List<ActivityDetail>? Activities { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		/// <summary>
		/// The human-readable identifier of the business account that isspecified by the user or defined by the auto-numbering sequence during thecreation of the account. This field is a natural key, as opposedto the surrogate key BAccountID.
		/// <para>DAC Field Name: AcctCD</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Account ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="BusinessAccountID", EmitDefaultValue=false)]
		public StringValue? BusinessAccountID { get; set; }

		[DataMember(Name="Campaigns", EmitDefaultValue=false)]
		public List<CampaignDetail>? Campaigns { get; set; }

		[DataMember(Name="Cases", EmitDefaultValue=false)]
		public List<BusinessAccountCaseDetail>? Cases { get; set; }

		/// <summary>
		/// Identifier of the business acccount class to which the business account belongs.
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Business Account Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		[DataMember(Name="Contacts", EmitDefaultValue=false)]
		public List<BusinessAccountContact>? Contacts { get; set; }

		[DataMember(Name="Contracts", EmitDefaultValue=false)]
		public List<BusinessAccountContract>? Contracts { get; set; }

		/// <summary>
		/// The ID of the user who created the record.
		/// <para>DAC: PX.Objects.CR.CRRelation</para>
		/// <para>Display Name: Creator</para>
		/// </summary>
		[DataMember(Name="CreatedByID", EmitDefaultValue=false)]
		public GuidValue? CreatedByID { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Created On</para>
		/// </summary>
		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="DefaultLocationSettings", EmitDefaultValue=false)]
		public BusinessAccountDefaultLocationSetting? DefaultLocationSettings { get; set; }

		[DataMember(Name="Duplicate", EmitDefaultValue=false)]
		public StringValue? Duplicate { get; set; }

		[DataMember(Name="Duplicates", EmitDefaultValue=false)]
		public List<DuplicateDetail>? Duplicates { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastIncomingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Incoming Activity</para>
		/// </summary>
		[DataMember(Name="LastIncomingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastIncomingActivity { get; set; }

		/// <summary>
		/// The ID of the user who last modified the record.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Last Modified By</para>
		/// </summary>
		[DataMember(Name="LastModifiedByID", EmitDefaultValue=false)]
		public GuidValue? LastModifiedByID { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Last Modified On</para>
		/// </summary>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastOutgoingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Outgoing Activity</para>
		/// </summary>
		[DataMember(Name="LastOutgoingActivity", EmitDefaultValue=false)]
		public DateTimeValue? LastOutgoingActivity { get; set; }

		[DataMember(Name="Locations", EmitDefaultValue=false)]
		public List<BusinessAccountLocation>? Locations { get; set; }

		[DataMember(Name="MainAddress", EmitDefaultValue=false)]
		public Address? MainAddress { get; set; }

		/// <summary>
		/// If set to true, this field indicates that the address has been successfully validated by Acumatica ERP.
		/// <para>DAC Field Name: IsValidated</para>
		/// <para>DAC: PX.Objects.CR.Address</para>
		/// <para>Display Name: Validated</para>
		/// </summary>
		[DataMember(Name="MainAddressValidated", EmitDefaultValue=false)]
		public BooleanValue? MainAddressValidated { get; set; }

		[DataMember(Name="MainContact", EmitDefaultValue=false)]
		public BusinessAccountMainContact? MainContact { get; set; }

		[DataMember(Name="MarketingLists", EmitDefaultValue=false)]
		public List<MarketingListDetail>? MarketingLists { get; set; }

		/// <summary>
		/// The full business account name (as opposed to theshort identifier AcctCD).
		/// <para>DAC Field Name: AcctName</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Account Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		[DataMember(Name="Opportunities", EmitDefaultValue=false)]
		public List<BusinessAccountOpportunityDetail>? Opportunities { get; set; }

		[DataMember(Name="Orders", EmitDefaultValue=false)]
		public List<BusinessAccountOrder>? Orders { get; set; }

		/// <summary>
		/// The identifier of the user responsible for the current document.If the WorkgroupID is specified, only a user that belongsto the specified workgroup can be used.
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID_description</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// </summary>
		[DataMember(Name="OwnerEmployeeName", EmitDefaultValue=false)]
		public StringValue? OwnerEmployeeName { get; set; }

		/// <summary>
		/// The identifier of the parent business account.
		/// <para>DAC Field Name: ParentBAccountID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Parent Account</para>
		/// </summary>
		[DataMember(Name="ParentAccount", EmitDefaultValue=false)]
		public StringValue? ParentAccount { get; set; }

		[DataMember(Name="PrimaryContact", EmitDefaultValue=false)]
		public Contact? PrimaryContact { get; set; }

		/// <summary>
		/// The flag identified that the salesTerritoryID is filled automaticallybased on state and countryID or can be assigned manually.
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Override Territory</para>
		/// </summary>
		[DataMember(Name="OverrideSalesTerritory", EmitDefaultValue=false)]
		public BooleanValue? OverrideSalesTerritory { get; set; }

		/// <summary>
		/// The reference to salesTerritoryID. If overrideSalesTerritoryis false then it's filled automaticallybased on state and countryID otherwise it's assigned by user.
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Sales Territory</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="SalesTerritoryID", EmitDefaultValue=false)]
		public StringValue? SalesTerritoryID { get; set; }

		[DataMember(Name="Relations", EmitDefaultValue=false)]
		public List<RelationDetail>? Relations { get; set; }

		[DataMember(Name="ShippingAddress", EmitDefaultValue=false)]
		public Address? ShippingAddress { get; set; }

		/// <summary>
		/// If set to <c>true</c>, indicates that the addressoverrides the default Address record, which isreferenced by DefAddressID.
		/// <para>DAC Field Name: OverrideAddress</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// <para>Display Name: Override</para>
		/// </summary>
		[DataMember(Name="ShippingAddressOverride", EmitDefaultValue=false)]
		public BooleanValue? ShippingAddressOverride { get; set; }

		/// <summary>
		/// If set to true, this field indicates that the address has been successfully validated by Acumatica ERP.
		/// <para>DAC Field Name: IsValidated</para>
		/// <para>DAC: PX.Objects.CR.Address</para>
		/// <para>Display Name: Validated</para>
		/// </summary>
		[DataMember(Name="ShippingAddressValidated", EmitDefaultValue=false)]
		public BooleanValue? ShippingAddressValidated { get; set; }

		[DataMember(Name="ShippingContact", EmitDefaultValue=false)]
		public BusinessAccountShippingContact? ShippingContact { get; set; }

		/// <summary>
		/// The identifier of the marketing or sales campaign that resulted in creation of the business account.
		/// <para>DAC Field Name: CampaignSourceID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Source Campaign</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="SourceCampaign", EmitDefaultValue=false)]
		public StringValue? SourceCampaign { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Customer Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// Represents the type of the business account.
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringSingleSelectValue? Type { get; set; }

		/// <summary>
		/// The identifier of the workgroup responsible for the current document.
		/// <para>DAC Field Name: WorkgroupID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// </summary>
		[DataMember(Name="Workgroup", EmitDefaultValue=false)]
		public StringValue? Workgroup { get; set; }

		/// <summary>
		/// <para>DAC Field Name: WorkgroupID_description</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// </summary>
		[DataMember(Name="WorkgroupDescription", EmitDefaultValue=false)]
		public StringValue? WorkgroupDescription { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// The identifier of the Currency,which is applied to the documents of the business account.
		/// <para>DAC Field Name: CuryID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Currency ID</para>
		/// <para>SQL Type: nvarchar(5)</para>
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// If set to true, indicates that the currencyof business account documents (which is specified by CuryID)can be overridden by a user during document entry.
		/// <para>DAC Field Name: AllowOverrideCury</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Enable Currency Override</para>
		/// </summary>
		[DataMember(Name="EnableCurrencyOverride", EmitDefaultValue=false)]
		public BooleanValue? EnableCurrencyOverride { get; set; }

		[DataMember(Name="LocaleName", EmitDefaultValue=false)]
		public StringValue? LocaleName { get; set; }

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Activities = "Activities";
			public const string Attributes = "Attributes";
			public const string Campaigns = "Campaigns";
			public const string Cases = "Cases";
			public const string Contacts = "Contacts";
			public const string Contracts = "Contracts";
			public const string DefaultLocationSettings = "DefaultLocationSettings";
			public const string Duplicates = "Duplicates";
			public const string Locations = "Locations";
			public const string MainAddress = "MainAddress";
			public const string MainContact = "MainContact";
			public const string MarketingLists = "MarketingLists";
			public const string Opportunities = "Opportunities";
			public const string Orders = "Orders";
			public const string PrimaryContact = "PrimaryContact";
			public const string Relations = "Relations";
			public const string ShippingAddress = "ShippingAddress";
			public const string ShippingContact = "ShippingContact";

			//Intentionally excluded
			//public const string All = "Files,Translations,Activities,Attributes,Campaigns,Cases,Contacts,Contracts,DefaultLocationSettings,Duplicates,Locations,MainAddress,MainContact,MarketingLists,Opportunities,Orders,PrimaryContact,Relations,ShippingAddress,ShippingContact";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}