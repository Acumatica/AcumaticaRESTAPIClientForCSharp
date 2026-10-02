using System;
using System.Collections.Generic;

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
	public class BusinessAccount : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// The human-readable identifier of the business account that isspecified by the user or defined by the auto-numbering sequence during thecreation of the account. This field is a natural key, as opposedto the surrogate key BAccountID.
		/// <para>DAC Field Name: AcctCD</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Account ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? BusinessAccountID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Customer Status</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringSingleSelectValue? Status { get; set; }

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
		/// Identifier of the business acccount class to which the business account belongs.
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Business Account Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// The full business account name (as opposed to theshort identifier AcctCD).
		/// <para>DAC Field Name: AcctName</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Account Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Name { get; set; }

		/// <summary>
		/// Represents the type of the business account.
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringSingleSelectValue? Type { get; set; }

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

		/// <summary>
		/// The flag identified that the salesTerritoryID is filled automaticallybased on state and countryID or can be assigned manually.
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Override Territory</para>
		/// </summary>
		public BooleanValue? OverrideSalesTerritory { get; set; }

		/// <summary>
		/// The reference to salesTerritoryID. If overrideSalesTerritoryis false then it's filled automaticallybased on state and countryID otherwise it's assigned by user.
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Sales Territory</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? SalesTerritoryID { get; set; }

		/// <summary>
		/// The identifier of the parent business account.
		/// <para>DAC Field Name: ParentBAccountID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Parent Account</para>
		/// </summary>
		public StringValue? ParentAccount { get; set; }

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

		/// <summary>
		/// The identifier of the marketing or sales campaign that resulted in creation of the business account.
		/// <para>DAC Field Name: CampaignSourceID</para>
		/// <para>DAC: PX.Objects.CR.BAccount</para>
		/// <para>Display Name: Source Campaign</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? SourceCampaign { get; set; }

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

		/// <summary>
		/// If set to <c>true</c>, indicates that the addressoverrides the default Address record, which isreferenced by DefAddressID.
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
		public BooleanValue? MainAddressValidated { get; set; }

		/// <summary>
		/// If set to true, this field indicates that the address has been successfully validated by Acumatica ERP.
		/// <para>DAC Field Name: IsValidated</para>
		/// <para>DAC: PX.Objects.CR.Address</para>
		/// <para>Display Name: Validated</para>
		/// </summary>
		public BooleanValue? ShippingAddressValidated { get; set; }

		/// <summary>
		/// The date and time when the record was last modified.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Last Modified On</para>
		/// </summary>
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC: PX.Objects.CR.Contact</para>
		/// <para>Display Name: Created On</para>
		/// </summary>
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The ID of the user who last modified the record.
		/// <para>DAC: PX.Objects.CR.CRLead</para>
		/// <para>Display Name: Last Modified By</para>
		/// </summary>
		public GuidValue? LastModifiedByID { get; set; }

		/// <summary>
		/// The ID of the user who created the record.
		/// <para>DAC: PX.Objects.CR.CRRelation</para>
		/// <para>Display Name: Creator</para>
		/// </summary>
		public GuidValue? CreatedByID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastIncomingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Incoming Activity</para>
		/// </summary>
		public DateTimeValue? LastIncomingActivity { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LastOutgoingActivityDate</para>
		/// <para>DAC: PX.Objects.CR.CRActivityStatistics</para>
		/// <para>Display Name: Last Outgoing Activity</para>
		/// </summary>
		public DateTimeValue? LastOutgoingActivity { get; set; }

		public StringValue? Duplicate { get; set; }

		public GuidValue? NoteID { get; set; }

		public StringValue? LocaleName { get; set; }

		#endregion

		#region LinkedEntities
		public BusinessAccountDefaultLocationSetting? DefaultLocationSettings { get; set; }

		public Address? MainAddress { get; set; }

		public BusinessAccountMainContact? MainContact { get; set; }

		public Contact? PrimaryContact { get; set; }

		public Address? ShippingAddress { get; set; }

		public BusinessAccountShippingContact? ShippingContact { get; set; }

		#endregion

		#region Details
		public List<ActivityDetail>? Activities { get; set; }

		public List<AttributeValue>? Attributes { get; set; }

		public List<CampaignDetail>? Campaigns { get; set; }

		public List<BusinessAccountCaseDetail>? Cases { get; set; }

		public List<BusinessAccountContact>? Contacts { get; set; }

		public List<BusinessAccountContract>? Contracts { get; set; }

		public List<DuplicateDetail>? Duplicates { get; set; }

		public List<BusinessAccountLocation>? Locations { get; set; }

		public List<MarketingListDetail>? MarketingLists { get; set; }

		public List<BusinessAccountOpportunityDetail>? Opportunities { get; set; }

		public List<BusinessAccountOrder>? Orders { get; set; }

		public List<RelationDetail>? Relations { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(BusinessAccount)} - \"{BusinessAccountID}\"";
		}

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